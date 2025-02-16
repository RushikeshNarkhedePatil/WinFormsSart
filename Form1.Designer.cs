namespace WinFormsSart
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtpassword = new TextBox();
            txtUname = new TextBox();
            txtph = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboGender = new ComboBox();
            btnRegister = new Button();
            bindingSource1 = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Fierst name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 84);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(97, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(122, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(97, 87);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(122, 27);
            txtAddress.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.3423424F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.6576576F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.Controls.Add(txtpassword, 3, 3);
            tableLayoutPanel1.Controls.Add(txtUname, 1, 3);
            tableLayoutPanel1.Controls.Add(txtph, 3, 2);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(txtLname, 3, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtAddress, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 2, 1);
            tableLayoutPanel1.Controls.Add(label7, 2, 2);
            tableLayoutPanel1.Controls.Add(label8, 2, 3);
            tableLayoutPanel1.Controls.Add(comboGender, 3, 1);
            tableLayoutPanel1.Location = new Point(150, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2195129F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.7804871F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(500, 322);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(339, 248);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(122, 27);
            txtpassword.TabIndex = 14;
            // 
            // txtUname
            // 
            txtUname.Location = new Point(97, 248);
            txtUname.Name = "txtUname";
            txtUname.PasswordChar = '*';
            txtUname.Size = new Size(122, 27);
            txtUname.TabIndex = 13;
            // 
            // txtph
            // 
            txtph.Location = new Point(339, 167);
            txtph.Name = "txtph";
            txtph.PasswordChar = '*';
            txtph.Size = new Size(122, 27);
            txtph.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '*';
            txtEmail.Size = new Size(122, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(339, 3);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(122, 27);
            txtLname.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 164);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 245);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "User Name ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 0);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 5;
            label5.Text = "Last name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(225, 84);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 6;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(225, 164);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 245);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 8;
            label8.Text = "Password";
            // 
            // comboGender
            // 
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboGender.Location = new Point(339, 87);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(151, 28);
            comboGender.TabIndex = 15;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(360, 378);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(125, 46);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Submit";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAddress;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRegister;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtpassword;
        private TextBox txtUname;
        private TextBox txtph;
        private TextBox txtEmail;
        private TextBox txtLname;
        private ComboBox comboGender;
        private BindingSource bindingSource1;
    }
}
