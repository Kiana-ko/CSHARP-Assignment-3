namespace FactoryShiftSupervisor
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
            DisplayButton = new Button();
            CloseButton = new Button();
            listBox1 = new ListBox();
            ImployeesInfos = new Label();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.BackgroundImageLayout = ImageLayout.Stretch;
            DisplayButton.Location = new Point(74, 359);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(161, 39);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "Display Imployees Info";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = (Image)resources.GetObject("CloseButton.BackgroundImage");
            CloseButton.BackgroundImageLayout = ImageLayout.Stretch;
            CloseButton.Location = new Point(291, 355);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(105, 43);
            CloseButton.TabIndex = 1;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(74, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(322, 276);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // ImployeesInfos
            // 
            ImployeesInfos.AutoSize = true;
            ImployeesInfos.BackColor = SystemColors.ControlDark;
            ImployeesInfos.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ImployeesInfos.Location = new Point(74, 42);
            ImployeesInfos.Name = "ImployeesInfos";
            ImployeesInfos.Size = new Size(210, 19);
            ImployeesInfos.TabIndex = 3;
            ImployeesInfos.Text = "Employees Information List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(604, 556);
            Controls.Add(ImployeesInfos);
            Controls.Add(listBox1);
            Controls.Add(CloseButton);
            Controls.Add(DisplayButton);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private Button CloseButton;
        private ListBox listBox1;
        private Label ImployeesInfos;
    }
}