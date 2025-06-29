SELECT EmployeeID, FirstName, LastName, Salary,
       dbo.fn_CalculateBonus(Salary) AS Bonus
FROM Employees;
