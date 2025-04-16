namespace Pharmacy_App_1
{
    partial class MainForm
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
            ViewData = new DataGridView();
            ShowMedicineButton = new Button();
            ShowCategoryButton = new Button();
            ShowExpButton = new Button();
            AddNewCategoryButton = new Button();
            AddMedicineButton = new Button();
            SearchMedicineTextBox = new TextBox();
            SearchCategoryTextBox = new TextBox();
            SearchMedicineButton = new Button();
            SearchCategoryButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewData).BeginInit();
            SuspendLayout();
            // 
            // ViewData
            // 
            ViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewData.Location = new Point(12, 119);
            ViewData.Name = "ViewData";
            ViewData.RowHeadersWidth = 51;
            ViewData.RowTemplate.Height = 29;
            ViewData.Size = new Size(765, 379);
            ViewData.TabIndex = 0;
            // 
            // ShowMedicineButton
            // 
            ShowMedicineButton.Location = new Point(803, 119);
            ShowMedicineButton.Name = "ShowMedicineButton";
            ShowMedicineButton.Size = new Size(268, 71);
            ShowMedicineButton.TabIndex = 1;
            ShowMedicineButton.Text = "Show All Medicine";
            ShowMedicineButton.UseVisualStyleBackColor = true;
            ShowMedicineButton.Click += ShowAllMedicineButton_Click;
            // 
            // ShowCategoryButton
            // 
            ShowCategoryButton.Location = new Point(803, 196);
            ShowCategoryButton.Name = "ShowCategoryButton";
            ShowCategoryButton.Size = new Size(268, 71);
            ShowCategoryButton.TabIndex = 2;
            ShowCategoryButton.Text = "Show All Categories";
            ShowCategoryButton.UseVisualStyleBackColor = true;
            ShowCategoryButton.Click += ShowAllCategoriesButton_Click;
            // 
            // ShowExpButton
            // 
            ShowExpButton.Location = new Point(803, 427);
            ShowExpButton.Name = "ShowExpButton";
            ShowExpButton.Size = new Size(268, 71);
            ShowExpButton.TabIndex = 3;
            ShowExpButton.Text = "Show Expired Medicine";
            ShowExpButton.UseVisualStyleBackColor = true;
            ShowExpButton.Click += ShowExpiredMedicineButton_Click;
            // 
            // AddNewCategoryButton
            // 
            AddNewCategoryButton.Location = new Point(803, 350);
            AddNewCategoryButton.Name = "AddNewCategoryButton";
            AddNewCategoryButton.Size = new Size(268, 71);
            AddNewCategoryButton.TabIndex = 3;
            AddNewCategoryButton.Text = "Add New Category";
            AddNewCategoryButton.UseVisualStyleBackColor = true;
            AddNewCategoryButton.Click += AddNewCategoryButton_Click;
            // 
            // AddMedicineButton
            // 
            AddMedicineButton.Location = new Point(803, 273);
            AddMedicineButton.Name = "AddMedicineButton";
            AddMedicineButton.Size = new Size(268, 71);
            AddMedicineButton.TabIndex = 3;
            AddMedicineButton.Text = "Add New Medicine";
            AddMedicineButton.UseVisualStyleBackColor = true;
            AddMedicineButton.Click += AddNewMedicineButton_Click;
            // 
            // SearchMedicineTextBox
            // 
            SearchMedicineTextBox.Location = new Point(136, 12);
            SearchMedicineTextBox.Name = "SearchMedicineTextBox";
            SearchMedicineTextBox.Size = new Size(251, 27);
            SearchMedicineTextBox.TabIndex = 4;
            // 
            // SearchCategoryTextBox
            // 
            SearchCategoryTextBox.Location = new Point(546, 12);
            SearchCategoryTextBox.Name = "SearchCategoryTextBox";
            SearchCategoryTextBox.Size = new Size(251, 27);
            SearchCategoryTextBox.TabIndex = 5;
            // 
            // SearchMedicineButton
            // 
            SearchMedicineButton.Location = new Point(136, 56);
            SearchMedicineButton.Name = "SearchMedicineButton";
            SearchMedicineButton.Size = new Size(147, 29);
            SearchMedicineButton.TabIndex = 6;
            SearchMedicineButton.Text = "Search Medicine";
            SearchMedicineButton.UseVisualStyleBackColor = true;
            SearchMedicineButton.Click += SearchMedicineButton_Click;
            // 
            // SearchCategoryButton
            // 
            SearchCategoryButton.Location = new Point(546, 56);
            SearchCategoryButton.Name = "SearchCategoryButton";
            SearchCategoryButton.Size = new Size(147, 29);
            SearchCategoryButton.TabIndex = 7;
            SearchCategoryButton.Text = "Search Category";
            SearchCategoryButton.UseVisualStyleBackColor = true;
            SearchCategoryButton.Click += SearchCategoryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 8;
            label1.Text = "Search Medicine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 19);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 9;
            label2.Text = "Search Category";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 522);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SearchCategoryButton);
            Controls.Add(SearchMedicineButton);
            Controls.Add(SearchCategoryTextBox);
            Controls.Add(SearchMedicineTextBox);
            Controls.Add(AddNewCategoryButton);
            Controls.Add(AddMedicineButton);
            Controls.Add(ShowExpButton);
            Controls.Add(ShowCategoryButton);
            Controls.Add(ShowMedicineButton);
            Controls.Add(ViewData);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)ViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ViewData;
        private Button ShowMedicineButton;
        private Button ShowCategoryButton;
        private Button ShowExpButton;
        private Button AddNewCategoryButton;
        private Button AddMedicineButton;
        private TextBox SearchMedicineTextBox;
        private TextBox SearchCategoryTextBox;
        private Button SearchMedicineButton;
        private Button SearchCategoryButton;
        private Label label1;
        private Label label2;
    }
}