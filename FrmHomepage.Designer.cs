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
            lblAddAnimal = new Label();
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
            btnAddAnimal.Location = new Point(233, 118);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(268, 75);
            btnAddAnimal.TabIndex = 1;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // lblAddAnimal
            // 
            lblAddAnimal.AutoSize = true;
            lblAddAnimal.Font = new Font("Segoe UI", 12F);
            lblAddAnimal.Location = new Point(266, 94);
            lblAddAnimal.Name = "lblAddAnimal";
            lblAddAnimal.Size = new Size(194, 21);
            lblAddAnimal.TabIndex = 2;
            lblAddAnimal.Text = "Add an animal to the farm:";
            // 
            // FrmHomepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAddAnimal);
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
        private Label lblAddAnimal;
    }
}