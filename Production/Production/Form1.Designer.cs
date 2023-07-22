namespace Production
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CloseButton = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            EmployeesInformationDisplayer = new Label();
            richTextBox1 = new RichTextBox();
            Instructions = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(590, 391);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(83, 36);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButtton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(366, 391);
            button2.Name = "button2";
            button2.Size = new Size(146, 36);
            button2.TabIndex = 1;
            button2.Text = "Display Employee's Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 173);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 155);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Employee Number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 210);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Employee Name";
            label2.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(366, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 304);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // EmployeesInformationDisplayer
            // 
            EmployeesInformationDisplayer.AutoSize = true;
            EmployeesInformationDisplayer.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EmployeesInformationDisplayer.Location = new Point(366, 23);
            EmployeesInformationDisplayer.Name = "EmployeesInformationDisplayer";
            EmployeesInformationDisplayer.Size = new Size(273, 19);
            EmployeesInformationDisplayer.TabIndex = 7;
            EmployeesInformationDisplayer.Text = "Employees' inforamation's displayer";
            EmployeesInformationDisplayer.Click += EmployeesInformationDisplaye_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(79, 55);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(222, 88);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "Please enter the information of the employee you'd like to add to the list below:";
            // 
            // Instructions
            // 
            Instructions.AutoSize = true;
            Instructions.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Instructions.Location = new Point(79, 23);
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(104, 21);
            Instructions.TabIndex = 9;
            Instructions.Text = "Instructions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 262);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 11;
            label3.Text = "Hourly Pay Rate";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 280);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(222, 23);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 318);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 13;
            label4.Text = "Shift";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 336);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 23);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(820, 455);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(Instructions);
            Controls.Add(richTextBox1);
            Controls.Add(EmployeesInformationDisplayer);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(CloseButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label EmployeesInformationDisplayer;
        private RichTextBox richTextBox1;
        private Label Instructions;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}