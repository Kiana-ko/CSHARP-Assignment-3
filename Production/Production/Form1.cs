using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Production
{
    public partial class Form1 : Form
    {
        public ProductionWorker productionWorker;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            productionWorker = new ProductionWorker();
        }

        private void CloseButtton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            productionWorker.EmployeeName = textBox1.Text;
            MessageBox.Show($"Employee succesfully added");
            listBox1.Items.Add($"Employee name: {productionWorker.EmployeeName}");

            double hourlyRate;
            if (double.TryParse(textBox3.Text, out hourlyRate))
            {
                productionWorker.HourlyRate = hourlyRate;
                listBox1.Items.Add($"Hourly Rate: {productionWorker.HourlyRate}");
            }
            else
            {
                MessageBox.Show("Invalid hourly rate. Please enter a valid numerical value.");
            }
            listBox1.Items.Add($"Employee Pay Rate: {productionWorker.HourlyRate} CAD Dollars");


            if (Enum.TryParse(textBox4.Text, out ShiftType shift))
            {
                productionWorker.Shift = shift;
                listBox1.Items.Add($"Shift: {productionWorker.Shift}");
            }
            else
            {
                MessageBox.Show("Invalid shift. Please enter a valid shift type (Day, Night, or Evening).");
                return; 
            }


            if (int.TryParse(textBox2.Text, out int employeeNumber))
            {
                productionWorker.EmployeeNumber = employeeNumber;
                MessageBox.Show($"Employee number updated");

                listBox1.Items.Add($"Employee number: {productionWorker.EmployeeNumber}");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Invalid employee number. Please enter a valid integer value.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeesInformationDisplaye_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}