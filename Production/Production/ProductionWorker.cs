using System;

namespace Production
{
    public class ProductionWorker : Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNumber { get; set; }
        public ShiftType Shift { get; set; }
        public int ShiftNumber { get; set; }
        public double HourlyRate { get; set; }
    }

    public enum ShiftType
    {
        NoShift = 0, 
        Day = 1,
        Night = 2,
        Evening = 3,
    }
}
