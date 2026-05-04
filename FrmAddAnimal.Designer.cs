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
            lblAddAnimal = new Label();
            lblAddNewAnimal = new Label();
            btnHomePage = new Button();
            btnAddAnimal = new Button();
            txbAnimalName = new TextBox();
            cbxSpecies = new ComboBox();
            cbxFoodType = new ComboBox();
            txbWeeklyBudget = new TextBox();
            lblAnimalName = new Label();
            lblSpecies = new Label();
            lblFoodType = new Label();
            lblWeeklyBudget = new Label();
            SuspendLayout();
            // 
            // lblAddAnimal
            // 
            lblAddAnimal.AutoSize = true;
            lblAddAnimal.Font = new Font("Segoe UI", 30F);
            lblAddAnimal.Location = new Point(259, 9);
            lblAddAnimal.Name = "lblAddAnimal";
            lblAddAnimal.Size = new Size(353, 54);
            lblAddAnimal.TabIndex = 0;
            lblAddAnimal.Text = "Livestock Manager";
            // 
            // lblAddNewAnimal
            // 
            lblAddNewAnimal.AutoSize = true;
            lblAddNewAnimal.Font = new Font("Segoe UI", 12F);
            lblAddNewAnimal.Location = new Point(37, 89);
            lblAddNewAnimal.Name = "lblAddNewAnimal";
            lblAddNewAnimal.Size = new Size(127, 21);
            lblAddNewAnimal.TabIndex = 1;
            lblAddNewAnimal.Text = "Add New Animal";
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(213, 288);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(168, 26);
            btnHomePage.TabIndex = 2;
            btnHomePage.Text = "Back to Homepage";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(39, 288);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(168, 26);
            btnAddAnimal.TabIndex = 3;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // txbAnimalName
            // 
            txbAnimalName.Location = new Point(149, 127);
            txbAnimalName.Name = "txbAnimalName";
            txbAnimalName.Size = new Size(302, 23);
            txbAnimalName.TabIndex = 4;
            // 
            // cbxSpecies
            // 
            cbxSpecies.FormattingEnabled = true;
            cbxSpecies.Items.AddRange(new object[] { "Cow", "Sheep", "Pig", "Chicken", "Horse", "Goat", "Duck", "Alpaca", "Deer", "Turkey" });
            cbxSpecies.Location = new Point(149, 166);
            cbxSpecies.Name = "cbxSpecies";
            cbxSpecies.Size = new Size(302, 23);
            cbxSpecies.TabIndex = 5;
            // 
            // cbxFoodType
            // 
            cbxFoodType.FormattingEnabled = true;
            cbxFoodType.Items.AddRange(new object[] { "Hay", "Grain", "Silage", "Pellets", "Grass", "Corn", "Fishmeal", "Molasses", "Straw", "Vegetables" });
            cbxFoodType.Location = new Point(149, 204);
            cbxFoodType.Name = "cbxFoodType";
            cbxFoodType.Size = new Size(302, 23);
            cbxFoodType.TabIndex = 6;
            // 
            // txbWeeklyBudget
            // 
            txbWeeklyBudget.Location = new Point(149, 245);
            txbWeeklyBudget.Name = "txbWeeklyBudget";
            txbWeeklyBudget.Size = new Size(302, 23);
            txbWeeklyBudget.TabIndex = 7;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Location = new Point(40, 130);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(80, 15);
            lblAnimalName.TabIndex = 8;
            lblAnimalName.Text = "Animal Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(40, 169);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 9;
            lblSpecies.Text = "Species";
            // 
            // lblFoodType
            // 
            lblFoodType.AutoSize = true;
            lblFoodType.Location = new Point(40, 207);
            lblFoodType.Name = "lblFoodType";
            lblFoodType.Size = new Size(61, 15);
            lblFoodType.TabIndex = 10;
            lblFoodType.Text = "Food Type";
            // 
            // lblWeeklyBudget
            // 
            lblWeeklyBudget.AutoSize = true;
            lblWeeklyBudget.Location = new Point(40, 248);
            lblWeeklyBudget.Name = "lblWeeklyBudget";
            lblWeeklyBudget.Size = new Size(103, 15);
            lblWeeklyBudget.TabIndex = 11;
            lblWeeklyBudget.Text = "Weekly Budget ($)";
            // 
            // FrmAddAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 532);
            Controls.Add(lblWeeklyBudget);
            Controls.Add(lblFoodType);
            Controls.Add(lblSpecies);
            Controls.Add(lblAnimalName);
            Controls.Add(txbWeeklyBudget);
            Controls.Add(cbxFoodType);
            Controls.Add(cbxSpecies);
            Controls.Add(txbAnimalName);
            Controls.Add(btnAddAnimal);
            Controls.Add(btnHomePage);
            Controls.Add(lblAddNewAnimal);
            Controls.Add(lblAddAnimal);
            Name = "FrmAddAnimal";
            Text = "Add Animal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAddAnimal;
        private Label lblAddNewAnimal;
        private Button btnHomePage;
        private Button btnAddAnimal;
        private TextBox txbAnimalName;
        private ComboBox cbxSpecies;
        private ComboBox cbxFoodType;
        private TextBox txbWeeklyBudget;
        private Label lblAnimalName;
        private Label lblSpecies;
        private Label lblFoodType;
        private Label lblWeeklyBudget;
    }
}
