namespace WinFormsApp1
{
    partial class frmRegister
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
            btnRegister = new Button();
            txtName = new TextBox();
            txtClass = new TextBox();
            btnClose = new Button();
            btnClear = new Button();
            label1 = new Label();
            btnDetail = new Button();
            label2 = new Label();
            label3 = new Label();
            txtFee = new TextBox();
            label4 = new Label();
            txtLibraryFee = new TextBox();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(177, 238);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(267, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtClass
            // 
            txtClass.Location = new Point(267, 82);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(125, 27);
            txtClass.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(377, 238);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(277, 238);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 41);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(177, 289);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(94, 29);
            btnDetail.TabIndex = 6;
            btnDetail.Text = "Info Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 85);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 7;
            label2.Text = "Class";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 133);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 9;
            label3.Text = "Fee";
            
            // 
            // txtFee
            // 
            txtFee.Location = new Point(267, 130);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(125, 27);
            txtFee.TabIndex = 8;
            txtFee.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 175);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "Library fee";
            // 
            // txtLibraryFee
            // 
            txtLibraryFee.Location = new Point(267, 172);
            txtLibraryFee.Name = "txtLibraryFee";
            txtLibraryFee.Size = new Size(125, 27);
            txtLibraryFee.TabIndex = 10;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(txtLibraryFee);
            Controls.Add(label3);
            Controls.Add(txtFee);
            Controls.Add(label2);
            Controls.Add(btnDetail);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(txtClass);
            Controls.Add(txtName);
            Controls.Add(btnRegister);
            Name = "frmRegister";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private TextBox txtName;
        private TextBox txtClass;
        private Button btnClose;
        private Button btnClear;
        private Label label1;
        private Button btnDetail;
        private Label label2;
        private Label label3;
        private TextBox txtFee;
        private Label label4;
        private TextBox txtLibraryFee;
    }
}
