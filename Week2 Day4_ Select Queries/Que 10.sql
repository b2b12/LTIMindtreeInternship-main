SELECT owner_name,CONCAT(contact_number,'-',email_address) AS contact_details
FROM building
ORDER BY owner_name DESC;
