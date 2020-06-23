using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;

namespace App
{
    public partial class PosForm : Form
    {
        int id;
        string payType;
        float price;
        double vat;
        int totalPay;
        int result;
        int cId;
        string username;
        public PosForm(string name)
        {
            InitializeComponent();
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Width = 20;
            dataGridView2.Columns[1].Width = 60;
            dataGridView2.Columns[2].Width = 30;
            dataGridView2.Columns[3].Width = 30;
            dataGridView2.Columns[4].Width = 70;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[1].Name = "Item Name";
            dataGridView2.Columns[2].Name = "Price";
            dataGridView2.Columns[3].Name = "Quantity";
            dataGridView2.Columns[4].Name = "Total Price";
            this.username = name;
        }
        ReportDataSource rs = new ReportDataSource();
        

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RMS"].ConnectionString);
        
        private void PosForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox2.Text = username;
            l_TimeDisplay.Text = DateTime.Now.ToLongTimeString();
            l_DateDisplay.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            searchData("");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l_TimeDisplay.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            t_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            t_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();           
        }
        
        private void b_Print_Click(object sender, EventArgs e)
        {
            if (t_Paid.Text == "")
            {
                MessageBox.Show("Please Enter a Payment Amount");
            }

            else if (int.Parse(t_Paid.Text) < int.Parse(t_Tpay.Text))
            {
                MessageBox.Show("Payment Amount is LOW !");
            }
            else if(checkBox_bKash.CheckState==CheckState.Checked && checkBox_Cash.CheckState==CheckState.Checked)
            {
                MessageBox.Show("Select a paymnet method");
            }
             
            else
            {
              
                List<Receipt> rcpt = new List<Receipt>();
                rcpt.Clear();
                for (int i = 0; i < dataGridView2.Rows.Count ; i++)
                {
                    Receipt receipt = new Receipt
                    {
                        Id = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString()),
                        Name = dataGridView2.Rows[i].Cells[1].Value.ToString(),
                        Price = float.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString()),
                        Quantity = int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()),
                        Total = float.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString())
                    };
                    rcpt.Add(receipt);
                }
                rs.Name = "DataSet1";
                rs.Value = rcpt;
                ReceiptForm frm = new ReceiptForm(rcpt,t_PayTotal.Text, t_v.Text, t_Vat.Text, t_Around.Text, t_Tpay.Text, t_Paid.Text, t_Return.Text, textBox2.Text, DateTime.Now.ToString("dd-MMM-yyyy"), DateTime.Now.ToString("hh:mm tt"));
               
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "App.rptReceipt.rdlc";

                PosService posService = new PosService();
                for (int j = 0; j < dataGridView2.Rows.Count ; j++)
                {
                    
                    if(checkBox_bKash.CheckState==CheckState.Checked)
                    {
                        payType="bKash";
                    }
                    if(checkBox_Cash.CheckState==CheckState.Checked)
                    {
                        payType="Cash";
                    }
                    price = int.Parse(dataGridView2.Rows[j].Cells[4].Value.ToString());
                    vat = Convert.ToSingle((price * 0.1)+price);
                    totalPay = (int)Math.Round(vat);
                    if (textBox7.Text == string.Empty)
                    {
                        cId = 0;
                    }
                    else
                    {
                        cId=int.Parse(textBox7.Text);
                    }
                    result = posService.Insert(new Pos { ItemId = int.Parse(dataGridView2.Rows[j].Cells[0].Value.ToString()), Name = dataGridView2.Rows[j].Cells[1].Value.ToString(), Price = float.Parse(dataGridView2.Rows[j].Cells[2].Value.ToString()), Quantity = int.Parse(dataGridView2.Rows[j].Cells[3].Value.ToString()), TotalAmount = totalPay, PaymentType = payType, SaleDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy")), CustomerId = cId, CashierName=textBox2.Text });
                    
                }
                if (result > 0)
                {
                    result = 0;
                    MessageBox.Show("Sales added.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                dataGridView2.Rows.Clear();
                t_PayTotal.Text = t_v.Text = t_Vat.Text = t_Around.Text = t_Tpay.Text = t_Paid.Text = t_Return.Text = string.Empty;
                frm.ShowDialog();                    
            }
            
        }


        private void t_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                t_Total.Text = (float.Parse(t_Price.Text) * int.Parse(t_Quantity.Text)).ToString();
                
            }
            catch
            {
 
            }
        }

        public void searchData(string find)
        {
            string sql = "SELECT * FROM ITEM WHERE Name LIKE '%"+find+"%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,cn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.Font = new Font("Roboto Regular", 12);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].Width = 40;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addToReceipt(Convert.ToString(id), t_Name.Text, t_Price.Text, t_Quantity.Text, t_Total.Text);
        }

        private void addToReceipt(string id,string name,string price, string quantity, string total)
        {
            if (t_Quantity.Text == "")
            {
                MessageBox.Show("Please Enter a valid Quantity");

            }

            //for (int k = 0; k < dataGridView2.Rows.Count; k++)
            //{
            //    if (dataGridView2.Rows[k].Cells[1].Value.ToString() == t_Name.Text)
            //    {
            //        dataGridView2.Rows[k].Cells[3].Value = Convert.ToString(int.Parse(dataGridView2.Rows[k].Cells[3].Value.ToString()) + 1);
            //        break;
            //    }

            //}
            else
            {
                String[] row = { id, name, price, quantity, total };
                dataGridView2.Rows.Add(row);
                t_Name.Text = t_Price.Text = t_Quantity.Text = t_Total.Text = string.Empty;
                Sum();
                Vat();
            }   
                    
                       
        }

        void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView2.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }
            t_PayTotal.Text = sum.ToString();
        }

        void Vat()
        {
            t_v.Text = (float.Parse(t_PayTotal.Text) * 0.1).ToString();
            t_Vat.Text = ((float.Parse(t_PayTotal.Text)*0.1)+float.Parse(t_PayTotal.Text)).ToString();
            
            t_Tpay.Text = ((int)Math.Round(float.Parse(t_Vat.Text))).ToString();
            double round = (Convert.ToInt32(t_Tpay.Text) - float.Parse(t_Vat.Text));
            t_Around.Text = Math.Round(round,2).ToString();
        }

        private void b_Clear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            t_PayTotal.Text = t_v.Text = t_Vat.Text = t_Around.Text = t_Tpay.Text = t_Paid.Text = t_Return.Text = string.Empty;
            
        }

        private void t_Paid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                t_Return.Text = (int.Parse(t_Paid.Text) - int.Parse(t_Tpay.Text)).ToString();

            }
            catch
            {

            }
        }      
    }
}
