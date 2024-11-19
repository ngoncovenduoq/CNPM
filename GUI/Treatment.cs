using MetroFramework.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_CNPM.Properties;
using System.Resources;

namespace Project_CNPM
{
    public partial class BS_Treatment : Form
    {
 
        public BS_Treatment()
        {
            InitializeComponent();
        }

        private void BS_Treatment_Load(object sender, EventArgs e)
        {
            panelPrescription.Visible = false;
            panelService.Visible = false;
        }

        private void hideSubMenu(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void resetButton()
        {
            //Bệnh nhân
            btnPatient.FillColor = Color.FromArgb(63, 220, 254);
            btnPatient.ForeColor = Color.Black;
            btnPatient.Image = Properties.Resources.patient1;

            //Dịch vụ
            btnService.FillColor = Color.FromArgb(63, 220, 254);
            btnService.ForeColor = Color.Black;
            btnService.Image = Properties.Resources.examination;

            //Kê đơn
            btnPrescription.FillColor = Color.FromArgb(63, 220, 254);
            btnPrescription.ForeColor = Color.Black;
            btnPrescription.Image = Properties.Resources.medicine1;

            //Tái khám
            btnExamination.FillColor = Color.FromArgb(63, 220, 254);
            btnExamination.ForeColor = Color.Black;
            btnExamination.Image = Properties.Resources.timetable1;

            //Tạo hóa đơn
            btnBill.FillColor = Color.FromArgb(63, 220, 254);
            btnBill.ForeColor = Color.Black;
            btnBill.Image = Properties.Resources.invoice;
        }

        //Thay đổi form

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelShow.Controls.Add(childForm);
            panelShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void hideChildForm()
        {
            if (activeForm is CreateInvoice)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            resetButton();
            showSubMenu(panePatient);
            hideSubMenu(panelPrescription);
            hideSubMenu(panelService);
            hideChildForm();
            btnPatient.FillColor = Color.FromArgb(7, 125, 4);
            btnPatient.ForeColor = Color.White;
            btnPatient.Image = Properties.Resources.patient;

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            hideSubMenu(panePatient);
            showSubMenu(panelService);
            hideSubMenu(panelPrescription);
            resetButton();
            hideChildForm();
            btnService.FillColor = Color.FromArgb(7, 125, 4);
            btnService.ForeColor = Color.White;
            btnService.Image = Properties.Resources.examination1;
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            hideSubMenu(panePatient);
            showSubMenu(panelPrescription);
            hideSubMenu(panelService);
            resetButton();
            hideChildForm();
            btnPrescription.FillColor = Color.FromArgb(7, 125, 4);
            btnPrescription.ForeColor = Color.White;
            btnPrescription.Image = Properties.Resources.medicine;
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            resetButton();
            hideSubMenu(panePatient);
            hideSubMenu(panelPrescription);
            hideSubMenu(panelService);
            hideChildForm();
            btnExamination.FillColor = Color.FromArgb(7, 125, 4);
            btnExamination.ForeColor = Color.White;
            btnExamination.Image = Properties.Resources.timetable11;
        }

        public void btnBill_Click(object sender, EventArgs e)
        {
            resetButton();
            hideSubMenu(panePatient);
            hideSubMenu(panelPrescription);
            hideSubMenu(panelService);
            btnBill.FillColor = Color.FromArgb(7, 125, 4);
            btnBill.ForeColor = Color.White;
            btnBill.Image = Properties.Resources.invoice1;

            CreateInvoice createInnovaForm = new CreateInvoice();
            openChildForm(createInnovaForm);
        }

        private BS_Treatment_Update updateForm;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateForm == null || updateForm.IsDisposed)
            {
                updateForm = new BS_Treatment_Update(); 
            }

            updateForm.StartPosition = FormStartPosition.Manual;
            updateForm.Location = Cursor.Position;

            updateForm.Show();
        }
    }
}
