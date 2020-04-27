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

namespace Hospital.App.Employees
{
    public partial class frmAddOrEditStaff : Form
    {
        public int id = 0;
        public frmAddOrEditStaff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    var s = new Staff();
                    s.StaffName = txtName.Text;
                    s.StaffEmail = txtEmail.Text;
                    s.StaffSection = txtSection.Text;
                    s.StaffAddress = txtAddress.Text;
                    s.StaffAge = int.Parse(txtAge.Text.ToString());
                    s.StaffPhoneNumber = txtPhoneNumber.Text;
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        if (id == 0)
                        {
                            db.SGenericRepository.Insert(s);
                        }
                        else
                        {
                            s.StaffID = id;
                            db.SGenericRepository.Update(s);
                        }
                        db.Save();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("به صورت صحیح وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddOrEditStaff_Load(object sender, EventArgs e)
        {
            if(id==0)
            {
                this.Text = "افزودن";
            }
            else
            {
                this.Text = "ویرایش";
                using(UnitOfWork db=new UnitOfWork())
                {
                    var s = db.SGenericRepository.GetById(id);
                    txtAddress.Text = s.StaffAddress;
                    txtAge.Text = s.StaffAge.ToString();
                    txtEmail.Text = s.StaffEmail;
                    txtName.Text = s.StaffName;
                    txtPhoneNumber.Text = s.StaffPhoneNumber;
                    txtSection.Text = s.StaffSection;
                }
            }
        }
    }
}
