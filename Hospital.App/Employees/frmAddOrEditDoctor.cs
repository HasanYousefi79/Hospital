using Hospital.DataLayer;
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
using ValidationComponents;

namespace Hospital.App.Employees
{
    public partial class frmAddOrEditDoctor : Form
    {
        public int id = 0;
        public frmAddOrEditDoctor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (rbBlood.Checked || rbHeart.Checked)
                    {
                        if (id != 0)
                        {
                            using (UnitOfWork db = new UnitOfWork())
                            {
                                var D = db.DGetGenericRepository.GetById(id);
                                if (D.DoctorImage != null)
                                {
                                    File.Delete(Application.StartupPath + "/Images/" + D.DoctorImage);
                                }
                            }
                        }
                        string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcDoctor.ImageLocation);
                        string path = Application.StartupPath + "/Images/";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        pcDoctor.Image.Save(path + imageName);
                        var d = new Doctor();
                        d.DoctorAddress = txtAddress.Text;
                        d.DoctorAge = int.Parse(txtAge.Text.ToString());
                        d.DoctorImage = imageName;
                        d.DoctorName = txtName.Text;
                        d.DoctorPhoneNumber = txtPhoneNumber.Text;
                        if (rbBlood.Checked)
                        {
                            d.DoctorSection = "خون";
                        }
                        else
                        {
                            d.DoctorSection = "قلب";
                        }
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (id == 0)
                            {
                                db.DGetGenericRepository.Insert(d);
                            }
                            else
                            {
                                d.DoctorID = id;
                                db.DGetGenericRepository.Update(d);
                            }
                            db.Save();
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        RtlMessageBox.Show("نوع بخش را انتخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("به صورت صحیح وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddOrEditDoctor_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                this.Text = "افزودن دکتر";
            }
            else
            {
                this.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var d = db.DGetGenericRepository.GetById(id);
                    txtAddress.Text = d.DoctorAddress;
                    txtAge.Text = d.DoctorAge.ToString();
                    txtName.Text = d.DoctorName;
                    txtPhoneNumber.Text = d.DoctorPhoneNumber;
                    pcDoctor.ImageLocation = Application.StartupPath + "/Images/" + d.DoctorImage;
                    if (d.DoctorSection == "خون")
                    {
                        rbBlood.Checked = true;
                    }
                    else
                    {
                        rbHeart.Checked = true;
                    }
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcDoctor.ImageLocation = openFile.FileName;
            }
        }
    }
}
