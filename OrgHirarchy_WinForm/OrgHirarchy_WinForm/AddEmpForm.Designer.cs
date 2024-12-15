namespace OrgHirarchy_WinForm
{
    partial class AddEmpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RoleEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.ParentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameEmp = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD EMPLOYEE";
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.BorderRadius = 15;
            this.SubmitBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.SubmitBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.SubmitBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.SubmitBTN.ForeColor = System.Drawing.Color.White;
            this.SubmitBTN.Location = new System.Drawing.Point(228, 399);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(297, 56);
            this.SubmitBTN.TabIndex = 21;
            this.SubmitBTN.Text = "SUBMIT";
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click_1);
            // 
            // RoleEmp
            // 
            this.RoleEmp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.RoleEmp.BorderRadius = 10;
            this.RoleEmp.BorderThickness = 4;
            this.RoleEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoleEmp.DefaultText = "";
            this.RoleEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoleEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoleEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoleEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoleEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleEmp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.RoleEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleEmp.Location = new System.Drawing.Point(228, 219);
            this.RoleEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoleEmp.Name = "RoleEmp";
            this.RoleEmp.PasswordChar = '\0';
            this.RoleEmp.PlaceholderText = "Enter Role";
            this.RoleEmp.SelectedText = "";
            this.RoleEmp.Size = new System.Drawing.Size(297, 56);
            this.RoleEmp.TabIndex = 20;
            // 
            // ParentID
            // 
            this.ParentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.ParentID.BorderRadius = 10;
            this.ParentID.BorderThickness = 4;
            this.ParentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ParentID.DefaultText = "";
            this.ParentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ParentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ParentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ParentID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.ParentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ParentID.Location = new System.Drawing.Point(228, 292);
            this.ParentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParentID.Name = "ParentID";
            this.ParentID.PasswordChar = '\0';
            this.ParentID.PlaceholderText = "Enter Parent ID";
            this.ParentID.SelectedText = "";
            this.ParentID.Size = new System.Drawing.Size(297, 56);
            this.ParentID.TabIndex = 19;
            // 
            // NameEmp
            // 
            this.NameEmp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.NameEmp.BorderRadius = 10;
            this.NameEmp.BorderThickness = 4;
            this.NameEmp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameEmp.DefaultText = "";
            this.NameEmp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameEmp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameEmp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameEmp.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.NameEmp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameEmp.Location = new System.Drawing.Point(228, 134);
            this.NameEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameEmp.Name = "NameEmp";
            this.NameEmp.PasswordChar = '\0';
            this.NameEmp.PlaceholderText = "Enter Name";
            this.NameEmp.SelectedText = "";
            this.NameEmp.Size = new System.Drawing.Size(297, 56);
            this.NameEmp.TabIndex = 18;
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.SubmitBTN);
            this.Controls.Add(this.RoleEmp);
            this.Controls.Add(this.ParentID);
            this.Controls.Add(this.NameEmp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmpForm";
            this.Text = "AddEmpForm";
            this.Load += new System.EventHandler(this.AddEmpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton SubmitBTN;
        private Guna.UI2.WinForms.Guna2TextBox RoleEmp;
        private Guna.UI2.WinForms.Guna2TextBox ParentID;
        private Guna.UI2.WinForms.Guna2TextBox NameEmp;
    }
}