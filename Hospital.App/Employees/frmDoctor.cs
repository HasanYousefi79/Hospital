using Hospital.App.Employees;
using Hospital.DataLayer.Context;
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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            frmAddOrEditDoctor frm = new frmAddOrEditDoctor();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
            }
        }

        void BindGrid()
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                dgvDoctor.AutoGenerateColumns = false;
                dgvDoctor.DataSource = db.DGetGenericRepository.Get();
            }
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnEditDoctor_Click(object sender, EventArgs e)
        {
            if(dgvDoctor.CurrentRow!=null)
            {
                int id = int.Parse(dgvDoctor.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditDoctor frm = new frmAddOrEditDoctor();
                frm.id = id;
                if (frm.ShowDialog()==DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show($"یک شخص را انخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void btnRemoveDoctor_Click(object sender, EventArgs e)
        {
            if (dgvDoctor.CurrentRow != null)
            {
                string name = dgvDoctor.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvDoctor.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var d = db.DGetGenericRepository.GetById(id);
                        if (d.DoctorImage != null)
                        {
                            File.Delete(Application.StartupPath + "/Images/" + d.DoctorImage);
                        }
                        db.DGetGenericRepository.Delete(d);
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

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                dgvDoctor.DataSource = db.DGetGenericRepository.Get(d => d.DoctorName.Contains(txtFilter.Text));
            }
        }
    }
}
