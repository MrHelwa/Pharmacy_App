namespace Pharmacy_App
{
    partial class AddNewCategoryForm
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
            ShowCategoriesButton = new Button();
            AddCategoryButton = new Button();
            CategoryNameTxtBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewData).BeginInit();
            SuspendLayout();
            // 
            // ViewData
            // 
            ViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewData.Location = new Point(12, 84);
            ViewData.Name = "ViewData";
            ViewData.RowHeadersWidth = 51;
            ViewData.RowTemplate.Height = 29;
            ViewData.Size = new Size(536, 410);
            ViewData.TabIndex = 0;
            // 
            // ShowCategoriesButton
            // 
            ShowCategoriesButton.Location = new Point(12, 12);
            ShowCategoriesButton.Name = "ShowCategoriesButton";
            ShowCategoriesButton.Size = new Size(253, 40);
            ShowCategoriesButton.TabIndex = 1;
            ShowCategoriesButton.Text = "Show All Categories";
            ShowCategoriesButton.UseVisualStyleBackColor = true;
            ShowCategoriesButton.Click += ShowCategoriesButton_Click;
            // 
            // AddCategoryButton
            // 
            AddCategoryButton.Location = new Point(745, 171);
            AddCategoryButton.Name = "AddCategoryButton";
            AddCategoryButton.Size = new Size(154, 47);
            AddCategoryButton.TabIndex = 1;
            AddCategoryButton.Text = "Add New Category";
            AddCategoryButton.UseVisualStyleBackColor = true;
            AddCategoryButton.Click += AddCategoryButton_Click;
            // 
            // CategoryNameTxtBox
            // 
            CategoryNameTxtBox.Location = new Point(715, 108);
            CategoryNameTxtBox.Name = "CategoryNameTxtBox";
            CategoryNameTxtBox.Size = new Size(239, 27);
            CategoryNameTxtBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(579, 112);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 3;
            label1.Text = "Category Name";
            // 
            // AddNewCategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 506);
            Controls.Add(label1);
            Controls.Add(CategoryNameTxtBox);
            Controls.Add(AddCategoryButton);
            Controls.Add(ShowCategoriesButton);
            Controls.Add(ViewData);
            Name = "AddNewCategoryForm";
            Text = "AddNewCategoryForm";
            ((System.ComponentModel.ISupportInitialize)ViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ViewData;
        private Button ShowCategoriesButton;
        private Button AddCategoryButton;
        private TextBox CategoryNameTxtBox;
        private Label label1;
    }
}