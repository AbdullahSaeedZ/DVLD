namespace PresentationLayer.Applications.ManageLocalApplications
{
    partial class ctrlManageLocalApplications
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewApplication = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchApplication = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LocalDrivingLicenseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassedTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.dgvApplications);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1441, 894);
            this.guna2Panel1.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(18, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(108, 37);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.cbStatus);
            this.guna2Panel2.Controls.Add(this.btnNewApplication);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.tbSearchApplication);
            this.guna2Panel2.Controls.Add(this.lblNumberOfRecords);
            this.guna2Panel2.Controls.Add(this.cbSearchBy);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(18, 71);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1405, 57);
            this.guna2Panel2.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cbStatus.BorderRadius = 10;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.FocusedState.Parent = this.cbStatus;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.HoverState.Parent = this.cbStatus;
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed",
            "Cancelled"});
            this.cbStatus.ItemsAppearance.Parent = this.cbStatus;
            this.cbStatus.Location = new System.Drawing.Point(704, 9);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.ShadowDecoration.Parent = this.cbStatus;
            this.cbStatus.Size = new System.Drawing.Size(128, 36);
            this.cbStatus.StartIndex = 0;
            this.cbStatus.TabIndex = 10;
            this.cbStatus.Visible = false;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // btnNewApplication
            // 
            this.btnNewApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnNewApplication.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewApplication.BorderRadius = 10;
            this.btnNewApplication.CheckedState.Parent = this.btnNewApplication;
            this.btnNewApplication.CustomImages.Parent = this.btnNewApplication;
            this.btnNewApplication.FillColor = System.Drawing.Color.Transparent;
            this.btnNewApplication.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNewApplication.ForeColor = System.Drawing.Color.Black;
            this.btnNewApplication.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewApplication.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewApplication.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNewApplication.HoverState.Image = global::PresentationLayer.Properties.Resources.addFill;
            this.btnNewApplication.HoverState.Parent = this.btnNewApplication;
            this.btnNewApplication.Image = global::PresentationLayer.Properties.Resources.addNoFill;
            this.btnNewApplication.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewApplication.Location = new System.Drawing.Point(1199, 9);
            this.btnNewApplication.Name = "btnNewApplication";
            this.btnNewApplication.PressedColor = System.Drawing.Color.DimGray;
            this.btnNewApplication.ShadowDecoration.Parent = this.btnNewApplication;
            this.btnNewApplication.Size = new System.Drawing.Size(181, 37);
            this.btnNewApplication.TabIndex = 7;
            this.btnNewApplication.Text = "New Application";
            this.btnNewApplication.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewApplication.Click += new System.EventHandler(this.btnNewApplication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(343, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search By:";
            // 
            // tbSearchApplication
            // 
            this.tbSearchApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchApplication.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchApplication.BorderColor = System.Drawing.Color.Silver;
            this.tbSearchApplication.BorderRadius = 10;
            this.tbSearchApplication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchApplication.DefaultText = "";
            this.tbSearchApplication.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchApplication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchApplication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchApplication.DisabledState.Parent = this.tbSearchApplication;
            this.tbSearchApplication.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchApplication.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearchApplication.FocusedState.Parent = this.tbSearchApplication;
            this.tbSearchApplication.ForeColor = System.Drawing.Color.Black;
            this.tbSearchApplication.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearchApplication.HoverState.Parent = this.tbSearchApplication;
            this.tbSearchApplication.Location = new System.Drawing.Point(704, 9);
            this.tbSearchApplication.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearchApplication.Name = "tbSearchApplication";
            this.tbSearchApplication.PasswordChar = '\0';
            this.tbSearchApplication.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearchApplication.PlaceholderText = "Search Application";
            this.tbSearchApplication.SelectedText = "";
            this.tbSearchApplication.ShadowDecoration.Parent = this.tbSearchApplication;
            this.tbSearchApplication.Size = new System.Drawing.Size(225, 36);
            this.tbSearchApplication.TabIndex = 5;
            this.tbSearchApplication.Visible = false;
            this.tbSearchApplication.TextChanged += new System.EventHandler(this.tbSearchApplication_TextChanged);
            this.tbSearchApplication.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchApplication_KeyPress);
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(190, 17);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(22, 23);
            this.lblNumberOfRecords.TabIndex = 0;
            this.lblNumberOfRecords.Text = "0";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchBy.BorderColor = System.Drawing.Color.Silver;
            this.cbSearchBy.BorderRadius = 10;
            this.cbSearchBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.FocusedColor = System.Drawing.Color.Empty;
            this.cbSearchBy.FocusedState.Parent = this.cbSearchBy;
            this.cbSearchBy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearchBy.ForeColor = System.Drawing.Color.Black;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.HoverState.Parent = this.cbSearchBy;
            this.cbSearchBy.ItemHeight = 30;
            this.cbSearchBy.Items.AddRange(new object[] {
            "None",
            "LDL.Application ID",
            "National No",
            "Full Name",
            "Status"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(461, 9);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(225, 36);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.AllowUserToOrderColumns = true;
            this.dgvApplications.AllowUserToResizeColumns = false;
            this.dgvApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApplications.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplications.ColumnHeadersHeight = 40;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalDrivingLicenseApplicationID,
            this.ClassName,
            this.NationalNo,
            this.FullName,
            this.ApplicationDate,
            this.PassedTests,
            this.Status});
            this.dgvApplications.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvApplications.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvApplications.EnableHeadersVisualStyles = false;
            this.dgvApplications.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvApplications.Location = new System.Drawing.Point(18, 152);
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 45;
            this.dgvApplications.RowTemplate.DividerHeight = 1;
            this.dgvApplications.RowTemplate.Height = 30;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(1405, 716);
            this.dgvApplications.TabIndex = 0;
            this.dgvApplications.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvApplications.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvApplications.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvApplications.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvApplications.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvApplications.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApplications.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvApplications.ThemeStyle.ReadOnly = true;
            this.dgvApplications.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvApplications.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvApplications.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvApplications.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvApplications.ThemeStyle.RowsStyle.Height = 30;
            this.dgvApplications.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvApplications.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApplications.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvApplications_MouseDoubleClick);
            // 
            // LocalDrivingLicenseApplicationID
            // 
            this.LocalDrivingLicenseApplicationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LocalDrivingLicenseApplicationID.DataPropertyName = "LocalDrivingLicenseApplicationID";
            this.LocalDrivingLicenseApplicationID.HeaderText = "LDL.Application ID";
            this.LocalDrivingLicenseApplicationID.MinimumWidth = 6;
            this.LocalDrivingLicenseApplicationID.Name = "LocalDrivingLicenseApplicationID";
            this.LocalDrivingLicenseApplicationID.ReadOnly = true;
            this.LocalDrivingLicenseApplicationID.Width = 150;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClassName.DataPropertyName = "DrivingClass";
            this.ClassName.HeaderText = "Driving Class";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Width = 330;
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            this.NationalNo.Width = 130;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 380;
            // 
            // ApplicationDate
            // 
            this.ApplicationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApplicationDate.DataPropertyName = "ApplicationDate";
            this.ApplicationDate.HeaderText = "Application Date";
            this.ApplicationDate.MinimumWidth = 6;
            this.ApplicationDate.Name = "ApplicationDate";
            this.ApplicationDate.ReadOnly = true;
            this.ApplicationDate.Width = 180;
            // 
            // PassedTests
            // 
            this.PassedTests.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PassedTests.DataPropertyName = "PassedTestCount";
            this.PassedTests.HeaderText = "Passed Tests";
            this.PassedTests.MinimumWidth = 6;
            this.PassedTests.Name = "PassedTests";
            this.PassedTests.ReadOnly = true;
            this.PassedTests.Width = 110;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 115;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripSeparator4,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.ScheduleTestsToolStripMenuItem,
            this.toolStripSeparator3,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(358, 292);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.applicationNoFillThin;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(354, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Enabled = false;
            this.editApplicationToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.editNoFill;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Enabled = false;
            this.deleteApplicationToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.removeNoFill;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Enabled = false;
            this.cancelApplicationToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.cancellApplicationNoFill;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(354, 6);
            // 
            // ScheduleTestsToolStripMenuItem
            // 
            this.ScheduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTToolStripMenuItem});
            this.ScheduleTestsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.newScheduleAppointmentNoFill24;
            this.ScheduleTestsToolStripMenuItem.Name = "ScheduleTestsToolStripMenuItem";
            this.ScheduleTestsToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.ScheduleTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.visionTestNoFill24;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.writtenTestNoFill24;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTToolStripMenuItem
            // 
            this.scheduleStreetTToolStripMenuItem.Enabled = false;
            this.scheduleStreetTToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.streetTestNoFill24;
            this.scheduleStreetTToolStripMenuItem.Name = "scheduleStreetTToolStripMenuItem";
            this.scheduleStreetTToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.scheduleStreetTToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(354, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.checkMarkNoFill24;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(354, 6);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Enabled = false;
            this.showLicenseDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.cardNoFill;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show Issued License Details of This Application";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryNoFill24;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // ctrlManageLocalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlManageLocalApplications";
            this.Size = new System.Drawing.Size(1441, 894);
            this.Load += new System.EventHandler(this.ctrlManageLocalApplications_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnNewApplication;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchApplication;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplications;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalDrivingLicenseApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassedTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}
