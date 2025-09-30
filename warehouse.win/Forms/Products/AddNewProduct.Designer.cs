namespace warehouse.win.Forms
{
    partial class AddNewProduct
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
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            lblDate = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 12;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(291, 176);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(143, 23);
            txtUserName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 213);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "واحد شمارش";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 184);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 9;
            label1.Text = "نام کالا";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(318, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "خروج";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(435, 252);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(377, 65);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(30, 15);
            lblDate.TabIndex = 13;
            lblDate.Text = "date";
            // 
            // AddNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDate);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Name = "AddNewProduct";
            Text = "AddNewProduct";
            Load += AddNewProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnLogin;
        private Label lblDate;
    }
}