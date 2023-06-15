select monthname(date),count(*) as number_of_events
from event
where year(date)='2013'
group by month(date)
order by month(date)
