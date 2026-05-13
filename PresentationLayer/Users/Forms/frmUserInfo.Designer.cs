namespace PresentationLayer.Users.Forms
{
    partial class frmUserInfo
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
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrlAddEditUserPermissions1 = new PresentationLayer.Users.Controls.ctrlAddEditUserPermissions();
            this.ctrlUserCard1 = new PresentationLayer.Users.Controls.ctrlUserCard();
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
            this.guna2ShadowPanel1.Controls.Add(this.ctrlAddEditUserPermissions1);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlUserCard1);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(861, 805);
            this.guna2ShadowPanel1.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(638, 753);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(200, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(803, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 8;
            // 
            // ctrlAddEditUserPermissions1
            // 
            this.ctrlAddEditUserPermissions1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlAddEditUserPermissions1.Location = new System.Drawing.Point(12, 501);
            this.ctrlAddEditUserPermissions1.Name = "ctrlAddEditUserPermissions1";
            this.ctrlAddEditUserPermissions1.PermissionsCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlAddEditUserPermissions1.PermissionsCardBorderThickness = 1;
            this.ctrlAddEditUserPermissions1.Size = new System.Drawing.Size(836, 242);
            this.ctrlAddEditUserPermissions1.TabIndex = 11;
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(8, 47);
            this.ctrlUserCard1.LoginInfoCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlUserCard1.LoginInfoCardBorderThickness = 1;
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.PersonCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlUserCard1.PersonCardBorderThickness = 1;
            this.ctrlUserCard1.Size = new System.Drawing.Size(841, 449);
            this.ctrlUserCard1.TabIndex = 9;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 805);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUserInfo";
            this.Load += new System.EventHandler(this.frmUserInfo_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Controls.ctrlUserCard ctrlUserCard1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Controls.ctrlAddEditUserPermissions ctrlAddEditUserPermissions1;
    }
}