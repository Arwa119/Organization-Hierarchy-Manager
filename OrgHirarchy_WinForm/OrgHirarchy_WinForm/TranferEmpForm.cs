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
    public partial class TranferEmpForm : Form
    {
        OrgTree TranTree;
        public TranferEmpForm(OrgTree tranTree)
        {
            InitializeComponent();
            this.TranTree = tranTree;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void transEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TranferBtn_Click_1(object sender, EventArgs e)
        {
            string empId = transEmpID.Text;
            string currentParentId = parentID.Text;
            string newParentId = NewParentID.Text;

            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(currentParentId) || string.IsNullOrEmpty(newParentId))
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            bool transferSuccess = TranTree.TransferEmp(empId, currentParentId, newParentId);

            if (transferSuccess)
            {
                MessageBox.Show("Employee transferred successfully.");
                transEmpID.Clear();
                parentID.Clear();
                NewParentID.Clear();
            }
            else
            {
                MessageBox.Show("Employee transfer failed. Please check the IDs.");
            }
        }
    }
}
