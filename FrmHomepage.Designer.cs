namespace LivestockGui
{
    partial class FrmHomepage
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
            lblHomePage = new Label();
            btnAddAnimal = new Button();
            btnRecordAnimalIntake = new Button();
            btnLivestockReport = new Button();
            btnRemoveAnimal = new Button();
            lblAnimalsOnFarm = new Label();
            rtbAnimalsOnFarm = new RichTextBox();
            SuspendLayout();
            // 
            // lblHomePage
            // 
            lblHomePage.AutoSize = true;
            lblHomePage.Font = new Font("Segoe UI", 30F);
            lblHomePage.Location = new Point(169, 9);
            lblHomePage.Name = "lblHomePage";
            lblHomePage.Size = new Size(438, 54);
            lblHomePage.TabIndex = 0;
            lblHomePage.Text = "Livestock Manager App";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(577, 318);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(184, 30);
            btnAddAnimal.TabIndex = 1;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // btnRecordAnimalIntake
            // 
            btnRecordAnimalIntake.Location = new Point(578, 354);
            btnRecordAnimalIntake.Name = "btnRecordAnimalIntake";
            btnRecordAnimalIntake.Size = new Size(183, 29);
            btnRecordAnimalIntake.TabIndex = 2;
            btnRecordAnimalIntake.Text = "Record Animal Intake";
            btnRecordAnimalIntake.UseVisualStyleBackColor = true;
            btnRecordAnimalIntake.Click += btnRecordAnimalIntake_Click;
            // 
            // btnLivestockReport
            // 
            btnLivestockReport.Location = new Point(578, 389);
            btnLivestockReport.Name = "btnLivestockReport";
            btnLivestockReport.Size = new Size(183, 29);
            btnLivestockReport.TabIndex = 3;
            btnLivestockReport.Text = "Farm Livestock Report";
            btnLivestockReport.UseVisualStyleBackColor = true;
            btnLivestockReport.Click += btnLivestockReport_Click;
            // 
            // btnRemoveAnimal
            // 
            btnRemoveAnimal.Location = new Point(24, 318);
            btnRemoveAnimal.Name = "btnRemoveAnimal";
            btnRemoveAnimal.Size = new Size(183, 29);
            btnRemoveAnimal.TabIndex = 4;
            btnRemoveAnimal.Text = "Remove Animal";
            btnRemoveAnimal.UseVisualStyleBackColor = true;
            btnRemoveAnimal.Click += btnRemoveAnimal_Click;
            // 
            // lblAnimalsOnFarm
            // 
            lblAnimalsOnFarm.AutoSize = true;
            lblAnimalsOnFarm.Font = new Font("Segoe UI", 12F);
            lblAnimalsOnFarm.Location = new Point(24, 81);
            lblAnimalsOnFarm.Name = "lblAnimalsOnFarm";
            lblAnimalsOnFarm.Size = new Size(130, 21);
            lblAnimalsOnFarm.TabIndex = 5;
            lblAnimalsOnFarm.Text = "Animals On Farm";
            // 
            // rtbAnimalsOnFarm
            // 
            rtbAnimalsOnFarm.Location = new Point(24, 102);
            rtbAnimalsOnFarm.Name = "rtbAnimalsOnFarm";
            rtbAnimalsOnFarm.Size = new Size(730, 210);
            rtbAnimalsOnFarm.TabIndex = 6;
            rtbAnimalsOnFarm.Text = "";
            // 
            // FrmHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbAnimalsOnFarm);
            Controls.Add(lblAnimalsOnFarm);
            Controls.Add(btnRemoveAnimal);
            Controls.Add(btnLivestockReport);
            Controls.Add(btnRecordAnimalIntake);
            Controls.Add(btnAddAnimal);
            Controls.Add(lblHomePage);
            Name = "FrmHomepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHomePage;
        private Button btnAddAnimal;
        private Button btnRecordAnimalIntake;
        private Button btnLivestockReport;
        private Button btnRemoveAnimal;
        private Label lblAnimalsOnFarm;
        private RichTextBox rtbAnimalsOnFarm;
    }
}