namespace Hospital.App
{
    partial class frmDoctor
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddDoctor = new System.Windows.Forms.ToolStripButton();
            this.btnEditDoctor = new System.Windows.Forms.ToolStripButton();
            this.btnRemoveDoctor = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDoctor,
            this.btnEditDoctor,
            this.btnRemoveDoctor,
            this.btnRefresh,
            this.toolStripLabel1,
            this.txtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 68);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Image = global::Hospital.App.Properties.Resources._1371475930_filenew;
            this.btnAddDoctor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(56, 63);
            this.btnAddDoctor.Text = "افزودن";
            this.btnAddDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnEditDoctor
            // 
            this.btnEditDoctor.Image = global::Hospital.App.Properties.Resources._1371475973_document_edit;
            this.btnEditDoctor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDoctor.Name = "btnEditDoctor";
            this.btnEditDoctor.Size = new System.Drawing.Size(60, 63);
            this.btnEditDoctor.Text = "ویرایش";
            this.btnEditDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditDoctor.Click += new System.EventHandler(this.btnEditDoctor_Click);
            // 
            // btnRemoveDoctor
            // 
            this.btnRemoveDoctor.Image = global::Hospital.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnRemoveDoctor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRemoveDoctor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemoveDoctor.Name = "btnRemoveDoctor";
            this.btnRemoveDoctor.Size = new System.Drawing.Size(47, 63);
            this.btnRemoveDoctor.Text = "حذف";
            this.btnRemoveDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveDoctor.Click += new System.EventHandler(this.btnRemoveDoctor_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Hospital.App.Properties.Resources._1371476394_refresh_red;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 63);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AllowUserToDeleteRows = false;
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.DoctorName,
            this.DoctorSection,
            this.DoctorPhoneNumber,
            this.DoctorAge,
            this.DoctorImage,
            this.DoctorAddress});
            this.dgvDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoctor.Location = new System.Drawing.Point(0, 68);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersWidth = 62;
            this.dgvDoctor.RowTemplate.Height = 28;
            this.dgvDoctor.Size = new System.Drawing.Size(678, 376);
            this.dgvDoctor.TabIndex = 1;
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "Column1";
            this.DoctorID.MinimumWidth = 8;
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Visible = false;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "نام";
            this.DoctorName.MinimumWidth = 8;
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // DoctorSection
            // 
            this.DoctorSection.DataPropertyName = "DoctorSection";
            this.DoctorSection.HeaderText = "بخش";
            this.DoctorSection.MinimumWidth = 8;
            this.DoctorSection.Name = "DoctorSection";
            this.DoctorSection.ReadOnly = true;
            // 
            // DoctorPhoneNumber
            // 
            this.DoctorPhoneNumber.DataPropertyName = "DoctorPhoneNumber";
            this.DoctorPhoneNumber.HeaderText = "تلفن";
            this.DoctorPhoneNumber.MinimumWidth = 8;
            this.DoctorPhoneNumber.Name = "DoctorPhoneNumber";
            this.DoctorPhoneNumber.ReadOnly = true;
            // 
            // DoctorAge
            // 
            this.DoctorAge.DataPropertyName = "DoctorAge";
            this.DoctorAge.HeaderText = "سن";
            this.DoctorAge.MinimumWidth = 8;
            this.DoctorAge.Name = "DoctorAge";
            this.DoctorAge.ReadOnly = true;
            // 
            // DoctorImage
            // 
            this.DoctorImage.DataPropertyName = "DoctorImage";
            this.DoctorImage.HeaderText = "Column6";
            this.DoctorImage.MinimumWidth = 8;
            this.DoctorImage.Name = "DoctorImage";
            this.DoctorImage.ReadOnly = true;
            this.DoctorImage.Visible = false;
            // 
            // DoctorAddress
            // 
            this.DoctorAddress.DataPropertyName = "DoctorAddress";
            this.DoctorAddress.HeaderText = "Column7";
            this.DoctorAddress.MinimumWidth = 8;
            this.DoctorAddress.Name = "DoctorAddress";
            this.DoctorAddress.ReadOnly = true;
            this.DoctorAddress.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 63);
            this.toolStripLabel1.Text = "جستجو :";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(100, 68);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDoctor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "دکتر ها";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnAddDoctor;
        private System.Windows.Forms.ToolStripButton btnEditDoctor;
        private System.Windows.Forms.ToolStripButton btnRemoveDoctor;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorAddress;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
    }
}