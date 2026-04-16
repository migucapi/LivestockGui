namespace LivestockGui
{
    partial class FrmFarmReport
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
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(217, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 2;
            label1.Text = "Livestock Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(150, 21);
            label2.TabIndex = 3;
            label2.Text = "Weekly Food Report";
            // 
            // button2
            // 
            button2.Location = new Point(12, 119);
            button2.Name = "button2";
            button2.Size = new Size(160, 27);
            button2.TabIndex = 7;
            button2.Text = "Refresh Report";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(178, 119);
            button1.Name = "button1";
            button1.Size = new Size(160, 27);
            button1.TabIndex = 8;
            button1.Text = "Back to Homepage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 155);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(770, 283);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // FrmFarmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFarmReport";
            Text = "FrmFarmReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button2;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}