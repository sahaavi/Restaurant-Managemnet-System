namespace App
{
    partial class CustomerListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_Add = new System.Windows.Forms.Button();
            this.TContact = new System.Windows.Forms.TextBox();
            this.l_Contact = new System.Windows.Forms.Label();
            this.TAdress = new System.Windows.Forms.TextBox();
            this.l_Address = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 202);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Add.Location = new System.Drawing.Point(61, 327);
            this.b_Add.Margin = new System.Windows.Forms.Padding(2);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(70, 32);
            this.b_Add.TabIndex = 14;
            this.b_Add.Text = "Update";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // TContact
            // 
            this.TContact.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TContact.Location = new System.Drawing.Point(29, 179);
            this.TContact.Margin = new System.Windows.Forms.Padding(2);
            this.TContact.Name = "TContact";
            this.TContact.Size = new System.Drawing.Size(140, 19);
            this.TContact.TabIndex = 13;
            // 
            // l_Contact
            // 
            this.l_Contact.AutoSize = true;
            this.l_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Contact.Location = new System.Drawing.Point(26, 148);
            this.l_Contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Contact.Name = "l_Contact";
            this.l_Contact.Size = new System.Drawing.Size(60, 18);
            this.l_Contact.TabIndex = 12;
            this.l_Contact.Text = "Contact";
            // 
            // TAdress
            // 
            this.TAdress.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAdress.Location = new System.Drawing.Point(29, 241);
            this.TAdress.Margin = new System.Windows.Forms.Padding(2);
            this.TAdress.Multiline = true;
            this.TAdress.Name = "TAdress";
            this.TAdress.Size = new System.Drawing.Size(140, 56);
            this.TAdress.TabIndex = 11;
            // 
            // l_Address
            // 
            this.l_Address.AutoSize = true;
            this.l_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Address.Location = new System.Drawing.Point(26, 212);
            this.l_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Address.Name = "l_Address";
            this.l_Address.Size = new System.Drawing.Size(62, 18);
            this.l_Address.TabIndex = 10;
            this.l_Address.Text = "Address";
            // 
            // TName
            // 
            this.TName.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TName.Location = new System.Drawing.Point(29, 119);
            this.TName.Margin = new System.Windows.Forms.Padding(2);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(140, 19);
            this.TName.TabIndex = 9;
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(26, 88);
            this.l_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(48, 18);
            this.l_Name.TabIndex = 8;
            this.l_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "No";
            // 
            // CustomerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(693, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.TContact);
            this.Controls.Add(this.l_Contact);
            this.Controls.Add(this.TAdress);
            this.Controls.Add(this.l_Address);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerListForm";
            this.Load += new System.EventHandler(this.CustomerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.TextBox TContact;
        private System.Windows.Forms.Label l_Contact;
        private System.Windows.Forms.TextBox TAdress;
        private System.Windows.Forms.Label l_Address;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}