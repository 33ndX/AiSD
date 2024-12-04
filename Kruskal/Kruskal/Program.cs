namespace Kruskal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<NodeG1> nodes = new List<NodeG1>
        {
            new NodeG1(0),
            new NodeG1(1),
            new NodeG1(2),
            new NodeG1(3),
            new NodeG1(4),
            new NodeG1(5),
            new NodeG1(6),
            new NodeG1(7),
            new NodeG1(8),
            new NodeG1(9)
        };
            List<Edge> edges = new List<Edge>
        {
            new Edge(nodes[4], nodes[7], 1),
            new Edge(nodes[5], nodes[8], 2),
            new Edge(nodes[0], nodes[2], 3),
            new Edge(nodes[7], nodes[8], 3),
            new Edge(nodes[1], nodes[2], 4),
            new Edge(nodes[2], nodes[5], 5),
            new Edge(nodes[0], nodes[1], 6),
            new Edge(nodes[8], nodes[9], 6),
            new Edge(nodes[2], nodes[6], 6),
            new Edge(nodes[3], nodes[6], 7),
            new Edge(nodes[6], nodes[9], 8),
            new Edge(nodes[1], nodes[4], 9),
            new Edge(nodes[0], nodes[3], 10),
            new Edge(nodes[5], nodes[7], 11),
            new Edge(nodes[3], nodes[7], 12)
        };
            GrafG1 g1 = new GrafG1(nodes, edges);
            var wynik = g1.Kruskal();
            Console.WriteLine("\nWynik");
            foreach (var edge in wynik.edges)
            {
                Console.WriteLine(edge.start.data + "-" + edge.end.data + ": " + edge.weight);
            }
        }
    }
}