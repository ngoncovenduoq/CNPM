using System;
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
    public partial class Owner_Income : Form
    {
        private DataSet _dataSet;
        public Owner_Income()
        {
            InitializeComponent();
        }

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam")
            {
                tbSearch.PlaceholderText = "Tìm kiếm";
            }
            else
            {
                tbSearch.PlaceholderText = "Search";
            }
            
        }

        public void ChangeColor(Color color, Color color2)
        {
            panelTop.BackColor = panelTopLeft.BackColor = Color.FromArgb(241, 241, 241);
            tbSearch.FillColor = color2;
            guna2DataGridView1.BackgroundColor = color2;
        }

        private void Owner_Income_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.ColumnHeadersHeight = 40;
            _dataSet = BLL.Owner.Income();
            change();
        }
        private void change()
        {
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            guna2DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            guna2DataGridView1.DataSource = _dataSet.Tables[0];
            guna2DataGridView1.Columns["HoTen"].HeaderText = "Họ và tên";
            guna2DataGridView1.Columns["Tongtien"].HeaderText = "Tổng tiền";
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text.Length > 0)
            {
                DataView dataView = _dataSet.Tables[0].DefaultView;
                dataView.RowFilter = string.Format("HoTen like '%{0}%'", tbSearch.Text);
                guna2DataGridView1.DataSource = dataView.ToTable();
            }
            else
            {
                change();
            }
        }
    }
}
