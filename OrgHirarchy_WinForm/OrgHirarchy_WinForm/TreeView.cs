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
    public partial class TreeView : Form
    {
        private OrgTree orgTree;
        public TreeView(OrgTree organizatonTree)
        {
            InitializeComponent();
            this.orgTree = organizatonTree;
 
            DisplayTree();
        }

        public void DisplayTree()
        {
            treeViewHierarchy.Nodes.Clear();

            if (orgTree.Root != null)
            {
                TreeNode root_Node = CreateNode(orgTree.Root);
                treeViewHierarchy.Nodes.Add(root_Node);
            }
            treeViewHierarchy.ExpandAll();
        }
        private System.Windows.Forms.TreeNode CreateNode(Tree_node node)
        {
            var new_node = new System.Windows.Forms.TreeNode($"ID: {node.ID}, Name: {node.Name}, Role: {node.Role}")
            {
                Tag = node.ID
            };
            foreach(var child in node.Children)
            {
                new_node.Nodes.Add(CreateNode(child));
            }

            return new_node;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeViewHierarchy_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            DisplayTree();
        }

        private void TreeView_Load(object sender, EventArgs e)
        {

        }
    }
}
