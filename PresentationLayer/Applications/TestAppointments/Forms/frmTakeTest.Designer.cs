namespace PresentationLayer.Applications.TestAppointments.Forms
{
    partial class frmTakeTest
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
            this.ctrlScheduledTestInfo1 = new PresentationLayer.Applications.TestAppointments.ctrlScheduledTestInfo();
            this.pnlTakeTest = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDeniedUpdate = new System.Windows.Forms.Label();
            this.tbTestNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbFail = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbPass = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.ControlBoxClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnlTakeTest.SuspendLayout();
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
            this.guna2ShadowPanel1.Controls.Add(this.ctrlScheduledTestInfo1);
            this.guna2ShadowPanel1.Controls.Add(this.pnlTakeTest);
            this.guna2ShadowPanel1.Controls.Add(this.btnClose);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.ControlBoxClose);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 240;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(814, 594);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // ctrlScheduledTestInfo1
            // 
            this.ctrlScheduledTestInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlScheduledTestInfo1.Location = new System.Drawing.Point(11, 36);
            this.ctrlScheduledTestInfo1.Name = "ctrlScheduledTestInfo1";
            this.ctrlScheduledTestInfo1.Size = new System.Drawing.Size(791, 369);
            this.ctrlScheduledTestInfo1.TabIndex = 14;
            // 
            // pnlTakeTest
            // 
            this.pnlTakeTest.BackColor = System.Drawing.Color.White;
            this.pnlTakeTest.BorderColor = System.Drawing.Color.Silver;
            this.pnlTakeTest.BorderRadius = 15;
            this.pnlTakeTest.BorderThickness = 1;
            this.pnlTakeTest.Controls.Add(this.lblDeniedUpdate);
            this.pnlTakeTest.Controls.Add(this.tbTestNotes);
            this.pnlTakeTest.Controls.Add(this.rbFail);
            this.pnlTakeTest.Controls.Add(this.rbPass);
            this.pnlTakeTest.Controls.Add(this.label1);
            this.pnlTakeTest.Controls.Add(this.label23);
            this.pnlTakeTest.Controls.Add(this.label3);
            this.pnlTakeTest.FillColor = System.Drawing.Color.White;
            this.pnlTakeTest.Location = new System.Drawing.Point(15, 411);
            this.pnlTakeTest.Name = "pnlTakeTest";
            this.pnlTakeTest.ShadowDecoration.Parent = this.pnlTakeTest;
            this.pnlTakeTest.Size = new System.Drawing.Size(784, 114);
            this.pnlTakeTest.TabIndex = 13;
            // 
            // lblDeniedUpdate
            // 
            this.lblDeniedUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeniedUpdate.AutoSize = true;
            this.lblDeniedUpdate.Font = new System.Drawing.Font("Tahoma", 11.18868F, System.Drawing.FontStyle.Bold);
            this.lblDeniedUpdate.ForeColor = System.Drawing.Color.Red;
            this.lblDeniedUpdate.Location = new System.Drawing.Point(163, 18);
            this.lblDeniedUpdate.Name = "lblDeniedUpdate";
            this.lblDeniedUpdate.Size = new System.Drawing.Size(503, 21);
            this.lblDeniedUpdate.TabIndex = 15;
            this.lblDeniedUpdate.Text = "Person has performed the test, cannot change test result.";
            this.lblDeniedUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeniedUpdate.Visible = false;
            // 
            // tbTestNotes
            // 
            this.tbTestNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTestNotes.BackColor = System.Drawing.Color.Transparent;
            this.tbTestNotes.BorderColor = System.Drawing.Color.Silver;
            this.tbTestNotes.BorderRadius = 10;
            this.tbTestNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTestNotes.DefaultText = "";
            this.tbTestNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTestNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTestNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestNotes.DisabledState.Parent = this.tbTestNotes;
            this.tbTestNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTestNotes.FocusedState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestNotes.FocusedState.Parent = this.tbTestNotes;
            this.tbTestNotes.ForeColor = System.Drawing.Color.Black;
            this.tbTestNotes.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.tbTestNotes.HoverState.Parent = this.tbTestNotes;
            this.tbTestNotes.Location = new System.Drawing.Point(466, 54);
            this.tbTestNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTestNotes.Multiline = true;
            this.tbTestNotes.Name = "tbTestNotes";
            this.tbTestNotes.PasswordChar = '\0';
            this.tbTestNotes.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbTestNotes.PlaceholderText = "";
            this.tbTestNotes.SelectedText = "";
            this.tbTestNotes.ShadowDecoration.Parent = this.tbTestNotes;
            this.tbTestNotes.Size = new System.Drawing.Size(280, 39);
            this.tbTestNotes.TabIndex = 16;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.BorderThickness = 0;
            this.rbFail.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbFail.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbFail.CheckedState.InnerOffset = -4;
            this.rbFail.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFail.Location = new System.Drawing.Point(241, 60);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(46, 22);
            this.rbFail.TabIndex = 10;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "Fail";
            this.rbFail.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbFail.UncheckedState.BorderThickness = 2;
            this.rbFail.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbFail.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.BorderThickness = 0;
            this.rbPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbPass.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbPass.CheckedState.InnerOffset = -4;
            this.rbPass.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPass.Location = new System.Drawing.Point(167, 60);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(56, 22);
            this.rbPass.TabIndex = 10;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "Pass";
            this.rbPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbPass.UncheckedState.BorderThickness = 2;
            this.rbPass.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbPass.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DimGray;
            this.label23.Location = new System.Drawing.Point(385, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 18);
            this.label23.TabIndex = 7;
            this.label23.Text = "Notes:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(52, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test Result:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnClose.Location = new System.Drawing.Point(545, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(119, 37);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(670, 538);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(119, 37);
            this.btnSave.TabIndex = 10;
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
            this.ControlBoxClose.Location = new System.Drawing.Point(754, 12);
            this.ControlBoxClose.Name = "ControlBoxClose";
            this.ControlBoxClose.ShadowDecoration.Parent = this.ControlBoxClose;
            this.ControlBoxClose.Size = new System.Drawing.Size(45, 29);
            this.ControlBoxClose.TabIndex = 9;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 594);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.pnlTakeTest.ResumeLayout(false);
            this.pnlTakeTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnlTakeTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBoxClose;
        private Guna.UI2.WinForms.Guna2RadioButton rbPass;
        private Guna.UI2.WinForms.Guna2RadioButton rbFail;
        private Guna.UI2.WinForms.Guna2TextBox tbTestNotes;
        private System.Windows.Forms.Label lblDeniedUpdate;
        private ctrlScheduledTestInfo ctrlScheduledTestInfo1;
    }
}