namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    partial class frmAddEditLocalLicenseApplication
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblDeniedUpdate = new System.Windows.Forms.Label();
            this.pnlApplicationInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbLocalLicenseClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithSearch1 = new PresentationLayer.PeopleFormsAndControls.ctrlPersonCardWithSearch();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblDeniedUpdate);
            this.guna2ShadowPanel1.Controls.Add(this.pnlApplicationInfo);
            this.guna2ShadowPanel1.Controls.Add(this.btnBack);
            this.guna2ShadowPanel1.Controls.Add(this.btnNext);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlPersonCardWithSearch1);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(886, 605);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // lblDeniedUpdate
            // 
            this.lblDeniedUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeniedUpdate.AutoSize = true;
            this.lblDeniedUpdate.Font = new System.Drawing.Font("Tahoma", 11.18868F, System.Drawing.FontStyle.Bold);
            this.lblDeniedUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblDeniedUpdate.Location = new System.Drawing.Point(254, 37);
            this.lblDeniedUpdate.Name = "lblDeniedUpdate";
            this.lblDeniedUpdate.Size = new System.Drawing.Size(357, 21);
            this.lblDeniedUpdate.TabIndex = 16;
            this.lblDeniedUpdate.Text = "Application started procees, cannot edit.";
            this.lblDeniedUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeniedUpdate.Visible = false;
            // 
            // pnlApplicationInfo
            // 
            this.pnlApplicationInfo.BackColor = System.Drawing.Color.White;
            this.pnlApplicationInfo.BorderColor = System.Drawing.Color.Silver;
            this.pnlApplicationInfo.BorderRadius = 20;
            this.pnlApplicationInfo.BorderThickness = 1;
            this.pnlApplicationInfo.Controls.Add(this.guna2PictureBox1);
            this.pnlApplicationInfo.Controls.Add(this.cbLocalLicenseClasses);
            this.pnlApplicationInfo.Controls.Add(this.label9);
            this.pnlApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.pnlApplicationInfo.Controls.Add(this.label7);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.pnlApplicationInfo.Controls.Add(this.label5);
            this.pnlApplicationInfo.Controls.Add(this.label3);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.pnlApplicationInfo.Controls.Add(this.label1);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationID);
            this.pnlApplicationInfo.Location = new System.Drawing.Point(26, 118);
            this.pnlApplicationInfo.Name = "pnlApplicationInfo";
            this.pnlApplicationInfo.ShadowDecoration.Parent = this.pnlApplicationInfo;
            this.pnlApplicationInfo.Size = new System.Drawing.Size(838, 415);
            this.pnlApplicationInfo.TabIndex = 17;
            this.pnlApplicationInfo.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(447, 226);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(18, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cbLocalLicenseClasses
            // 
            this.cbLocalLicenseClasses.BackColor = System.Drawing.Color.Transparent;
            this.cbLocalLicenseClasses.BorderColor = System.Drawing.Color.Silver;
            this.cbLocalLicenseClasses.BorderRadius = 10;
            this.cbLocalLicenseClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocalLicenseClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocalLicenseClasses.FocusedColor = System.Drawing.Color.Empty;
            this.cbLocalLicenseClasses.FocusedState.Parent = this.cbLocalLicenseClasses;
            this.cbLocalLicenseClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLocalLicenseClasses.ForeColor = System.Drawing.Color.Black;
            this.cbLocalLicenseClasses.FormattingEnabled = true;
            this.cbLocalLicenseClasses.HoverState.Parent = this.cbLocalLicenseClasses;
            this.cbLocalLicenseClasses.ItemHeight = 30;
            this.cbLocalLicenseClasses.ItemsAppearance.Parent = this.cbLocalLicenseClasses;
            this.cbLocalLicenseClasses.Location = new System.Drawing.Point(404, 180);
            this.cbLocalLicenseClasses.Name = "cbLocalLicenseClasses";
            this.cbLocalLicenseClasses.ShadowDecoration.Parent = this.cbLocalLicenseClasses;
            this.cbLocalLicenseClasses.Size = new System.Drawing.Size(288, 36);
            this.cbLocalLicenseClasses.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(129, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Created By:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUser.Location = new System.Drawing.Point(406, 267);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(121, 18);
            this.lblCreatedByUser.TabIndex = 0;
            this.lblCreatedByUser.Text = "Not Assigned Yet";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(129, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Application Fees:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(406, 228);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(121, 18);
            this.lblApplicationFees.TabIndex = 0;
            this.lblApplicationFees.Text = "Not Assigned Yet";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(129, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Driving License Classification:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(129, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(406, 150);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(121, 18);
            this.lblApplicationDate.TabIndex = 0;
            this.lblApplicationDate.Text = "Not Assigned Yet";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(129, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Driving License Application ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(406, 111);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(121, 18);
            this.lblApplicationID.TabIndex = 0;
            this.lblApplicationID.Text = "Not Assigned Yet";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.BorderRadius = 10;
            this.btnBack.BorderThickness = 1;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::PresentationLayer.Properties.Resources.BackShortArrow;
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBack.Location = new System.Drawing.Point(22, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(108, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.Color.DimGray;
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNext.ForeColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::PresentationLayer.Properties.Resources.nextShortArrow;
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.Location = new System.Drawing.Point(664, 548);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(200, 37);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(458, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(200, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.ControlBoxClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 10;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(664, 548);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(200, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlPersonCardWithSearch1
            // 
            this.ctrlPersonCardWithSearch1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonCardWithSearch1.CardBorderColor = System.Drawing.Color.Silver;
            this.ctrlPersonCardWithSearch1.CardBorderThickness = 1;
            this.ctrlPersonCardWithSearch1.FilterBorderColor = System.Drawing.Color.Silver;
            this.ctrlPersonCardWithSearch1.FilterBorderThickness = 1;
            this.ctrlPersonCardWithSearch1.FilterEnabled = true;
            this.ctrlPersonCardWithSearch1.FilterVisible = true;
            this.ctrlPersonCardWithSearch1.Location = new System.Drawing.Point(17, 112);
            this.ctrlPersonCardWithSearch1.Name = "ctrlPersonCardWithSearch1";
            this.ctrlPersonCardWithSearch1.Size = new System.Drawing.Size(853, 421);
            this.ctrlPersonCardWithSearch1.TabIndex = 3;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(828, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(35, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(527, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Local Driving License Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAddEditLocalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 605);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditLocalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditLocalLicenseApplication";
            this.Activated += new System.EventHandler(this.frmAddEditLocalLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddEditLocalLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.pnlApplicationInfo.ResumeLayout(false);
            this.pnlApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private PeopleFormsAndControls.ctrlPersonCardWithSearch ctrlPersonCardWithSearch1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlApplicationInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApplicationDate;
        private Guna.UI2.WinForms.Guna2ComboBox cbLocalLicenseClasses;
        private System.Windows.Forms.Label lblDeniedUpdate;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}