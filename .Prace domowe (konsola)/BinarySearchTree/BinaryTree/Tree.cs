using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinaryTree 
{
    internal class Tree 
    {
        public NodeT root;

        public NodeT ZnajdzRodzica(NodeT dziecko)
        {
            var tempVar = this.root;
            while (true)
            {
                if (dziecko.data < tempVar.data)
                {
                    if (tempVar.lewe == null)
                    {
                        return tempVar;
                    }
                    else
                    {
                        tempVar = tempVar.lewe;
                    }
                }
                else
                {
                    if (tempVar.prawe == null)
                    {
                        return tempVar;
                    }
                    else
                    {
                        tempVar = tempVar.prawe;
                    }
                }
            }
        }

        public NodeT Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
            }
            else
            {
                var rodzic = this.ZnajdzRodzica(dziecko);
                if (dziecko.data < rodzic.data)
                {
                    rodzic.PolaczLewe(dziecko);
                }
                else
                {
                    rodzic.PolaczPrawe(dziecko);
                }
            }
            return dziecko;
        }

        public void Delete(int liczba)
        {
            NodeT current = root;
            NodeT rodzic = null;

            // Znajdź węzeł do usunięcia
            while (current != null && current.data != liczba)
            {
                rodzic = current;
                if (liczba < current.data)
                {
                    current = current.lewe;
                }
                else
                {
                    current = current.prawe;
                }
            }

            if (current == null)
            {
                return;
            }

            // Przypadek 1: Węzeł bez dzieci (liść)
            if (current.lewe == null && current.prawe == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else if (rodzic.lewe == current)
                {
                    rodzic.lewe = null;
                }
                else
                {
                    rodzic.prawe = null;
                }
            }
            // Przypadek 2: Węzeł z jednym dzieckiem
            else if (current.lewe == null || current.prawe == null)
            {
                NodeT dziecko = (current.lewe != null) ? current.lewe : current.prawe;

                if (current == root)
                {
                    root = dziecko;
                }
                else if (rodzic.lewe == current)
                {
                    rodzic.lewe = dziecko;
                }
                else
                {
                    rodzic.prawe = dziecko;
                }
            }
            // Przypadek 3: Węzeł z dwoma dziećmi
            else
            {
                NodeT nastepcaRodzica = current;
                NodeT nastepca = current.prawe;

                while (nastepca.lewe != null)
                {
                    nastepcaRodzica = nastepca;
                    nastepca = nastepca.lewe;
                }

                current.data = nastepca.data;

                if (nastepcaRodzica.lewe == nastepca)
                {
                    nastepcaRodzica.lewe = nastepca.prawe;
                }
                else
                {
                    nastepcaRodzica.prawe = nastepca.prawe;
                }
            }
        }
        public void PrintTree(NodeT node, string indent = "", bool isLeft = true)
        {
            if (node != null)
            {
                Console.WriteLine(indent + (isLeft ? "├── " : "└── ") + node.data);
                indent += isLeft ? "│   " : "    ";
                PrintTree(node.lewe, indent, true);
                PrintTree(node.prawe, indent, false);
            }
        }


    }
}
