using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Serialize_Click(object sender, EventArgs e)
        {
            Codec codec = new Codec();

            TreeNode root = GetTreeFromTreeView();

            string serializedTree = codec.serialize(root);

            txtBox_serializedText.Text = serializedTree;
        }

        private void btn_Deserialize_Click(object sender, EventArgs e)
        {
            Codec codec = new Codec();

            treeViewBinaryTree.Nodes.Clear();

            TreeNode root = codec.deserialize(txtBox_serializedText.Text.Trim('[', ']'));

            PopulateTreeViewFromRoot(root);

            treeViewBinaryTree.ExpandAll();

        }

        private TreeNode GetTreeFromTreeView()
        {
            int rootNumber = Convert.ToInt32(treeViewBinaryTree.Nodes[0].Text);

            TreeNode root = new TreeNode(rootNumber);

            RSetTreeNodes(root, treeViewBinaryTree.Nodes[0]);

            return root;
        }

        private void RSetTreeNodes(TreeNode node, System.Windows.Forms.TreeNode treeViewNode)
        {

            if (treeViewNode.Nodes.Count > 0)
            {
                node.left = new TreeNode(Convert.ToInt32(treeViewNode.Nodes[0].Text));
                RSetTreeNodes(node.left, treeViewNode.Nodes[0]);
            }

            if (treeViewNode.Nodes.Count > 1)
            {
                node.right = new TreeNode(Convert.ToInt32(treeViewNode.Nodes[1].Text));
                RSetTreeNodes(node.right, treeViewNode.Nodes[1]);
            }

        }

        /// <summary>
        /// Function to populate TreeView from root
        /// </summary>
        private void PopulateTreeViewFromRoot(TreeNode root)
        {

            System.Windows.Forms.TreeNode treeViewNodeRoot = new System.Windows.Forms.TreeNode();
            treeViewNodeRoot.Text = root.val.ToString();
            
            treeViewBinaryTree.Nodes.Add(treeViewNodeRoot);
            RPopulateTreeView(root, treeViewNodeRoot);
        }

        /// <summary>
        /// Recursive function to populate TreeView nodes
        /// </summary>
        private void RPopulateTreeView(TreeNode parentnode, System.Windows.Forms.TreeNode parentTreeViewNode)
        {            

            if (parentnode.left != null)
            {
                System.Windows.Forms.TreeNode treeViewNodeLeft = new System.Windows.Forms.TreeNode();
                treeViewNodeLeft.Text = parentnode.left.val.ToString();
                parentTreeViewNode.Nodes.Add(treeViewNodeLeft);

                RPopulateTreeView(parentnode.left, treeViewNodeLeft);
            }

            if (parentnode.right != null)
            {
                System.Windows.Forms.TreeNode treeViewNodeRight = new System.Windows.Forms.TreeNode();
                treeViewNodeRight.Text = parentnode.right.val.ToString();
                parentTreeViewNode.Nodes.Add(treeViewNodeRight);
                RPopulateTreeView(parentnode.right, treeViewNodeRight);
            }
        
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            treeViewBinaryTree.Nodes.Remove(treeViewBinaryTree.SelectedNode);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (treeViewBinaryTree.SelectedNode == null && treeViewBinaryTree.Nodes.Count > 0)
            {
                MessageBox.Show("Please select a node", "Parent node missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (treeViewBinaryTree.Nodes.Count == 0)
            {
                System.Windows.Forms.TreeNode root = new System.Windows.Forms.TreeNode();
                root.Text = numericUpDown.Text;
                numericUpDown.Value++;
                treeViewBinaryTree.Nodes.Add(root);                
                return;
            }

            if (treeViewBinaryTree.SelectedNode != null)
            {
                if (treeViewBinaryTree.SelectedNode.Nodes.Count == 2)
                {
                    MessageBox.Show("No more children allowed for this node", "Only two children allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                System.Windows.Forms.TreeNode node = new System.Windows.Forms.TreeNode();
                node.Text = numericUpDown.Text;
                numericUpDown.Value++;
                treeViewBinaryTree.SelectedNode.Nodes.Add(node);
                treeViewBinaryTree.SelectedNode.Expand();
                return;
            }

        }
    }
}
