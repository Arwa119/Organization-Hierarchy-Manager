namespace OrgHirarchy_WinForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TransferSideButton = new System.Windows.Forms.Button();
            this.TreeViewButton = new System.Windows.Forms.Button();
            this.ListSideButton = new System.Windows.Forms.Button();
            this.RemoveEmpSide = new System.Windows.Forms.Button();
            this.AddEmpSide = new System.Windows.Forms.Button();
            this.reportSideButton = new System.Windows.Forms.Button();
            this.SearchSIde = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.panelSideBar.Controls.Add(this.pictureBox1);
            this.panelSideBar.Controls.Add(this.TransferSideButton);
            this.panelSideBar.Controls.Add(this.TreeViewButton);
            this.panelSideBar.Controls.Add(this.ListSideButton);
            this.panelSideBar.Controls.Add(this.RemoveEmpSide);
            this.panelSideBar.Controls.Add(this.AddEmpSide);
            this.panelSideBar.Controls.Add(this.reportSideButton);
            this.panelSideBar.Controls.Add(this.SearchSIde);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 42);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(293, 664);
            this.panelSideBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TransferSideButton
            // 
            this.TransferSideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.TransferSideButton.FlatAppearance.BorderSize = 0;
            this.TransferSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferSideButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferSideButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TransferSideButton.Image = ((System.Drawing.Image)(resources.GetObject("TransferSideButton.Image")));
            this.TransferSideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransferSideButton.Location = new System.Drawing.Point(1, 403);
            this.TransferSideButton.Name = "TransferSideButton";
            this.TransferSideButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TransferSideButton.Size = new System.Drawing.Size(291, 54);
            this.TransferSideButton.TabIndex = 7;
            this.TransferSideButton.Text = "    Transfer Employee";
            this.TransferSideButton.UseVisualStyleBackColor = false;
            this.TransferSideButton.MouseEnter += new System.EventHandler(this.TransferSideButton_MouseEnter);
            this.TransferSideButton.MouseLeave += new System.EventHandler(this.TransferSideButton_MouseLeave);
            // 
            // TreeViewButton
            // 
            this.TreeViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.TreeViewButton.FlatAppearance.BorderSize = 0;
            this.TreeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TreeViewButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TreeViewButton.Image = ((System.Drawing.Image)(resources.GetObject("TreeViewButton.Image")));
            this.TreeViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TreeViewButton.Location = new System.Drawing.Point(1, 223);
            this.TreeViewButton.Name = "TreeViewButton";
            this.TreeViewButton.Size = new System.Drawing.Size(291, 54);
            this.TreeViewButton.TabIndex = 0;
            this.TreeViewButton.Text = "Tree View";
            this.TreeViewButton.UseVisualStyleBackColor = false;
            this.TreeViewButton.MouseEnter += new System.EventHandler(this.TreeViewButton_MouseEnter);
            this.TreeViewButton.MouseLeave += new System.EventHandler(this.TreeViewButton_MouseLeave);
            // 
            // ListSideButton
            // 
            this.ListSideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ListSideButton.FlatAppearance.BorderSize = 0;
            this.ListSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListSideButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSideButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ListSideButton.Image = ((System.Drawing.Image)(resources.GetObject("ListSideButton.Image")));
            this.ListSideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ListSideButton.Location = new System.Drawing.Point(1, 585);
            this.ListSideButton.Name = "ListSideButton";
            this.ListSideButton.Size = new System.Drawing.Size(291, 54);
            this.ListSideButton.TabIndex = 6;
            this.ListSideButton.Text = "    List Subordinates";
            this.ListSideButton.UseVisualStyleBackColor = false;
            this.ListSideButton.MouseEnter += new System.EventHandler(this.ListSideButton_MouseEnter);
            this.ListSideButton.MouseLeave += new System.EventHandler(this.ListSideButton_MouseLeave);
            // 
            // RemoveEmpSide
            // 
            this.RemoveEmpSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.RemoveEmpSide.FlatAppearance.BorderSize = 0;
            this.RemoveEmpSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEmpSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmpSide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveEmpSide.Image = ((System.Drawing.Image)(resources.GetObject("RemoveEmpSide.Image")));
            this.RemoveEmpSide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveEmpSide.Location = new System.Drawing.Point(1, 343);
            this.RemoveEmpSide.Name = "RemoveEmpSide";
            this.RemoveEmpSide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveEmpSide.Size = new System.Drawing.Size(291, 54);
            this.RemoveEmpSide.TabIndex = 1;
            this.RemoveEmpSide.Text = "    Remove Employee";
            this.RemoveEmpSide.UseVisualStyleBackColor = false;
            this.RemoveEmpSide.MouseEnter += new System.EventHandler(this.RemoveEmpSide_MouseEnter);
            this.RemoveEmpSide.MouseLeave += new System.EventHandler(this.RemoveEmpSide_MouseLeave);
            // 
            // AddEmpSide
            // 
            this.AddEmpSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.AddEmpSide.FlatAppearance.BorderSize = 0;
            this.AddEmpSide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmpSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpSide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddEmpSide.Image = ((System.Drawing.Image)(resources.GetObject("AddEmpSide.Image")));
            this.AddEmpSide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmpSide.Location = new System.Drawing.Point(1, 283);
            this.AddEmpSide.Name = "AddEmpSide";
            this.AddEmpSide.Size = new System.Drawing.Size(291, 54);
            this.AddEmpSide.TabIndex = 3;
            this.AddEmpSide.Text = "Add Employee";
            this.AddEmpSide.UseVisualStyleBackColor = false;
            this.AddEmpSide.Click += new System.EventHandler(this.button3_Click);
            this.AddEmpSide.MouseEnter += new System.EventHandler(this.AddEmpSide_MouseEnter);
            this.AddEmpSide.MouseLeave += new System.EventHandler(this.AddEmpSide_MouseLeave);
            // 
            // reportSideButton
            // 
            this.reportSideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.reportSideButton.FlatAppearance.BorderSize = 0;
            this.reportSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportSideButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportSideButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.reportSideButton.Image = ((System.Drawing.Image)(resources.GetObject("reportSideButton.Image")));
            this.reportSideButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportSideButton.Location = new System.Drawing.Point(1, 525);
            this.reportSideButton.Name = "reportSideButton";
            this.reportSideButton.Size = new System.Drawing.Size(291, 54);
            this.reportSideButton.TabIndex = 5;
            this.reportSideButton.Text = "Reporting Chain";
            this.reportSideButton.UseVisualStyleBackColor = false;
            this.reportSideButton.MouseEnter += new System.EventHandler(this.reportSideButton_MouseEnter);
            this.reportSideButton.MouseLeave += new System.EventHandler(this.reportSideButton_MouseLeave);
            // 
            // SearchSIde
            // 
            this.SearchSIde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.SearchSIde.FlatAppearance.BorderSize = 0;
            this.SearchSIde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchSIde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSIde.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchSIde.Image = ((System.Drawing.Image)(resources.GetObject("SearchSIde.Image")));
            this.SearchSIde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchSIde.Location = new System.Drawing.Point(1, 465);
            this.SearchSIde.Name = "SearchSIde";
            this.SearchSIde.Size = new System.Drawing.Size(291, 54);
            this.SearchSIde.TabIndex = 4;
            this.SearchSIde.Text = "Search";
            this.SearchSIde.UseVisualStyleBackColor = false;
            this.SearchSIde.MouseEnter += new System.EventHandler(this.SearchSIde_MouseEnter);
            this.SearchSIde.MouseLeave += new System.EventHandler(this.SearchSIde_MouseLeave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.panelHeader.Controls.Add(this.BtnMin);
            this.panelHeader.Controls.Add(this.BtnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1141, 42);
            this.panelHeader.TabIndex = 1;
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(1019, 0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(64, 42);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(1089, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(51, 42);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(196)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(293, 42);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(848, 664);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 706);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button TreeViewButton;
        private System.Windows.Forms.Button RemoveEmpSide;
        private System.Windows.Forms.Button SearchSIde;
        private System.Windows.Forms.Button reportSideButton;
        private System.Windows.Forms.Button AddEmpSide;
        private System.Windows.Forms.Button ListSideButton;
        private System.Windows.Forms.Button TransferSideButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnMin;
    }
}

