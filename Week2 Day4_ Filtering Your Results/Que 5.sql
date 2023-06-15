SELECT owner_name,address,contact_number
FROM building
WHERE email_address is null
ORDER BY owner_name ASC;
