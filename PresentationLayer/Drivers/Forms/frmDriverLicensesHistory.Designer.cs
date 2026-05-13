namespace PresentationLayer.Drivers.Forms
{
    partial class frmDriverLicensesHistory
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonCard1 = new PresentationLayer.PeopleFormsAndControls.ctrlPersonCard();
            this.ctrlListDriverLicenses1 = new PresentationLayer.Drivers.Controls.ctrlListDriverLicenses();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1.SuspendLayout();
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
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlPersonCard1);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlListDriverLicenses1);
            this.guna2ShadowPanel1.Controls.Add(this.btnClose);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1179, 893);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(425, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(328, 33);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Driver Licenses History";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.BorderColor = System.Drawing.Color.Silver;
            this.ctrlPersonCard1.BorderThickness = 1;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(169, 75);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(840, 348);
            this.ctrlPersonCard1.TabIndex = 12;
            // 
            // ctrlListDriverLicenses1
            // 
            this.ctrlListDriverLicenses1.BackColor = System.Drawing.Color.White;
            this.ctrlListDriverLicenses1.DGVBorderColor = System.Drawing.Color.Gainsboro;
            this.ctrlListDriverLicenses1.DGVBorderThickness = 1;
            this.ctrlListDriverLicenses1.Location = new System.Drawing.Point(17, 429);
            this.ctrlListDriverLicenses1.Name = "ctrlListDriverLicenses1";
            this.ctrlListDriverLicenses1.OuterBorderColor = System.Drawing.Color.Silver;
            this.ctrlListDriverLicenses1.OuterBorderThickness = 1;
            this.ctrlListDriverLicenses1.Size = new System.Drawing.Size(1145, 391);
            this.ctrlListDriverLicenses1.TabBorderColor = System.Drawing.Color.Gainsboro;
            this.ctrlListDriverLicenses1.TabBorderThickness = 1;
            this.ctrlListDriverLicenses1.TabIndex = 11;
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
            this.btnClose.Location = new System.Drawing.Point(1039, 839);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(1119, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 9;
            // 
            // frmDriverLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 893);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDriverLicensesHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDriverLicensesHistory";
            this.Load += new System.EventHandler(this.frmDriverLicensesHistory_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private PeopleFormsAndControls.ctrlPersonCard ctrlPersonCard1;
        private Controls.ctrlListDriverLicenses ctrlListDriverLicenses1;
        private System.Windows.Forms.Label lblTitle;
    }
}