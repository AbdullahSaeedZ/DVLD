namespace PresentationLayer.MainForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQuickSearch = new System.Windows.Forms.Label();
            this.tbQuickSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pbBreadcrumb = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblProfileUsername = new System.Windows.Forms.Label();
            this.lblProfilePersonName = new System.Windows.Forms.Label();
            this.pnlControlsContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlSideBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.btnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.btnDrivers = new Guna.UI2.WinForms.Guna2Button();
            this.btnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.pbProfilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreadcrumb)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnlTopBar;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.lblQuickSearch);
            this.pnlTopBar.Controls.Add(this.tbQuickSearch);
            this.pnlTopBar.Controls.Add(this.guna2ControlBox2);
            this.pnlTopBar.Controls.Add(this.lblBreadcrumb);
            this.pnlTopBar.Controls.Add(this.guna2ControlBox3);
            this.pnlTopBar.Controls.Add(this.ControlBoxClose);
            this.pnlTopBar.Controls.Add(this.pbBreadcrumb);
            this.pnlTopBar.CustomBorderColor = System.Drawing.Color.Silver;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(267, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.ShadowDecoration.Parent = this.pnlTopBar;
            this.pnlTopBar.Size = new System.Drawing.Size(1441, 59);
            this.pnlTopBar.TabIndex = 6;
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuickSearch.BackColor = System.Drawing.Color.White;
            this.lblQuickSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuickSearch.Image = global::PresentationLayer.Properties.Resources.QuickSearch;
            this.lblQuickSearch.Location = new System.Drawing.Point(1190, 14);
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.Size = new System.Drawing.Size(28, 23);
            this.lblQuickSearch.TabIndex = 4;
            this.lblQuickSearch.Click += new System.EventHandler(this.lblQuickSearch_Click);
            // 
            // tbQuickSearch
            // 
            this.tbQuickSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuickSearch.BorderColor = System.Drawing.Color.Silver;
            this.tbQuickSearch.BorderRadius = 10;
            this.tbQuickSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbQuickSearch.DefaultText = "";
            this.tbQuickSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbQuickSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbQuickSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuickSearch.DisabledState.Parent = this.tbQuickSearch;
            this.tbQuickSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbQuickSearch.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbQuickSearch.FocusedState.Parent = this.tbQuickSearch;
            this.tbQuickSearch.ForeColor = System.Drawing.Color.Black;
            this.tbQuickSearch.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbQuickSearch.HoverState.Parent = this.tbQuickSearch;
            this.tbQuickSearch.Location = new System.Drawing.Point(1004, 8);
            this.tbQuickSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbQuickSearch.Name = "tbQuickSearch";
            this.tbQuickSearch.PasswordChar = '\0';
            this.tbQuickSearch.PlaceholderText = "Person ID Quick Serach";
            this.tbQuickSearch.SelectedText = "";
            this.tbQuickSearch.ShadowDecoration.Parent = this.tbQuickSearch;
            this.tbQuickSearch.Size = new System.Drawing.Size(225, 39);
            this.tbQuickSearch.TabIndex = 1;
            this.tbQuickSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQuickSearch_KeyDown);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1347, 3);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.DimGray;
            this.lblBreadcrumb.Location = new System.Drawing.Point(61, 23);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(81, 18);
            this.lblBreadcrumb.TabIndex = 1;
            this.lblBreadcrumb.Text = "Overview";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1301, 3);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(1393, 3);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 0;
            this.ControlBoxClose.Click += new System.EventHandler(this.ControlBoxClose_Click);
            // 
            // pbBreadcrumb
            // 
            this.pbBreadcrumb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbBreadcrumb.Image = global::PresentationLayer.Properties.Resources.overviewNoFillThin;
            this.pbBreadcrumb.Location = new System.Drawing.Point(13, 12);
            this.pbBreadcrumb.Name = "pbBreadcrumb";
            this.pbBreadcrumb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbBreadcrumb.ShadowDecoration.Parent = this.pbBreadcrumb;
            this.pbBreadcrumb.Size = new System.Drawing.Size(43, 38);
            this.pbBreadcrumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBreadcrumb.TabIndex = 0;
            this.pbBreadcrumb.TabStop = false;
            // 
            // lblProfileUsername
            // 
            this.lblProfileUsername.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProfileUsername.AutoSize = true;
            this.lblProfileUsername.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblProfileUsername.Location = new System.Drawing.Point(69, 914);
            this.lblProfileUsername.Name = "lblProfileUsername";
            this.lblProfileUsername.Size = new System.Drawing.Size(65, 16);
            this.lblProfileUsername.TabIndex = 1;
            this.lblProfileUsername.Text = "Username";
            // 
            // lblProfilePersonName
            // 
            this.lblProfilePersonName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblProfilePersonName.AutoSize = true;
            this.lblProfilePersonName.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfilePersonName.Location = new System.Drawing.Point(69, 892);
            this.lblProfilePersonName.Name = "lblProfilePersonName";
            this.lblProfilePersonName.Size = new System.Drawing.Size(87, 16);
            this.lblProfilePersonName.TabIndex = 1;
            this.lblProfilePersonName.Text = "Person Name ";
            // 
            // pnlControlsContainer
            // 
            this.pnlControlsContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlControlsContainer.BorderRadius = 20;
            this.pnlControlsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControlsContainer.Location = new System.Drawing.Point(267, 59);
            this.pnlControlsContainer.Name = "pnlControlsContainer";
            this.pnlControlsContainer.ShadowDecoration.Parent = this.pnlControlsContainer;
            this.pnlControlsContainer.Size = new System.Drawing.Size(1441, 894);
            this.pnlControlsContainer.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Separator1.Location = new System.Drawing.Point(33, 871);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSideBar.Controls.Add(this.guna2PictureBox2);
            this.pnlSideBar.Controls.Add(this.guna2Separator1);
            this.pnlSideBar.Controls.Add(this.btnOverview);
            this.pnlSideBar.Controls.Add(this.btnPeople);
            this.pnlSideBar.Controls.Add(this.btnUsers);
            this.pnlSideBar.Controls.Add(this.btnLogout);
            this.pnlSideBar.Controls.Add(this.btnSettings);
            this.pnlSideBar.Controls.Add(this.btnDrivers);
            this.pnlSideBar.Controls.Add(this.lblProfilePersonName);
            this.pnlSideBar.Controls.Add(this.btnApplications);
            this.pnlSideBar.Controls.Add(this.pbProfilePic);
            this.pnlSideBar.Controls.Add(this.lblProfileUsername);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.ShadowDecoration.Parent = this.pnlSideBar;
            this.pnlSideBar.Size = new System.Drawing.Size(267, 953);
            this.pnlSideBar.TabIndex = 6;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::PresentationLayer.Properties.Resources.saudiMapLogoBlack512;
            this.guna2PictureBox2.Location = new System.Drawing.Point(43, 41);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(181, 180);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 27;
            this.guna2PictureBox2.TabStop = false;
            // 
            // btnOverview
            // 
            this.btnOverview.BorderRadius = 10;
            this.btnOverview.CheckedState.Parent = this.btnOverview;
            this.btnOverview.CustomImages.Parent = this.btnOverview;
            this.btnOverview.FillColor = System.Drawing.Color.Transparent;
            this.btnOverview.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnOverview.ForeColor = System.Drawing.Color.DimGray;
            this.btnOverview.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnOverview.HoverState.FillColor = System.Drawing.Color.White;
            this.btnOverview.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnOverview.HoverState.Image = global::PresentationLayer.Properties.Resources.overviewFillThin;
            this.btnOverview.HoverState.Parent = this.btnOverview;
            this.btnOverview.Image = global::PresentationLayer.Properties.Resources.overviewNoFillThin;
            this.btnOverview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnOverview.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnOverview.Location = new System.Drawing.Point(13, 250);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.ShadowDecoration.Parent = this.btnOverview;
            this.btnOverview.Size = new System.Drawing.Size(241, 45);
            this.btnOverview.TabIndex = 1;
            this.btnOverview.Tag = "Overview";
            this.btnOverview.Text = "Overview";
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BorderRadius = 10;
            this.btnPeople.CheckedState.Parent = this.btnPeople;
            this.btnPeople.CustomImages.Parent = this.btnPeople;
            this.btnPeople.FillColor = System.Drawing.Color.Transparent;
            this.btnPeople.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnPeople.ForeColor = System.Drawing.Color.DimGray;
            this.btnPeople.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPeople.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPeople.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.HoverState.Image = global::PresentationLayer.Properties.Resources.peopleFillThin;
            this.btnPeople.HoverState.Parent = this.btnPeople;
            this.btnPeople.Image = global::PresentationLayer.Properties.Resources.peopleNoFillThin;
            this.btnPeople.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPeople.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPeople.Location = new System.Drawing.Point(13, 352);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.ShadowDecoration.Parent = this.btnPeople;
            this.btnPeople.Size = new System.Drawing.Size(241, 45);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.Tag = "People";
            this.btnPeople.Text = "People";
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 10;
            this.btnUsers.CheckedState.Parent = this.btnUsers;
            this.btnUsers.CustomImages.Parent = this.btnUsers;
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnUsers.ForeColor = System.Drawing.Color.DimGray;
            this.btnUsers.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUsers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.HoverState.Image = global::PresentationLayer.Properties.Resources.UsersFillThin;
            this.btnUsers.HoverState.Parent = this.btnUsers;
            this.btnUsers.Image = global::PresentationLayer.Properties.Resources.usersNoFill;
            this.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUsers.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnUsers.Location = new System.Drawing.Point(13, 454);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ShadowDecoration.Parent = this.btnUsers;
            this.btnUsers.Size = new System.Drawing.Size(241, 45);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Tag = "Users";
            this.btnUsers.Text = "Users";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.HoverState.Image = global::PresentationLayer.Properties.Resources.logoutThick;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::PresentationLayer.Properties.Resources.logoutThin;
            this.btnLogout.Location = new System.Drawing.Point(223, 908);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(30, 30);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Tag = "";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSettings.BorderRadius = 10;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.HoverState.Image = global::PresentationLayer.Properties.Resources.settingsFill;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::PresentationLayer.Properties.Resources.settingNoFill;
            this.btnSettings.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSettings.Location = new System.Drawing.Point(187, 908);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(30, 30);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Tag = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BorderRadius = 10;
            this.btnDrivers.CheckedState.Parent = this.btnDrivers;
            this.btnDrivers.CustomImages.Parent = this.btnDrivers;
            this.btnDrivers.FillColor = System.Drawing.Color.Transparent;
            this.btnDrivers.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDrivers.ForeColor = System.Drawing.Color.DimGray;
            this.btnDrivers.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDrivers.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDrivers.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDrivers.HoverState.Image = global::PresentationLayer.Properties.Resources.DriverFillThin;
            this.btnDrivers.HoverState.Parent = this.btnDrivers;
            this.btnDrivers.Image = global::PresentationLayer.Properties.Resources.driversNoFillThin;
            this.btnDrivers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDrivers.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDrivers.Location = new System.Drawing.Point(13, 403);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.ShadowDecoration.Parent = this.btnDrivers;
            this.btnDrivers.Size = new System.Drawing.Size(241, 45);
            this.btnDrivers.TabIndex = 1;
            this.btnDrivers.Tag = "Drivers";
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BorderRadius = 10;
            this.btnApplications.CheckedState.Parent = this.btnApplications;
            this.btnApplications.CustomImages.Parent = this.btnApplications;
            this.btnApplications.FillColor = System.Drawing.Color.Transparent;
            this.btnApplications.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnApplications.ForeColor = System.Drawing.Color.DimGray;
            this.btnApplications.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnApplications.HoverState.FillColor = System.Drawing.Color.White;
            this.btnApplications.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnApplications.HoverState.Image = global::PresentationLayer.Properties.Resources.applications;
            this.btnApplications.HoverState.Parent = this.btnApplications;
            this.btnApplications.Image = global::PresentationLayer.Properties.Resources.applicationNoFillThin;
            this.btnApplications.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnApplications.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnApplications.Location = new System.Drawing.Point(13, 301);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.ShadowDecoration.Parent = this.btnApplications;
            this.btnApplications.Size = new System.Drawing.Size(241, 45);
            this.btnApplications.TabIndex = 1;
            this.btnApplications.Tag = "Applications";
            this.btnApplications.Text = "Applications";
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbProfilePic.Image = global::PresentationLayer.Properties.Resources.defaultMaleProfile;
            this.pbProfilePic.Location = new System.Drawing.Point(13, 888);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProfilePic.ShadowDecoration.Parent = this.pbProfilePic;
            this.pbProfilePic.Size = new System.Drawing.Size(50, 50);
            this.pbProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilePic.TabIndex = 0;
            this.pbProfilePic.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1708, 953);
            this.Controls.Add(this.pnlControlsContainer);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBreadcrumb)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2TextBox tbQuickSearch;
        private System.Windows.Forms.Label lblQuickSearch;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnDrivers;
        private Guna.UI2.WinForms.Guna2Button btnPeople;
        private Guna.UI2.WinForms.Guna2Button btnApplications;
        private Guna.UI2.WinForms.Guna2Button btnOverview;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbProfilePic;
        private System.Windows.Forms.Label lblProfileUsername;
        private System.Windows.Forms.Label lblProfilePersonName;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlControlsContainer;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbBreadcrumb;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lblBreadcrumb;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}