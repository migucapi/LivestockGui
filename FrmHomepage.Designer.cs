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
            label1 = new Label();
            btnAddAnimal = new Button();
            btnRecordAnimalIntake = new Button();
            btnLivestockReport = new Button();
            btnRemoveAnimal = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(438, 54);
            label1.TabIndex = 0;
            label1.Text = "Livestock Manager App";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 81);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 5;
            label2.Text = "Animals On Farm";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(24, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(730, 210);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // FrmHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(btnRemoveAnimal);
            Controls.Add(btnLivestockReport);
            Controls.Add(btnRecordAnimalIntake);
            Controls.Add(btnAddAnimal);
            Controls.Add(label1);
            Name = "FrmHomepage";
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddAnimal;
        private Button btnRecordAnimalIntake;
        private Button btnLivestockReport;
        private Button btnRemoveAnimal;
        private Label label2;
        private RichTextBox richTextBox1;
    }
}