using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Graf
    {
        List<NodeG> nodes = new List<NodeG>();


        public void PrzechodzeniWGlab(NodeG node)
        {
            if (node == null)
                return;

            HashSet<NodeG> odwiedzone = new HashSet<NodeG>();
            WGlab(node, odwiedzone);

        }

        public void WGlab(NodeG node, HashSet<NodeG> odwiedzone) {
            if (odwiedzone.Contains(node))
            {
                return;
            }

            Console.Write(node.data + " ");
            odwiedzone.Add(node);

            foreach(var sasiad in node.sasiedni)
            {
                WGlab(sasiad, odwiedzone);
            }
        }

        public void PrzechodzenieWSzerz(NodeG startNode)
        {
            if(startNode == null)
            {
                return;
            }

            HashSet<NodeG> odwiedzone = new HashSet<NodeG>();
            Queue<NodeG> queue = new Queue<NodeG>();

            queue.Enqueue(startNode);
            odwiedzone.Add(startNode);

            while(queue.Count > 0)
            {
                NodeG currentNode = queue.Dequeue();
                Console.Write(currentNode.data + " ");

                foreach(var sasiad in currentNode.sasiedni)
                {
                    if (!odwiedzone.Contains(sasiad))
                    {
                        queue.Enqueue(sasiad);
                        odwiedzone.Add(sasiad);
                    }
                }
            }
        }


    }
}
