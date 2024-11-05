using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zaj3
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            List l1 = new List();
            l1.AddLast(3);
            l1.AddLast(2);
            l1.AddFirst(5);
            l1.AddFirst(8);
            l1.AddFirst(4);

            l1.RemoveLast();
            l1.RemoveFirst();
             
            MessageBox.Show(l1.Get(2).ToString());


            Tree t1 = new Tree();
            t1.AddToTree(2);
            t1.AddToTree(3);
            t1.AddToTree(4);
            t1.AddToTree(2);
            t1.AddToTree(1);

            t1.InOrder();

            Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          //Application.Run(new Form1());
        }
    }
}
