using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Kruskal
{
    internal class GrafG1
    {
        List <NodeG1> nodes = new List <NodeG1>();
        List<Edge> edges = new List<Edge>();

        public GrafG1()
        {

        }

        public GrafG1(Edge e)
        {
            edges.Add(e);
            nodes.Add(e.start);
            nodes.Add(e.end);
        }

        public int IleNowychWelzow(Edge e)
        {
            int noweWezly = 0;
            if (!nodes.Contains(e.start))
            {
                noweWezly++;
            }
            if (!nodes.Contains(e.end))
            {
                noweWezly++;
            }
            return noweWezly;
        }

        public void AddEdge(Edge e)
        {
            switch (IleNowychWelzow(e))
            {
                case 0:
                    int przedDodaniem = PrzechodzenieWGlab(nodes[0]).Count;
                    edges.Add(e);
                    int poDodaniu = PrzechodzenieWGlab(nodes[0]).Count;
                    if (przedDodaniem == poDodaniu)
                        edges.Remove(e);
                    break;
                case 1:
                    edges.Add(e);
                    if (!nodes.Contains(e.start))
                    {
                        nodes.Add(e.start);
                    }
                    if (!nodes.Contains(e.end))
                    {
                        nodes.Add(e.end);
                    }
                    break;
                case 2:
                    Join(new GrafG1(e));
                    break;
                default:
                    break;
            }
        }

        public void Join(GrafG1 g1)
        {
            foreach (var e in g1.edges)
            {
                if (!edges.Contains(e))
                {
                    edges.Add(e);
                }
            }
            foreach (var n in g1.nodes)
            {
                if (!nodes.Contains(n))
                {
                    nodes.Add(n);
                }
            }
        }

        public GrafG1 Kruskal()
        {
            //this
            GrafG1 mst = new GrafG1();
            foreach (var e in edges)
            {
                mst.AddEdge(e);
            }
            return mst;
        }

        public List<NodeG1> PrzechodzenieWGlab(NodeG1 elementStartowy)
        {
            List<NodeG1> odwiedzone = new List<NodeG1>();
            List<NodeG1> doOdwiedzenia = new List<NodeG1>();
            doOdwiedzenia.Add(elementStartowy);

            while (doOdwiedzenia.Count > 0)
            {
                NodeG1 obecny = doOdwiedzenia[0];
                doOdwiedzenia.RemoveAt(0);
                if (!odwiedzone.Contains(obecny))
                {
                    odwiedzone.Add(obecny);
                    foreach (var krawedz in edges)
                    {
                        if (krawedz.start == obecny && !odwiedzone.Contains(krawedz.end))
                        {
                            doOdwiedzenia.Add(krawedz.end);
                        }
                        else if (krawedz.end == obecny && !odwiedzone.Contains(krawedz.start))
                        {
                            doOdwiedzenia.Add(krawedz.start);
                        }
                    }
                }
            }
            return odwiedzone;
        }
    }
//Generowanie listy
//Metoda ma sortować i ten algorytm co ma być

// 

}
