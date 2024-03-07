
CREATE FUNCTION [dbo].[GetDayId]
(
   @vdate Date
) 
RETURNS INT
AS
BEGIN
	IF(FORMAT(@vdate, 'dddd') = 'Saturday') RETURN 0; 
	 IF(FORMAT(@vdate, 'dddd') = 'Sunday') RETURN 1; 
	 IF(FORMAT(@vdate, 'dddd') = 'Monday') RETURN 2;
	 IF(FORMAT(@vdate, 'dddd') = 'Tuesday') RETURN 3;
	 IF(FORMAT(@vdate, 'dddd') = 'Wednesday') RETURN 4;
	 IF(FORMAT(@vdate, 'dddd') = 'Thursday') RETURN 5;
	 IF(FORMAT(@vdate, 'dddd') = 'Friday') RETURN 6;
	 RETURN -1;
END