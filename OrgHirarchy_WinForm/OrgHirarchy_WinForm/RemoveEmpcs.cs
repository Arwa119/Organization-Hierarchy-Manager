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
    public partial class RemoveEmpcs : Form
    {
        private OrgTree organizeTree;
        private TreeView treeView;
        public RemoveEmpcs( OrgTree orgT,TreeView view_tree)
        {
            InitializeComponent();
            organizeTree = orgT;
            this.treeView = view_tree;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveEmpcs_Load(object sender, EventArgs e)
        {

        }
        private void RemoveBTN_Click_1(object sender, EventArgs e)
        {
            string ID_node = RemoveID.Text.Trim();

            if (!string.IsNullOrEmpty(ID_node))
            {
                if (organizeTree.Root != null && organizeTree.Root.ID == ID_node)
                {
                    MessageBox.Show("Cannot remove the root node directly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemoveID.Clear();
                    return; 
                }

                bool removeCheck = organizeTree.RemoveNode(ID_node);
                if (removeCheck)
                {
                    MessageBox.Show("Employee deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    treeView.DisplayTree();
                    RemoveID.Clear();
                }
                else
                {
                    MessageBox.Show("Employee Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RemoveID.Clear();

                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            string empId = editID.Text.Trim();
            string newName = NewName.Text.Trim();

            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Please fill in both Employee ID and New Name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Call the edit method
            bool editCheck = organizeTree.EditNode(empId, newName);
            if (editCheck)
            {
                MessageBox.Show("Employee name updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editID.Clear();
                NewName.Clear();
            }
            else
            {
                MessageBox.Show("Employee ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                editID.Clear();
                NewName.Clear();
            }
        }

        private void editID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
