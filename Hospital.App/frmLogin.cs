﻿using Hospital.DataLayer.Context;
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
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public bool Active = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnEnter.Text = "ذخیره تغییرات";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.Get().First();
                    txtUserName.Text = login.UserName;
                    txtPassword.Text = login.Password;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (IsEdit)
                    {
                        var login = db.LoginRepository.Get().First();
                        login.UserName = txtUserName.Text;
                        login.Password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.Get(l => l.UserName == txtUserName.Text && l.Password == txtPassword.Text).Any())
                        {
                            Active = true;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("کاربری یافت نشد");
                        }
                    }
                }
            }
        }
    }
}
