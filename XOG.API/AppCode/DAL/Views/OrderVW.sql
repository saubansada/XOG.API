
CREATE VIEW [OrderVW] AS
SELECT
	ROW_NUMBER() over(order by o.Id) ViewInfoId,
	o.Id OrderId,  od.Id, COALESCE(ro.Id, -1) ReturnDetailId, COALESCE(r.Id, -1) ReturnId, u.FirstName, u.LastName,
	u.Id as UserId, u.UserName as PhoneNumber, o.OrderDate, o.OrderState, o.DeliveredDate, o.DispatchedDate, COALESCE(r.IsReturn, 0) IsReturn,
	--Sum((od.Price - ((od.Price * od.Discount / 100))) * od.Quantity) SumOrdered,
	--Sum((od.Price - ((od.Price * od.Discount / 100))) * od.Quantity - IIF(ro.Quantity != null, ro.Quantity, 0)) TotalBill,
	--Sum((od.Price - ((od.Price * od.Discount / 100))) * od.Quantity - IIF(ro.Quantity != null, ro.Quantity, 0)) - Sum((od.Price - ((od.Price * od.Discount / 100))) * od.Quantity - ro.Quantity) SumReturned,
    addr.AddressLine1, addr.AddressLine2, addr.LandMark, addr.AreaCode, addr.Country, addr.FullName, addr.GPS, addr.PhoneNumber OrderedPhoneNumber, 
	p.ProductName, pv.ProductId, pv.Id ProductVariantId, pv.Volume, qm.QuantityMeasureName, qm.Acronym, 
	qm.Id QuantityMeasureId, o.OrderToAddressId, pi.ImageUrl, pi.Id ImageId,
	od.Price, (od.Price - (od.Price * od.Discount / 100)) DiscPrice, od.Discount, od.Quantity OrderedQuantity, 
	COALESCE(r.ReturnOrderState, 0) ReturnOrderStatus,
	(od.Quantity - SUM(COALESCE(ro2.Quantity, 0))) TotalQuantity, 
	COALESCE(ro.Quantity, 0) ReturnedQuantity, 
	SUM(COALESCE(ro2.Quantity, 0)) TotalReturnedQuantity, 
	o.TimePeriod TimePeriod, 
	CAST([dbo].[GetDeliveryDate](o.OrderDate, o.TimePeriod) AS DATETIME) DeliveryDate,
    [dbo].[GetTimeSlot](o.OrderDate, o.TimePeriod) AS TimePeriodText,
	od.Gst, 
	((od.Price - (od.Price * od.Discount / 100)) * (od.Quantity)) OrderedTotal,
	((od.Price - (od.Price * od.Discount / 100)) * (SUM(COALESCE(ro2.Quantity, 0)))) ReturnTotal,
	((od.Price - (od.Price * od.Discount / 100)) * (COALESCE(ro.Quantity, 0))) ReturnTotalSum,
	((od.Price - (od.Price * od.Discount / 100)) * (od.Quantity - SUM(COALESCE(ro2.Quantity, 0)))) Total
	, r.ReturnOrderDate
	FROM Orders o
	INNER JOIN OrderDetails od on o.Id = od.OrderId
	INNER JOIN AspNetUsers u on o.OrderedByUserId = u.Id
	INNER JOIN ProductVariants pv on pv.Id = od.ProductVariantId
	INNER JOIN Products p on p.Id = pv.ProductId
	INNER JOIN ProductImages pi on pi.ProductId = p.Id
	INNER JOIN QuantityMeasures qm on qm.Id = pv.MeasureId
	LEFT JOIN Addresses addr on addr.AddressOfUserId = u.Id and addr.IsDefault = 1
	LEFT JOIN ReturnOrderDetails ro on ro.OrderDetailsId = od.Id
	LEFT JOIN ReturnOrders r on r.Id = ro.ReturnOrderId
	LEFT JOIN ReturnOrderDetails ro2 on ro2.OrderDetailsId = od.Id
	WHERE pi.Id in (SELECT max(Id) FROM ProductImages where ProductId = p.Id)
	Group By o.Id, od.Id, u.FirstName, u.LastName, u.Id, u.UserName, o.OrderDate, o.OrderState, o.DeliveredDate, o.TimePeriod,
	o.DispatchedDate, addr.AddressLine1, addr.AddressLine2, addr.LandMark, addr.Country, addr.AreaCode, addr.FullName, addr.GPS, addr.PhoneNumber, 
	p.ProductName, pv.ProductId, pv.Id, pv.Volume, qm.QuantityMeasureName, qm.Acronym, qm.Id, o.OrderToAddressId, pi.ImageUrl, pi.Id,
	od.Price, od.Discount, ro.Id, od.Quantity, r.Id, r.ReturnOrderState, r.IsReturn, ro.Quantity, od.Discount, od.Price, od.GST, r.ReturnOrderDate;