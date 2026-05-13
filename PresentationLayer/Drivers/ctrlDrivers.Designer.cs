namespace PresentationLayer.Drivers
{
    partial class ctrlDrivers
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearchDrivers = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvDrivers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicensesHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DriverID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberofActiveLicenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.dgvDrivers);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1441, 894);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.tbSearchDrivers);
            this.guna2Panel2.Controls.Add(this.lblNumberOfRecords);
            this.guna2Panel2.Controls.Add(this.cbSearchBy);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(18, 27);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1405, 57);
            this.guna2Panel2.TabIndex = 8;
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
            // tbSearchDrivers
            // 
            this.tbSearchDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchDrivers.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchDrivers.BorderColor = System.Drawing.Color.Silver;
            this.tbSearchDrivers.BorderRadius = 10;
            this.tbSearchDrivers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchDrivers.DefaultText = "";
            this.tbSearchDrivers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearchDrivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearchDrivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDrivers.DisabledState.Parent = this.tbSearchDrivers;
            this.tbSearchDrivers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearchDrivers.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearchDrivers.FocusedState.Parent = this.tbSearchDrivers;
            this.tbSearchDrivers.ForeColor = System.Drawing.Color.Black;
            this.tbSearchDrivers.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbSearchDrivers.HoverState.Parent = this.tbSearchDrivers;
            this.tbSearchDrivers.Location = new System.Drawing.Point(751, 9);
            this.tbSearchDrivers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearchDrivers.Name = "tbSearchDrivers";
            this.tbSearchDrivers.PasswordChar = '\0';
            this.tbSearchDrivers.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearchDrivers.PlaceholderText = "Search Drivers";
            this.tbSearchDrivers.SelectedText = "";
            this.tbSearchDrivers.ShadowDecoration.Parent = this.tbSearchDrivers;
            this.tbSearchDrivers.Size = new System.Drawing.Size(225, 36);
            this.tbSearchDrivers.TabIndex = 5;
            this.tbSearchDrivers.Visible = false;
            this.tbSearchDrivers.TextChanged += new System.EventHandler(this.tbSearchDrivers_TextChanged);
            this.tbSearchDrivers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchDrivers_KeyPress);
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
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(461, 9);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(225, 36);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // dgvDrivers
            // 
            this.dgvDrivers.AllowUserToAddRows = false;
            this.dgvDrivers.AllowUserToDeleteRows = false;
            this.dgvDrivers.AllowUserToOrderColumns = true;
            this.dgvDrivers.AllowUserToResizeColumns = false;
            this.dgvDrivers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrivers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrivers.BackgroundColor = System.Drawing.Color.White;
            this.dgvDrivers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDrivers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrivers.ColumnHeadersHeight = 40;
            this.dgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrivers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DriverID,
            this.PersonID,
            this.NationalNo,
            this.FullName,
            this.CreatedDate,
            this.NumberofActiveLicenses});
            this.dgvDrivers.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrivers.EnableHeadersVisualStyles = false;
            this.dgvDrivers.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDrivers.Location = new System.Drawing.Point(18, 109);
            this.dgvDrivers.Name = "dgvDrivers";
            this.dgvDrivers.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrivers.RowHeadersVisible = false;
            this.dgvDrivers.RowHeadersWidth = 45;
            this.dgvDrivers.RowTemplate.DividerHeight = 1;
            this.dgvDrivers.RowTemplate.Height = 30;
            this.dgvDrivers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivers.Size = new System.Drawing.Size(1405, 742);
            this.dgvDrivers.TabIndex = 0;
            this.dgvDrivers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDrivers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDrivers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDrivers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDrivers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvDrivers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvDrivers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrivers.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDrivers.ThemeStyle.ReadOnly = true;
            this.dgvDrivers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDrivers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDrivers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDrivers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDrivers.ThemeStyle.RowsStyle.Height = 30;
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvDrivers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDrivers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDrivers_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonInfoToolStripMenuItem,
            this.showLicensesHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 64);
            // 
            // showPersonInfoToolStripMenuItem
            // 
            this.showPersonInfoToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.personCardNoFill24;
            this.showPersonInfoToolStripMenuItem.Name = "showPersonInfoToolStripMenuItem";
            this.showPersonInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.showPersonInfoToolStripMenuItem.Text = "Show Person Info";
            this.showPersonInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonInfoToolStripMenuItem_Click);
            // 
            // showLicensesHistoryToolStripMenuItem
            // 
            this.showLicensesHistoryToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.LicenseHistoryNoFill24;
            this.showLicensesHistoryToolStripMenuItem.Name = "showLicensesHistoryToolStripMenuItem";
            this.showLicensesHistoryToolStripMenuItem.Size = new System.Drawing.Size(212, 30);
            this.showLicensesHistoryToolStripMenuItem.Text = "Show Licenses History";
            this.showLicensesHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicensesHistoryToolStripMenuItem_Click);
            // 
            // DriverID
            // 
            this.DriverID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DriverID.DataPropertyName = "DriverID";
            this.DriverID.HeaderText = "Driver ID";
            this.DriverID.MinimumWidth = 6;
            this.DriverID.Name = "DriverID";
            this.DriverID.ReadOnly = true;
            this.DriverID.Width = 140;
            // 
            // PersonID
            // 
            this.PersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PersonID.DataPropertyName = "PersonID";
            this.PersonID.HeaderText = "Person ID";
            this.PersonID.MinimumWidth = 6;
            this.PersonID.Name = "PersonID";
            this.PersonID.ReadOnly = true;
            this.PersonID.Width = 140;
            // 
            // NationalNo
            // 
            this.NationalNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NationalNo.DataPropertyName = "NationalNo";
            this.NationalNo.HeaderText = "National No";
            this.NationalNo.MinimumWidth = 6;
            this.NationalNo.Name = "NationalNo";
            this.NationalNo.ReadOnly = true;
            this.NationalNo.Width = 140;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 575;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.MinimumWidth = 6;
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 260;
            // 
            // NumberofActiveLicenses
            // 
            this.NumberofActiveLicenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NumberofActiveLicenses.DataPropertyName = "NumberOfActiveLicenses";
            this.NumberofActiveLicenses.HeaderText = "Active Licenses";
            this.NumberofActiveLicenses.MinimumWidth = 6;
            this.NumberofActiveLicenses.Name = "NumberofActiveLicenses";
            this.NumberofActiveLicenses.ReadOnly = true;
            this.NumberofActiveLicenses.Width = 147;
            // 
            // ctrlDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ctrlDrivers";
            this.Size = new System.Drawing.Size(1441, 894);
            this.Load += new System.EventHandler(this.ctrlDrivers_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbSearchDrivers;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDrivers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicensesHistoryToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriverID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberofActiveLicenses;
    }
}
