namespace PresentationLayer.Applications.ManageApplicationTypes.Forms
{
    partial class frmEditApplicationType
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
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblApplicationTypeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbApplicationTypeFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbApplicationTypeTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(449, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(27, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Application Type Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(27, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Application Type Title:";
            // 
            // lblApplicationTypeID
            // 
            this.lblApplicationTypeID.AutoSize = true;
            this.lblApplicationTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationTypeID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblApplicationTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.lblApplicationTypeID.Location = new System.Drawing.Point(199, 91);
            this.lblApplicationTypeID.Name = "lblApplicationTypeID";
            this.lblApplicationTypeID.Size = new System.Drawing.Size(27, 18);
            this.lblApplicationTypeID.TabIndex = 15;
            this.lblApplicationTypeID.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Application Type ID:";
            // 
            // tbApplicationTypeFees
            // 
            this.tbApplicationTypeFees.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbApplicationTypeFees.BackColor = System.Drawing.Color.White;
            this.tbApplicationTypeFees.BorderColor = System.Drawing.Color.Silver;
            this.tbApplicationTypeFees.BorderRadius = 10;
            this.tbApplicationTypeFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApplicationTypeFees.DefaultText = "";
            this.tbApplicationTypeFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApplicationTypeFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApplicationTypeFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeFees.DisabledState.Parent = this.tbApplicationTypeFees;
            this.tbApplicationTypeFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeFees.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbApplicationTypeFees.FocusedState.Parent = this.tbApplicationTypeFees;
            this.tbApplicationTypeFees.ForeColor = System.Drawing.Color.Black;
            this.tbApplicationTypeFees.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbApplicationTypeFees.HoverState.Parent = this.tbApplicationTypeFees;
            this.tbApplicationTypeFees.Location = new System.Drawing.Point(193, 196);
            this.tbApplicationTypeFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbApplicationTypeFees.Name = "tbApplicationTypeFees";
            this.tbApplicationTypeFees.PasswordChar = '\0';
            this.tbApplicationTypeFees.PlaceholderText = "";
            this.tbApplicationTypeFees.SelectedText = "";
            this.tbApplicationTypeFees.ShadowDecoration.Parent = this.tbApplicationTypeFees;
            this.tbApplicationTypeFees.Size = new System.Drawing.Size(259, 32);
            this.tbApplicationTypeFees.TabIndex = 1;
            this.tbApplicationTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationTypeFees_Validating);
            // 
            // tbApplicationTypeTitle
            // 
            this.tbApplicationTypeTitle.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbApplicationTypeTitle.BackColor = System.Drawing.Color.White;
            this.tbApplicationTypeTitle.BorderColor = System.Drawing.Color.Silver;
            this.tbApplicationTypeTitle.BorderRadius = 10;
            this.tbApplicationTypeTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApplicationTypeTitle.DefaultText = "";
            this.tbApplicationTypeTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbApplicationTypeTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbApplicationTypeTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeTitle.DisabledState.Parent = this.tbApplicationTypeTitle;
            this.tbApplicationTypeTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbApplicationTypeTitle.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbApplicationTypeTitle.FocusedState.Parent = this.tbApplicationTypeTitle;
            this.tbApplicationTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.tbApplicationTypeTitle.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbApplicationTypeTitle.HoverState.Parent = this.tbApplicationTypeTitle;
            this.tbApplicationTypeTitle.Location = new System.Drawing.Point(195, 142);
            this.tbApplicationTypeTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbApplicationTypeTitle.Name = "tbApplicationTypeTitle";
            this.tbApplicationTypeTitle.PasswordChar = '\0';
            this.tbApplicationTypeTitle.PlaceholderText = "";
            this.tbApplicationTypeTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApplicationTypeTitle.SelectedText = "";
            this.tbApplicationTypeTitle.ShadowDecoration.Parent = this.tbApplicationTypeTitle;
            this.tbApplicationTypeTitle.Size = new System.Drawing.Size(259, 32);
            this.tbApplicationTypeTitle.TabIndex = 0;
            this.tbApplicationTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbApplicationTypeTitle_Validating);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormTitle.Location = new System.Drawing.Point(144, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(220, 23);
            this.lblFormTitle.TabIndex = 17;
            this.lblFormTitle.Text = "Edit Application Type ";
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
            this.btnCancel.Location = new System.Drawing.Point(248, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(115, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(369, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(115, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.lblFormTitle);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.tbApplicationTypeTitle);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.tbApplicationTypeFees);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.lblApplicationTypeID);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(506, 334);
            this.guna2ShadowPanel1.TabIndex = 20;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(459, 199);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 334);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditApplicationType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditApplicationType";
            this.Load += new System.EventHandler(this.frmEditApplicationType_Load);
            this.Shown += new System.EventHandler(this.frmEditApplicationType_Shown);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApplicationTypeID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbApplicationTypeFees;
        private Guna.UI2.WinForms.Guna2TextBox tbApplicationTypeTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}