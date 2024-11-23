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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
            TreeViewButton.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            TreeViewButton.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);
        }

        private void TreeViewButton_MouseLeave(object sender, EventArgs e)
        {
            TreeViewButton.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            TreeViewButton.ForeColor = System.Drawing.Color.White;
        }

        private void AddEmpSide_MouseEnter(object sender, EventArgs e)
        {
            AddEmpSide.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            AddEmpSide.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);
        }

        private void AddEmpSide_MouseLeave(object sender, EventArgs e)
        {
            AddEmpSide.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            AddEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void TransferSideButton_MouseEnter(object sender, EventArgs e)
        {
            TransferSideButton.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            TransferSideButton.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);
        }

        private void TransferSideButton_MouseLeave(object sender, EventArgs e)
        {
            TransferSideButton.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            TransferSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void RemoveEmpSide_MouseEnter(object sender, EventArgs e)
        {
            RemoveEmpSide.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            RemoveEmpSide.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);
        }

        private void RemoveEmpSide_MouseLeave(object sender, EventArgs e)
        {
            RemoveEmpSide.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            RemoveEmpSide.ForeColor = System.Drawing.Color.White;
        }

        private void SearchSIde_MouseEnter(object sender, EventArgs e)
        {
            SearchSIde.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            SearchSIde.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);
        }

        private void SearchSIde_MouseLeave(object sender, EventArgs e)
        {
            SearchSIde.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            SearchSIde.ForeColor = System.Drawing.Color.White;
        }

        private void reportSideButton_MouseEnter(object sender, EventArgs e)
        {
            reportSideButton.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            reportSideButton.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);

        }

        private void reportSideButton_MouseLeave(object sender, EventArgs e)
        {
            reportSideButton.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
            reportSideButton.ForeColor = System.Drawing.Color.White;
        }

        private void ListSideButton_MouseEnter(object sender, EventArgs e)
        {
            ListSideButton.BackColor = System.Drawing.Color.FromArgb(230, 215, 196);
            ListSideButton.ForeColor = System.Drawing.Color.FromArgb(33, 40, 66);

        }

        private void ListSideButton_MouseLeave(object sender, EventArgs e)
        {
            ListSideButton.BackColor = System.Drawing.Color.FromArgb(33, 40, 66);
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
    }
}
