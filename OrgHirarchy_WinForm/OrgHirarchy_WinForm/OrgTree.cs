using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrgHirarchy_WinForm
{
    public class Tree_node//this class assigns the node value and makes nodes
    {
        public string Name { get; set; }  // node name
        public string Role { get; set; }  // ceo , manager , employee etc...
        public string ID { get; set; }    // id to identify each node(person)
        public List<Tree_node> Children {  get; set; } //this will handle the subordinates of a position(node)
        public Tree_node(string name, string role, string id) //constructor
        {
            this.Name = name;
            this.Role = role;
            this.ID = id;
            Children = new List<Tree_node>();
        }
      
    }
    public class OrgTree //this class gives nodes a tree structure
    {
        public Tree_node Root { get; set; }
        public OrgTree(string rootName,string role, string id)
        {
            Root = new Tree_node(rootName,role,id);
        }
        public Tree_node FindNode(Tree_node currentNode,string id)
        {
            if (currentNode == null) 
                return null;
            if (currentNode.ID == id) 
                return currentNode;
            foreach (var child in currentNode.Children) //var is used to explicitly declare the datatype
            {
                var findingNode = FindNode(child, id);
                if (findingNode != null)
                    return findingNode;
            }
            return null;
        }
        public void AddNode(string parentID, string nodeName,string nodeRole,string nodeId)
        {   
            Tree_node parentNode = FindNode(Root, parentID);
            if (parentNode != null)
            { 
                parentNode.Children.Add(new Tree_node(nodeName,nodeRole,nodeId)); 
            }
        }
        public bool RemoveNode(string id)
        {
           
            if (Root != null && Root.ID == id)
            {
                MessageBox.Show("Cannot remove the root node directly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            return removeRecursive(Root, id);
        }

        private bool removeRecursive(Tree_node parentNode, string id)
        {
            if (parentNode == null)
                return false;

            for (int i = 0; i < parentNode.Children.Count; i++)
            {
               
                if (parentNode.Children[i].ID == id)
                {
                    
                    parentNode.Children.RemoveAt(i);
                    return true;
                }
                else
                {
                   
                    bool childCheck = removeRecursive(parentNode.Children[i], id);
                    if (childCheck)
                    {
                        return true; 
                    }
                }
            }

            return false; 
        }

        public List<Tree_node> DFS(string searchTerm, string filter)
        {
            List<Tree_node> result = new List<Tree_node>();
            DFSRecursive(Root, searchTerm, filter, result);
            return result;
        }

        private void DFSRecursive(Tree_node currentNode, string searchTerm, string filter, List<Tree_node> result)
        {
            if (currentNode == null)
                return;

            if ((filter == "ID" && currentNode.ID.Contains(searchTerm)) ||
                (filter == "Name" && currentNode.Name.ToLower().Contains(searchTerm.ToLower())))
            {
                result.Add(currentNode);
            }

            foreach (var child in currentNode.Children)
            {
                DFSRecursive(child, searchTerm, filter, result);
            }
        }
        public List<Tree_node> BFS(string searchTerm, string filter)
        {
            EmpQueue<Tree_node> queue = new EmpQueue<Tree_node>();
            List<Tree_node> result = new List<Tree_node>();

            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                Tree_node currentNode = queue.Dequeue();

                if ((filter == "ID" && currentNode.ID.Contains(searchTerm)) ||
                    (filter == "Name" && currentNode.Name.ToLower().Contains(searchTerm.ToLower())))
                {
                    result.Add(currentNode);  
                }

                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return result;  
        }

        public bool TransferEmp(string empID, string currentP_ID, string newP_ID)
        {
            if (Root == null) return false;

            Tree_node currentParent = FindNode(Root, currentP_ID);
            if (currentParent == null)
            {
                MessageBox.Show("Current Parent not found.");
                return false;
            }

            Tree_node empNode = null;
            foreach (var child in currentParent.Children)
            {
                if (child.ID == empID)
                {
                    empNode = child;
                    break;
                }
            }

            if (empNode == null)
            {
                MessageBox.Show("Employee not found under the specified parent.");
                return false;
            }

            Tree_node newParent = FindNode(Root, newP_ID);
            if (newParent == null)
            {
                MessageBox.Show("New Parent not found.");
                return false;
            }

            if ((empNode.Role == "manager" || empNode.Role == "Manager") && (newParent.Role=="manager" || newParent.Role == "Manager"))
            {
                foreach (var subordinate in empNode.Children)
                {
                    newParent.Children.Add(subordinate);
                }

                empNode.Children.Clear();
                currentParent.Children.Remove(empNode);
                newParent.Children.Add(empNode);
                empNode.Role = "employee";
            }

            if ((newParent.Role == "CEO" || newParent.Role == "ceo") && (empNode.Role == "employee" || empNode.Role == "Employee"))
            {
                currentParent.Children.Remove(empNode);
                newParent.Children.Add(empNode);
                empNode.Role = "manager";
            }

            /*currentParent.Children.Remove(empNode);
            newParent.Children.Add(empNode);*/

            return true;
        }


        public List<string> GetReportChain(string empId)
        {
            List<string> rpChain = new List<string>();

            if (FindChain(Root, empId, rpChain))
            {
                rpChain.Reverse(); 
                return rpChain;
            }

            return new List<string>(); 
        }

        private bool FindChain(Tree_node currentNode, string targetId, List<string> rpChain)
        {
            if (currentNode == null)
                return false;

            rpChain.Add($"Name: {currentNode.Name}, Role: {currentNode.Role}, ID: {currentNode.ID}");

            if (currentNode.ID == targetId)
                return true;

            foreach (var child in currentNode.Children)
            {
                if (FindChain(child, targetId, rpChain))
                    return true;
            }

            rpChain.RemoveAt(rpChain.Count - 1);
            return false;
        }



        public bool EditNode(string id, string newName)
        {

            Tree_node node = FindNode(Root, id);

            if (node != null)
            {
                node.Name = newName;
                return true;
            }

            return false;
        }

    }

}

