using System;

namespace Production
{
    public class ProductionWorker : Employee
    {
        public ShiftType Shift { get; set; }
        public double HourlyRate { get; set; }
    }

    public enum ShiftType
    {
        Day = 1,
        Night = 2
    }
}
