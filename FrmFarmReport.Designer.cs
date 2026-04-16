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
            lblFarmReport = new Label();
            lblWeeklyFoodReport = new Label();
            btnRefreshReport = new Button();
            btnHomepage = new Button();
            rtbLivestockReport = new RichTextBox();
            SuspendLayout();
            // 
            // lblFarmReport
            // 
            lblFarmReport.AutoSize = true;
            lblFarmReport.Font = new Font("Segoe UI", 30F);
            lblFarmReport.Location = new Point(217, 9);
            lblFarmReport.Name = "lblFarmReport";
            lblFarmReport.Size = new Size(353, 54);
            lblFarmReport.TabIndex = 2;
            lblFarmReport.Text = "Livestock Manager";
            // 
            // lblWeeklyFoodReport
            // 
            lblWeeklyFoodReport.AutoSize = true;
            lblWeeklyFoodReport.Font = new Font("Segoe UI", 12F);
            lblWeeklyFoodReport.Location = new Point(12, 82);
            lblWeeklyFoodReport.Name = "lblWeeklyFoodReport";
            lblWeeklyFoodReport.Size = new Size(150, 21);
            lblWeeklyFoodReport.TabIndex = 3;
            lblWeeklyFoodReport.Text = "Weekly Food Report";
            // 
            // btnRefreshReport
            // 
            btnRefreshReport.Location = new Point(12, 119);
            btnRefreshReport.Name = "btnRefreshReport";
            btnRefreshReport.Size = new Size(160, 27);
            btnRefreshReport.TabIndex = 7;
            btnRefreshReport.Text = "Refresh Report";
            btnRefreshReport.UseVisualStyleBackColor = true;
            // 
            // btnHomepage
            // 
            btnHomepage.Location = new Point(178, 119);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(160, 27);
            btnHomepage.TabIndex = 8;
            btnHomepage.Text = "Back to Homepage";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += button1_Click;
            // 
            // rtbLivestockReport
            // 
            rtbLivestockReport.Location = new Point(12, 155);
            rtbLivestockReport.Name = "rtbLivestockReport";
            rtbLivestockReport.Size = new Size(770, 283);
            rtbLivestockReport.TabIndex = 9;
            rtbLivestockReport.Text = "";
            // 
            // FrmFarmReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbLivestockReport);
            Controls.Add(btnHomepage);
            Controls.Add(btnRefreshReport);
            Controls.Add(lblWeeklyFoodReport);
            Controls.Add(lblFarmReport);
            Name = "FrmFarmReport";
            Text = "Farm Livestock Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFarmReport;
        private Label lblWeeklyFoodReport;
        private Button btnRefreshReport;
        private Button btnHomepage;
        private RichTextBox rtbLivestockReport;
    }
}