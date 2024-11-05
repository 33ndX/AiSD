using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace zaj3
{
    public class Tree
    {
        
        public NodeT korzen;

        public Tree()
        {
            korzen = null;
        }

        public void AddToTree(int data)
        {
            korzen = AddToTree(korzen, data, null);
        }

        public NodeT AddToTree(NodeT nodeT, int data, NodeT rodzic)
        {
            if (nodeT == null)
            {
                NodeT nT = new NodeT(data);
                nT.rodzic = rodzic;
                return nT;
            }

            if (data <= nodeT.data)
            {
                nodeT.lewe = AddToTree(nodeT.lewe, data, nodeT);
            }

            else if (data > nodeT.data)
            {
                nodeT.prawe = AddToTree(nodeT.prawe, data, nodeT);
            }

            return nodeT;
        }

        public void InOrder(NodeT node)
        {
            if (node == null)
            {
                return;
            }
            else
            {
                InOrder(node.lewe);
                MessageBox.Show(node.data + " ");
                InOrder(node.prawe);
            }
        }

        public void InOrder()
        {
            InOrder(korzen);
        }
    }
}

