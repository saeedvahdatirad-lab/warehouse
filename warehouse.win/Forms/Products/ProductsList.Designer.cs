
namespace warehouse.win.Forms
{
    partial class ProductsList
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
            dataGridView1 = new DataGridView();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label7 = new Label();
            btnCancel = new Button();
            btnLogin = new Button();
            button1 = new Button();
            button2 = new Button();
            id = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCountUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, ProductName, ProductCountUnit });
            dataGridView1.Location = new Point(12, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.Size = new Size(951, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(680, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(68, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(786, 22);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(93, 23);
            txtUserName.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(492, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(345, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(82, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(68, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(668, 20);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 23);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(951, 57);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "فرم ثبت کالا";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 24);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 17;
            label6.Text = "مقدار";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 24);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 16;
            label5.Text = "تاریخ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(742, 24);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 15;
            label4.Text = "کد کالا";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 24);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "نام کالا";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 24);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 14;
            label2.Text = "واحد";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(885, 24);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "شماره سند";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(12, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(951, 57);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجوی کالا";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(904, 23);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 18;
            label7.Text = "جستجو";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(330, 398);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "پرینت";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(541, 398);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(133, 23);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "ورودی از اکسل";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(411, 398);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 13;
            button1.Text = "گزارش به اکسل";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(249, 398);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            id.HeaderText = "ردیف";
            id.Name = "id";
            id.Width = 40;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "نام کالا";
            ProductName.Name = "ProductName";
            ProductName.Width = 300;
            // 
            // ProductCountUnit
            // 
            ProductCountUnit.HeaderText = "واحد";
            ProductCountUnit.Name = "ProductCountUnit";
            // 
            // ProductsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(button2);
            Controls.Add(btnCancel);
            Controls.Add(button1);
            Controls.Add(btnLogin);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "ProductsList";
            Text = "ProductsList";
            Load += ProductsList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private Button btnCancel;
        private Button btnLogin;
        private Button button1;
        private Button button2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCountUnit;
    }
}