namespace LivestockGui
{
    partial class FrmAddAnimal
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
            label1 = new Label();
            label2 = new Label();
            btnHomePage = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(259, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 0;
            label1.Text = "Livestock Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 1;
            label2.Text = "Add New Animal";
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(211, 290);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(168, 26);
            btnHomePage.TabIndex = 2;
            btnHomePage.Text = "Back to Homepage";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // button1
            // 
            button1.Location = new Point(37, 290);
            button1.Name = "button1";
            button1.Size = new Size(168, 26);
            button1.TabIndex = 3;
            button1.Text = "Add Animal";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(146, 206);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(302, 23);
            comboBox2.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 247);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 132);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 8;
            label3.Text = "Animal Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 171);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Species";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 209);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 10;
            label5.Text = "Food Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 250);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 11;
            label6.Text = "Weekly Budget ($)";
            // 
            // FrmAddAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 532);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnHomePage);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAddAnimal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHomePage;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
