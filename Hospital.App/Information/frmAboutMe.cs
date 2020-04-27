using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.App.Information
{
    public partial class frmAboutMe : Form
    {
        public frmAboutMe()
        {
            InitializeComponent();
        }

        private void frmAboutMe_Load(object sender, EventArgs e)
        {
            name.Text = "حسن یوسفی";
            mobile.Text = "09168434974";
            email.Text = "Hasan79Yousefi@Gmail.Com";
            telegram.Text = "HasanYousefi10@";
            instagram.Text = "HasanYousefi10";
            study.Text = "مهندسی کامپیوتر";
            university.Text = "دانشگاه شهرکرد";
        }
    }
}
