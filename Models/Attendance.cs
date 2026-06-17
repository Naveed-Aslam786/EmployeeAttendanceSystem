using System;

namespace EmployeeAttendanceSystem.Models
{
    public class Attendance
    {
        public int AttendanceID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime AttendanceDate { get; set; }

        public string Status { get; set; }
    }
}