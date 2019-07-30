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
        }

        private void btn_Deserialize_Click(object sender, EventArgs e)
        {
            TreeNode root = deserialize(txtBox_serializedText.Text.Trim());           

            //string serialized = serialize( root);

            // Your Codec object will be instantiated and called as such:
            // Codec codec = new Codec();
            // codec.deserialize(codec.serialize(root));

        }



        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            return serializeNodes(root);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            string trimmedData = data.Trim('[', ']');
            string[] stringNodes = trimmedData.Split(',');
            List<int?> intNodes = new List<int?>();

            foreach (string stringNode in stringNodes)
            {
                if (stringNode == "null")
                {
                    intNodes.Add(null);
                    continue;
                }
                int result;
                if (int.TryParse(stringNode, out result))
                {
                    intNodes.Add(result);
                }
                else
                {
                    intNodes.Add(null);
                }
            }

            return deSerializeNodes(intNodes);
        }

        public TreeNode deSerializeNodes(List<int?> intNodes)
        {
            int? firstNode = intNodes.FirstOrDefault();

            if (firstNode == null)
            {
                return null;
            }

            TreeNode rootNode = new TreeNode(firstNode.Value);

            deSerializeNode(rootNode, intNodes, 1);

            return rootNode;
        }

        public void deSerializeNode(TreeNode node, List<int?> intNodes, int index)
        {
            if (intNodes[index] != null)
            {
                node.left = new TreeNode(intNodes[index +1].Value);
                if (intNodes[index + 2] != null)
                {
                    deSerializeNode(node.left, intNodes, index + 2);
                }
                if (intNodes[index + 3] != null)
                {
                    deSerializeNode(node.left, intNodes, index + 3);
                }
            }

            if (intNodes[index + 1] != null)
            {
                node.right = new TreeNode(intNodes[index + 1].Value);
                if (intNodes[index + 4] != null)
                {
                    deSerializeNode(node.right, intNodes, index + 4);
                }
                if (intNodes[index + 5] != null)
                {
                    deSerializeNode(node.right, intNodes, index + 5);
                }
            }            

        }

        public string serializeNodes(TreeNode rootNode)
        {

            string nodeString = "[" + rootNode.val;
            serializeNode(rootNode, nodeString);

            return nodeString + "]";
        }

        public void serializeNode(TreeNode node, string nodeString)
        {
            if (node.left != null)
            {
                nodeString += "," + node.left.val;
            }
            else
            {
                nodeString += ",null";
            }

            if (node.right != null)
            {
                nodeString += "," + node.right.val;
            }
            else
            {
                nodeString += ",null";
            }

            if (node.left != null)
            {
                serializeNode(node.left, nodeString);
            }

            if (node.right != null)
            {
                serializeNode(node.right, nodeString);
            }


        }

    }
}
