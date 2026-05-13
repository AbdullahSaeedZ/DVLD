namespace PresentationLayer.Applications.ManageDetainedLicenses
{
    partial class ctrlManageDetainedLicenses
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
            this.cbIsReleased = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnReleaseLicense = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetain = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDetainedLicenses = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DetainID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetainDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FineFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReleased = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseApplicationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.btnBack);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.dgvDetainedLicenses);
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
            this.guna2Panel2.Controls.Add(this.cbIsReleased);
            this.guna2Panel2.Controls.Add(this.btnReleaseLicense);
            this.guna2Panel2.Controls.Add(this.btnDetain);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.tbSearch);
            this.guna2Panel2.Controls.Add(this.lblNumberOfRecords);
            this.guna2Panel2.Controls.Add(this.cbSearchBy);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(18, 71);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1405, 57);
            this.guna2Panel2.TabIndex = 8;
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.BackColor = System.Drawing.Color.Transparent;
            this.cbIsReleased.BorderColor = System.Drawing.Color.Silver;
            this.cbIsReleased.BorderRadius = 10;
            this.cbIsReleased.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.FocusedColor = System.Drawing.Color.Empty;
            this.cbIsReleased.FocusedState.Parent = this.cbIsReleased;
            this.cbIsReleased.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIsReleased.ForeColor = System.Drawing.Color.Black;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.HoverState.Parent = this.cbIsReleased;
            this.cbIsReleased.ItemHeight = 30;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.ItemsAppearance.Parent = this.cbIsReleased;
            this.cbIsReleased.Location = new System.Drawing.Point(704, 9);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.ShadowDecoration.Parent = this.cbIsReleased;
            this.cbIsReleased.Size = new System.Drawing.Size(128, 36);
            this.cbIsReleased.StartIndex = 0;
            this.cbIsReleased.TabIndex = 10;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicense.BorderColor = System.Drawing.Color.DimGray;
            this.btnReleaseLicense.BorderRadius = 10;
            this.btnReleaseLicense.CheckedState.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.CustomImages.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.FillColor = System.Drawing.Color.Transparent;
            this.btnReleaseLicense.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnReleaseLicense.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseLicense.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleaseLicense.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnReleaseLicense.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseLicense.HoverState.Image = global::PresentationLayer.Properties.Resources.releaseFill24;
            this.btnReleaseLicense.HoverState.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.Image = global::PresentationLayer.Properties.Resources.releaseNoFill24;
            this.btnReleaseLicense.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReleaseLicense.Location = new System.Drawing.Point(1025, 8);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.PressedColor = System.Drawing.Color.DimGray;
            this.btnReleaseLicense.ShadowDecoration.Parent = this.btnReleaseLicense;
            this.btnReleaseLicense.Size = new System.Drawing.Size(176, 37);
            this.btnReleaseLicense.TabIndex = 7;
            this.btnReleaseLicense.Text = "Release License";
            this.btnReleaseLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.Transparent;
            this.btnDetain.BorderColor = System.Drawing.Color.DimGray;
            this.btnDetain.BorderRadius = 10;
            this.btnDetain.CheckedState.Parent = this.btnDetain;
            this.btnDetain.CustomImages.Parent = this.btnDetain;
            this.btnDetain.FillColor = System.Drawing.Color.Transparent;
            this.btnDetain.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDetain.ForeColor = System.Drawing.Color.Black;
            this.btnDetain.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetain.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetain.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDetain.HoverState.Image = global::PresentationLayer.Properties.Resources.detainFill24;
            this.btnDetain.HoverState.Parent = this.btnDetain;
            this.btnDetain.Image = global::PresentationLayer.Properties.Resources.detainNoFill24;
            this.btnDetain.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetain.Location = new System.Drawing.Point(1218, 9);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.PressedColor = System.Drawing.Color.DimGray;
            this.btnDetain.ShadowDecoration.Parent = this.btnDetain;
            this.btnDetain.Size = new System.Drawing.Size(167, 37);
            this.btnDetain.TabIndex = 7;
            this.btnDetain.Text = "Detain License";
            this.btnDetain.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.BackColor = System.Drawing.Color.Transparent;
            this.tbSearch.BorderColor = System.Drawing.Color.Silver;
            this.tbSearch.BorderRadius = 10;
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.Parent = this.tbSearch;
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearch.FocusedState.Parent = this.tbSearch;
            this.tbSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearch.HoverState.Parent = this.tbSearch;
            this.tbSearch.Location = new System.Drawing.Point(704, 9);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearch.PlaceholderText = "Search Application";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(225, 36);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
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
            "Detain ID",
            "License ID",
            "Release Application ID",
            "National No",
            "Full Name",
            "Is Released"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(461, 9);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(225, 36);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.AllowUserToOrderColumns = true;
            this.dgvDetainedLicenses.AllowUserToResizeColumns = false;
            this.dgvDetainedLicenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetainedLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetainedLicenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenses.ColumnHeadersHeight = 40;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainedLicenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DetainID,
            this.LicenseID,
            this.DetainDate,
            this.FineFees,
            this.IsReleased,
            this.ReleaseDate,
            this.NationalNo,
            this.FullName,
            this.ReleaseApplicationID});
            this.dgvDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenses.EnableHeadersVisualStyles = false;
            this.dgvDetainedLicenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(18, 152);
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetainedLicenses.RowHeadersVisible = false;
            this.dgvDetainedLicenses.RowHeadersWidth = 45;
            this.dgvDetainedLicenses.RowTemplate.DividerHeight = 1;
            this.dgvDetainedLicenses.RowTemplate.Height = 30;
            this.dgvDetainedLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1405, 716);
            this.dgvDetainedLicenses.TabIndex = 0;
            this.dgvDetainedLicenses.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetainedLicenses.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetainedLicenses.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetainedLicenses.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDetainedLicenses.ThemeStyle.ReadOnly = true;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvDetainedLicenses.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDetainedLicenses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDetainedLicenses_MouseDoubleClick);
            // 
            // DetainID
            // 
            this.DetainID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DetainID.DataPropertyName = "DetainID";
            this.DetainID.HeaderText = "Detain ID";
            this.DetainID.MinimumWidth = 6;
            this.DetainID.Name = "DetainID";
            this.DetainID.ReadOnly = true;
            this.DetainID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DetainID.Width = 90;
            // 
            // LicenseID
            // 
            this.LicenseID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LicenseID.DataPropertyName = "LicenseID";
            this.LicenseID.HeaderText = "License ID";
            this.LicenseID.MinimumWidth = 6;
            this.LicenseID.Name = "LicenseID";
            this.LicenseID.ReadOnly = true;
            this.LicenseID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LicenseID.Width = 90;
            // 
            // DetainDate
            // 
            this.DetainDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DetainDate.DataPropertyName = "DetainDate";
            this.DetainDate.HeaderText = "Detention Date";
            this.DetainDate.MinimumWidth = 6;
            this.DetainDate.Name = "DetainDate";
            this.DetainDate.ReadOnly = true;
            this.DetainDate.Width = 195;
            // 
            // FineFees
            // 
            this.FineFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FineFees.DataPropertyName = "FineFees";
            this.FineFees.HeaderText = "Fine Fees";
            this.FineFees.MinimumWidth = 6;
            this.FineFees.Name = "FineFees";
            this.FineFees.ReadOnly = true;
            this.FineFees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FineFees.Width = 130;
            // 
            // IsReleased
            // 
            this.IsReleased.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsReleased.DataPropertyName = "IsReleased";
            this.IsReleased.HeaderText = "Is Released";
            this.IsReleased.MinimumWidth = 6;
            this.IsReleased.Name = "IsReleased";
            this.IsReleased.ReadOnly = true;
            this.IsReleased.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsReleased.Width = 95;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReleaseDate.Width = 195;
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            this.NationalNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NationalNo.Width = 110;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FullName.Width = 367;
            // 
            // ReleaseApplicationID
            // 
            this.ReleaseApplicationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ReleaseApplicationID.DataPropertyName = "ReleaseApplicationID";
            this.ReleaseApplicationID.HeaderText = "Release App.ID";
            this.ReleaseApplicationID.MinimumWidth = 6;
            this.ReleaseApplicationID.Name = "ReleaseApplicationID";
            this.ReleaseApplicationID.ReadOnly = true;
            this.ReleaseApplicationID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ReleaseApplicationID.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicensesHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 130);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.personCardNoFill24;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.LicenseCardNoFill64;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicensesHistoryToolStripMenuItem
            // 
            this.showPersonLicensesHistoryToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryNoFill24;
            this.showPersonLicensesHistoryToolStripMenuItem.Name = "showPersonLicensesHistoryToolStripMenuItem";
            this.showPersonLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.showPersonLicensesHistoryToolStripMenuItem.Text = "Show Person Licenses History";
            this.showPersonLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicensesHistoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.releaseNoFill24;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(256, 30);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // ctrlManageDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlManageDetainedLicenses";
            this.Size = new System.Drawing.Size(1441, 894);
            this.Load += new System.EventHandler(this.ctrlManageDetainedLicenses_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbIsReleased;
        private Guna.UI2.WinForms.Guna2Button btnDetain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetainedLicenses;
        private Guna.UI2.WinForms.Guna2Button btnReleaseLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetainDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FineFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsReleased;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseApplicationID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
    }
}
