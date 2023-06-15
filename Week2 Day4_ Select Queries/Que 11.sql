SELECT SUBSTRING(meter_number,1,3) AS meter_code
FROM meter
ORDER BY meter_code DESC;
