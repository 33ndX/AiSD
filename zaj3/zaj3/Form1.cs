using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zaj3
{
    public partial class Form1 : Form
    {
        int[] tab = null;
        int[] Tab
        {
            get
            {
                return tab;
            }
            set
            {
                tab = value;
                bool isTabEmpty = tab == null || tab.Length == 0;
                button1.Enabled = !isTabEmpty;
                button2.Enabled = !isTabEmpty;
                button3.Enabled = !isTabEmpty;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
       
       

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            BubbleSort(sTab);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label2.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            InsertSort(sTab);
            watch.Stop();
            label5.Text = TabToString(sTab, label5);
            label2.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sTab = (int[])Tab.Clone();
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Stop();
            label5.Text = TabToString(MergeSort(sTab, 0, sTab.Length - 1), label5);
            label2.Text = watch.Elapsed.TotalMilliseconds.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandTab((int)numericUpDown1.Value, 0, 500);
            label4.Text = TabToString(tab, label1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Convert();
            label3.Text = TabToString(tab, label3);
        }
        public void Convert()
        {
            string input = textBox1.Text;
            Tab = input.Split(',', ' ').Select(int.Parse).ToArray();
        }

        public void RandTab(int n, int a, int b)
        {
            Tab = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                tab[i] = rand.Next(a, b);
            }
        }

        static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j + 1];
                        tab[j + 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }

        static void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while (j > 0 && tab[j - 1] > tab[j])
                {
                    temp = tab[j - 1];
                    tab[j - 1] = tab[j];
                    tab[j] = temp;
                    j--;
                }
            }
        }

        public static int[] MergeSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int middle = (end + start) / 2;
                int[] leftArr = MergeSort(array, start, middle);
                int[] rightArr = MergeSort(array, middle + 1, end);
                int[] mergedArr = MergeArray(leftArr, rightArr);
                return mergedArr;
            }
            return new int[] { array[start] };
        }

        public static int[] MergeArray(int[] leftArr, int[] rightArr)
        {
            int[] mergedArr = new int[leftArr.Length + rightArr.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = 0;

           
            while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
            {
                if (leftArr[leftIndex] < rightArr[rightIndex])
                {
                    mergedArr[mergedIndex++] = leftArr[leftIndex++];
                }
                else
                {
                    mergedArr[mergedIndex++] = rightArr[rightIndex++];
                }
            }

           
            while (leftIndex < leftArr.Length)
            {
                mergedArr[mergedIndex++] = leftArr[leftIndex++];
            }

            while (rightIndex < rightArr.Length)
            {
                mergedArr[mergedIndex++] = rightArr[rightIndex++];
            }

            return mergedArr;
        }

        static string TabToString(int[] tab, System.Windows.Forms.Label label)
        {
            string text = string.Join(", ", tab);
            Size textSize = TextRenderer.MeasureText(text, label.Font);

            if (textSize.Width > label.Width)
            {
                string shortText = text;
                while (textSize.Width > label.Width && shortText.Length > 0)
                {
                    shortText = shortText.Substring(0, shortText.Length - 1);
                    textSize = TextRenderer.MeasureText(shortText + "...", label.Font);
                }
                return shortText + "...";
            }
            return text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Tab = new int[0];
        }
    }
}

