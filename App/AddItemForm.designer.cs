namespace App
{
    partial class AddItemForm
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
            this.l_AddMenu = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.l_Price = new System.Windows.Forms.Label();
            this.t_Price = new System.Windows.Forms.TextBox();
            this.l_Description = new System.Windows.Forms.Label();
            this.t_Description = new System.Windows.Forms.TextBox();
            this.l_Catagory = new System.Windows.Forms.Label();
            this.c_Catagory = new System.Windows.Forms.ComboBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_AddMenu
            // 
            this.l_AddMenu.AutoSize = true;
            this.l_AddMenu.Font = new System.Drawing.Font("Gill Sans MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_AddMenu.Location = new System.Drawing.Point(123, 27);
            this.l_AddMenu.Name = "l_AddMenu";
            this.l_AddMenu.Size = new System.Drawing.Size(193, 52);
            this.l_AddMenu.TabIndex = 0;
            this.l_AddMenu.Text = "Add Item";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(62, 100);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(62, 24);
            this.l_Name.TabIndex = 1;
            this.l_Name.Text = "Name";
            // 
            // t_Name
            // 
            this.t_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Name.Location = new System.Drawing.Point(66, 127);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(242, 31);
            this.t_Name.TabIndex = 2;
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Price.Location = new System.Drawing.Point(62, 168);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(55, 24);
            this.l_Price.TabIndex = 3;
            this.l_Price.Text = "Price";
            // 
            // t_Price
            // 
            this.t_Price.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Price.Location = new System.Drawing.Point(66, 195);
            this.t_Price.Name = "t_Price";
            this.t_Price.Size = new System.Drawing.Size(242, 31);
            this.t_Price.TabIndex = 4;
            this.t_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_Price_ONLY_NUMBER_KeyPress);
            // 
            // l_Description
            // 
            this.l_Description.AutoSize = true;
            this.l_Description.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Description.Location = new System.Drawing.Point(62, 232);
            this.l_Description.Name = "l_Description";
            this.l_Description.Size = new System.Drawing.Size(111, 24);
            this.l_Description.TabIndex = 5;
            this.l_Description.Text = "Description";
            // 
            // t_Description
            // 
            this.t_Description.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_Description.Location = new System.Drawing.Point(66, 259);
            this.t_Description.Name = "t_Description";
            this.t_Description.Size = new System.Drawing.Size(242, 31);
            this.t_Description.TabIndex = 6;
            // 
            // l_Catagory
            // 
            this.l_Catagory.AutoSize = true;
            this.l_Catagory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Catagory.Location = new System.Drawing.Point(62, 303);
            this.l_Catagory.Name = "l_Catagory";
            this.l_Catagory.Size = new System.Drawing.Size(91, 24);
            this.l_Catagory.TabIndex = 7;
            this.l_Catagory.Text = "Catagory";
            // 
            // c_Catagory
            // 
            this.c_Catagory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Catagory.FormattingEnabled = true;
            this.c_Catagory.Location = new System.Drawing.Point(66, 330);
            this.c_Catagory.Name = "c_Catagory";
            this.c_Catagory.Size = new System.Drawing.Size(242, 31);
            this.c_Catagory.TabIndex = 8;
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Add.Location = new System.Drawing.Point(151, 389);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(93, 38);
            this.b_Add.TabIndex = 9;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 477);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.c_Catagory);
            this.Controls.Add(this.l_Catagory);
            this.Controls.Add(this.t_Description);
            this.Controls.Add(this.l_Description);
            this.Controls.Add(this.t_Price);
            this.Controls.Add(this.l_Price);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_AddMenu);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_AddMenu;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label l_Price;
        private System.Windows.Forms.TextBox t_Price;
        private System.Windows.Forms.Label l_Description;
        private System.Windows.Forms.TextBox t_Description;
        private System.Windows.Forms.Label l_Catagory;
        private System.Windows.Forms.ComboBox c_Catagory;
        private System.Windows.Forms.Button b_Add;
    }
}