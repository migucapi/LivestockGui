namespace LivestockGui
{
    partial class FrmRemoveAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(209, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 1;
            label1.Text = "Livestock Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 85);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 2;
            label2.Text = "Remove Animal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 126);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 3;
            label3.Text = "Choose Animal to Remove";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(42, 144);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 23);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(42, 383);
            button1.Name = "button1";
            button1.Size = new Size(160, 27);
            button1.TabIndex = 5;
            button1.Text = "Back to Homepage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(42, 185);
            button2.Name = "button2";
            button2.Size = new Size(160, 27);
            button2.TabIndex = 6;
            button2.Text = "Remove Animal";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmRemoveAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRemoveAnimal";
            Text = "FrmRemoveAnimal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}