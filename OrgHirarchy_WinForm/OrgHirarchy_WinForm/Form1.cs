using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgHirarchy_WinForm
{
    public partial class Form1 : Form
    {
        private OrgTree orgTree;
        private TreeView View;

        public Form1()
        {
            InitializeComponent();
            orgTree = new OrgTree("John","CEO","1");
            //DisplayTree();
        }

        public void loadform(object Form)
        {
            if(this.panelMain.Controls.Count > 0)
            {
                this.panelMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new AddEmpForm(orgTree));
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {

        }

        private void TreeViewButton_MouseEnter(object sender, EventArgs e)
        {
            TreeViewButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            TreeViewButton.ForeColor = System.Drawing.Color.White;
        }

        private void TreeViewButton_MouseLeave(object sender, EventArgs e)
        {
            TreeViewButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            TreeViewButton.ForeColor = System.Drawing.Color.White;
        }

        private void AddEmpSide_MouseEnter(object sender, EventArgs e)
        {
            AddEmpSide.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            AddEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void AddEmpSide_MouseLeave(object sender, EventArgs e)
        {
            AddEmpSide.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            AddEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void TransferSideButton_MouseEnter(object sender, EventArgs e)
        {
            TransferSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            TransferSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void TransferSideButton_MouseLeave(object sender, EventArgs e)
        {
            TransferSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            TransferSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void RemoveEmpSide_MouseEnter(object sender, EventArgs e)
        {
            RemoveEmpSide.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            RemoveEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void RemoveEmpSide_MouseLeave(object sender, EventArgs e)
        {
            RemoveEmpSide.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            RemoveEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void SearchSIde_MouseEnter(object sender, EventArgs e)
        {
            SearchSIde.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            SearchSIde.ForeColor = System.Drawing.Color.White;
        }

        private void SearchSIde_MouseLeave(object sender, EventArgs e)
        {
            SearchSIde.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            SearchSIde.ForeColor = System.Drawing.Color.White;
        }

        private void reportSideButton_MouseEnter(object sender, EventArgs e)
        {
            reportSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            reportSideButton.ForeColor = System.Drawing.Color.White;

        }

        private void reportSideButton_MouseLeave(object sender, EventArgs e)
        {
            reportSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            reportSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void ListSideButton_MouseEnter(object sender, EventArgs e)
        {
            ListSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82); 
            ListSideButton.ForeColor = System.Drawing.Color.White;

        }

        private void ListSideButton_MouseLeave(object sender, EventArgs e)
        {
            ListSideButton.BackColor = System.Drawing.Color.FromArgb(30, 41, 82);
            ListSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e)
        {
            BtnClose.BackColor = System.Drawing.Color.Red;
            BtnClose.ForeColor = System.Drawing.Color.White;

        }

        private void BtnClose_MouseMove(object sender, MouseEventArgs e)
        {
            BtnClose.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            BtnClose.ForeColor = System.Drawing.Color.White;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            BtnClose.ForeColor = System.Drawing.Color.White;
        }

        private void TreeViewButton_Click(object sender, EventArgs e)
        {
            View = new TreeView(orgTree);
            loadform(View);
        }

        private void RemoveEmpSide_Click(object sender, EventArgs e)
        {
            loadform(new RemoveEmpcs(orgTree, View));
        }

        private void SearchSIde_Click(object sender, EventArgs e)
        {
            loadform(new Search(orgTree)); 
        }

        private void ListSideButton_Click(object sender, EventArgs e)
        {
            loadform(new SubordinateForm(orgTree));
        }

        private void reportSideButton_Click(object sender, EventArgs e)
        {
            loadform(new ReprtingChain(orgTree));
        }

        private void TransferSideButton_Click(object sender, EventArgs e)
        {
            loadform(new TranferEmpForm(orgTree));
        }
    }
}
