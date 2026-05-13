namespace PresentationLayer.Applications.ManageLocalApplications.Forms
{
    partial class frmIssueNewLocalDrivingLicense
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
            this.btnIssueNewLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlLocalApplicationInfo1 = new PresentationLayer.Applications.ManageLocalApplications.Controls.ctrlLocalApplicationInfo();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnIssueNewLicense);
            this.guna2ShadowPanel1.Controls.Add(this.btnClose);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel3);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlLocalApplicationInfo1);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(928, 738);
            this.guna2ShadowPanel1.TabIndex = 6;
            // 
            // btnIssueNewLicense
            // 
            this.btnIssueNewLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIssueNewLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnIssueNewLicense.BorderColor = System.Drawing.Color.DimGray;
            this.btnIssueNewLicense.BorderRadius = 10;
            this.btnIssueNewLicense.BorderThickness = 1;
            this.btnIssueNewLicense.CheckedState.Parent = this.btnIssueNewLicense;
            this.btnIssueNewLicense.CustomImages.Parent = this.btnIssueNewLicense;
            this.btnIssueNewLicense.FillColor = System.Drawing.Color.Transparent;
            this.btnIssueNewLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnIssueNewLicense.ForeColor = System.Drawing.Color.DimGray;
            this.btnIssueNewLicense.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnIssueNewLicense.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnIssueNewLicense.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnIssueNewLicense.HoverState.Parent = this.btnIssueNewLicense;
            this.btnIssueNewLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnIssueNewLicense.Location = new System.Drawing.Point(728, 689);
            this.btnIssueNewLicense.Name = "btnIssueNewLicense";
            this.btnIssueNewLicense.ShadowDecoration.Parent = this.btnIssueNewLicense;
            this.btnIssueNewLicense.Size = new System.Drawing.Size(185, 37);
            this.btnIssueNewLicense.TabIndex = 14;
            this.btnIssueNewLicense.Text = "Issue License";
            this.btnIssueNewLicense.Click += new System.EventHandler(this.btnIssueNewLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(594, 689);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.tbNotes);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(13, 564);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(901, 114);
            this.guna2Panel3.TabIndex = 13;
            // 
            // tbNotes
            // 
            this.tbNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbNotes.BorderColor = System.Drawing.Color.Silver;
            this.tbNotes.BorderRadius = 10;
            this.tbNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNotes.DefaultText = "";
            this.tbNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNotes.DisabledState.Parent = this.tbNotes;
            this.tbNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNotes.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbNotes.FocusedState.Parent = this.tbNotes;
            this.tbNotes.ForeColor = System.Drawing.Color.Black;
            this.tbNotes.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbNotes.HoverState.Parent = this.tbNotes;
            this.tbNotes.Location = new System.Drawing.Point(115, 17);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.PasswordChar = '\0';
            this.tbNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbNotes.PlaceholderText = "";
            this.tbNotes.SelectedText = "";
            this.tbNotes.ShadowDecoration.Parent = this.tbNotes;
            this.tbNotes.Size = new System.Drawing.Size(773, 87);
            this.tbNotes.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Notes:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(230, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 33);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Issue New Local Driving License";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctrlLocalApplicationInfo1
            // 
            this.ctrlLocalApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalApplicationInfo1.BasicApplicationBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalApplicationInfo1.BasicApplicationBorderThickness = 1;
            this.ctrlLocalApplicationInfo1.DrivingLicenseApplicationBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalApplicationInfo1.DrivingLicenseApplicationBorderThickness = 1;
            this.ctrlLocalApplicationInfo1.Location = new System.Drawing.Point(13, 71);
            this.ctrlLocalApplicationInfo1.Name = "ctrlLocalApplicationInfo1";
            this.ctrlLocalApplicationInfo1.Size = new System.Drawing.Size(901, 487);
            this.ctrlLocalApplicationInfo1.TabIndex = 11;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(868, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 9;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmIssueNewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 738);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssueNewLocalDrivingLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueNewLocalDrivingLicense";
            this.Activated += new System.EventHandler(this.frmIssueNewLocalDrivingLicense_Activated);
            this.Load += new System.EventHandler(this.frmIssueNewLocalDrivingLicense_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlLocalApplicationInfo ctrlLocalApplicationInfo1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnIssueNewLicense;
        private Guna.UI2.WinForms.Guna2TextBox tbNotes;
    }
}