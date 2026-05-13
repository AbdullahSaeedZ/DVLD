namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    partial class frmReleaseDetainedLicense
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowReleasedLicenseInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowLicensesHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLocalDrivingLicenseInfoWithFilter1 = new PresentationLayer.Applications.DrivingLicenses.Controls.ctrlLocalDrivingLicenseInfoWithFilter();
            this.pnlApplicationInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.lblDetentionDate = new System.Windows.Forms.Label();
            this.lblDetainID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReleaseLicense = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnShowReleasedLicenseInfo);
            this.guna2ShadowPanel1.Controls.Add(this.btnShowLicensesHistory);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlLocalDrivingLicenseInfoWithFilter1);
            this.guna2ShadowPanel1.Controls.Add(this.pnlApplicationInfo);
            this.guna2ShadowPanel1.Controls.Add(this.btnReleaseLicense);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(999, 800);
            this.guna2ShadowPanel1.TabIndex = 6;
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
            this.btnCancel.Location = new System.Drawing.Point(665, 746);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(155, 37);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnShowReleasedLicenseInfo
            // 
            this.btnShowReleasedLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnShowReleasedLicenseInfo.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowReleasedLicenseInfo.BorderRadius = 10;
            this.btnShowReleasedLicenseInfo.CheckedState.Parent = this.btnShowReleasedLicenseInfo;
            this.btnShowReleasedLicenseInfo.CustomImages.Parent = this.btnShowReleasedLicenseInfo;
            this.btnShowReleasedLicenseInfo.Enabled = false;
            this.btnShowReleasedLicenseInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowReleasedLicenseInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReleasedLicenseInfo.ForeColor = System.Drawing.Color.Black;
            this.btnShowReleasedLicenseInfo.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowReleasedLicenseInfo.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowReleasedLicenseInfo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowReleasedLicenseInfo.HoverState.Image = global::PresentationLayer.Properties.Resources.LicenseCardFill64;
            this.btnShowReleasedLicenseInfo.HoverState.Parent = this.btnShowReleasedLicenseInfo;
            this.btnShowReleasedLicenseInfo.Image = global::PresentationLayer.Properties.Resources.LicenseCardNoFill64;
            this.btnShowReleasedLicenseInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowReleasedLicenseInfo.Location = new System.Drawing.Point(240, 746);
            this.btnShowReleasedLicenseInfo.Name = "btnShowReleasedLicenseInfo";
            this.btnShowReleasedLicenseInfo.PressedColor = System.Drawing.Color.DimGray;
            this.btnShowReleasedLicenseInfo.ShadowDecoration.Parent = this.btnShowReleasedLicenseInfo;
            this.btnShowReleasedLicenseInfo.Size = new System.Drawing.Size(235, 26);
            this.btnShowReleasedLicenseInfo.TabIndex = 19;
            this.btnShowReleasedLicenseInfo.Text = "Show Released License Info";
            this.btnShowReleasedLicenseInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowReleasedLicenseInfo.Click += new System.EventHandler(this.btnShowReleasedLicenseInfo_Click);
            // 
            // btnShowLicensesHistory
            // 
            this.btnShowLicensesHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnShowLicensesHistory.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowLicensesHistory.BorderRadius = 10;
            this.btnShowLicensesHistory.CheckedState.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.CustomImages.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Enabled = false;
            this.btnShowLicensesHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnShowLicensesHistory.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicensesHistory.ForeColor = System.Drawing.Color.Black;
            this.btnShowLicensesHistory.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowLicensesHistory.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowLicensesHistory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowLicensesHistory.HoverState.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryFill24;
            this.btnShowLicensesHistory.HoverState.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryNoFill24;
            this.btnShowLicensesHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(26, 746);
            this.btnShowLicensesHistory.Name = "btnShowLicensesHistory";
            this.btnShowLicensesHistory.PressedColor = System.Drawing.Color.DimGray;
            this.btnShowLicensesHistory.ShadowDecoration.Parent = this.btnShowLicensesHistory;
            this.btnShowLicensesHistory.Size = new System.Drawing.Size(195, 26);
            this.btnShowLicensesHistory.TabIndex = 19;
            this.btnShowLicensesHistory.Text = "Show Licenses History";
            this.btnShowLicensesHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowLicensesHistory.Click += new System.EventHandler(this.btnShowLicensesHistory_Click);
            // 
            // ctrlLocalDrivingLicenseInfoWithFilter1
            // 
            this.ctrlLocalDrivingLicenseInfoWithFilter1.FilterBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.FilterBorderThickness = 1;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.FilterVisible = true;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.LicenseCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.LicenseCardBorderThickness = 1;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.Location = new System.Drawing.Point(13, 87);
            this.ctrlLocalDrivingLicenseInfoWithFilter1.Name = "ctrlLocalDrivingLicenseInfoWithFilter1";
            this.ctrlLocalDrivingLicenseInfoWithFilter1.Size = new System.Drawing.Size(973, 413);
            this.ctrlLocalDrivingLicenseInfoWithFilter1.TabIndex = 18;
            this.ctrlLocalDrivingLicenseInfoWithFilter1.OnLicenseSelected += new System.Action(this.ctrlLocalDrivingLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // pnlApplicationInfo
            // 
            this.pnlApplicationInfo.BackColor = System.Drawing.Color.White;
            this.pnlApplicationInfo.BorderColor = System.Drawing.Color.Silver;
            this.pnlApplicationInfo.BorderRadius = 20;
            this.pnlApplicationInfo.BorderThickness = 1;
            this.pnlApplicationInfo.Controls.Add(this.guna2PictureBox3);
            this.pnlApplicationInfo.Controls.Add(this.guna2PictureBox1);
            this.pnlApplicationInfo.Controls.Add(this.guna2PictureBox2);
            this.pnlApplicationInfo.Controls.Add(this.label17);
            this.pnlApplicationInfo.Controls.Add(this.label6);
            this.pnlApplicationInfo.Controls.Add(this.label4);
            this.pnlApplicationInfo.Controls.Add(this.label11);
            this.pnlApplicationInfo.Controls.Add(this.label10);
            this.pnlApplicationInfo.Controls.Add(this.label8);
            this.pnlApplicationInfo.Controls.Add(this.label13);
            this.pnlApplicationInfo.Controls.Add(this.label1);
            this.pnlApplicationInfo.Controls.Add(this.lblTotalFees);
            this.pnlApplicationInfo.Controls.Add(this.lblFineFees);
            this.pnlApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.pnlApplicationInfo.Controls.Add(this.lblLicenseID);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationID);
            this.pnlApplicationInfo.Controls.Add(this.lblDetentionDate);
            this.pnlApplicationInfo.Controls.Add(this.lblDetainID);
            this.pnlApplicationInfo.Controls.Add(this.label2);
            this.pnlApplicationInfo.Location = new System.Drawing.Point(17, 506);
            this.pnlApplicationInfo.Name = "pnlApplicationInfo";
            this.pnlApplicationInfo.ShadowDecoration.Parent = this.pnlApplicationInfo;
            this.pnlApplicationInfo.Size = new System.Drawing.Size(964, 230);
            this.pnlApplicationInfo.TabIndex = 17;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox3.Location = new System.Drawing.Point(801, 178);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(18, 24);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 32;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(355, 176);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(18, 24);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 31;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox2.Location = new System.Drawing.Point(355, 142);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(18, 24);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 30;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(641, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "Created By:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(646, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Fees:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(143, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Application Fees:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(154, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Detention Date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(644, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "License ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(617, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Application ID:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(171, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Detention ID:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(195, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fine Fees:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.Black;
            this.lblTotalFees.Location = new System.Drawing.Point(763, 179);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(27, 18);
            this.lblTotalFees.TabIndex = 17;
            this.lblTotalFees.Text = "NA";
            // 
            // lblFineFees
            // 
            this.lblFineFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.Black;
            this.lblFineFees.Location = new System.Drawing.Point(314, 179);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(27, 18);
            this.lblFineFees.TabIndex = 20;
            this.lblFineFees.Text = "NA";
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUser.Location = new System.Drawing.Point(763, 109);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(27, 18);
            this.lblCreatedByUser.TabIndex = 20;
            this.lblCreatedByUser.Text = "NA";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationFees.Location = new System.Drawing.Point(314, 144);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(27, 18);
            this.lblApplicationFees.TabIndex = 17;
            this.lblApplicationFees.Text = "NA";
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLicenseID.AutoSize = true;
            this.lblLicenseID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLicenseID.Location = new System.Drawing.Point(763, 74);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(118, 18);
            this.lblLicenseID.TabIndex = 18;
            this.lblLicenseID.Text = "Not Selected Yet";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationID.Location = new System.Drawing.Point(763, 147);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(121, 18);
            this.lblApplicationID.TabIndex = 25;
            this.lblApplicationID.Text = "Not Assigned Yet";
            // 
            // lblDetentionDate
            // 
            this.lblDetentionDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetentionDate.AutoSize = true;
            this.lblDetentionDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetentionDate.ForeColor = System.Drawing.Color.Black;
            this.lblDetentionDate.Location = new System.Drawing.Point(314, 109);
            this.lblDetentionDate.Name = "lblDetentionDate";
            this.lblDetentionDate.Size = new System.Drawing.Size(27, 18);
            this.lblDetentionDate.TabIndex = 17;
            this.lblDetentionDate.Text = "NA";
            // 
            // lblDetainID
            // 
            this.lblDetainID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDetainID.AutoSize = true;
            this.lblDetainID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.Black;
            this.lblDetainID.Location = new System.Drawing.Point(314, 74);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(27, 18);
            this.lblDetainID.TabIndex = 25;
            this.lblDetainID.Text = "NA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Release Application Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicense.BorderColor = System.Drawing.Color.DimGray;
            this.btnReleaseLicense.BorderRadius = 10;
            this.btnReleaseLicense.BorderThickness = 1;
            this.btnReleaseLicense.CheckedState.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.CustomImages.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReleaseLicense.Enabled = false;
            this.btnReleaseLicense.FillColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.DimGray;
            this.btnReleaseLicense.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnReleaseLicense.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleaseLicense.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseLicense.HoverState.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReleaseLicense.Location = new System.Drawing.Point(826, 746);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.ShadowDecoration.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.Size = new System.Drawing.Size(155, 37);
            this.btnReleaseLicense.TabIndex = 6;
            this.btnReleaseLicense.Text = "Release";
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(941, 12);
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
            this.lblTitle.Location = new System.Drawing.Point(371, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Release License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 800);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReleaseDetainedLicense";
            this.Activated += new System.EventHandler(this.frmReleaseDetainedLicense_Activated);
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.pnlApplicationInfo.ResumeLayout(false);
            this.pnlApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnShowReleasedLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnShowLicensesHistory;
        private Controls.ctrlLocalDrivingLicenseInfoWithFilter ctrlLocalDrivingLicenseInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Panel pnlApplicationInfo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblLicenseID;
        private System.Windows.Forms.Label lblDetentionDate;
        private System.Windows.Forms.Label lblDetainID;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnReleaseLicense;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}