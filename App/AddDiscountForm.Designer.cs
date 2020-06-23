namespace App
{
    partial class AddDiscountForm
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
            this.l_AddDiscount = new System.Windows.Forms.Label();
            this.l_Catagory = new System.Windows.Forms.Label();
            this.c_Catagory = new System.Windows.Forms.ComboBox();
            this.l_Item = new System.Windows.Forms.Label();
            this.c_Item = new System.Windows.Forms.ComboBox();
            this.l_EnterPercentage = new System.Windows.Forms.Label();
            this.t_EnterPercentage = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_AddDiscount
            // 
            this.l_AddDiscount.AutoSize = true;
            this.l_AddDiscount.Font = new System.Drawing.Font("Gill Sans MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_AddDiscount.Location = new System.Drawing.Point(81, 29);
            this.l_AddDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_AddDiscount.Name = "l_AddDiscount";
            this.l_AddDiscount.Size = new System.Drawing.Size(192, 38);
            this.l_AddDiscount.TabIndex = 0;
            this.l_AddDiscount.Text = "Add Discount";
            // 
            // l_Catagory
            // 
            this.l_Catagory.AutoSize = true;
            this.l_Catagory.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Catagory.Location = new System.Drawing.Point(62, 93);
            this.l_Catagory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Catagory.Name = "l_Catagory";
            this.l_Catagory.Size = new System.Drawing.Size(61, 15);
            this.l_Catagory.TabIndex = 1;
            this.l_Catagory.Text = "Catagory";
            // 
            // c_Catagory
            // 
            this.c_Catagory.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Catagory.FormattingEnabled = true;
            this.c_Catagory.Location = new System.Drawing.Point(64, 118);
            this.c_Catagory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Catagory.Name = "c_Catagory";
            this.c_Catagory.Size = new System.Drawing.Size(197, 21);
            this.c_Catagory.TabIndex = 2;
            // 
            // l_Item
            // 
            this.l_Item.AutoSize = true;
            this.l_Item.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Item.Location = new System.Drawing.Point(62, 161);
            this.l_Item.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Item.Name = "l_Item";
            this.l_Item.Size = new System.Drawing.Size(34, 15);
            this.l_Item.TabIndex = 3;
            this.l_Item.Text = "Item";
            this.l_Item.Click += new System.EventHandler(this.l_Item_Click);
            // 
            // c_Item
            // 
            this.c_Item.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_Item.FormattingEnabled = true;
            this.c_Item.Location = new System.Drawing.Point(64, 186);
            this.c_Item.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.c_Item.Name = "c_Item";
            this.c_Item.Size = new System.Drawing.Size(197, 21);
            this.c_Item.TabIndex = 4;
            // 
            // l_EnterPercentage
            // 
            this.l_EnterPercentage.AutoSize = true;
            this.l_EnterPercentage.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_EnterPercentage.Location = new System.Drawing.Point(62, 233);
            this.l_EnterPercentage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_EnterPercentage.Name = "l_EnterPercentage";
            this.l_EnterPercentage.Size = new System.Drawing.Size(130, 15);
            this.l_EnterPercentage.TabIndex = 5;
            this.l_EnterPercentage.Text = "Enter Percentage (%)";
            // 
            // t_EnterPercentage
            // 
            this.t_EnterPercentage.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_EnterPercentage.Location = new System.Drawing.Point(64, 258);
            this.t_EnterPercentage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.t_EnterPercentage.Name = "t_EnterPercentage";
            this.t_EnterPercentage.Size = new System.Drawing.Size(197, 19);
            this.t_EnterPercentage.TabIndex = 6;
            // 
            // b_Add
            // 
            this.b_Add.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Add.Location = new System.Drawing.Point(134, 306);
            this.b_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(56, 28);
            this.b_Add.TabIndex = 7;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 377);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.t_EnterPercentage);
            this.Controls.Add(this.l_EnterPercentage);
            this.Controls.Add(this.c_Item);
            this.Controls.Add(this.l_Item);
            this.Controls.Add(this.c_Catagory);
            this.Controls.Add(this.l_Catagory);
            this.Controls.Add(this.l_AddDiscount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddDiscountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_AddDiscount;
        private System.Windows.Forms.Label l_Catagory;
        private System.Windows.Forms.ComboBox c_Catagory;
        private System.Windows.Forms.Label l_Item;
        private System.Windows.Forms.ComboBox c_Item;
        private System.Windows.Forms.Label l_EnterPercentage;
        private System.Windows.Forms.TextBox t_EnterPercentage;
        private System.Windows.Forms.Button b_Add;
    }
}