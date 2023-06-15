SELECT meter_id, total_units
FROM electricity_reading
where h13<h14
order by total_units DESC;
