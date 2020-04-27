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
    public partial class frmEditManager : Form
    {
        public frmEditManager()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var M = db.MGenericRepository.GetById(1);
                        if (M.ManagerImage != null)
                        {
                            File.Delete(Application.StartupPath + "/Images/" + M.ManagerImage);
                        }
                    }
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcManager.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcManager.Image.Save(path + imageName);
                    var m = new Manager();
                    m.ManagerID = 1;
                    m.ManagerName = txtName.Text;
                    m.ManagerAddress = txtAddress.Text;
                    m.ManagerAge = int.Parse(txtAge.Text.ToString());
                    m.ManagerPhoneNumber = txtPhoneNumber.Text;
                    m.ManagerExpert = txtExpert.Text;
                    m.ManagerEmail = txtEmail.Text;
                    m.ManagerImage = imageName;
                    using(UnitOfWork db=new UnitOfWork())
                    {
                        db.MGenericRepository.Update(m);
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

        private void frmEditManager_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var m = db.MGenericRepository.GetById(1);
                txtAddress.Text = m.ManagerAddress;
                txtAge.Text = m.ManagerAge.ToString();
                txtEmail.Text = m.ManagerEmail;
                txtExpert.Text = m.ManagerExpert;
                txtName.Text = m.ManagerName;
                txtPhoneNumber.Text = m.ManagerPhoneNumber;
                pcManager.ImageLocation = Application.StartupPath + "/Images/" + m.ManagerImage;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                pcManager.ImageLocation = openFile.FileName;
            }
        }
    }
}
