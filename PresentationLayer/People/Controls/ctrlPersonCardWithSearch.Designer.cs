namespace PresentationLayer.PeopleFormsAndControls
{
    partial class ctrlPersonCardWithSearch
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
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbSearchBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ctrlPersonCard1 = new PresentationLayer.PeopleFormsAndControls.ctrlPersonCard();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilter.BorderColor = System.Drawing.Color.Silver;
            this.pnlFilter.BorderRadius = 15;
            this.pnlFilter.BorderThickness = 1;
            this.pnlFilter.Controls.Add(this.btnSearch);
            this.pnlFilter.Controls.Add(this.btnAddPerson);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.tbSearch);
            this.pnlFilter.Controls.Add(this.cbSearchBy);
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(14, 7);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.ShadowDecoration.Parent = this.pnlFilter;
            this.pnlFilter.Size = new System.Drawing.Size(827, 57);
            this.pnlFilter.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.BorderColor = System.Drawing.Color.LightGray;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.DimGray;
            this.btnSearch.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Image = global::PresentationLayer.Properties.Resources.SearchBlackFill;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::PresentationLayer.Properties.Resources.SearchGrayFill;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(521, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(107, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Tag = "Settings";
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddPerson.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.BorderRadius = 10;
            this.btnAddPerson.CheckedState.Parent = this.btnAddPerson;
            this.btnAddPerson.CustomImages.Parent = this.btnAddPerson;
            this.btnAddPerson.FillColor = System.Drawing.Color.Transparent;
            this.btnAddPerson.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddPerson.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.HoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPerson.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddPerson.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAddPerson.HoverState.Image = global::PresentationLayer.Properties.Resources.addFill;
            this.btnAddPerson.HoverState.Parent = this.btnAddPerson;
            this.btnAddPerson.Image = global::PresentationLayer.Properties.Resources.addNoFill;
            this.btnAddPerson.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddPerson.Location = new System.Drawing.Point(676, 10);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.PressedColor = System.Drawing.Color.DimGray;
            this.btnAddPerson.ShadowDecoration.Parent = this.btnAddPerson;
            this.btnAddPerson.Size = new System.Drawing.Size(137, 37);
            this.btnAddPerson.TabIndex = 3;
            this.btnAddPerson.Text = "Add Person";
            this.btnAddPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By:";
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
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
            this.tbSearch.Location = new System.Drawing.Point(290, 11);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbSearch.PlaceholderText = "Search People";
            this.tbSearch.SelectedText = "";
            this.tbSearch.ShadowDecoration.Parent = this.tbSearch;
            this.tbSearch.Size = new System.Drawing.Size(216, 36);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
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
            this.cbSearchBy.ForeColor = System.Drawing.Color.DimGray;
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.HoverState.Parent = this.cbSearchBy;
            this.cbSearchBy.ItemHeight = 30;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Person ID",
            "National No"});
            this.cbSearchBy.ItemsAppearance.Parent = this.cbSearchBy;
            this.cbSearchBy.Location = new System.Drawing.Point(132, 11);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.ShadowDecoration.Parent = this.cbSearchBy;
            this.cbSearchBy.Size = new System.Drawing.Size(154, 36);
            this.cbSearchBy.StartIndex = 0;
            this.cbSearchBy.TabIndex = 0;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbSearchBy_SelectedIndexChanged);
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.BorderColor = System.Drawing.Color.Silver;
            this.ctrlPersonCard1.BorderThickness = 1;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(8, 71);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(838, 347);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.pnlFilter);
            this.Name = "ctrlPersonCardWithSearch";
            this.Size = new System.Drawing.Size(846, 419);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchBy;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
    }
}
