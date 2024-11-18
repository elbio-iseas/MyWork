SELECT E.email, count() AS total_sites from sites AS S
INNER JOIN Employees AS E
ON S.customer_id = E.id
WHERE S.is_active = 1
GROUP BY S.customer_id
