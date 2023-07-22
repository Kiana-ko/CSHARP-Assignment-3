using System;

namespace FactoryShiftSupervisor
{
   
    public class ShiftSupervisor : Employee
    {
        public decimal AnnualSalary { get; set; }
        public decimal AnnualProductionBonus { get; set; } 

        public decimal NightShift_ProductionBonus { get; private set; }
        public decimal DayShift_ProductionBonus { get; private set; }

        
        public ShiftSupervisor(decimal annualSalary)
        {
            AnnualSalary = annualSalary;
           AnnualProductionBonusCalculator();
        }

        
        private void AnnualProductionBonusCalculator()
        {
            NightShift_ProductionBonus = 10m / 100m * AnnualSalary;
            DayShift_ProductionBonus =   7m / 100m  * AnnualSalary;
            AnnualProductionBonus = NightShift_ProductionBonus + DayShift_ProductionBonus;
        }
    }
}
