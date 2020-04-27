using Hospital.App.Employees;
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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvStaff.AutoGenerateColumns = false;
                dgvStaff.DataSource = db.SGenericRepository.Get();
            }
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null)
            {
                string name = dgvStaff.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgvStaff.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.SGenericRepository.Delete(id);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using(UnitOfWork db=new UnitOfWork())
            {
                dgvStaff.DataSource = db.SGenericRepository.Get(s => s.StaffName.Contains(txtFilter.Text));
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            frmAddOrEditStaff frm = new frmAddOrEditStaff();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if(dgvStaff.CurrentRow!=null)
            {
                int id = int.Parse(dgvStaff.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditStaff frm = new frmAddOrEditStaff();
                frm.id = id;
                if(frm.ShowDialog()==DialogResult.OK)
                {
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show($"یک شخص را انخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
