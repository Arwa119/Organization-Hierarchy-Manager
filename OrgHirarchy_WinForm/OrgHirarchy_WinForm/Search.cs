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
    public partial class Search : Form
    {
        private OrgTree orgTree;

       
        public Search(OrgTree tree )
        {
            InitializeComponent();
            this.orgTree = tree;
            Filter.Items.Add("Name");
            Filter.Items.Add("ID");
            serachType.Items.Add("BFS");
            serachType.Items.Add("DFS");
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        
        private void SerachBTN_Click(object sender, EventArgs e)
        {
            string searchItem = seacrhTxtBox.Text.Trim();

            if (string.IsNullOrEmpty(searchItem))
            {
                MessageBox.Show("Please enter a search term.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Filter.SelectedItem == null)
            {
                MessageBox.Show("Please select a filter.", "Filter Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (serachType.SelectedItem == null)
            {
                MessageBox.Show("Please select a search type (BFS or DFS).", "Search Type Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filter = Filter.SelectedItem.ToString();
            string searchType = serachType.SelectedItem.ToString();

            List<Tree_node> result = new List<Tree_node>();

            try
            {
                if (searchType == "BFS")
                {
                    result = orgTree.BFS(searchItem, filter);
                }
                else if (searchType == "DFS")
                {
                    result = orgTree.DFS(searchItem, filter);
                }

                var simplifiedResults = result.Select(x => new { x.Name, x.Role, x.ID }).ToList();
                searchGrid.DataSource = simplifiedResults;

                if (simplifiedResults.Count == 0)
                {
                    MessageBox.Show("No results found for the given search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
