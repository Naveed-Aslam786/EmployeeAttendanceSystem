using System;

namespace EmployeeAttendanceSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public DateTime JoiningDate { get; set; }
    }
}
