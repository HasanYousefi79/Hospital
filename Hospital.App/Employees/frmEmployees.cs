using Hospital.App.Employees;
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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.ShowDialog();
            this.Close();
        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            frmManagers frm = new frmManagers();
            frm.ShowDialog();
            this.Close();
        }
    }
}
