namespace Graf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NodeG a = new NodeG(3);
            NodeG b = new NodeG(4);
            NodeG c = new NodeG(6);
            NodeG d = new NodeG(8);
            NodeG e = new NodeG(5);
            NodeG f = new NodeG(1);
            NodeG g = new NodeG(7);
            a.DodajSasiada(b);
            a.DodajSasiada(c);

            b.DodajSasiada(a);
            b.DodajSasiada(d);
            b.DodajSasiada(e);

            c.DodajSasiada(a);
            c.DodajSasiada(d);
            c.DodajSasiada(f);

            d.DodajSasiada(b);
            d.DodajSasiada(f);
            d.DodajSasiada(c);

            e.DodajSasiada(b);
            e.DodajSasiada(f);

            f.DodajSasiada(c);
            f.DodajSasiada(d);
            f.DodajSasiada(e);
            f.DodajSasiada(g);

            g.DodajSasiada(f);

            List<NodeG> lista = new List<NodeG>(a.PrzechodzenieWSzerz(a));
            foreach (var x in lista)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}