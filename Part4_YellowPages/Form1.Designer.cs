namespace Part4_YellowPages
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddNote = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.grpModify = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModifyFirstName = new System.Windows.Forms.TextBox();
            this.txtModifyLastName = new System.Windows.Forms.TextBox();
            this.txtModifyPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtModifyNote = new System.Windows.Forms.TextBox();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpAddUser.SuspendLayout();
            this.grpModify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnAddNew);
            this.grpAddUser.Controls.Add(this.txtAddNote);
            this.grpAddUser.Controls.Add(this.txtAddPhoneNumber);
            this.grpAddUser.Controls.Add(this.txtAddLastName);
            this.grpAddUser.Controls.Add(this.txtAddFirstName);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Location = new System.Drawing.Point(30, 28);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(277, 181);
            this.grpAddUser.TabIndex = 0;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Note";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(117, 25);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(140, 20);
            this.txtAddFirstName.TabIndex = 2;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(117, 48);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(140, 20);
            this.txtAddLastName.TabIndex = 2;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(117, 70);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(140, 20);
            this.txtAddPhoneNumber.TabIndex = 2;
            // 
            // txtAddNote
            // 
            this.txtAddNote.Location = new System.Drawing.Point(117, 92);
            this.txtAddNote.Name = "txtAddNote";
            this.txtAddNote.Size = new System.Drawing.Size(140, 20);
            this.txtAddNote.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(167, 118);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(90, 34);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New User";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // grpModify
            // 
            this.grpModify.Controls.Add(this.btnModifyUser);
            this.grpModify.Controls.Add(this.txtModifyNote);
            this.grpModify.Controls.Add(this.txtModifyPhoneNumber);
            this.grpModify.Controls.Add(this.txtModifyLastName);
            this.grpModify.Controls.Add(this.txtModifyFirstName);
            this.grpModify.Controls.Add(this.label8);
            this.grpModify.Controls.Add(this.label7);
            this.grpModify.Controls.Add(this.label6);
            this.grpModify.Controls.Add(this.label5);
            this.grpModify.Location = new System.Drawing.Point(313, 30);
            this.grpModify.Name = "grpModify";
            this.grpModify.Size = new System.Drawing.Size(280, 179);
            this.grpModify.TabIndex = 1;
            this.grpModify.TabStop = false;
            this.grpModify.Text = "Modify User";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "FirstName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "LastName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PhoneNumber";
            // 
            // txtModifyFirstName
            // 
            this.txtModifyFirstName.Location = new System.Drawing.Point(126, 23);
            this.txtModifyFirstName.Name = "txtModifyFirstName";
            this.txtModifyFirstName.Size = new System.Drawing.Size(139, 20);
            this.txtModifyFirstName.TabIndex = 1;
            // 
            // txtModifyLastName
            // 
            this.txtModifyLastName.Location = new System.Drawing.Point(126, 46);
            this.txtModifyLastName.Name = "txtModifyLastName";
            this.txtModifyLastName.Size = new System.Drawing.Size(139, 20);
            this.txtModifyLastName.TabIndex = 1;
            // 
            // txtModifyPhoneNumber
            // 
            this.txtModifyPhoneNumber.Location = new System.Drawing.Point(126, 68);
            this.txtModifyPhoneNumber.Name = "txtModifyPhoneNumber";
            this.txtModifyPhoneNumber.Size = new System.Drawing.Size(139, 20);
            this.txtModifyPhoneNumber.TabIndex = 1;
            // 
            // txtModifyNote
            // 
            this.txtModifyNote.Location = new System.Drawing.Point(126, 90);
            this.txtModifyNote.Name = "txtModifyNote";
            this.txtModifyNote.Size = new System.Drawing.Size(139, 20);
            this.txtModifyNote.TabIndex = 1;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Location = new System.Drawing.Point(163, 129);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(102, 34);
            this.btnModifyUser.TabIndex = 2;
            this.btnModifyUser.Text = "Modify Current User";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(599, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 178);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete User";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "FirstName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "LastName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Note";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "PhoneNumber";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(116, 24);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(147, 20);
            this.textBox9.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(116, 46);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(147, 20);
            this.textBox10.TabIndex = 1;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(116, 68);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(147, 20);
            this.textBox11.TabIndex = 1;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(116, 90);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(147, 20);
            this.textBox12.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(21, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(831, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(874, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(965, 449);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpModify);
            this.Controls.Add(this.grpAddUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.grpModify.ResumeLayout(false);
            this.grpModify.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtAddNote;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpModify;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.TextBox txtModifyNote;
        private System.Windows.Forms.TextBox txtModifyPhoneNumber;
        private System.Windows.Forms.TextBox txtModifyLastName;
        private System.Windows.Forms.TextBox txtModifyFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}