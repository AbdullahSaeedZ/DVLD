namespace PresentationLayer.Users.Forms
{
    partial class frmChangePassword
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowHidePassword2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowHidePassword1 = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlUserCard1 = new PresentationLayer.Users.Controls.ctrlUserCard();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel1);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlUserCard1);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(870, 818);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.tbCurrentPassword);
            this.guna2Panel1.Controls.Add(this.btnShowHidePassword2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnShowHidePassword1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.tbConfirmPassword);
            this.guna2Panel1.Controls.Add(this.tbNewPassword);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Location = new System.Drawing.Point(25, 502);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(823, 245);
            this.guna2Panel1.TabIndex = 24;
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCurrentPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbCurrentPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbCurrentPassword.BorderRadius = 10;
            this.tbCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCurrentPassword.DefaultText = "";
            this.tbCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentPassword.DisabledState.Parent = this.tbCurrentPassword;
            this.tbCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbCurrentPassword.FocusedState.Parent = this.tbCurrentPassword;
            this.tbCurrentPassword.ForeColor = System.Drawing.Color.Black;
            this.tbCurrentPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbCurrentPassword.HoverState.Parent = this.tbCurrentPassword;
            this.tbCurrentPassword.Location = new System.Drawing.Point(356, 70);
            this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '\0';
            this.tbCurrentPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbCurrentPassword.PlaceholderText = "Enter Current Password";
            this.tbCurrentPassword.SelectedText = "";
            this.tbCurrentPassword.ShadowDecoration.Parent = this.tbCurrentPassword;
            this.tbCurrentPassword.Size = new System.Drawing.Size(225, 36);
            this.tbCurrentPassword.TabIndex = 18;
            this.tbCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPassword_Validating);
            // 
            // btnShowHidePassword2
            // 
            this.btnShowHidePassword2.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword2.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword2.BorderRadius = 10;
            this.btnShowHidePassword2.CheckedState.Parent = this.btnShowHidePassword2;
            this.btnShowHidePassword2.CustomImages.Parent = this.btnShowHidePassword2;
            this.btnShowHidePassword2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowHidePassword2.FillColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowHidePassword2.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword2.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowHidePassword2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowHidePassword2.HoverState.Parent = this.btnShowHidePassword2;
            this.btnShowHidePassword2.Image = global::PresentationLayer.Properties.Resources.showPasswordEye;
            this.btnShowHidePassword2.Location = new System.Drawing.Point(549, 178);
            this.btnShowHidePassword2.Name = "btnShowHidePassword2";
            this.btnShowHidePassword2.ShadowDecoration.Parent = this.btnShowHidePassword2;
            this.btnShowHidePassword2.Size = new System.Drawing.Size(25, 23);
            this.btnShowHidePassword2.TabIndex = 22;
            this.btnShowHidePassword2.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(185, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Current Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnShowHidePassword1
            // 
            this.btnShowHidePassword1.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword1.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword1.BorderRadius = 10;
            this.btnShowHidePassword1.CheckedState.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.CustomImages.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShowHidePassword1.FillColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnShowHidePassword1.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword1.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnShowHidePassword1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowHidePassword1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnShowHidePassword1.HoverState.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.Image = global::PresentationLayer.Properties.Resources.showPasswordEye;
            this.btnShowHidePassword1.Location = new System.Drawing.Point(549, 127);
            this.btnShowHidePassword1.Name = "btnShowHidePassword1";
            this.btnShowHidePassword1.ShadowDecoration.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.Size = new System.Drawing.Size(25, 23);
            this.btnShowHidePassword1.TabIndex = 23;
            this.btnShowHidePassword1.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(208, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "New Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbConfirmPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbConfirmPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbConfirmPassword.BorderRadius = 10;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbConfirmPassword.FocusedState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.Black;
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbConfirmPassword.HoverState.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.Location = new System.Drawing.Point(356, 174);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '\0';
            this.tbConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.PlaceholderText = "Enter Password";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.ShadowDecoration.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.Size = new System.Drawing.Size(225, 36);
            this.tbConfirmPassword.TabIndex = 21;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNewPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbNewPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbNewPassword.BorderRadius = 10;
            this.tbNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPassword.DefaultText = "";
            this.tbNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewPassword.DisabledState.Parent = this.tbNewPassword;
            this.tbNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNewPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbNewPassword.FocusedState.Parent = this.tbNewPassword;
            this.tbNewPassword.ForeColor = System.Drawing.Color.Black;
            this.tbNewPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbNewPassword.HoverState.Parent = this.tbNewPassword;
            this.tbNewPassword.Location = new System.Drawing.Point(356, 122);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '\0';
            this.tbNewPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbNewPassword.PlaceholderText = "Enter Password";
            this.tbNewPassword.SelectedText = "";
            this.tbNewPassword.ShadowDecoration.Parent = this.tbNewPassword;
            this.tbNewPassword.Size = new System.Drawing.Size(225, 36);
            this.tbNewPassword.TabIndex = 20;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(183, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnSave.Location = new System.Drawing.Point(648, 763);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(200, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(442, 763);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(200, 37);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(12, 47);
            this.ctrlUserCard1.LoginInfoCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlUserCard1.LoginInfoCardBorderThickness = 1;
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.PersonCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlUserCard1.PersonCardBorderThickness = 1;
            this.ctrlUserCard1.Size = new System.Drawing.Size(846, 449);
            this.ctrlUserCard1.TabIndex = 9;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(812, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 818);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Controls.ctrlUserCard ctrlUserCard1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword2;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword1;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}