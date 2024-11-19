using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class ReportOwner : Form
    {
        private int trangthai;
        public ReportOwner(int trangthai)
        {
            InitializeComponent();
            this.trangthai = trangthai;
        }

        private void ReportOwner_Load(object sender, EventArgs e)
        {
            if (trangthai == 0)
            {
                DataSet set = BLL.Owner.LayChiTieuThuoc();

                reportViewer1.LocalReport.ReportPath = "Medican.rdlc";

                var source = new ReportDataSource("Medican", set.Tables[0]);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source);

                this.reportViewer1.RefreshReport();
            }
            else
            {

                DataSet set = BLL.Owner.LayChiTieuDungCu();
                reportViewer1.LocalReport.ReportPath = "Material.rdlc";

                var source = new ReportDataSource("Material", set.Tables[0]);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source);

                this.reportViewer1.RefreshReport();
            }
        }
    }
}
