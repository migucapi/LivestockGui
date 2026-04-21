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
            lblRemoveAnimal = new Label();
            lblRemAnimal = new Label();
            lblChooseAnimal = new Label();
            cbxChooseAnimal = new ComboBox();
            btnHomepage = new Button();
            btnRemoveAnimal = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblRemoveAnimal
            // 
            lblRemoveAnimal.AutoSize = true;
            lblRemoveAnimal.Font = new Font("Segoe UI", 30F);
            lblRemoveAnimal.Location = new Point(209, 9);
            lblRemoveAnimal.Name = "lblRemoveAnimal";
            lblRemoveAnimal.Size = new Size(353, 54);
            lblRemoveAnimal.TabIndex = 1;
            lblRemoveAnimal.Text = "Livestock Manager";
            // 
            // lblRemAnimal
            // 
            lblRemAnimal.AutoSize = true;
            lblRemAnimal.Font = new Font("Segoe UI", 12F);
            lblRemAnimal.Location = new Point(42, 85);
            lblRemAnimal.Name = "lblRemAnimal";
            lblRemAnimal.Size = new Size(120, 21);
            lblRemAnimal.TabIndex = 2;
            lblRemAnimal.Text = "Remove Animal";
            // 
            // lblChooseAnimal
            // 
            lblChooseAnimal.AutoSize = true;
            lblChooseAnimal.Location = new Point(299, 146);
            lblChooseAnimal.Name = "lblChooseAnimal";
            lblChooseAnimal.Size = new Size(148, 15);
            lblChooseAnimal.TabIndex = 3;
            lblChooseAnimal.Text = "Choose Animal to Remove";
            // 
            // cbxChooseAnimal
            // 
            cbxChooseAnimal.FormattingEnabled = true;
            cbxChooseAnimal.Location = new Point(226, 225);
            cbxChooseAnimal.Name = "cbxChooseAnimal";
            cbxChooseAnimal.Size = new Size(278, 23);
            cbxChooseAnimal.TabIndex = 4;
            // 
            // btnHomepage
            // 
            btnHomepage.Location = new Point(42, 383);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(160, 27);
            btnHomepage.TabIndex = 5;
            btnHomepage.Text = "Back to Homepage";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // btnRemoveAnimal
            // 
            btnRemoveAnimal.Location = new Point(287, 317);
            btnRemoveAnimal.Name = "btnRemoveAnimal";
            btnRemoveAnimal.Size = new Size(160, 27);
            btnRemoveAnimal.TabIndex = 6;
            btnRemoveAnimal.Text = "Remove Animal";
            btnRemoveAnimal.UseVisualStyleBackColor = true;
            btnRemoveAnimal.Click += btnRemoveAnimal_Click;
            // 
            // FrmRemoveAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoveAnimal);
            Controls.Add(btnHomepage);
            Controls.Add(cbxChooseAnimal);
            Controls.Add(lblChooseAnimal);
            Controls.Add(lblRemAnimal);
            Controls.Add(lblRemoveAnimal);
            Name = "FrmRemoveAnimal";
            Text = "Remove Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRemoveAnimal;
        private Label lblRemAnimal;
        private Label lblChooseAnimal;
        private ComboBox cbxChooseAnimal;
        private Button btnHomepage;
        private Button btnRemoveAnimal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}