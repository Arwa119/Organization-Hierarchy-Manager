namespace OrgHirarchy_WinForm
{
    partial class Search
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
            this.SEARCHEMPLBL = new System.Windows.Forms.Label();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.serachType = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.SerachBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.seacrhTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SEARCHEMPLBL
            // 
            this.SEARCHEMPLBL.AutoSize = true;
            this.SEARCHEMPLBL.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCHEMPLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.SEARCHEMPLBL.Location = new System.Drawing.Point(12, 20);
            this.SEARCHEMPLBL.Name = "SEARCHEMPLBL";
            this.SEARCHEMPLBL.Size = new System.Drawing.Size(419, 42);
            this.SEARCHEMPLBL.TabIndex = 2;
            this.SEARCHEMPLBL.Text = "SEARCH EMPLOYEES";
            // 
            // searchGrid
            // 
            this.searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Location = new System.Drawing.Point(20, 216);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.RowHeadersWidth = 51;
            this.searchGrid.RowTemplate.Height = 24;
            this.searchGrid.Size = new System.Drawing.Size(798, 376);
            this.searchGrid.TabIndex = 4;
            // 
            // serachType
            // 
            this.serachType.FormattingEnabled = true;
            this.serachType.Location = new System.Drawing.Point(285, 124);
            this.serachType.Name = "serachType";
            this.serachType.Size = new System.Drawing.Size(258, 24);
            this.serachType.TabIndex = 7;
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Location = new System.Drawing.Point(284, 154);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(259, 24);
            this.Filter.TabIndex = 8;
            // 
            // SerachBTN
            // 
            this.SerachBTN.BorderRadius = 15;
            this.SerachBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SerachBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SerachBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SerachBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SerachBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SerachBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.SerachBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.SerachBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SerachBTN.ForeColor = System.Drawing.Color.White;
            this.SerachBTN.Location = new System.Drawing.Point(560, 124);
            this.SerachBTN.Name = "SerachBTN";
            this.SerachBTN.Size = new System.Drawing.Size(258, 56);
            this.SerachBTN.TabIndex = 11;
            this.SerachBTN.Text = "SEARCH";
            this.SerachBTN.Click += new System.EventHandler(this.SerachBTN_Click);
            // 
            // seacrhTxtBox
            // 
            this.seacrhTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.seacrhTxtBox.BorderRadius = 10;
            this.seacrhTxtBox.BorderThickness = 4;
            this.seacrhTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seacrhTxtBox.DefaultText = "";
            this.seacrhTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seacrhTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seacrhTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacrhTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacrhTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seacrhTxtBox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.seacrhTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seacrhTxtBox.Location = new System.Drawing.Point(12, 124);
            this.seacrhTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seacrhTxtBox.Name = "seacrhTxtBox";
            this.seacrhTxtBox.PasswordChar = '\0';
            this.seacrhTxtBox.PlaceholderText = "Enter Name OR ID";
            this.seacrhTxtBox.SelectedText = "";
            this.seacrhTxtBox.Size = new System.Drawing.Size(258, 54);
            this.seacrhTxtBox.TabIndex = 14;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.seacrhTxtBox);
            this.Controls.Add(this.SerachBTN);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.serachType);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.SEARCHEMPLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SEARCHEMPLBL;
        private System.Windows.Forms.DataGridView searchGrid;
        private System.Windows.Forms.ComboBox serachType;
        private System.Windows.Forms.ComboBox Filter;
        private Guna.UI2.WinForms.Guna2GradientButton SerachBTN;
        private Guna.UI2.WinForms.Guna2TextBox seacrhTxtBox;
    }
}