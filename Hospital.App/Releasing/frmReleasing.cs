using Hospital.Business.Releasing;
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
using ValidationComponents;

namespace Hospital.App
{
    public partial class frmReleasing : Form
    {
        int day;
        public frmReleasing()
        {
            InitializeComponent();
        }

        private void frmReleasing_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPatientsList.AutoGenerateColumns = false;
                dgvPatientsList.DataSource = db.PatientsRepository.GetNamePatient();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPatientsList.DataSource = db.PatientsRepository.GetNamePatient(txtFilter.Text);
            }
        }

        private void dgvPatientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvPatientsList.CurrentRow.Cells[1].Value.ToString();
            using (UnitOfWork db = new UnitOfWork())
            {
                int id = db.PatientsRepository.GetPatientIdByName(txtName.Text);
                var p = db.PGenericRepository.GetById(id);
                day = (int.Parse(DateTime.Now.DayOfYear.ToString()) - int.Parse(p.PatientDate.ToString())) + 1;
                txtDay.Text = day.ToString();
                if (p.PatientDisease == "قلبی")
                {
                    txtDisease.Text = "قلبی";
                }
                else
                {
                    txtDisease.Text = "خونی";
                }
                double amount = ReleasingPatiants.Release(day, p.PatientAmount);
                txtAmount.Text = amount.ToString();
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    int id = db.PatientsRepository.GetPatientIdByName(txtName.Text);
                    var p = db.PGenericRepository.GetById(id);
                    string name = p.PatientName;
                    if (RtlMessageBox.Show($"آیا از ترخیص {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        db.PGenericRepository.Delete(p);
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("بیمار را انتخب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
