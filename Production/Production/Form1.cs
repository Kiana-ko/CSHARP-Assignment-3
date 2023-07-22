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

            if (int.TryParse(textBox2.Text, out int employeeNumber))
            {
                productionWorker.EmployeeNumber = employeeNumber;
                MessageBox.Show($"Employee number updated");

                listBox1.Items.Add($"Employee number: {productionWorker.EmployeeNumber}");


                textBox1.Clear();
                textBox2.Clear();
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
    }
}