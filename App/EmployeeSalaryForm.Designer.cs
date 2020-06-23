namespace App
{
    partial class EmployeeSalaryForm
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
            this.l_EmpSalary = new System.Windows.Forms.Label();
            this.l_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.l_EmpName = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.tdays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpay = new System.Windows.Forms.TextBox();
            this.l_AdvSalary = new System.Windows.Forms.Label();
            this.tsalary = new System.Windows.Forms.TextBox();
            this.l_MonSalary = new System.Windows.Forms.Label();
            this.b_Add = new System.Windows.Forms.Button();
            this.l_SalRemain = new System.Windows.Forms.Label();
            this.lAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tyear = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_EmpSalary
            // 
            this.l_EmpSalary.AutoSize = true;
            this.l_EmpSalary.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EmpSalary.Location = new System.Drawing.Point(142, 9);
            this.l_EmpSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_EmpSalary.Name = "l_EmpSalary";
            this.l_EmpSalary.Size = new System.Drawing.Size(257, 37);
            this.l_EmpSalary.TabIndex = 0;
            this.l_EmpSalary.Text = "Employee Salary";
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.l_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Date.Location = new System.Drawing.Point(37, 79);
            this.l_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(63, 24);
            this.l_Date.TabIndex = 1;
            this.l_Date.Text = "Month";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 112);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // l_EmpName
            // 
            this.l_EmpName.AutoSize = true;
            this.l_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EmpName.Location = new System.Drawing.Point(37, 146);
            this.l_EmpName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_EmpName.Name = "l_EmpName";
            this.l_EmpName.Size = new System.Drawing.Size(116, 24);
            this.l_EmpName.TabIndex = 3;
            this.l_EmpName.Text = "Employee Id";
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(40, 184);
            this.tid.Margin = new System.Windows.Forms.Padding(2);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(87, 20);
            this.tid.TabIndex = 4;
            this.tid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tdays
            // 
            this.tdays.Location = new System.Drawing.Point(149, 277);
            this.tdays.Margin = new System.Windows.Forms.Padding(2);
            this.tdays.Name = "tdays";
            this.tdays.Size = new System.Drawing.Size(215, 20);
            this.tdays.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "No of Days";
            // 
            // tpay
            // 
            this.tpay.Location = new System.Drawing.Point(149, 356);
            this.tpay.Margin = new System.Windows.Forms.Padding(2);
            this.tpay.Name = "tpay";
            this.tpay.Size = new System.Drawing.Size(215, 20);
            this.tpay.TabIndex = 8;
            // 
            // l_AdvSalary
            // 
            this.l_AdvSalary.AutoSize = true;
            this.l_AdvSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_AdvSalary.Location = new System.Drawing.Point(145, 321);
            this.l_AdvSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_AdvSalary.Name = "l_AdvSalary";
            this.l_AdvSalary.Size = new System.Drawing.Size(41, 24);
            this.l_AdvSalary.TabIndex = 7;
            this.l_AdvSalary.Text = "Pay";
            // 
            // tsalary
            // 
            this.tsalary.Location = new System.Drawing.Point(149, 422);
            this.tsalary.Margin = new System.Windows.Forms.Padding(2);
            this.tsalary.Name = "tsalary";
            this.tsalary.Size = new System.Drawing.Size(215, 20);
            this.tsalary.TabIndex = 10;
            // 
            // l_MonSalary
            // 
            this.l_MonSalary.AutoSize = true;
            this.l_MonSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_MonSalary.Location = new System.Drawing.Point(145, 396);
            this.l_MonSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_MonSalary.Name = "l_MonSalary";
            this.l_MonSalary.Size = new System.Drawing.Size(132, 24);
            this.l_MonSalary.TabIndex = 9;
            this.l_MonSalary.Text = "Monthly Salary";
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Add.Location = new System.Drawing.Point(194, 487);
            this.b_Add.Margin = new System.Windows.Forms.Padding(2);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(107, 34);
            this.b_Add.TabIndex = 11;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // l_SalRemain
            // 
            this.l_SalRemain.AutoSize = true;
            this.l_SalRemain.Location = new System.Drawing.Point(11, 474);
            this.l_SalRemain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_SalRemain.Name = "l_SalRemain";
            this.l_SalRemain.Size = new System.Drawing.Size(89, 13);
            this.l_SalRemain.TabIndex = 12;
            this.l_SalRemain.Text = "Salary Remaining";
            // 
            // lAmount
            // 
            this.lAmount.AutoSize = true;
            this.lAmount.Location = new System.Drawing.Point(110, 474);
            this.lAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAmount.Name = "lAmount";
            this.lAmount.Size = new System.Drawing.Size(43, 13);
            this.lAmount.TabIndex = 13;
            this.lAmount.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee Name";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(340, 184);
            this.tname.Margin = new System.Windows.Forms.Padding(2);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(161, 20);
            this.tname.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tyear
            // 
            this.tyear.CustomFormat = "yyyy";
            this.tyear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tyear.Location = new System.Drawing.Point(340, 112);
            this.tyear.Margin = new System.Windows.Forms.Padding(2);
            this.tyear.Name = "tyear";
            this.tyear.Size = new System.Drawing.Size(181, 20);
            this.tyear.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Year";
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 566);
            this.Controls.Add(this.tyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lAmount);
            this.Controls.Add(this.l_SalRemain);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.tsalary);
            this.Controls.Add(this.l_MonSalary);
            this.Controls.Add(this.tpay);
            this.Controls.Add(this.l_AdvSalary);
            this.Controls.Add(this.tdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.l_EmpName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.l_Date);
            this.Controls.Add(this.l_EmpSalary);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeSalaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeSalaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_EmpSalary;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label l_EmpName;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox tdays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tpay;
        private System.Windows.Forms.Label l_AdvSalary;
        private System.Windows.Forms.TextBox tsalary;
        private System.Windows.Forms.Label l_MonSalary;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label l_SalRemain;
        private System.Windows.Forms.Label lAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tyear;
        private System.Windows.Forms.Label label3;
    }
}