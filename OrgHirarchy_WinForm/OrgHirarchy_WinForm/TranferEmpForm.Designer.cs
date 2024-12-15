namespace OrgHirarchy_WinForm
{
    partial class TranferEmpForm
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
            this.transEmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.NewParentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.parentID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TranferBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRANSFER EMPLOYEE";
            // 
            // transEmpID
            // 
            this.transEmpID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.transEmpID.BorderRadius = 10;
            this.transEmpID.BorderThickness = 4;
            this.transEmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transEmpID.DefaultText = "";
            this.transEmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.transEmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.transEmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transEmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.transEmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transEmpID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.transEmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.transEmpID.Location = new System.Drawing.Point(257, 154);
            this.transEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.transEmpID.Name = "transEmpID";
            this.transEmpID.PasswordChar = '\0';
            this.transEmpID.PlaceholderText = "Enter ID";
            this.transEmpID.SelectedText = "";
            this.transEmpID.Size = new System.Drawing.Size(297, 56);
            this.transEmpID.TabIndex = 14;
            this.transEmpID.TextChanged += new System.EventHandler(this.transEmpID_TextChanged);
            // 
            // NewParentID
            // 
            this.NewParentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.NewParentID.BorderRadius = 10;
            this.NewParentID.BorderThickness = 4;
            this.NewParentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewParentID.DefaultText = "";
            this.NewParentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewParentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewParentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewParentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewParentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewParentID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.NewParentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewParentID.Location = new System.Drawing.Point(257, 312);
            this.NewParentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NewParentID.Name = "NewParentID";
            this.NewParentID.PasswordChar = '\0';
            this.NewParentID.PlaceholderText = "New Parent ID";
            this.NewParentID.SelectedText = "";
            this.NewParentID.Size = new System.Drawing.Size(297, 56);
            this.NewParentID.TabIndex = 15;
            // 
            // parentID
            // 
            this.parentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.parentID.BorderRadius = 10;
            this.parentID.BorderThickness = 4;
            this.parentID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.parentID.DefaultText = "";
            this.parentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.parentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.parentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.parentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.parentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parentID.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.parentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.parentID.Location = new System.Drawing.Point(257, 239);
            this.parentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parentID.Name = "parentID";
            this.parentID.PasswordChar = '\0';
            this.parentID.PlaceholderText = "Parent ID";
            this.parentID.SelectedText = "";
            this.parentID.Size = new System.Drawing.Size(297, 56);
            this.parentID.TabIndex = 16;
            // 
            // TranferBtn
            // 
            this.TranferBtn.BorderRadius = 15;
            this.TranferBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TranferBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TranferBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TranferBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TranferBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TranferBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(75)))), ((int)(((byte)(162)))));
            this.TranferBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(126)))), ((int)(((byte)(234)))));
            this.TranferBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.TranferBtn.ForeColor = System.Drawing.Color.White;
            this.TranferBtn.Location = new System.Drawing.Point(257, 419);
            this.TranferBtn.Name = "TranferBtn";
            this.TranferBtn.Size = new System.Drawing.Size(297, 56);
            this.TranferBtn.TabIndex = 17;
            this.TranferBtn.Text = "TRANSFER";
            this.TranferBtn.Click += new System.EventHandler(this.TranferBtn_Click_1);
            // 
            // TranferEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(830, 617);
            this.Controls.Add(this.TranferBtn);
            this.Controls.Add(this.parentID);
            this.Controls.Add(this.NewParentID);
            this.Controls.Add(this.transEmpID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TranferEmpForm";
            this.Text = "TranferEmpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox transEmpID;
        private Guna.UI2.WinForms.Guna2TextBox NewParentID;
        private Guna.UI2.WinForms.Guna2TextBox parentID;
        private Guna.UI2.WinForms.Guna2GradientButton TranferBtn;
    }
}