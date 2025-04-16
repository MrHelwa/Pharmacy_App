namespace Pharmacy_App_1
{
    partial class AddNewMedicineForm
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
            MedicineNameTxtBox = new TextBox();
            MedicinePriceTxtBox = new TextBox();
            ExpirationDatePicker = new DateTimePicker();
            ProductionDatePicker = new DateTimePicker();
            ViewData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AddMedicineButton = new Button();
            ShowMedicinesButton = new Button();
            categoriesListBox = new ListBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)ViewData).BeginInit();
            SuspendLayout();
            // 
            // MedicineNameTxtBox
            // 
            MedicineNameTxtBox.Location = new Point(834, 168);
            MedicineNameTxtBox.Name = "MedicineNameTxtBox";
            MedicineNameTxtBox.Size = new Size(250, 27);
            MedicineNameTxtBox.TabIndex = 0;
            // 
            // MedicinePriceTxtBox
            // 
            MedicinePriceTxtBox.Location = new Point(834, 243);
            MedicinePriceTxtBox.Name = "MedicinePriceTxtBox";
            MedicinePriceTxtBox.Size = new Size(250, 27);
            MedicinePriceTxtBox.TabIndex = 1;
            // 
            // ExpirationDatePicker
            // 
            ExpirationDatePicker.Location = new Point(834, 393);
            ExpirationDatePicker.Name = "ExpirationDatePicker";
            ExpirationDatePicker.Size = new Size(250, 27);
            ExpirationDatePicker.TabIndex = 5;
            // 
            // ProductionDatePicker
            // 
            ProductionDatePicker.Location = new Point(834, 317);
            ProductionDatePicker.Name = "ProductionDatePicker";
            ProductionDatePicker.Size = new Size(250, 27);
            ProductionDatePicker.TabIndex = 6;
            // 
            // ViewData
            // 
            ViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewData.Location = new Point(12, 104);
            ViewData.Name = "ViewData";
            ViewData.RowHeadersWidth = 51;
            ViewData.RowTemplate.Height = 29;
            ViewData.Size = new Size(662, 358);
            ViewData.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(687, 172);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 8;
            label1.Text = "Medicine Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(693, 247);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 8;
            label2.Text = "Medicine Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(687, 321);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 8;
            label3.Text = "Production Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(687, 393);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 8;
            label4.Text = "Expiration Date";
            // 
            // AddMedicineButton
            // 
            AddMedicineButton.Location = new Point(863, 440);
            AddMedicineButton.Name = "AddMedicineButton";
            AddMedicineButton.Size = new Size(195, 51);
            AddMedicineButton.TabIndex = 9;
            AddMedicineButton.Text = "Add Medicine";
            AddMedicineButton.UseVisualStyleBackColor = true;
            AddMedicineButton.Click += AddMedicineButton_Click;
            // 
            // ShowMedicinesButton
            // 
            ShowMedicinesButton.Location = new Point(206, 12);
            ShowMedicinesButton.Name = "ShowMedicinesButton";
            ShowMedicinesButton.Size = new Size(191, 40);
            ShowMedicinesButton.TabIndex = 10;
            ShowMedicinesButton.Text = "Show All Medicines";
            ShowMedicinesButton.UseVisualStyleBackColor = true;
            ShowMedicinesButton.Click += ShowAllMedicineButton_Click;
            // 
            // categoriesListBox
            // 
            categoriesListBox.FormattingEnabled = true;
            categoriesListBox.ItemHeight = 20;
            categoriesListBox.Location = new Point(834, 105);
            categoriesListBox.Name = "categoriesListBox";
            categoriesListBox.Size = new Size(250, 24);
            categoriesListBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(687, 105);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 12;
            label6.Text = "Medicine Category";
            // 
            // AddNewMedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 503);
            Controls.Add(label6);
            Controls.Add(categoriesListBox);
            Controls.Add(ShowMedicinesButton);
            Controls.Add(AddMedicineButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ViewData);
            Controls.Add(ProductionDatePicker);
            Controls.Add(ExpirationDatePicker);
            Controls.Add(MedicinePriceTxtBox);
            Controls.Add(MedicineNameTxtBox);
            Name = "AddNewMedicineForm";
            Text = "AddNewMedicineForm";
            ((System.ComponentModel.ISupportInitialize)ViewData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MedicineNameTxtBox;
        private TextBox MedicinePriceTxtBox;
        private DateTimePicker ExpirationDatePicker;
        private DateTimePicker ProductionDatePicker;
        private DataGridView ViewData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button AddMedicineButton;
        private Button ShowMedicinesButton;
        private ListBox categoriesListBox;
        private Label label6;
    }
}