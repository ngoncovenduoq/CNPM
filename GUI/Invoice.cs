using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Project_CNPM
{
    public partial class Invoice : Form
    {
        string stt;
        public Invoice(string stt)
        {
            InitializeComponent();
            this.stt = stt;
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            DataSet list = BLL.Rec_Cashier.LayHDDV(stt);
            DataSet list1 = BLL.Rec_Cashier.LayHDThuoc(stt);

            reportViewer1.LocalReport.ReportPath = "Invoice.rdlc";

            var source = new ReportDataSource("invoice", list.Tables[0]);
            var source1 = new ReportDataSource("thuocinvoice", list1.Tables[0]);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.DataSources.Add(source1);

            this.reportViewer1.RefreshReport();
        }
    }
}
