namespace Hospital.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPatients = new System.Windows.Forms.ToolStripButton();
            this.btnEmployees = new System.Windows.Forms.ToolStripButton();
            this.btnAccounting = new System.Windows.Forms.ToolStripButton();
            this.btnInformation = new System.Windows.Forms.ToolStripButton();
            this.btnMySelf = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.Form1Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSetting = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnLoginSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPatients,
            this.btnEmployees,
            this.btnAccounting,
            this.btnInformation,
            this.btnMySelf});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPatients
            // 
            this.btnPatients.Image = global::Hospital.App.Properties.Resources.list2;
            this.btnPatients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPatients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(59, 63);
            this.btnPatients.Text = "بیماران";
            this.btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Image = global::Hospital.App.Properties.Resources.Users;
            this.btnEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(70, 63);
            this.btnEmployees.Text = "کارمندان";
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnAccounting
            // 
            this.btnAccounting.Image = global::Hospital.App.Properties.Resources.servicesCosts;
            this.btnAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccounting.Name = "btnAccounting";
            this.btnAccounting.Size = new System.Drawing.Size(83, 63);
            this.btnAccounting.Text = "حسابداری";
            this.btnAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccounting.Click += new System.EventHandler(this.btnAccounting_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Image = global::Hospital.App.Properties.Resources._1371476499_todo_list;
            this.btnInformation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(66, 63);
            this.btnInformation.Text = "اطلاعات";
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnMySelf
            // 
            this.btnMySelf.Image = global::Hospital.App.Properties.Resources._1371476468_preferences_contact_list;
            this.btnMySelf.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMySelf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMySelf.Name = "btnMySelf";
            this.btnMySelf.Size = new System.Drawing.Size(93, 63);
            this.btnMySelf.Text = "درباره ی من";
            this.btnMySelf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMySelf.Click += new System.EventHandler(this.btnMySelf_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 518);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(778, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(158, 19);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(158, 19);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // Form1Timer
            // 
            this.Form1Timer.Enabled = true;
            this.Form1Timer.Interval = 1000;
            this.Form1Timer.Tick += new System.EventHandler(this.Form1Timer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetting});
            this.toolStrip2.Location = new System.Drawing.Point(0, 68);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(778, 28);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoginSetting});
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(82, 23);
            this.btnSetting.Text = "تنظیمات";
            // 
            // btnLoginSetting
            // 
            this.btnLoginSetting.Name = "btnLoginSetting";
            this.btnLoginSetting.Size = new System.Drawing.Size(270, 34);
            this.btnLoginSetting.Text = "تنظیمات ورودی";
            this.btnLoginSetting.Click += new System.EventHandler(this.btnLoginSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بیمارستان";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnPatients;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer Form1Timer;
        private System.Windows.Forms.ToolStripButton btnEmployees;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton btnAccounting;
        private System.Windows.Forms.ToolStripButton btnInformation;
        private System.Windows.Forms.ToolStripButton btnMySelf;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton btnSetting;
        private System.Windows.Forms.ToolStripMenuItem btnLoginSetting;
    }
}

