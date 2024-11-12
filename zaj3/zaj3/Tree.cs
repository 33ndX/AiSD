using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace zaj3
{
    public class Tree
    {
        
        public NodeT root;

        public Tree()
        {
            root = null;
        }

        public NodeT FindParent(NodeT dziecko)
        {
            var tmp = this.root;
            while (true) { 
                if (dziecko.data < tmp.data)
                {
                    if (tmp.lewe == null)
                    {
                        return tmp;
                    }
                    else
                    {
                        tmp = tmp.lewe;
                    }
              
                }
                else
                {
                    if (tmp.prawe == null)
                    {
                        return tmp;
                    }
                    else
                    {
                        tmp = tmp.prawe;
                    }
                }
            }
        }


        public NodeT Add(int num)
        {
            var dziecko = new NodeT(num);
            if(this.root == null) 
            {
                this.root = dziecko;
            }
            else
            {
                var rodzic = this.FindParent(dziecko);
                if (dziecko.data < rodzic.data)
                {
                    rodzic.LinkLeft(dziecko);
                }
                else
                {
                    rodzic.LinkRight(dziecko);
                }
            }
            return dziecko;
        }

        public void Delete(int num)
        {
            NodeT currnet = root;
            NodeT rodzic = null;

            while (currnet.data != num && currnet != null)
            {
                rodzic = currnet;
                if (num < currnet.data)
                {
                    currnet = currnet.lewe;
                }
                else
                {
                    currnet = currnet.prawe;
                }
            }
            
            if(currnet == null)
            {
                return;
            }
            //Bez dziecka

            if (currnet.lewe == null && currnet.prawe == null)
            {
                if(currnet == null)
                {
                    root = null;
                }
                else if (rodzic.lewe == currnet)
                {
                    rodzic.lewe = null;
                }
                else
                {
                    rodzic.prawe = null;
                }                
            }
            //1 dziecko
            else if(currnet.lewe == null || currnet.prawe == null)
            {
                var dziecko = new NodeT(num);
                if(currnet == root)
                {
                    root = dziecko;
                }
                else if (rodzic.lewe == currnet)
                {
                    rodzic.LinkLeft(dziecko);
                }
                else
                {
                    rodzic.LinkRight(dziecko);
                }
            }
            //2 dzieci
            else
            {
                NodeT nastepcaRodzica = currnet;
                NodeT nastepca = currnet.prawe;

                while(nastepca.lewe != null)
                {
                    nastepcaRodzica = nastepca;
                    nastepca = nastepca.lewe;
                }

                currnet.data = nastepca.data;

                if(nastepcaRodzica.lewe == nastepca)
                {
                    nastepcaRodzica.lewe = nastepca.prawe;
                }
                else
                {
                    nastepcaRodzica.prawe = nastepca.prawe;
                }
            }
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
            InOrder(root);
        }







    }
}

