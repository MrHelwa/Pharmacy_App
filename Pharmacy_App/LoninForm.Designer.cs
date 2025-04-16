namespace Pharmacy_App
{
    partial class LoninForm
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
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LoginBtn = new Button();
            RegisterPage = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(281, 43);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(278, 27);
            txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(281, 150);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(278, 27);
            txt_password.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 50);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 150);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(310, 228);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(216, 29);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Log In";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginClick;
            // 
            // RegisterPage
            // 
            RegisterPage.Location = new Point(310, 300);
            RegisterPage.Name = "RegisterPage";
            RegisterPage.Size = new Size(216, 29);
            RegisterPage.TabIndex = 3;
            RegisterPage.Text = "Register Page";
            RegisterPage.UseVisualStyleBackColor = true;
            RegisterPage.Click += RegisterBtn_Click;
            // 
            // LoninForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterPage);
            Controls.Add(LoginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Name = "LoninForm";
            Text = "LoninForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button LoginBtn;
        private Button RegisterPage;
    }
}