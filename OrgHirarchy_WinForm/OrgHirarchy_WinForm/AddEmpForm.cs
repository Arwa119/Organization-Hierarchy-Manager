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
    public partial class AddEmpForm : Form
    {
        private  OrgTree organizationlTree;
        public AddEmpForm(OrgTree organizationlTree)
        {
            InitializeComponent();
            this.organizationlTree = organizationlTree;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmpForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBTN_Click_1(object sender, EventArgs e)
        {
            string name_emp = NameEmp.Text.Trim();
            string role = RoleEmp.Text.Trim();
            string parentId = ParentID.Text.Trim();

            if (!string.IsNullOrEmpty(parentId) && !string.IsNullOrEmpty(name_emp) && !string.IsNullOrEmpty(role))
            {
                Tree_node parentNode = organizationlTree.FindNode(organizationlTree.Root, parentId);
                if (parentNode == null)
                {
                    MessageBox.Show("Parent ID does not exist in the hierarchy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (parentNode.Role.Equals("CEO", StringComparison.OrdinalIgnoreCase))
                {
                    if (!role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("If the parent is a CEO, the new employee's role must be Manager.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (parentNode.Role.Equals("Manager", StringComparison.OrdinalIgnoreCase))
                {
                    if (!role.Equals("Employee", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("If the parent is a Manager, the new employee's role must be Employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The parent must be a CEO or Manager to add a new employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string id = Guid.NewGuid().ToString().Substring(0, 3);
                organizationlTree.AddNode(parentId, name_emp, role, id);

                MessageBox.Show("Employee Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ParentID.Clear();
                NameEmp.Clear();
                RoleEmp.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
