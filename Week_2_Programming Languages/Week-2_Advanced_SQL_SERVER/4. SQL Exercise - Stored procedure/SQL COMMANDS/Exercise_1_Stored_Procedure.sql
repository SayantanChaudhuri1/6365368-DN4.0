ALTER PROCEDURE sp_GetEmployeesByDept
  @DepartmentID INT
AS
BEGIN
  SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
  FROM Employees
  WHERE DepartmentID = @DepartmentID;
END;
