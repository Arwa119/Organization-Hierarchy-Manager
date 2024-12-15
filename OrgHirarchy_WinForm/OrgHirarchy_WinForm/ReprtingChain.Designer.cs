namespace OrgHirarchy_WinForm
{
    partial class ReprtingChain
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
            this.ReportTree = new System.Windows.Forms.TreeView();
            this.ReportBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.reportId = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // subordianateLbl
            // 
            this.subordianateLbl.AutoSize = true;
            this.subordianateLbl.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subordianateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.subordianateLbl.Location = new System.Drawing.Point(12, 9);
            this.subordianateLbl.Name = "subordianateLbl";
            this.subordianateLbl.Size = new System.Drawing.Size(285, 42);
            this.subordianateLbl.TabIndex = 4;
            this.subordianateLbl.Text = "Reporting Chain";
            // 
            // ReportTree
            // 
            this.ReportTree.Location = new System.Drawing.Point(12, 246);
            this.ReportTree.Name = "ReportTree";
            this.ReportTree.Size = new System.Drawing.Size(806, 348);
            this.ReportTree.TabIndex = 7;
            // 
            // ReportBTN
            // 
            this.ReportBTN.BorderRadius = 15;
            this.ReportBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.ReportBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.ReportBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.ReportBTN.ForeColor = System.Drawing.Color.White;
            this.ReportBTN.Location = new System.Drawing.Point(560, 128);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Size = new System.Drawing.Size(258, 56);
            this.ReportBTN.TabIndex = 11;
            this.ReportBTN.Text = "REPORT CHAIN";
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // reportId
            // 
            this.reportId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.reportId.BorderRadius = 10;
            this.reportId.BorderThickness = 4;
            this.reportId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reportId.DefaultText = "";
            this.reportId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reportId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reportId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reportId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportId.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.reportId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reportId.Location = new System.Drawing.Point(19, 128);
            this.reportId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportId.Name = "reportId";
            this.reportId.PasswordChar = '\0';
            this.reportId.PlaceholderText = "Enter ID";
            this.reportId.SelectedText = "";
            this.reportId.Size = new System.Drawing.Size(258, 56);
            this.reportId.TabIndex = 14;
            // 
            // ReprtingChain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.reportId);
            this.Controls.Add(this.ReportBTN);
            this.Controls.Add(this.ReportTree);
            this.Controls.Add(this.subordianateLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReprtingChain";
            this.Text = "ReprtingChain";
            this.Load += new System.EventHandler(this.ReprtingChain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label subordianateLbl;
        private System.Windows.Forms.TreeView ReportTree;
        private Guna.UI2.WinForms.Guna2GradientButton ReportBTN;
        private Guna.UI2.WinForms.Guna2TextBox reportId;
    }
}