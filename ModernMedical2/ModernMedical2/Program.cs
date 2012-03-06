using System;

namespace ModernMedical2
{
    class Program
    {
        private static string outputForNumber(int n)
        {
            string s = n.ToString();
            const int MODERN = 3;
            const int MEDICAL = 5;

            if (0 == n % MODERN)
            {
                s = "Modern";
                if (0 == n % MEDICAL)
                {
                    s = s + "" + "Medical";
                }
            }
            else if (0 == n % MEDICAL)
            {
                s = "Medical";
            }

            return s;
        }
          
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(outputForNumber(i));
            }

            // Keep console in view
            Console.WriteLine("\nPress ENTER to exit");
            Console.ReadLine();
        }
    }
}
