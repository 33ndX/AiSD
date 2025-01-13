using System;
using Grafy;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graf graf = new Graf();
            NodeG a = new NodeG(1);
            NodeG b = new NodeG(2);
            NodeG c = new NodeG(3);
            NodeG d = new NodeG(4);
            NodeG e = new NodeG(5);
            NodeG f = new NodeG(6);
            NodeG g = new NodeG(7);

           
            a.DodajSasiada(b);
            a.DodajSasiada(c);
            a.DodajSasiada(e);

            b.DodajSasiada(d);
            b.DodajSasiada(f);
            

            c.DodajSasiada(e);
            c.DodajSasiada(g);

            e.DodajSasiada(f);



            Console.WriteLine("W Głąb");
            graf.PrzechodzeniWGlab(a);
            Console.WriteLine('\n');
            Console.WriteLine("W Szerz");
            graf.PrzechodzenieWSzerz(a);
            
        }
    }
}