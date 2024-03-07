CREATE FUNCTION [dbo].[GetTimeSlot]
(
	@orderDate Date,
	@timeId int
)
RETURNS NVARCHAR(MAX)
AS
BEGIN

	DECLARE @timeslot AS VARCHAR(20); 
	DECLARE @deliveryDate AS DATE;

	SET @deliveryDate = [dbo].[GetDeliveryDate](@orderDate, @timeId);

	if (@timeId is null) RETURN '';
	if @timeId not in (select id from DeliveryTimings) RETURN '';

	select @timeslot = concat(IIF(d.FromHours < 10, '0', ''), IIF(d.FromHours > 12, d.FromHours - 12, d.FromHours), ':', 
	IIF(d.FromMinutes < 10, '0', ''), d.FromMinutes, IIF(d.FromHours > 12, 'PM', 'AM'), ' - ', 
	IIF((d.ToHours < 10 and d.FromHours <> d.ToHours) or (d.FromHours = d.ToHours and d.FromHours+1 < 10), '0', ''), IIF(d.FromHours = d.ToHours, d.ToHours + 1, d.ToHours) - IIF(d.ToHours > 12, 12, 0), ':', IIF(d.ToMinutes < 10 or d.ToMinutes = 59, '0', ''), IIF(d.ToMinutes = 59, '0', ''),
	IIF(d.ToHours > 12, 'PM', 'AM')) from DeliveryTimings d
	where Id = @timeId;
	RETURN CONCAT(FORMAT(@deliveryDate, 'dd-MM-yyyy'), ' ', @timeslot);
END