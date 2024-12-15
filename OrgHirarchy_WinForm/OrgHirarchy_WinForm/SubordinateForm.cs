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
    public partial class SubordinateForm : Form
    {
        private OrgTree SUb_Tree;
        public SubordinateForm(OrgTree tree)
        {
            InitializeComponent();
            SUb_Tree = tree;
        }

        private void SubordinateForm_Load(object sender, EventArgs e)
        {

        }
        private LinkedListEmp<Subordinate> GetSubordinates(string enteredId)
        {
            if (string.IsNullOrWhiteSpace(enteredId))
            {
                MessageBox.Show("Please enter a valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            // Use the Sub_Tree instance to access the Root and FindNode
            Tree_node node = SUb_Tree.FindNode(SUb_Tree.Root, enteredId);
            if (node == null)
            {
                MessageBox.Show("ID not found in the hierarchy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            var subordinates = new LinkedListEmp<Subordinate>();

            if (node.Role.Equals("CEO", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var manager in node.Children)
                {
                    subordinates.AddLast(new Subordinate(manager.Name, manager.Role, manager.ID));
                    foreach (var employee in manager.Children)
                    {
                        subordinates.AddLast(new Subordinate(employee.Name, employee.Role, employee.ID));
                    }
                }
            }
            else if (node.Role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
            {
                foreach (var employee in node.Children)
                {
                    subordinates.AddLast(new Subordinate(employee.Name, employee.Role, employee.ID));
                }
            }
            if (subordinates.Count() == 0)
            {
                MessageBox.Show("This ID has no subordinates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }


            return subordinates;
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string enteredId = subordianteTextbox.Text.Trim();
            var subordinates = GetSubordinates(enteredId);

            if (subordinates != null && subordinates.Count() > 0)
            {
                subordianteGrid.DataSource = subordinates.ToList();
            }
        }

        private void subordianteTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subordianteTextbox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
