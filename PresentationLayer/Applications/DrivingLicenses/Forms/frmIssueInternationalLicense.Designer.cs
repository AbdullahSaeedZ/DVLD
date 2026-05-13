namespace PresentationLayer.Applications.DrivingLicenses.Forms
{
    partial class frmIssueInternationalLicense
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnShowLicenseInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowLicensesHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlLocalDrivingLicenseInfoWithFilter1 = new PresentationLayer.Applications.DrivingLicenses.Controls.ctrlLocalDrivingLicenseInfoWithFilter();
            this.pnlApplicationInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblLocalLicenseID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCreatedByUser = new System.Windows.Forms.Label();
            this.lblInterLicenseID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblInterApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssueLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnShowLicenseInfo);
            this.guna2ShadowPanel1.Controls.Add(this.btnShowLicensesHistory);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlLocalDrivingLicenseInfoWithFilter1);
            this.guna2ShadowPanel1.Controls.Add(this.pnlApplicationInfo);
            this.guna2ShadowPanel1.Controls.Add(this.btnIssueLicense);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1000, 789);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnShowLicenseInfo.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.BorderRadius = 10;
            this.btnShowLicenseInfo.CheckedState.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.CustomImages.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Enabled = false;
            this.btnShowLicenseInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.Black;
            this.btnShowLicenseInfo.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowLicenseInfo.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowLicenseInfo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowLicenseInfo.HoverState.Image = global::PresentationLayer.Properties.Resources.LicenseCardFill64;
            this.btnShowLicenseInfo.HoverState.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Image = global::PresentationLayer.Properties.Resources.LicenseCardNoFill64;
            this.btnShowLicenseInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(241, 736);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.PressedColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.ShadowDecoration.Parent = this.btnShowLicenseInfo;
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(223, 26);
            this.btnShowLicenseInfo.TabIndex = 19;
            this.btnShowLicenseInfo.Text = "Show Issued License Info";
            this.btnShowLicenseInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
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
            this.btnShowLicensesHistory.Location = new System.Drawing.Point(27, 736);
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
            this.pnlApplicationInfo.Controls.Add(this.guna2PictureBox2);
            this.pnlApplicationInfo.Controls.Add(this.label17);
            this.pnlApplicationInfo.Controls.Add(this.label16);
            this.pnlApplicationInfo.Controls.Add(this.label11);
            this.pnlApplicationInfo.Controls.Add(this.label10);
            this.pnlApplicationInfo.Controls.Add(this.lblIssueDate);
            this.pnlApplicationInfo.Controls.Add(this.lblExpirationDate);
            this.pnlApplicationInfo.Controls.Add(this.lblFees);
            this.pnlApplicationInfo.Controls.Add(this.lblLocalLicenseID);
            this.pnlApplicationInfo.Controls.Add(this.label13);
            this.pnlApplicationInfo.Controls.Add(this.label12);
            this.pnlApplicationInfo.Controls.Add(this.label3);
            this.pnlApplicationInfo.Controls.Add(this.label1);
            this.pnlApplicationInfo.Controls.Add(this.lblCreatedByUser);
            this.pnlApplicationInfo.Controls.Add(this.lblInterLicenseID);
            this.pnlApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.pnlApplicationInfo.Controls.Add(this.lblInterApplicationID);
            this.pnlApplicationInfo.Controls.Add(this.label2);
            this.pnlApplicationInfo.Location = new System.Drawing.Point(18, 507);
            this.pnlApplicationInfo.Name = "pnlApplicationInfo";
            this.pnlApplicationInfo.ShadowDecoration.Parent = this.pnlApplicationInfo;
            this.pnlApplicationInfo.Size = new System.Drawing.Size(964, 215);
            this.pnlApplicationInfo.TabIndex = 17;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox2.Location = new System.Drawing.Point(362, 161);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(18, 24);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 29;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(633, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 18);
            this.label17.TabIndex = 4;
            this.label17.Text = "Created By:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(599, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "Expiration Date:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(154, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "Application Date:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(602, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Intr.License ID:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(325, 134);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(27, 18);
            this.lblIssueDate.TabIndex = 23;
            this.lblIssueDate.Text = "NA";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(765, 134);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(27, 18);
            this.lblExpirationDate.TabIndex = 28;
            this.lblExpirationDate.Text = "NA";
            // 
            // lblFees
            // 
            this.lblFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.Black;
            this.lblFees.Location = new System.Drawing.Point(325, 164);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(27, 18);
            this.lblFees.TabIndex = 21;
            this.lblFees.Text = "NA";
            // 
            // lblLocalLicenseID
            // 
            this.lblLocalLicenseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalLicenseID.AutoSize = true;
            this.lblLocalLicenseID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicenseID.Location = new System.Drawing.Point(765, 104);
            this.lblLocalLicenseID.Name = "lblLocalLicenseID";
            this.lblLocalLicenseID.Size = new System.Drawing.Size(118, 18);
            this.lblLocalLicenseID.TabIndex = 26;
            this.lblLocalLicenseID.Text = "Not Selected Yet";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(137, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Intr.Application ID:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(592, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "Local License ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(197, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Issue Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(242, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fees:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatedByUser.AutoSize = true;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.Black;
            this.lblCreatedByUser.Location = new System.Drawing.Point(765, 164);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(27, 18);
            this.lblCreatedByUser.TabIndex = 20;
            this.lblCreatedByUser.Text = "NA";
            // 
            // lblInterLicenseID
            // 
            this.lblInterLicenseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterLicenseID.AutoSize = true;
            this.lblInterLicenseID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterLicenseID.ForeColor = System.Drawing.Color.Black;
            this.lblInterLicenseID.Location = new System.Drawing.Point(765, 74);
            this.lblInterLicenseID.Name = "lblInterLicenseID";
            this.lblInterLicenseID.Size = new System.Drawing.Size(121, 18);
            this.lblInterLicenseID.TabIndex = 18;
            this.lblInterLicenseID.Text = "Not Assigned Yet";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.Black;
            this.lblApplicationDate.Location = new System.Drawing.Point(325, 104);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(27, 18);
            this.lblApplicationDate.TabIndex = 17;
            this.lblApplicationDate.Text = "NA";
            // 
            // lblInterApplicationID
            // 
            this.lblInterApplicationID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInterApplicationID.AutoSize = true;
            this.lblInterApplicationID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterApplicationID.ForeColor = System.Drawing.Color.Black;
            this.lblInterApplicationID.Location = new System.Drawing.Point(325, 74);
            this.lblInterApplicationID.Name = "lblInterApplicationID";
            this.lblInterApplicationID.Size = new System.Drawing.Size(121, 18);
            this.lblInterApplicationID.TabIndex = 25;
            this.lblInterApplicationID.Text = "Not Assigned Yet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Application Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueLicense.BorderColor = System.Drawing.Color.DimGray;
            this.btnIssueLicense.BorderRadius = 10;
            this.btnIssueLicense.BorderThickness = 1;
            this.btnIssueLicense.CheckedState.Parent = this.btnIssueLicense;
            this.btnIssueLicense.CustomImages.Parent = this.btnIssueLicense;
            this.btnIssueLicense.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FillColor = System.Drawing.Color.Transparent;
            this.btnIssueLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnIssueLicense.ForeColor = System.Drawing.Color.DimGray;
            this.btnIssueLicense.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnIssueLicense.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssueLicense.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIssueLicense.HoverState.Parent = this.btnIssueLicense;
            this.btnIssueLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssueLicense.Location = new System.Drawing.Point(827, 736);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.ShadowDecoration.Parent = this.btnIssueLicense;
            this.btnIssueLicense.Size = new System.Drawing.Size(155, 37);
            this.btnIssueLicense.TabIndex = 6;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(666, 736);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(155, 37);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(942, 12);
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
            this.lblTitle.Location = new System.Drawing.Point(262, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(477, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New International Driving License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmIssueInternationalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 789);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueInternationalLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueInternationalLicense";
            this.Activated += new System.EventHandler(this.frmIssueInternationalLicense_Activated);
            this.Load += new System.EventHandler(this.frmIssueInternationalLicense_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.pnlApplicationInfo.ResumeLayout(false);
            this.pnlApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlApplicationInfo;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlLocalDrivingLicenseInfoWithFilter ctrlLocalDrivingLicenseInfoWithFilter1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnShowLicenseInfo;
        private Guna.UI2.WinForms.Guna2Button btnShowLicensesHistory;
        private Guna.UI2.WinForms.Guna2Button btnIssueLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblLocalLicenseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.Label lblInterLicenseID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblInterApplicationID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}