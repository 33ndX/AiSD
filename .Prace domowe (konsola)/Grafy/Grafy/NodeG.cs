using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class NodeG
    {
        public List<NodeG> sasiedni = new List<NodeG>();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public void DodajSasiada(NodeG sasiad)
        {
            if (!sasiedni.Contains(sasiad))
            {
                sasiedni.Add(sasiad);
                sasiad.sasiedni.Add(this); 
            }
        }

    }
}
