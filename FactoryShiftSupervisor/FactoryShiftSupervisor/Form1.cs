using System;
using System.Windows.Forms;

namespace FactoryShiftSupervisor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            ShiftSupervisor supervisor1 = new ShiftSupervisor(73000m)
            {
                Name = "Mike",
                AnnualSalary = 73000m,
                EmployeeNumber = 001,
            };



            listBox1.Items.Add($"Shift Supervisor 1, {supervisor1.Name}");
            listBox1.Items.Add($"Employee Number: {supervisor1.EmployeeNumber}");
            listBox1.Items.Add($"Annual Salary: {supervisor1.AnnualSalary} CAD");
            listBox1.Items.Add($"{supervisor1.Name}'s Annual Production Bonus: {supervisor1.AnnualProductionBonus} CAD ");

            listBox1.Items.Add(new string("= = = = = = = = = = = = = = = = = = = = = = = = = = ="));

            ShiftSupervisor supervisor2 = new ShiftSupervisor(80000m)
            {
                Name = "Atrina",
                AnnualSalary = 80000m,
                EmployeeNumber = 002,
            };



            listBox1.Items.Add($"Shift Supervisor 1, {supervisor2.Name}");
            listBox1.Items.Add($"Employee Number: {supervisor2.EmployeeNumber}");
            listBox1.Items.Add($"Annual Salary: {supervisor2.AnnualSalary} CAD");
            listBox1.Items.Add($"{supervisor2.Name}'s Annual Production Bonus: {supervisor2.AnnualProductionBonus} CAD ");

            listBox1.Items.Add(new string("= = = = = = = = = = = = = = = = = = = = = = = = = = ="));
        }



        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
