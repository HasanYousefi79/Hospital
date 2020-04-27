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
using ValidationComponents;

namespace Hospital.App
{
    public partial class frmAddOrEdit : Form
    {
        public int Id = 0;
        public string Time = DateTime.Now.DayOfYear.ToString();
        public frmAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcPatient.ImageLocation = openFile.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    if (rbBlood.Checked || rbHeart.Checked)
                    {
                        if (Id != 0)
                        {
                            using (UnitOfWork db = new UnitOfWork())
                            {
                                var P = db.PGenericRepository.GetById(Id);
                                if (P.PatientImage != null)
                                {
                                    File.Delete(Application.StartupPath + "/Images/" + P.PatientImage);
                                }
                            }
                        }
                        string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcPatient.ImageLocation);
                        string path = Application.StartupPath + "/Images/";
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        pcPatient.Image.Save(path + imageName);
                        var p = new Patient();
                        p.PatientName = txtName.Text;
                        p.PatientPhoneNumber = txtPhoneNumber.Text;
                        p.PatientAddress = txtAddress.Text;
                        p.PatientEmail = txtEmail.Text;
                        p.PatientImage = imageName;
                        if (rbBlood.Checked)
                        {
                            p.PatientDisease = "خونی";
                            p.PatientAmount = 12000;
                        }
                        else
                        {
                            p.PatientDisease = "قلبی";
                            p.PatientAmount = 15000;
                        }
                        using (UnitOfWork db = new UnitOfWork())
                        {
                            if (Id == 0)
                            {
                                p.PatientDate = DateTime.Now.DayOfYear.ToString();
                                db.PGenericRepository.Insert(p);
                            }
                            else
                            {
                                p.PatientID = Id;
                                p.PatientDate = Time;
                                db.PGenericRepository.Update(p);
                            }
                            db.Save();
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        RtlMessageBox.Show("نوع بیماری را انتخاب کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                RtlMessageBox.Show("به صورت صحیح وارد کنید!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                this.Text = "افزودن";
            }
            else
            {
                this.Text = "ویرایش";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var p = db.PGenericRepository.GetById(Id);
                    txtName.Text = p.PatientName;
                    txtPhoneNumber.Text = p.PatientPhoneNumber;
                    txtEmail.Text = p.PatientEmail;
                    txtAddress.Text = p.PatientAddress;
                    pcPatient.ImageLocation = Application.StartupPath + "/Images/" + p.PatientImage;
                    if (p.PatientDisease == "خونی")
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

    }
}
