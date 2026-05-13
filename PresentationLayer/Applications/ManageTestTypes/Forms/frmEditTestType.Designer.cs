namespace PresentationLayer.Applications.ManageTestTypes.Forms
{
    partial class frmEditTestType
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTestTypeTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTestTypeFees = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTestTypeID = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tbTestTypeDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
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
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblFormTitle.Location = new System.Drawing.Point(181, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(153, 23);
            this.lblFormTitle.TabIndex = 17;
            this.lblFormTitle.Text = "Edit Test Type ";
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
            this.btnCancel.Location = new System.Drawing.Point(252, 394);
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
            this.btnSave.Location = new System.Drawing.Point(373, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(115, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(455, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(27, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Test Type ID:";
            // 
            // tbTestTypeTitle
            // 
            this.tbTestTypeTitle.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbTestTypeTitle.BackColor = System.Drawing.Color.Transparent;
            this.tbTestTypeTitle.BorderColor = System.Drawing.Color.Silver;
            this.tbTestTypeTitle.BorderRadius = 10;
            this.tbTestTypeTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTestTypeTitle.DefaultText = "";
            this.tbTestTypeTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTestTypeTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTestTypeTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeTitle.DisabledState.Parent = this.tbTestTypeTitle;
            this.tbTestTypeTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeTitle.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeTitle.FocusedState.Parent = this.tbTestTypeTitle;
            this.tbTestTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.tbTestTypeTitle.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeTitle.HoverState.Parent = this.tbTestTypeTitle;
            this.tbTestTypeTitle.Location = new System.Drawing.Point(195, 142);
            this.tbTestTypeTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTestTypeTitle.Name = "tbTestTypeTitle";
            this.tbTestTypeTitle.PasswordChar = '\0';
            this.tbTestTypeTitle.PlaceholderText = "";
            this.tbTestTypeTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTestTypeTitle.SelectedText = "";
            this.tbTestTypeTitle.ShadowDecoration.Parent = this.tbTestTypeTitle;
            this.tbTestTypeTitle.Size = new System.Drawing.Size(259, 32);
            this.tbTestTypeTitle.TabIndex = 0;
            this.tbTestTypeTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestTitle_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(29, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Test Type Fees:";
            // 
            // tbTestTypeFees
            // 
            this.tbTestTypeFees.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbTestTypeFees.BackColor = System.Drawing.Color.Transparent;
            this.tbTestTypeFees.BorderColor = System.Drawing.Color.Silver;
            this.tbTestTypeFees.BorderRadius = 10;
            this.tbTestTypeFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTestTypeFees.DefaultText = "";
            this.tbTestTypeFees.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTestTypeFees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTestTypeFees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeFees.DisabledState.Parent = this.tbTestTypeFees;
            this.tbTestTypeFees.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeFees.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeFees.FocusedState.Parent = this.tbTestTypeFees;
            this.tbTestTypeFees.ForeColor = System.Drawing.Color.Black;
            this.tbTestTypeFees.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeFees.HoverState.Parent = this.tbTestTypeFees;
            this.tbTestTypeFees.Location = new System.Drawing.Point(195, 322);
            this.tbTestTypeFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTestTypeFees.Name = "tbTestTypeFees";
            this.tbTestTypeFees.PasswordChar = '\0';
            this.tbTestTypeFees.PlaceholderText = "";
            this.tbTestTypeFees.SelectedText = "";
            this.tbTestTypeFees.ShadowDecoration.Parent = this.tbTestTypeFees;
            this.tbTestTypeFees.Size = new System.Drawing.Size(259, 32);
            this.tbTestTypeFees.TabIndex = 1;
            this.tbTestTypeFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestTypeFees_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(27, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Test Type Title:";
            // 
            // lblTestTypeID
            // 
            this.lblTestTypeID.AutoSize = true;
            this.lblTestTypeID.BackColor = System.Drawing.Color.Transparent;
            this.lblTestTypeID.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTestTypeID.ForeColor = System.Drawing.Color.DimGray;
            this.lblTestTypeID.Location = new System.Drawing.Point(199, 91);
            this.lblTestTypeID.Name = "lblTestTypeID";
            this.lblTestTypeID.Size = new System.Drawing.Size(27, 18);
            this.lblTestTypeID.TabIndex = 15;
            this.lblTestTypeID.Text = "NA";
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
            this.guna2ShadowPanel1.Controls.Add(this.tbTestTypeDescription);
            this.guna2ShadowPanel1.Controls.Add(this.tbTestTypeTitle);
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.tbTestTypeFees);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.lblTestTypeID);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(512, 448);
            this.guna2ShadowPanel1.TabIndex = 21;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::PresentationLayer.Properties.Resources.Saudi_Riyal_Symbol1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(463, 323);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 26);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 29;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tbTestTypeDescription
            // 
            this.tbTestTypeDescription.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbTestTypeDescription.BackColor = System.Drawing.Color.Transparent;
            this.tbTestTypeDescription.BorderColor = System.Drawing.Color.Silver;
            this.tbTestTypeDescription.BorderRadius = 10;
            this.tbTestTypeDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTestTypeDescription.DefaultText = "";
            this.tbTestTypeDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTestTypeDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTestTypeDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeDescription.DisabledState.Parent = this.tbTestTypeDescription;
            this.tbTestTypeDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestTypeDescription.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeDescription.FocusedState.Parent = this.tbTestTypeDescription;
            this.tbTestTypeDescription.ForeColor = System.Drawing.Color.Black;
            this.tbTestTypeDescription.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestTypeDescription.HoverState.Parent = this.tbTestTypeDescription;
            this.tbTestTypeDescription.Location = new System.Drawing.Point(195, 193);
            this.tbTestTypeDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTestTypeDescription.Multiline = true;
            this.tbTestTypeDescription.Name = "tbTestTypeDescription";
            this.tbTestTypeDescription.PasswordChar = '\0';
            this.tbTestTypeDescription.PlaceholderText = "";
            this.tbTestTypeDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTestTypeDescription.SelectedText = "";
            this.tbTestTypeDescription.ShadowDecoration.Parent = this.tbTestTypeDescription;
            this.tbTestTypeDescription.Size = new System.Drawing.Size(259, 107);
            this.tbTestTypeDescription.TabIndex = 0;
            this.tbTestTypeDescription.Validating += new System.ComponentModel.CancelEventHandler(this.tbTestTypeDescription_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(27, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Test Type Description:";
            // 
            // frmEditTestType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 448);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditTestType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditTestType";
            this.Load += new System.EventHandler(this.frmEditTestType_Load);
            this.Shown += new System.EventHandler(this.frmEditTestType_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblFormTitle;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbTestTypeDescription;
        private Guna.UI2.WinForms.Guna2TextBox tbTestTypeTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbTestTypeFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTestTypeID;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}