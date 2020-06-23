namespace App
{
    partial class AddCutomerForm
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
            this.l_AddCustomer = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.l_Address = new System.Windows.Forms.Label();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.l_Contact = new System.Windows.Forms.Label();
            this.ContactBox = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_AddCustomer
            // 
            this.l_AddCustomer.AutoSize = true;
            this.l_AddCustomer.Font = new System.Drawing.Font("Gill Sans MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_AddCustomer.Location = new System.Drawing.Point(59, 35);
            this.l_AddCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_AddCustomer.Name = "l_AddCustomer";
            this.l_AddCustomer.Size = new System.Drawing.Size(245, 45);
            this.l_AddCustomer.TabIndex = 0;
            this.l_AddCustomer.Text = "Add Customer";
            this.l_AddCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(57, 110);
            this.l_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(48, 18);
            this.l_Name.TabIndex = 1;
            this.l_Name.Text = "Name";
            this.l_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(125, 110);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(140, 19);
            this.NameBox.TabIndex = 2;
            // 
            // l_Address
            // 
            this.l_Address.AutoSize = true;
            this.l_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Address.Location = new System.Drawing.Point(57, 232);
            this.l_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Address.Name = "l_Address";
            this.l_Address.Size = new System.Drawing.Size(62, 18);
            this.l_Address.TabIndex = 3;
            this.l_Address.Text = "Address";
            // 
            // AdressBox
            // 
            this.AdressBox.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdressBox.Location = new System.Drawing.Point(125, 213);
            this.AdressBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdressBox.Multiline = true;
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(140, 56);
            this.AdressBox.TabIndex = 4;
            // 
            // l_Contact
            // 
            this.l_Contact.AutoSize = true;
            this.l_Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Contact.Location = new System.Drawing.Point(57, 162);
            this.l_Contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Contact.Name = "l_Contact";
            this.l_Contact.Size = new System.Drawing.Size(60, 18);
            this.l_Contact.TabIndex = 5;
            this.l_Contact.Text = "Contact";
            // 
            // ContactBox
            // 
            this.ContactBox.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBox.Location = new System.Drawing.Point(125, 162);
            this.ContactBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactBox.Name = "ContactBox";
            this.ContactBox.Size = new System.Drawing.Size(140, 19);
            this.ContactBox.TabIndex = 6;
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Add.Location = new System.Drawing.Point(125, 296);
            this.b_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(70, 32);
            this.b_Add.TabIndex = 7;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // AddCutomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 368);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.ContactBox);
            this.Controls.Add(this.l_Contact);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.l_Address);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_AddCustomer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCutomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_AddCustomer;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label l_Address;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Label l_Contact;
        private System.Windows.Forms.TextBox ContactBox;
        private System.Windows.Forms.Button b_Add;
    }
}

