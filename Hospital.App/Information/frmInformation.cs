using Hospital.DataLayer;
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

namespace Hospital.App
{
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
        }

        private void frmInformation_Load(object sender, EventArgs e)
        {
            lblStart.Text = "27 بهمن 1398";
            lblEnd.Text = "5 اسفند 1398";
            lblName.Text = "بیمارستان پناه";
            using (UnitOfWork db = new UnitOfWork())
            {
                int B = db.PGenericRepository.Get(p => p.PatientDisease == "خونی").Count();
                lblBlood.Text = B.ToString();
                int H = db.PGenericRepository.Get(p => p.PatientDisease == "قلبی").Count();
                lblHeart.Text = H.ToString();
                int E = db.SGenericRepository.Get().Count();
                lblEmployee.Text = E.ToString();
                int D = db.DGetGenericRepository.Get().Count();
                lblDoctor.Text = D.ToString();
            }
        }
    }
}
