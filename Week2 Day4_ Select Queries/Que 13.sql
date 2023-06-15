SELECT name
FROM building_type
WHERE RIGHT(name,1) IN('L')
ORDER BY name ASC
