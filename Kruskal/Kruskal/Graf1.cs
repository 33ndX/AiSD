using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Kruskal
{
    internal class Graf1
    {
        List <NodeG1> nodes = new List <NodeG1>();
        List<Edge> edges = new List<Edge>();

        public void Grarf1(Edge k)
        {
            Add(k);
        }

        public int IleNowychWelzow(Edge k)
        {
            int i=0;
            var tmp = 1;
            
            return i;
        }

        public void Add(Edge k)
        {
           
        }

        public void Join(Graf1 g1)
        {
            for(int i=0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
            }
        }
    }


}
