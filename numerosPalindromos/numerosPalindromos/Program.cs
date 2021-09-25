using System;

namespace numerosPalindromos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            for(int i = n; i < 1000000; i++)
            {
                if(isPalindromo(i))
                    if(isPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
            }

            
        }

        static bool isPalindromo(int x)
        {
            int nx = x;
            String stra = nx.ToString();
            String strb = "";
            int temp = stra.Length - 1;
            for(int i = temp; i >= 0; i--)
            {
                strb += stra[i];
            }
            if (stra.Equals(strb))
                return true;
            return false;
        }

        static bool isPrimo(int x)
        {
            int nx = x, cont = 0;
            for(int i = 1; i < nx; i++)
            {
                if (nx % i == 0)
                    cont++;
            }
            if (cont < 2)
                return true;
            else
                return false;
        }
    }
}
