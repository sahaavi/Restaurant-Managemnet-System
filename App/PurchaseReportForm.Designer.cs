namespace App
{
    partial class PurchaseReportForm
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
            this.l_PurchaseReport = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_To = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.b_Total = new System.Windows.Forms.Button();
            this.l_Total = new System.Windows.Forms.Label();
            this.PAmount = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.l_Category = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.l_Form = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_PurchaseReport
            // 
            this.l_PurchaseReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PurchaseReport.AutoSize = true;
            this.l_PurchaseReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_PurchaseReport.Location = new System.Drawing.Point(330, 9);
            this.l_PurchaseReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_PurchaseReport.Name = "l_PurchaseReport";
            this.l_PurchaseReport.Size = new System.Drawing.Size(274, 37);
            this.l_PurchaseReport.TabIndex = 0;
            this.l_PurchaseReport.Text = "Purchase   Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // l_To
            // 
            this.l_To.AutoSize = true;
            this.l_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_To.Location = new System.Drawing.Point(28, 168);
            this.l_To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_To.Name = "l_To";
            this.l_To.Size = new System.Drawing.Size(27, 20);
            this.l_To.TabIndex = 3;
            this.l_To.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(30, 202);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // b_Total
            // 
            this.b_Total.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Total.Location = new System.Drawing.Point(62, 310);
            this.b_Total.Margin = new System.Windows.Forms.Padding(2);
            this.b_Total.Name = "b_Total";
            this.b_Total.Size = new System.Drawing.Size(112, 36);
            this.b_Total.TabIndex = 6;
            this.b_Total.Text = "Search";
            this.b_Total.UseVisualStyleBackColor = true;
            this.b_Total.Click += new System.EventHandler(this.b_Total_Click);
            // 
            // l_Total
            // 
            this.l_Total.AutoSize = true;
            this.l_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Total.Location = new System.Drawing.Point(236, 506);
            this.l_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Total.Name = "l_Total";
            this.l_Total.Size = new System.Drawing.Size(40, 17);
            this.l_Total.TabIndex = 7;
            this.l_Total.Text = "Total";
            // 
            // PAmount
            // 
            this.PAmount.AutoSize = true;
            this.PAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmount.Location = new System.Drawing.Point(289, 506);
            this.PAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PAmount.Name = "PAmount";
            this.PAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PAmount.Size = new System.Drawing.Size(56, 17);
            this.PAmount.TabIndex = 8;
            this.PAmount.Text = "Amount";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(97, 254);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(126, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // l_Category
            // 
            this.l_Category.AutoSize = true;
            this.l_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Category.Location = new System.Drawing.Point(28, 254);
            this.l_Category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Category.Name = "l_Category";
            this.l_Category.Size = new System.Drawing.Size(65, 17);
            this.l_Category.TabIndex = 10;
            this.l_Category.Text = "Category";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 110);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // l_Form
            // 
            this.l_Form.AutoSize = true;
            this.l_Form.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Form.Location = new System.Drawing.Point(26, 77);
            this.l_Form.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Form.Name = "l_Form";
            this.l_Form.Size = new System.Drawing.Size(46, 20);
            this.l_Form.TabIndex = 11;
            this.l_Form.Text = "Form";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(501, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(754, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PurchaseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.l_Form);
            this.Controls.Add(this.l_Category);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PAmount);
            this.Controls.Add(this.l_Total);
            this.Controls.Add(this.b_Total);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.l_To);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_PurchaseReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PurchaseReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseReportForm";
            this.Load += new System.EventHandler(this.PurchaseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_PurchaseReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button b_Total;
        private System.Windows.Forms.Label l_Total;
        private System.Windows.Forms.Label PAmount;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label l_Category;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label l_Form;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}