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
        //public string serialize(TreeNode root)
        //{

        //}

        // Decodes your encoded data to tree.
        public TreeNode deserialize(String data)
        {
            string[] data_array = data.Split(',');
            List<string> data_list = data_array.ToList<string>();
            return rdeserialize(data_list);
        }

        public TreeNode rdeserialize(List<string> l)
        {
            if(l.Count == 0)
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
