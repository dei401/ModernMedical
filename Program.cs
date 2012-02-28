using System;

namespace ModernMedical1
{
    class Program
    {
        
        private static bool isModern(int n)
        {
            if (0 < n)
            {
                while (0 < n)
                {
                    n = n - 3;
                }
            }
            return (0 == n);
        }

        private static bool isMedical(int n) 
        {

            if (0 < n)
            {
                while (0 < n)
                {
                    n = n - 5;
                }
            }
            return (0 == n);
        }

        private static string outputForNumber(int n)
        {
            string s = n.ToString();

            if (isModern(n))
            {
                s = "Modern";
                if (isMedical(n))
                {
                    s = s + "" + "Medical";
                }
            }
            else if (isMedical(n))
            {
                s = "Medical";
            }

            return s;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(outputForNumber(i));
            }

        }
    }
}
