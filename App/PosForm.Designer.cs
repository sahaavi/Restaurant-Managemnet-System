namespace App
{
    partial class PosForm
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
            this.components = new System.ComponentModel.Container();
            this.l_Item = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_TimeDisplay = new System.Windows.Forms.Label();
            this.l_Time = new System.Windows.Forms.Label();
            this.l_DateDisplay = new System.Windows.Forms.Label();
            this.l_Date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_Print = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.b_Clear = new System.Windows.Forms.Button();
            this.l_Cashier = new System.Windows.Forms.Label();
            this.l_Vat = new System.Windows.Forms.Label();
            this.l_auto = new System.Windows.Forms.Label();
            this.l_TPayment = new System.Windows.Forms.Label();
            this.l_Payment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox_Cash = new System.Windows.Forms.CheckBox();
            this.checkBox_bKash = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Total = new System.Windows.Forms.TextBox();
            this.t_Quantity = new System.Windows.Forms.TextBox();
            this.t_Price = new System.Windows.Forms.TextBox();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Paid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_v = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Vat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_Return = new System.Windows.Forms.TextBox();
            this.t_Tpay = new System.Windows.Forms.TextBox();
            this.t_Around = new System.Windows.Forms.TextBox();
            this.t_PayTotal = new System.Windows.Forms.TextBox();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Item
            // 
            this.l_Item.AutoSize = true;
            this.l_Item.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Item.Location = new System.Drawing.Point(12, 16);
            this.l_Item.Name = "l_Item";
            this.l_Item.Size = new System.Drawing.Size(166, 34);
            this.l_Item.TabIndex = 13;
            this.l_Item.Text = "Search Item";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(193, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 30);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_TimeDisplay
            // 
            this.l_TimeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_TimeDisplay.AutoSize = true;
            this.l_TimeDisplay.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TimeDisplay.Location = new System.Drawing.Point(1688, 24);
            this.l_TimeDisplay.Name = "l_TimeDisplay";
            this.l_TimeDisplay.Size = new System.Drawing.Size(58, 23);
            this.l_TimeDisplay.TabIndex = 24;
            this.l_TimeDisplay.Text = "Show";
            // 
            // l_Time
            // 
            this.l_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Time.AutoSize = true;
            this.l_Time.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Time.Location = new System.Drawing.Point(1616, 24);
            this.l_Time.Name = "l_Time";
            this.l_Time.Size = new System.Drawing.Size(66, 23);
            this.l_Time.TabIndex = 23;
            this.l_Time.Text = "Time :";
            // 
            // l_DateDisplay
            // 
            this.l_DateDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_DateDisplay.AutoSize = true;
            this.l_DateDisplay.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_DateDisplay.Location = new System.Drawing.Point(1420, 24);
            this.l_DateDisplay.Name = "l_DateDisplay";
            this.l_DateDisplay.Size = new System.Drawing.Size(58, 23);
            this.l_DateDisplay.TabIndex = 22;
            this.l_DateDisplay.Text = "Show";
            // 
            // l_Date
            // 
            this.l_Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_Date.AutoSize = true;
            this.l_Date.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Date.Location = new System.Drawing.Point(1352, 24);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(62, 23);
            this.l_Date.TabIndex = 21;
            this.l_Date.Text = "Date :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_Print
            // 
            this.b_Print.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Print.Location = new System.Drawing.Point(91, 30);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(132, 44);
            this.b_Print.TabIndex = 27;
            this.b_Print.Text = "PRINT";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.LightCyan;
            this.panel5.Controls.Add(this.b_Clear);
            this.panel5.Controls.Add(this.b_Print);
            this.panel5.Location = new System.Drawing.Point(49, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(533, 100);
            this.panel5.TabIndex = 28;
            // 
            // b_Clear
            // 
            this.b_Clear.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Clear.Location = new System.Drawing.Point(332, 30);
            this.b_Clear.Name = "b_Clear";
            this.b_Clear.Size = new System.Drawing.Size(132, 44);
            this.b_Clear.TabIndex = 28;
            this.b_Clear.Text = "CLEAR";
            this.b_Clear.UseVisualStyleBackColor = true;
            this.b_Clear.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // l_Cashier
            // 
            this.l_Cashier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_Cashier.AutoSize = true;
            this.l_Cashier.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Cashier.Location = new System.Drawing.Point(1007, 23);
            this.l_Cashier.Name = "l_Cashier";
            this.l_Cashier.Size = new System.Drawing.Size(86, 23);
            this.l_Cashier.TabIndex = 29;
            this.l_Cashier.Text = "Cashier :";
            // 
            // l_Vat
            // 
            this.l_Vat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Vat.AutoSize = true;
            this.l_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Vat.Location = new System.Drawing.Point(21, 92);
            this.l_Vat.Name = "l_Vat";
            this.l_Vat.Size = new System.Drawing.Size(98, 25);
            this.l_Vat.TabIndex = 34;
            this.l_Vat.Text = "With VAT";
            // 
            // l_auto
            // 
            this.l_auto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_auto.AutoSize = true;
            this.l_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_auto.Location = new System.Drawing.Point(18, 125);
            this.l_auto.Name = "l_auto";
            this.l_auto.Size = new System.Drawing.Size(122, 25);
            this.l_auto.TabIndex = 37;
            this.l_auto.Text = "Auto Around";
            // 
            // l_TPayment
            // 
            this.l_TPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_TPayment.AutoSize = true;
            this.l_TPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_TPayment.Location = new System.Drawing.Point(18, 160);
            this.l_TPayment.Name = "l_TPayment";
            this.l_TPayment.Size = new System.Drawing.Size(138, 25);
            this.l_TPayment.TabIndex = 39;
            this.l_TPayment.Text = "Total Payment";
            // 
            // l_Payment
            // 
            this.l_Payment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_Payment.AutoSize = true;
            this.l_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Payment.Location = new System.Drawing.Point(18, 200);
            this.l_Payment.Name = "l_Payment";
            this.l_Payment.Size = new System.Drawing.Size(99, 25);
            this.l_Payment.TabIndex = 41;
            this.l_Payment.Text = "Payments";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 42;
            this.label6.Text = "Paid Amount";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Returned Amount";
            // 
            // checkBox_Cash
            // 
            this.checkBox_Cash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Cash.AutoSize = true;
            this.checkBox_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Cash.Location = new System.Drawing.Point(161, 201);
            this.checkBox_Cash.Name = "checkBox_Cash";
            this.checkBox_Cash.Size = new System.Drawing.Size(70, 24);
            this.checkBox_Cash.TabIndex = 46;
            this.checkBox_Cash.Text = "Cash";
            this.checkBox_Cash.UseVisualStyleBackColor = true;
            // 
            // checkBox_bKash
            // 
            this.checkBox_bKash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_bKash.AutoSize = true;
            this.checkBox_bKash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bKash.Location = new System.Drawing.Point(251, 201);
            this.checkBox_bKash.Name = "checkBox_bKash";
            this.checkBox_bKash.Size = new System.Drawing.Size(78, 24);
            this.checkBox_bKash.TabIndex = 47;
            this.checkBox_bKash.Text = "bKash";
            this.checkBox_bKash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.t_Total);
            this.groupBox1.Controls.Add(this.t_Quantity);
            this.groupBox1.Controls.Add(this.t_Price);
            this.groupBox1.Controls.Add(this.t_Name);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1148, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 391);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add to receipt";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add To Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Total
            // 
            this.t_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Total.Location = new System.Drawing.Point(135, 199);
            this.t_Total.Name = "t_Total";
            this.t_Total.ReadOnly = true;
            this.t_Total.Size = new System.Drawing.Size(212, 30);
            this.t_Total.TabIndex = 7;
            // 
            // t_Quantity
            // 
            this.t_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Quantity.Location = new System.Drawing.Point(135, 144);
            this.t_Quantity.Name = "t_Quantity";
            this.t_Quantity.Size = new System.Drawing.Size(212, 30);
            this.t_Quantity.TabIndex = 6;
            this.t_Quantity.TextChanged += new System.EventHandler(this.t_Quantity_TextChanged);
            // 
            // t_Price
            // 
            this.t_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Price.Location = new System.Drawing.Point(135, 90);
            this.t_Price.Name = "t_Price";
            this.t_Price.ReadOnly = true;
            this.t_Price.Size = new System.Drawing.Size(212, 30);
            this.t_Price.TabIndex = 5;
            // 
            // t_Name
            // 
            this.t_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Name.Location = new System.Drawing.Point(135, 37);
            this.t_Name.Name = "t_Name";
            this.t_Name.ReadOnly = true;
            this.t_Name.Size = new System.Drawing.Size(417, 30);
            this.t_Name.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 29);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // t_Paid
            // 
            this.t_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Paid.Location = new System.Drawing.Point(454, 235);
            this.t_Paid.Name = "t_Paid";
            this.t_Paid.Size = new System.Drawing.Size(159, 30);
            this.t_Paid.TabIndex = 49;
            this.t_Paid.TextChanged += new System.EventHandler(this.t_Paid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 577);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 51;
            this.label5.Text = "Receipt";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(315, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 29);
            this.label12.TabIndex = 52;
            this.label12.Text = "Customer ID";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(502, 580);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(159, 30);
            this.textBox7.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 469);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(18, 638);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(720, 282);
            this.dataGridView2.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_v);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.t_Vat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.t_Return);
            this.groupBox2.Controls.Add(this.t_Tpay);
            this.groupBox2.Controls.Add(this.t_Around);
            this.groupBox2.Controls.Add(this.t_PayTotal);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.l_Vat);
            this.groupBox2.Controls.Add(this.t_Paid);
            this.groupBox2.Controls.Add(this.l_auto);
            this.groupBox2.Controls.Add(this.checkBox_bKash);
            this.groupBox2.Controls.Add(this.l_TPayment);
            this.groupBox2.Controls.Add(this.checkBox_Cash);
            this.groupBox2.Controls.Add(this.l_Payment);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1055, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 445);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment";
            // 
            // t_v
            // 
            this.t_v.Location = new System.Drawing.Point(454, 58);
            this.t_v.Name = "t_v";
            this.t_v.ReadOnly = true;
            this.t_v.Size = new System.Drawing.Size(159, 27);
            this.t_v.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "VAT";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "10 %";
            // 
            // t_Vat
            // 
            this.t_Vat.Location = new System.Drawing.Point(454, 93);
            this.t_Vat.Name = "t_Vat";
            this.t_Vat.ReadOnly = true;
            this.t_Vat.Size = new System.Drawing.Size(159, 27);
            this.t_Vat.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Total";
            // 
            // t_Return
            // 
            this.t_Return.Location = new System.Drawing.Point(454, 268);
            this.t_Return.Name = "t_Return";
            this.t_Return.ReadOnly = true;
            this.t_Return.Size = new System.Drawing.Size(159, 27);
            this.t_Return.TabIndex = 54;
            // 
            // t_Tpay
            // 
            this.t_Tpay.Location = new System.Drawing.Point(454, 161);
            this.t_Tpay.Name = "t_Tpay";
            this.t_Tpay.ReadOnly = true;
            this.t_Tpay.Size = new System.Drawing.Size(159, 27);
            this.t_Tpay.TabIndex = 53;
            // 
            // t_Around
            // 
            this.t_Around.Location = new System.Drawing.Point(454, 126);
            this.t_Around.Name = "t_Around";
            this.t_Around.ReadOnly = true;
            this.t_Around.Size = new System.Drawing.Size(159, 27);
            this.t_Around.TabIndex = 52;
            // 
            // t_PayTotal
            // 
            this.t_PayTotal.Location = new System.Drawing.Point(454, 24);
            this.t_PayTotal.Name = "t_PayTotal";
            this.t_PayTotal.ReadOnly = true;
            this.t_PayTotal.Size = new System.Drawing.Size(159, 27);
            this.t_PayTotal.TabIndex = 50;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(Entities.Receipt);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1232, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "Avishek";
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1849, 935);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_Cashier);
            this.Controls.Add(this.l_TimeDisplay);
            this.Controls.Add(this.l_Time);
            this.Controls.Add(this.l_DateDisplay);
            this.Controls.Add(this.l_Date);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.l_Item);
            this.Name = "PosForm";
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Item;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_TimeDisplay;
        private System.Windows.Forms.Label l_Time;
        private System.Windows.Forms.Label l_DateDisplay;
        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_Print;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button b_Clear;
        private System.Windows.Forms.Label l_Cashier;
        private System.Windows.Forms.Label l_Vat;
        private System.Windows.Forms.Label l_auto;
        private System.Windows.Forms.Label l_TPayment;
        private System.Windows.Forms.Label l_Payment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox_Cash;
        private System.Windows.Forms.CheckBox checkBox_bKash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Total;
        private System.Windows.Forms.TextBox t_Quantity;
        private System.Windows.Forms.TextBox t_Price;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Paid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_Return;
        private System.Windows.Forms.TextBox t_Tpay;
        private System.Windows.Forms.TextBox t_Around;
        private System.Windows.Forms.TextBox t_PayTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_Vat;
        private System.Windows.Forms.TextBox t_v;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.TextBox textBox2;
    }
}