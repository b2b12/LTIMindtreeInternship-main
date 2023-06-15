SELECT * FROM bill
WHERE payment_date BETWEEN '2018-01-01' AND '2018-12-31'
ORDER BY payable_amount DESC;
