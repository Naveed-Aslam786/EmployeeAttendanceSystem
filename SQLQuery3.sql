CREATE TABLE Attendance
(
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL,

    AttendanceDate DATE NOT NULL,

    Status NVARCHAR(20) NOT NULL,

    CONSTRAINT FK_Attendance_Employees
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID)
);