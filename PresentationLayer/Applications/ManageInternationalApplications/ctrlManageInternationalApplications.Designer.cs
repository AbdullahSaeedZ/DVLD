namespace PresentationLayer.Applications.ManageInternationalApplications
{
    partial class ctrlManageInternationalApplications
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
            this.cbIsActive = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewInterLiecnse = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchApplication = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvApplications = new Guna.UI2.WinForms.Guna2DataGridView();
            this.InternationalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalLicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.guna2Panel1.TabIndex = 2;
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
            this.guna2Panel2.Controls.Add(this.cbIsActive);
            this.guna2Panel2.Controls.Add(this.btnNewInterLiecnse);
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
            // cbIsActive
            // 
            this.cbIsActive.BackColor = System.Drawing.Color.Transparent;
            this.cbIsActive.BorderColor = System.Drawing.Color.Silver;
            this.cbIsActive.BorderRadius = 10;
            this.cbIsActive.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FocusedColor = System.Drawing.Color.Empty;
            this.cbIsActive.FocusedState.Parent = this.cbIsActive;
            this.cbIsActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsActive.ForeColor = System.Drawing.Color.Black;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.HoverState.Parent = this.cbIsActive;
            this.cbIsActive.ItemHeight = 30;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Active",
            "Not Active"});
            this.cbIsActive.ItemsAppearance.Parent = this.cbIsActive;
            this.cbIsActive.Location = new System.Drawing.Point(704, 9);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.ShadowDecoration.Parent = this.cbIsActive;
            this.cbIsActive.Size = new System.Drawing.Size(128, 36);
            this.cbIsActive.StartIndex = 0;
            this.cbIsActive.TabIndex = 10;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // btnNewInterLiecnse
            // 
            this.btnNewInterLiecnse.BackColor = System.Drawing.Color.Transparent;
            this.btnNewInterLiecnse.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewInterLiecnse.BorderRadius = 10;
            this.btnNewInterLiecnse.CheckedState.Parent = this.btnNewInterLiecnse;
            this.btnNewInterLiecnse.CustomImages.Parent = this.btnNewInterLiecnse;
            this.btnNewInterLiecnse.FillColor = System.Drawing.Color.Transparent;
            this.btnNewInterLiecnse.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNewInterLiecnse.ForeColor = System.Drawing.Color.Black;
            this.btnNewInterLiecnse.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewInterLiecnse.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewInterLiecnse.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNewInterLiecnse.HoverState.Image = global::PresentationLayer.Properties.Resources.addFill;
            this.btnNewInterLiecnse.HoverState.Parent = this.btnNewInterLiecnse;
            this.btnNewInterLiecnse.Image = global::PresentationLayer.Properties.Resources.addNoFill;
            this.btnNewInterLiecnse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewInterLiecnse.Location = new System.Drawing.Point(1180, 9);
            this.btnNewInterLiecnse.Name = "btnNewInterLiecnse";
            this.btnNewInterLiecnse.PressedColor = System.Drawing.Color.DimGray;
            this.btnNewInterLiecnse.ShadowDecoration.Parent = this.btnNewInterLiecnse;
            this.btnNewInterLiecnse.Size = new System.Drawing.Size(200, 37);
            this.btnNewInterLiecnse.TabIndex = 7;
            this.btnNewInterLiecnse.Text = "Issue New Licesne";
            this.btnNewInterLiecnse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewInterLiecnse.Click += new System.EventHandler(this.btnNewLicesnse_Click);
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
            "Int. License ID",
            "Application ID",
            "Driver ID",
            "L. License ID",
            "Is Active"});
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
            this.InternationalLicenseID,
            this.ApplicationID,
            this.DriverID,
            this.LocalLicenseID,
            this.IssueDate,
            this.ExpirationDate,
            this.IsActive});
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
            // InternationalLicenseID
            // 
            this.InternationalLicenseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.InternationalLicenseID.DataPropertyName = "InternationalLicenseID";
            this.InternationalLicenseID.HeaderText = "Int. License ID";
            this.InternationalLicenseID.MinimumWidth = 6;
            this.InternationalLicenseID.Name = "InternationalLicenseID";
            this.InternationalLicenseID.ReadOnly = true;
            this.InternationalLicenseID.Width = 180;
            // 
            // ApplicationID
            // 
            this.ApplicationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ApplicationID.DataPropertyName = "ApplicationID";
            this.ApplicationID.HeaderText = "Application ID";
            this.ApplicationID.MinimumWidth = 6;
            this.ApplicationID.Name = "ApplicationID";
            this.ApplicationID.ReadOnly = true;
            this.ApplicationID.Width = 180;
            // 
            // DriverID
            // 
            this.DriverID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DriverID.DataPropertyName = "DriverID";
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.MinimumWidth = 6;
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            this.DriverID.Width = 180;
            // 
            // LocalLicenseID
            // 
            this.LocalLicenseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LocalLicenseID.DataPropertyName = "IssuedUsingLocalLicenseID";
            this.LocalLicenseID.HeaderText = "L. License ID";
            this.LocalLicenseID.MinimumWidth = 6;
            this.LocalLicenseID.Name = "LocalLicenseID";
            this.LocalLicenseID.ReadOnly = true;
            this.LocalLicenseID.Width = 180;
            // 
            // IssueDate
            // 
            this.IssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "Issue Date";
            this.IssueDate.MinimumWidth = 6;
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            this.IssueDate.Width = 270;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.MinimumWidth = 6;
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Width = 270;
            // 
            // IsActive
            // 
            this.IsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsActive.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showLicenseInfoToolStripMenuItem,
            this.showLicensesHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(264, 94);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.personCardNoFill24;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.internationalLicensesNoFill24;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.showLicenseInfoToolStripMenuItem.Text = "Show International License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // showLicensesHistoryToolStripMenuItem
            // 
            this.showLicensesHistoryToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryNoFill24;
            this.showLicensesHistoryToolStripMenuItem.Name = "showLicensesHistoryToolStripMenuItem";
            this.showLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.showLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            this.showLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicensesHistoryToolStripMenuItem_Click);
            // 
            // ctrlManageInternationalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlManageInternationalApplications";
            this.Size = new System.Drawing.Size(1441, 894);
            this.Load += new System.EventHandler(this.ctrlManageInternationalApplications_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsActive;
        private Guna.UI2.WinForms.Guna2Button btnNewInterLiecnse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchApplication;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn InternationalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalLicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
