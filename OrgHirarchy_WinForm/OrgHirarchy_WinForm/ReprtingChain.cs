using System;
using System.Collections;
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
    public partial class ReprtingChain : Form
    {
        private OrgTree Rprt_tree;
        public ReprtingChain(OrgTree rprt_tree)
        {
            InitializeComponent();
            this.Rprt_tree = rprt_tree;
        }
        

        // Load the organization tree into the TreeView control
        private void ReprtingChain_Load(object sender, EventArgs e)
        {
            LoadOrgTreeView(Rprt_tree.Root);
        }
        private void LoadOrgTreeView(Tree_node node)
        {
            ReportTree.Nodes.Clear();
            PopulateTreeView(node, null);
        }
        private void PopulateTreeView(Tree_node node, TreeNode parentNode)
        {
            if (node == null) return;

            TreeNode newTreeNode = new TreeNode(node.Name);
            if (parentNode == null)
            {
                ReportTree.Nodes.Add(newTreeNode);
            }
            else
            {
                parentNode.Nodes.Add(newTreeNode);
            }

            foreach (var child in node.Children)
            {
                PopulateTreeView(child, newTreeNode);
            }
        }

        private void ReportBTN_Click(object sender, EventArgs e)
        {
            string enteredId = reportId.Text.Trim();
            if (string.IsNullOrEmpty(enteredId))
            {
                MessageBox.Show("Please enter an Employee ID.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> reportingChain = Rprt_tree.GetReportChain(enteredId);
            if (reportingChain.Count == 0)
            {
                MessageBox.Show("No reporting chain found for the entered Employee ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reportId.Clear();
            }
            else
            {
                ReportTree.Nodes.Clear();

                TreeNode rootNode = new TreeNode("Reporting Chain");
                ReportTree.Nodes.Add(rootNode);

                foreach (var report in reportingChain)
                {
                    TreeNode reportNode = new TreeNode(report); // Add name, role, and ID
                    rootNode.Nodes.Add(reportNode);
                }

                ReportTree.ExpandAll();
            }

        }
    }
}
