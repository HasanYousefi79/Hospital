using Hospital.App.Information;
using Hospital.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK && frmLogin.Active == true && frmLogin.Active == true)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            if(frmLogin.Active==false)
            {
                Application.Exit();
            }
        }

        private void Form1Timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            frmPatients frm = new frmPatients();
            frm.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployees frm = new frmEmployees();
            frm.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            frmInformation frm = new frmInformation();
            frm.ShowDialog();
        }

        private void btnMySelf_Click(object sender, EventArgs e)
        {
            frmAboutMe frm = new frmAboutMe();
            frm.ShowDialog();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            frmReleasing frm = new frmReleasing();
            frm.ShowDialog();
        }

        private void btnLoginSetting_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }
    }
}
