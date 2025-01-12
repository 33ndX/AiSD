using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class NodeT
    {
        public NodeT lewe;
        public NodeT prawe;
        public NodeT rodzic;
        public int data;
        private NodeT current;

        public NodeT(int data)
        {
            lewe = null;
            prawe = null;
            rodzic = null;
            this.data = data;
        }

        public NodeT(NodeT current)
        {
            this.current = current;
        }

        public void PolaczLewe(NodeT dziecko)
        {
            this.lewe = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = this;
            }
        }

        public void PolaczPrawe(NodeT dziecko)
        {
            this.prawe = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = this;
            }
        }
    }
}
