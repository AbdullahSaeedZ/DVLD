namespace PresentationLayer.Applications.TestAppointments.Forms
{
    partial class frmListTestAppointments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfRecords = new System.Windows.Forms.Label();
            this.btnNewAppointment = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestAppointments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TestAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppointmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppointmentDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlLocalApplicationInfo1 = new PresentationLayer.Applications.ManageLocalApplications.Controls.ctrlLocalApplicationInfo();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.guna2ShadowPanel1.Controls.Add(this.guna2Panel3);
            this.guna2ShadowPanel1.Controls.Add(this.lblTitle);
            this.guna2ShadowPanel1.Controls.Add(this.ctrlLocalApplicationInfo1);
            this.guna2ShadowPanel1.Controls.Add(this.btnClose);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(928, 975);
            this.guna2ShadowPanel1.TabIndex = 5;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.lblNumberOfRecords);
            this.guna2Panel3.Controls.Add(this.btnNewAppointment);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.dgvTestAppointments);
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(17, 564);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(895, 349);
            this.guna2Panel3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(91, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total Records:";
            // 
            // lblNumberOfRecords
            // 
            this.lblNumberOfRecords.AutoSize = true;
            this.lblNumberOfRecords.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Bold);
            this.lblNumberOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfRecords.Location = new System.Drawing.Point(252, 88);
            this.lblNumberOfRecords.Name = "lblNumberOfRecords";
            this.lblNumberOfRecords.Size = new System.Drawing.Size(22, 23);
            this.lblNumberOfRecords.TabIndex = 9;
            this.lblNumberOfRecords.Text = "0";
            // 
            // btnNewAppointment
            // 
            this.btnNewAppointment.BackColor = System.Drawing.Color.Transparent;
            this.btnNewAppointment.BorderColor = System.Drawing.Color.DimGray;
            this.btnNewAppointment.BorderRadius = 10;
            this.btnNewAppointment.CheckedState.Parent = this.btnNewAppointment;
            this.btnNewAppointment.CustomImages.Parent = this.btnNewAppointment;
            this.btnNewAppointment.FillColor = System.Drawing.Color.Transparent;
            this.btnNewAppointment.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnNewAppointment.ForeColor = System.Drawing.Color.Black;
            this.btnNewAppointment.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewAppointment.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewAppointment.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNewAppointment.HoverState.Image = global::PresentationLayer.Properties.Resources.addFill;
            this.btnNewAppointment.HoverState.Parent = this.btnNewAppointment;
            this.btnNewAppointment.Image = global::PresentationLayer.Properties.Resources.addNoFill;
            this.btnNewAppointment.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewAppointment.Location = new System.Drawing.Point(615, 76);
            this.btnNewAppointment.Name = "btnNewAppointment";
            this.btnNewAppointment.PressedColor = System.Drawing.Color.DimGray;
            this.btnNewAppointment.ShadowDecoration.Parent = this.btnNewAppointment;
            this.btnNewAppointment.Size = new System.Drawing.Size(192, 37);
            this.btnNewAppointment.TabIndex = 8;
            this.btnNewAppointment.Text = "New Appointment";
            this.btnNewAppointment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewAppointment.Click += new System.EventHandler(this.btnNewAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Appointments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            this.dgvTestAppointments.AllowUserToOrderColumns = true;
            this.dgvTestAppointments.AllowUserToResizeColumns = false;
            this.dgvTestAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTestAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTestAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestAppointments.ColumnHeadersHeight = 40;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTestAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestAppointmentID,
            this.AppointmentDate,
            this.PaidFees,
            this.IsLocked});
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestAppointments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestAppointments.EnableHeadersVisualStyles = false;
            this.dgvTestAppointments.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTestAppointments.Location = new System.Drawing.Point(87, 119);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestAppointments.RowHeadersVisible = false;
            this.dgvTestAppointments.RowHeadersWidth = 45;
            this.dgvTestAppointments.RowTemplate.DividerHeight = 1;
            this.dgvTestAppointments.RowTemplate.Height = 30;
            this.dgvTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestAppointments.Size = new System.Drawing.Size(732, 200);
            this.dgvTestAppointments.TabIndex = 0;
            this.dgvTestAppointments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTestAppointments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTestAppointments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTestAppointments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTestAppointments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTestAppointments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTestAppointments.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTestAppointments.ThemeStyle.ReadOnly = true;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTestAppointments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.Height = 30;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.dgvTestAppointments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // TestAppointmentID
            // 
            this.TestAppointmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TestAppointmentID.DataPropertyName = "TestAppointmentID";
            this.TestAppointmentID.HeaderText = "Appointment ID";
            this.TestAppointmentID.MinimumWidth = 6;
            this.TestAppointmentID.Name = "TestAppointmentID";
            this.TestAppointmentID.ReadOnly = true;
            this.TestAppointmentID.Width = 200;
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AppointmentDate.DataPropertyName = "AppointmentDate";
            this.AppointmentDate.HeaderText = "Appointment Date";
            this.AppointmentDate.MinimumWidth = 6;
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.ReadOnly = true;
            this.AppointmentDate.Width = 260;
            // 
            // PaidFees
            // 
            this.PaidFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PaidFees.DataPropertyName = "PaidFees";
            this.PaidFees.HeaderText = "Paid Fees";
            this.PaidFees.MinimumWidth = 6;
            this.PaidFees.Name = "PaidFees";
            this.PaidFees.ReadOnly = true;
            this.PaidFees.Width = 130;
            // 
            // IsLocked
            // 
            this.IsLocked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IsLocked.DataPropertyName = "IsLocked";
            this.IsLocked.HeaderText = "Is Locked";
            this.IsLocked.MinimumWidth = 6;
            this.IsLocked.Name = "IsLocked";
            this.IsLocked.ReadOnly = true;
            this.IsLocked.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsLocked.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsLocked.Width = 130;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppointmentDateToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 64);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editAppointmentDateToolStripMenuItem
            // 
            this.editAppointmentDateToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.editDateNoFill24;
            this.editAppointmentDateToolStripMenuItem.Name = "editAppointmentDateToolStripMenuItem";
            this.editAppointmentDateToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.editAppointmentDateToolStripMenuItem.Text = "Edit Appointment Date";
            this.editAppointmentDateToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentDateToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::PresentationLayer.Properties.Resources.takeTestNoFill24;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(283, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(270, 33);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Test Appointments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ctrlLocalApplicationInfo1
            // 
            this.ctrlLocalApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalApplicationInfo1.BasicApplicationBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalApplicationInfo1.BasicApplicationBorderThickness = 1;
            this.ctrlLocalApplicationInfo1.DrivingLicenseApplicationBorderColor = System.Drawing.Color.Silver;
            this.ctrlLocalApplicationInfo1.DrivingLicenseApplicationBorderThickness = 1;
            this.ctrlLocalApplicationInfo1.Location = new System.Drawing.Point(13, 71);
            this.ctrlLocalApplicationInfo1.Name = "ctrlLocalApplicationInfo1";
            this.ctrlLocalApplicationInfo1.Size = new System.Drawing.Size(901, 487);
            this.ctrlLocalApplicationInfo1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 1;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Location = new System.Drawing.Point(784, 919);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ControlBoxClose
            // 
            this.ControlBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlBoxClose.HoverState.Parent = this.ControlBoxClose;
            this.ControlBoxClose.IconColor = System.Drawing.Color.Gray;
            this.ControlBoxClose.Location = new System.Drawing.Point(868, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 9;
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 975);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListTestAppointments";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private ManageLocalApplications.Controls.ctrlLocalApplicationInfo ctrlLocalApplicationInfo1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTestAppointments;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnNewAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocked;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}