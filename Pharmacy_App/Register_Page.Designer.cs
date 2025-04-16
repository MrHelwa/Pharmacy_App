namespace Pharmacy_App
{
    partial class Register_Page
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
            NameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Register_btn = new Button();
            Login_btn = new Button();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(329, 27);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(205, 27);
            NameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(329, 107);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(205, 27);
            EmailTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(329, 194);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(205, 27);
            PasswordTextBox.TabIndex = 0;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(329, 290);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(205, 27);
            ConfirmPasswordTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 114);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 201);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 297);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 1;
            label4.Text = "Confirm Password";
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(329, 343);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(187, 29);
            Register_btn.TabIndex = 2;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += RegisterButton_Click;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(329, 396);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(187, 29);
            Login_btn.TabIndex = 3;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_Click;
            // 
            // Register_Page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login_btn);
            Controls.Add(Register_btn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(NameTextBox);
            Name = "Register_Page";
            Text = "Register Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Register_btn;
        private Button Login_btn;
    }
}