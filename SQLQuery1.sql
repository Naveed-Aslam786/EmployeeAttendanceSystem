CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(20) NOT NULL,
    Department NVARCHAR(50) NOT NULL,
    Designation NVARCHAR(50) NOT NULL,
    ContactNumber NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    JoiningDate DATE NOT NULL
);