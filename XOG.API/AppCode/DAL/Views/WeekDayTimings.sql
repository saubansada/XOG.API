CREATE view [WeekDayTimings] as 
select ROW_NUMBER() over (order by dt.Id) as Id, wds.Id as WeekDayId, wds.DayName, 
wds.IsActive as IsWeekDayActive, 
 cast((case when wds.IsActive = 1 and dt.IsActive = 1 and [dbo].[GetDayId](getdate()) <> wds.Id then 1 
	when wds.IsActive = 1 and dt.IsActive = 1 and [dbo].[GetDayId](getdate()) = wds.Id
		 and dt.ToHours >= DATEPART(hour, GETDATE())
		 and (dt.ToMinutes = 0 or dt.ToMinutes > DATEPART(minute, GETDATE()))
	then 1 else 0 end) as bit) as IsTimingActive,
dt.FromHours as HourStart, dt.ToHours as HourEnd, 
dt.FromMinutes as MinuteStart, dt.ToMinutes as MinutesEnd,
dt.FromHours, dt.FromMinutes, cast((case when dt.ToHours = 23 then 0 else dt.ToHours + 1 end) as smallint) as ToHours, 
cast(case when dt.ToMinutes = 59 then 0 else dt.ToMinutes end as smallint) ToMinutes from WeekDayStatuses wds
left join DeliveryTimings dt on dt.DayId = wds.Id;