CREATE FUNCTION [dbo].[GetDeliveryDate]
(
	@orderedDate Date, 
	@timePeriod smallint
)
RETURNS DATETIME
AS
BEGIN
	DECLARE @deliveryDate AS DATE;
	DECLARE @addDays AS INT;
	DECLARE @dWeekDay AS INT;
	DECLARE @weekDay AS INT = [dbo].[GetDayId](@orderedDate);

	select @dWeekDay = dt.DayId From DeliveryTimings dt where @timePeriod = dt.Id;

	IF(@dWeekDay = @weekDay) SET @addDays = 0;
	IF (@dWeekDay < @weekDay) SET @addDays = ((6 + (@dWeekDay - @weekDay)) % 6) + 1; 
	IF (@dWeekDay > @weekDay) SET @addDays = ((6 + (@dWeekDay - @weekDay)) % 6); 


	select @deliveryDate =  DATEADD(day, @addDays, @orderedDate) from DeliveryTimings dt
	RETURN @deliveryDate;
END