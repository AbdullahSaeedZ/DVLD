namespace PresentationLayer.LoginForm
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnShowHidePassword1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chbKeepMeLoggedIn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox8 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 85;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnShowHidePassword1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox6);
            this.guna2ShadowPanel1.Controls.Add(this.chbKeepMeLoggedIn);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2ControlBox1);
            this.guna2ShadowPanel1.Controls.Add(this.btnLogin);
            this.guna2ShadowPanel1.Controls.Add(this.tbUsername);
            this.guna2ShadowPanel1.Controls.Add(this.tbPassword);
            this.guna2ShadowPanel1.Controls.Add(this.guna2PictureBox8);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 254;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(484, 542);
            this.guna2ShadowPanel1.TabIndex = 5;
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
            this.btnShowHidePassword1.Location = new System.Drawing.Point(376, 334);
            this.btnShowHidePassword1.Name = "btnShowHidePassword1";
            this.btnShowHidePassword1.ShadowDecoration.Parent = this.btnShowHidePassword1;
            this.btnShowHidePassword1.Size = new System.Drawing.Size(25, 23);
            this.btnShowHidePassword1.TabIndex = 25;
            this.btnShowHidePassword1.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = global::PresentationLayer.Properties.Resources.illu6;
            this.guna2PictureBox6.Location = new System.Drawing.Point(209, 53);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.ShadowDecoration.Parent = this.guna2PictureBox6;
            this.guna2PictureBox6.Size = new System.Drawing.Size(45, 52);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox6.TabIndex = 21;
            this.guna2PictureBox6.TabStop = false;
            // 
            // chbKeepMeLoggedIn
            // 
            this.chbKeepMeLoggedIn.Animated = true;
            this.chbKeepMeLoggedIn.AutoSize = true;
            this.chbKeepMeLoggedIn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbKeepMeLoggedIn.CheckedState.BorderRadius = 2;
            this.chbKeepMeLoggedIn.CheckedState.BorderThickness = 0;
            this.chbKeepMeLoggedIn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbKeepMeLoggedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbKeepMeLoggedIn.Location = new System.Drawing.Point(84, 377);
            this.chbKeepMeLoggedIn.Name = "chbKeepMeLoggedIn";
            this.chbKeepMeLoggedIn.Size = new System.Drawing.Size(132, 18);
            this.chbKeepMeLoggedIn.TabIndex = 18;
            this.chbKeepMeLoggedIn.Text = "Keep Me Logged In";
            this.chbKeepMeLoggedIn.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbKeepMeLoggedIn.UncheckedState.BorderRadius = 2;
            this.chbKeepMeLoggedIn.UncheckedState.BorderThickness = 0;
            this.chbKeepMeLoggedIn.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbKeepMeLoggedIn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(79, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log in";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(426, 19);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 33);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.DimGray;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(117, 426);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(250, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BorderRadius = 10;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.Parent = this.tbUsername;
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.FocusedState.Parent = this.tbUsername;
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.HoverState.Parent = this.tbUsername;
            this.tbUsername.Location = new System.Drawing.Point(77, 289);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.SelectedText = "";
            this.tbUsername.ShadowDecoration.Parent = this.tbUsername;
            this.tbUsername.Size = new System.Drawing.Size(331, 35);
            this.tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BorderRadius = 10;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(77, 330);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(331, 35);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // guna2PictureBox8
            // 
            this.guna2PictureBox8.Image = global::PresentationLayer.Properties.Resources.illu8;
            this.guna2PictureBox8.Location = new System.Drawing.Point(36, 24);
            this.guna2PictureBox8.Name = "guna2PictureBox8";
            this.guna2PictureBox8.ShadowDecoration.Parent = this.guna2PictureBox8;
            this.guna2PictureBox8.Size = new System.Drawing.Size(413, 255);
            this.guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox8.TabIndex = 24;
            this.guna2PictureBox8.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1700;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 542);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CheckBox chbKeepMeLoggedIn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox8;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword1;
        private System.Windows.Forms.Timer timer1;
    }
}