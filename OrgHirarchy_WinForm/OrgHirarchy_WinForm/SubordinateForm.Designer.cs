namespace OrgHirarchy_WinForm
{
    partial class SubordinateForm
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
            this.subordianateLbl = new System.Windows.Forms.Label();
            this.subordianteGrid = new System.Windows.Forms.DataGridView();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.subordianteTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.subordianteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // subordianateLbl
            // 
            this.subordianateLbl.AutoSize = true;
            this.subordianateLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subordianateLbl.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subordianateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.subordianateLbl.Location = new System.Drawing.Point(12, 9);
            this.subordianateLbl.Name = "subordianateLbl";
            this.subordianateLbl.Size = new System.Drawing.Size(401, 42);
            this.subordianateLbl.TabIndex = 3;
            this.subordianateLbl.Text = "LIST SUBORDINATES";
            // 
            // subordianteGrid
            // 
            this.subordianteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.subordianteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subordianteGrid.Location = new System.Drawing.Point(12, 231);
            this.subordianteGrid.Name = "subordianteGrid";
            this.subordianteGrid.RowHeadersWidth = 51;
            this.subordianteGrid.RowTemplate.Height = 24;
            this.subordianteGrid.Size = new System.Drawing.Size(806, 374);
            this.subordianteGrid.TabIndex = 4;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(560, 117);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(258, 56);
            this.guna2GradientButton1.TabIndex = 10;
            this.guna2GradientButton1.Text = "LIST";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // subordianteTextbox
            // 
            this.subordianteTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.subordianteTextbox.BorderRadius = 10;
            this.subordianteTextbox.BorderThickness = 4;
            this.subordianteTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subordianteTextbox.DefaultText = "";
            this.subordianteTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subordianteTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subordianteTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subordianteTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subordianteTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subordianteTextbox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.subordianteTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subordianteTextbox.Location = new System.Drawing.Point(19, 117);
            this.subordianteTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subordianteTextbox.Name = "subordianteTextbox";
            this.subordianteTextbox.PasswordChar = '\0';
            this.subordianteTextbox.PlaceholderText = "Enter ID";
            this.subordianteTextbox.SelectedText = "";
            this.subordianteTextbox.Size = new System.Drawing.Size(258, 56);
            this.subordianteTextbox.TabIndex = 13;
            this.subordianteTextbox.TextChanged += new System.EventHandler(this.subordianteTextbox_TextChanged_1);
            // 
            // SubordinateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.subordianteTextbox);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.subordianteGrid);
            this.Controls.Add(this.subordianateLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubordinateForm";
            this.Text = "SubordinateForm";
            this.Load += new System.EventHandler(this.SubordinateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subordianteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subordianateLbl;
        private System.Windows.Forms.DataGridView subordianteGrid;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox subordianteTextbox;
    }
}