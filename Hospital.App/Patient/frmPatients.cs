using Hospital.DataLayer;
using Hospital.DataLayer.Context;
using Hospital.Utility.Convertor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital.App
{
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPatients.AutoGenerateColumns = false;
                dgvPatients.DataSource = db.PGenericRepository.Get();
            }
        }

        private void frmPatients_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddOrEdit frm = new frmAddOrEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnRemovePatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                string name = dgvPatients.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvPatients.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var p = db.PGenericRepository.GetById(id);
                        if (p.PatientImage != null)
                        {
                            File.Delete(Application.StartupPath + "/Images/" + p.PatientImage);
                        }
                        db.PGenericRepository.Delete(p);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show($"یک شخص را انخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null)
            {
                int id = int.Parse(dgvPatients.CurrentRow.Cells[0].Value.ToString());
                string time = dgvPatients.CurrentRow.Cells[6].Value.ToString();
                frmAddOrEdit frm = new frmAddOrEdit();
                frm.Id = id;
                frm.Time = time;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show($"یک شخص را انخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvPatients.DataSource = db.PGenericRepository.Get(p => p.PatientName.Contains(txtFilter.Text));
            }
        }
    }
}
