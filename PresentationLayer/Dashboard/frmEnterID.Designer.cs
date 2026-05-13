namespace PresentationLayer.Dashboard
{
    partial class frmEnterID
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
            this.guna2Panel8 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel8);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnSearch);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(433, 213);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // guna2Panel8
            // 
            this.guna2Panel8.BackColor = System.Drawing.Color.White;
            this.guna2Panel8.BorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel8.BorderRadius = 10;
            this.guna2Panel8.BorderThickness = 1;
            this.guna2Panel8.Controls.Add(this.tbID);
            this.guna2Panel8.Controls.Add(this.lblEnterID);
            this.guna2Panel8.FillColor = System.Drawing.Color.White;
            this.guna2Panel8.Location = new System.Drawing.Point(12, 63);
            this.guna2Panel8.Name = "guna2Panel8";
            this.guna2Panel8.ShadowDecoration.Parent = this.guna2Panel8;
            this.guna2Panel8.Size = new System.Drawing.Size(409, 82);
            this.guna2Panel8.TabIndex = 11;
            // 
            // tbID
            // 
            this.tbID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbID.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbID.BackColor = System.Drawing.Color.Transparent;
            this.tbID.BorderColor = System.Drawing.Color.Silver;
            this.tbID.BorderRadius = 10;
            this.tbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbID.DefaultText = "";
            this.tbID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.DisabledState.Parent = this.tbID;
            this.tbID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbID.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbID.FocusedState.Parent = this.tbID;
            this.tbID.ForeColor = System.Drawing.Color.Black;
            this.tbID.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbID.HoverState.Parent = this.tbID;
            this.tbID.Location = new System.Drawing.Point(104, 36);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbID.Name = "tbID";
            this.tbID.PasswordChar = '\0';
            this.tbID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbID.PlaceholderText = "";
            this.tbID.SelectedText = "";
            this.tbID.ShadowDecoration.Parent = this.tbID;
            this.tbID.Size = new System.Drawing.Size(212, 28);
            this.tbID.TabIndex = 29;
            this.tbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbID_KeyDown);
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            this.tbID.Validating += new System.ComponentModel.CancelEventHandler(this.tbID_Validating);
            // 
            // lblEnterID
            // 
            this.lblEnterID.AutoSize = true;
            this.lblEnterID.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterID.Font = new System.Drawing.Font("Tahoma", 10.22642F, System.Drawing.FontStyle.Bold);
            this.lblEnterID.ForeColor = System.Drawing.Color.DimGray;
            this.lblEnterID.Location = new System.Drawing.Point(100, 14);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(83, 19);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "Enter ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(160, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Show Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.btnCancel.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancel.Location = new System.Drawing.Point(164, 159);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(119, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.Location = new System.Drawing.Point(289, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(119, 37);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(373, 12);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEnterID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 213);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnterID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnterID";
            this.Activated += new System.EventHandler(this.frmEnterID_Activated);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2Panel8.ResumeLayout(false);
            this.guna2Panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel8;
        private System.Windows.Forms.Label lblEnterID;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox tbID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}