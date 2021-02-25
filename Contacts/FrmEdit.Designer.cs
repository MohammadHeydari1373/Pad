namespace Contacts
{
    partial class FrmEdit
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
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSubmit = new System.Windows.Forms.Button();
            this.gbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.txtAge);
            this.gbAdd.Controls.Add(this.txtAddress);
            this.gbAdd.Controls.Add(this.label5);
            this.gbAdd.Controls.Add(this.txtNumber);
            this.gbAdd.Controls.Add(this.label3);
            this.gbAdd.Controls.Add(this.label4);
            this.gbAdd.Controls.Add(this.txtFamily);
            this.gbAdd.Controls.Add(this.label2);
            this.gbAdd.Controls.Add(this.txtName);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Location = new System.Drawing.Point(12, 24);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(428, 244);
            this.gbAdd.TabIndex = 0;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "ایجاد کاربرجدید";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(262, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(120, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 140);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(367, 98);
            this.txtAddress.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "آدرس";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(18, 92);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(136, 20);
            this.txtNumber.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره تماس";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "سن";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(16, 31);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(136, 20);
            this.txtFamily.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(233, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام";
            // 
            // btnAddSubmit
            // 
            this.btnAddSubmit.Location = new System.Drawing.Point(319, 275);
            this.btnAddSubmit.Name = "btnAddSubmit";
            this.btnAddSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubmit.TabIndex = 1;
            this.btnAddSubmit.Text = "ثبت";
            this.btnAddSubmit.UseVisualStyleBackColor = true;
            this.btnAddSubmit.Click += new System.EventHandler(this.btnAddSubmit_Click);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 320);
            this.Controls.Add(this.btnAddSubmit);
            this.Controls.Add(this.gbAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSubmit;
        private System.Windows.Forms.NumericUpDown txtAge;
    }
}