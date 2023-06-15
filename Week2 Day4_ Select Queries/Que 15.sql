SELECT due_date, payable_amount
FROM bill
WHERE  NOT payment_date BETWEEN '2017-09-10' AND '2017-10-10'
