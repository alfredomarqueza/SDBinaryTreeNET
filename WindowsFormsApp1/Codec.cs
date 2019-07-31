// by @alfredomarqueza 2019
// codec class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Codec
    {        

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder result = rserialize(root, str);
            return result.ToString();
        }

        private StringBuilder rserialize(TreeNode root, StringBuilder str)
        {
            // Recursive serialization.
            if (root == null)
            {
                str.Append("null,");
            }
            else
            {
                str.Append(root.val + ",");
                str = rserialize(root.left, str);
                str = rserialize(root.right, str);
            }
            return str;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            string[] data_array = data.Split(',');
            List<string> data_list = data_array.ToList<string>();
            return rdeserialize(data_list);
        }

        private TreeNode rdeserialize(List<string> l)
        {
            if(!l.Any())
                return null;

            // Recursive deserialization.
            if (l[0] == "null")
            {
                l.RemoveAt(0);
                return null;
            }

            TreeNode root = new TreeNode(Convert.ToInt32(l[0]));
            l.RemoveAt(0);
            root.left = rdeserialize(l);
            root.right = rdeserialize(l);

            return root;
        }

    }
}
