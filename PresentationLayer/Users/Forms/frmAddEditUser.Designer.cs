namespace PresentationLayer.UsersFormsAndControls
{
    partial class frmAddEditUser
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLoginInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlAddEditUserPermissions1 = new PresentationLayer.Users.Controls.ctrlAddEditUserPermissions();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnShowHidePassword2 = new Guna.UI2.WinForms.Guna2Button();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnShowHidePassword1 = new Guna.UI2.WinForms.Guna2Button();
            this.chbIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonCardWithSearch1 = new PresentationLayer.PeopleFormsAndControls.ctrlPersonCardWithSearch();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlLoginInfo.SuspendLayout();
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
            this.guna2ShadowPanel1.Controls.Add(this.btnBack);
            this.guna2ShadowPanel1.Controls.Add(this.pnlLoginInfo);
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
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(890, 605);
            this.guna2ShadowPanel1.TabIndex = 0;
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
            this.btnBack.Location = new System.Drawing.Point(23, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(108, 37);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlLoginInfo
            // 
            this.pnlLoginInfo.BackColor = System.Drawing.Color.White;
            this.pnlLoginInfo.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlLoginInfo.BorderRadius = 20;
            this.pnlLoginInfo.Controls.Add(this.ctrlAddEditUserPermissions1);
            this.pnlLoginInfo.Controls.Add(this.guna2Panel1);
            this.pnlLoginInfo.Location = new System.Drawing.Point(24, 120);
            this.pnlLoginInfo.Name = "pnlLoginInfo";
            this.pnlLoginInfo.ShadowDecoration.Parent = this.pnlLoginInfo;
            this.pnlLoginInfo.Size = new System.Drawing.Size(844, 422);
            this.pnlLoginInfo.TabIndex = 16;
            this.pnlLoginInfo.Visible = false;
            // 
            // ctrlAddEditUserPermissions1
            // 
            this.ctrlAddEditUserPermissions1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlAddEditUserPermissions1.Location = new System.Drawing.Point(3, 168);
            this.ctrlAddEditUserPermissions1.Name = "ctrlAddEditUserPermissions1";
            this.ctrlAddEditUserPermissions1.PermissionsCardBorderColor = System.Drawing.Color.Silver;
            this.ctrlAddEditUserPermissions1.PermissionsCardBorderThickness = 1;
            this.ctrlAddEditUserPermissions1.Size = new System.Drawing.Size(838, 243);
            this.ctrlAddEditUserPermissions1.TabIndex = 17;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnShowHidePassword2);
            this.guna2Panel1.Controls.Add(this.tbConfirmPassword);
            this.guna2Panel1.Controls.Add(this.btnShowHidePassword1);
            this.guna2Panel1.Controls.Add(this.chbIsActive);
            this.guna2Panel1.Controls.Add(this.tbPassword);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.lblUserID);
            this.guna2Panel1.Controls.Add(this.tbUsername);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(837, 144);
            this.guna2Panel1.TabIndex = 16;
            // 
            // btnShowHidePassword2
            // 
            this.btnShowHidePassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnShowHidePassword2.Location = new System.Drawing.Point(767, 89);
            this.btnShowHidePassword2.Name = "btnShowHidePassword2";
            this.btnShowHidePassword2.ShadowDecoration.Parent = this.btnShowHidePassword2;
            this.btnShowHidePassword2.Size = new System.Drawing.Size(25, 23);
            this.btnShowHidePassword2.TabIndex = 15;
            this.btnShowHidePassword2.Click += new System.EventHandler(this.btnShowHidePassword_Click);
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
            this.tbConfirmPassword.Location = new System.Drawing.Point(574, 84);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '\0';
            this.tbConfirmPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbConfirmPassword.PlaceholderText = "Enter Password";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.ShadowDecoration.Parent = this.tbConfirmPassword;
            this.tbConfirmPassword.Size = new System.Drawing.Size(225, 36);
            this.tbConfirmPassword.TabIndex = 3;
            this.tbConfirmPassword.UseSystemPasswordChar = true;
            this.tbConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPassword_Validating);
            // 
            // btnShowHidePassword1
            // 
            this.btnShowHidePassword1.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnShowHidePassword1.Location = new System.Drawing.Point(497, 89);
            this.btnShowHidePassword1.Name = "btnShowHidePassword1";
            this.btnShowHidePassword1.ShadowDecoration.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.Size = new System.Drawing.Size(25, 23);
            this.btnShowHidePassword1.TabIndex = 15;
            this.btnShowHidePassword1.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // chbIsActive
            // 
            this.chbIsActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbIsActive.AutoSize = true;
            this.chbIsActive.Checked = true;
            this.chbIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckedState.BorderRadius = 2;
            this.chbIsActive.CheckedState.BorderThickness = 0;
            this.chbIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsActive.Location = new System.Drawing.Point(306, 18);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(73, 18);
            this.chbIsActive.TabIndex = 16;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsActive.UncheckedState.BorderRadius = 2;
            this.chbIsActive.UncheckedState.BorderThickness = 0;
            this.chbIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbPassword.BorderRadius = 10;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(305, 84);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbPassword.PlaceholderText = "Enter Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(225, 36);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(571, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(302, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(103, 18);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(136, 18);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "Not Assigned Yet";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderColor = System.Drawing.Color.Silver;
            this.tbUsername.BorderRadius = 10;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.ForeColor = System.Drawing.Color.Black;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.Location = new System.Drawing.Point(34, 84);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbUsername.PlaceholderText = "Enter Username";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(225, 36);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ctrlPersonCardWithSearch1.Location = new System.Drawing.Point(20, 115);
            this.ctrlPersonCardWithSearch1.Name = "ctrlPersonCardWithSearch1";
            this.ctrlPersonCardWithSearch1.Size = new System.Drawing.Size(851, 421);
            this.ctrlPersonCardWithSearch1.TabIndex = 3;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(832, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 8;
            this.ControlBoxClose.Click += new System.EventHandler(this.ControlBoxClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(35, 76);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New User";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 605);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditUser";
            this.Activated += new System.EventHandler(this.frmAddEditUser_Activated);
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.pnlLoginInfo.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private PeopleFormsAndControls.ctrlPersonCardWithSearch ctrlPersonCardWithSearch1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginInfo;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword2;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword1;
        private Guna.UI2.WinForms.Guna2CheckBox chbIsActive;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserID;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private Users.Controls.ctrlAddEditUserPermissions ctrlAddEditUserPermissions1;
    }
}