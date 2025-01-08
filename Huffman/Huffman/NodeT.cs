using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huffman
{
    internal class NodeT
    {
        public NodeT left;
        public NodeT right;
        public NodeT parent;
        public int data;

        public NodeT(int data)
        {
            this.data = data;
            left = null;
            right = null;
            parent = null;
        }

        public int GetLiczbaDzieci()
        {
            int result = 0;
            if(this.left != null)
            {
                result++;
            }
            if(this.right != null)
            {
                result++;
            }
            return result;
        }
    }
}
