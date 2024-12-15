namespace OrgHirarchy_WinForm
{
    partial class RemoveEmpcs
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
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveID = new Guna.UI2.WinForms.Guna2TextBox();
            this.RemoveBTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.EditBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NewName = new Guna.UI2.WinForms.Guna2TextBox();
            this.editID = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "REMOVE EMPLOYEE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "EDIT EMPLOYEE";
            // 
            // RemoveID
            // 
            this.RemoveID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.RemoveID.BorderRadius = 10;
            this.RemoveID.BorderThickness = 4;
            this.RemoveID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemoveID.DefaultText = "";
            this.RemoveID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RemoveID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RemoveID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RemoveID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RemoveID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemoveID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.RemoveID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RemoveID.Location = new System.Drawing.Point(53, 153);
            this.RemoveID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RemoveID.Name = "RemoveID";
            this.RemoveID.PasswordChar = '\0';
            this.RemoveID.PlaceholderText = "Enter ID";
            this.RemoveID.SelectedText = "";
            this.RemoveID.Size = new System.Drawing.Size(258, 56);
            this.RemoveID.TabIndex = 14;
            // 
            // RemoveBTN
            // 
            this.RemoveBTN.BorderRadius = 15;
            this.RemoveBTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RemoveBTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RemoveBTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveBTN.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RemoveBTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RemoveBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.RemoveBTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.RemoveBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.RemoveBTN.ForeColor = System.Drawing.Color.White;
            this.RemoveBTN.Location = new System.Drawing.Point(525, 153);
            this.RemoveBTN.Name = "RemoveBTN";
            this.RemoveBTN.Size = new System.Drawing.Size(258, 56);
            this.RemoveBTN.TabIndex = 15;
            this.RemoveBTN.Text = "REMOVE";
            this.RemoveBTN.Click += new System.EventHandler(this.RemoveBTN_Click_1);
            // 
            // EditBtn
            // 
            this.EditBtn.BorderRadius = 15;
            this.EditBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.EditBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.EditBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(534, 469);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(258, 56);
            this.EditBtn.TabIndex = 16;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // NewName
            // 
            this.NewName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.NewName.BorderRadius = 10;
            this.NewName.BorderThickness = 4;
            this.NewName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewName.DefaultText = "";
            this.NewName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewName.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.NewName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewName.Location = new System.Drawing.Point(53, 469);
            this.NewName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewName.Name = "NewName";
            this.NewName.PasswordChar = '\0';
            this.NewName.PlaceholderText = "Enter New Name";
            this.NewName.SelectedText = "";
            this.NewName.Size = new System.Drawing.Size(258, 56);
            this.NewName.TabIndex = 17;
            // 
            // editID
            // 
            this.editID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.editID.BorderRadius = 10;
            this.editID.BorderThickness = 4;
            this.editID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editID.DefaultText = "";
            this.editID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.editID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.editID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.editID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.editID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.editID.Location = new System.Drawing.Point(53, 385);
            this.editID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editID.Name = "editID";
            this.editID.PasswordChar = '\0';
            this.editID.PlaceholderText = "Enter ID";
            this.editID.SelectedText = "";
            this.editID.Size = new System.Drawing.Size(258, 56);
            this.editID.TabIndex = 18;
            this.editID.TextChanged += new System.EventHandler(this.editID_TextChanged);
            // 
            // RemoveEmpcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.editID);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.RemoveBTN);
            this.Controls.Add(this.RemoveID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveEmpcs";
            this.Text = "RemoveEmpcs";
            this.Load += new System.EventHandler(this.RemoveEmpcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox RemoveID;
        private Guna.UI2.WinForms.Guna2GradientButton RemoveBTN;
        private Guna.UI2.WinForms.Guna2GradientButton EditBtn;
        private Guna.UI2.WinForms.Guna2TextBox NewName;
        private Guna.UI2.WinForms.Guna2TextBox editID;
    }
}