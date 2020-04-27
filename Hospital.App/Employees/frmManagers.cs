using Hospital.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.App.Employees
{
    public partial class frmManagers : Form
    {
        public frmManagers()
        {
            InitializeComponent();
        }

        void Bind()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var m = db.MGenericRepository.GetById(1);
                lblName.Text = m.ManagerName;
                lblPhoneNumber.Text = m.ManagerPhoneNumber;
                lblExpert.Text = m.ManagerExpert;
                lblEmail.Text = m.ManagerEmail;
                lblAge.Text = m.ManagerAge.ToString();
                lblAddress.Text = m.ManagerAddress;
                pcManager.ImageLocation = Application.StartupPath + "/Images/" + m.ManagerImage;
            }
        }

        private void frmManagers_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            frmEditManager frm = new frmEditManager();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Bind();
            }
        }
    }
}
