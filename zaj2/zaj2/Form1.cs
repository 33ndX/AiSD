using System.Collections.Generic;

namespace zaj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void InsertSort(int[] array)
        {
            for (int i=1; i<=array.Length-1; i++)
            {
                int current = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = current;
            }
        }
        int[] tab = { 6, 5, 3, 1, 8, 7, 2, 4 };
        private void button1_Click(object sender, EventArgs e)
        {
            InsertSort(tab);
            string text = TabToString(tab);
            label2.Text = text;
        }

        static string TabToString(int[] tab)
        {
            string text = string.Join(", ", tab);
            return text;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "{ 6, 5, 3, 1, 8, 7, 2, 4 }";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }
    }
}