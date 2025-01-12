public class HelloWorld 
{
    static void Main(string[] args)
    {
        string s1 = "abaabbaaa";
        string s2 = "babab";
        s1 = " " + s1;
        s2 = " " + s2;

        Console.WriteLine(NWP(s1, s2));
    }

    static int NWP(string s1, string s2)
    {
        int[,] tab = new int[s1.Length, s2.Length];

        for (int i = 0; i < s1.Length; i++)
        {
            tab[i, 0] = 0;
        }
        
        for (int j = 0; j < s2.Length; j++)
        {
            tab[0, j] = 0;
        }

        for (int i = 1; i < s1.Length; i++)
        {
            for (int j = 1; j < s2.Length; j++)
            {
                if (s1[i] == s2[j])
                {
                    tab[i, j] = tab[i - 1, j - 1] + 1;
                }
                else
                {
                    tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                }
            }
        }

        return tab[s1.Length - 1, s2.Length - 1];
    }
}
