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
using Microsoft.Reporting.WinForms;

namespace App
{
    public partial class ReceiptForm : Form
    {
        List<Receipt> _list;
        string total, vat,wVat, autoRound, totalPay, paidAmount, returnAmount,cashier,date,time;
        public ReceiptForm(List<Receipt> datasource,string total, string vat, string wVat, string autoRound, string totalPay, string paidAmount, string returnAmount, string cashier, string date, string time)
        {
            InitializeComponent();

            this._list = datasource;
            this.total = total;
            this.vat = vat;
            this.wVat = wVat;
            this.autoRound = autoRound;
            this.totalPay = totalPay;
            this.paidAmount = paidAmount;
            this.returnAmount = returnAmount;
            this.cashier = cashier;
            this.date = date;
            this.time = time;
        }

        

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("sDate",date),
                new Microsoft.Reporting.WinForms.ReportParameter("CName",cashier),
                new Microsoft.Reporting.WinForms.ReportParameter("sTime",time),
                new Microsoft.Reporting.WinForms.ReportParameter("total",total),
                new Microsoft.Reporting.WinForms.ReportParameter("vat",vat),
                new Microsoft.Reporting.WinForms.ReportParameter("withVat",wVat),
                new Microsoft.Reporting.WinForms.ReportParameter("autoRound",autoRound),
                new Microsoft.Reporting.WinForms.ReportParameter("tPay",totalPay),
                new Microsoft.Reporting.WinForms.ReportParameter("paidAmount",paidAmount),
                new Microsoft.Reporting.WinForms.ReportParameter("returnAmount",returnAmount)

            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

    }
}
