using System;
using System.Collections.Generic;


namespace LIST_inl.Uppg_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namnen = new List<string>();

            Console.WriteLine("Skriv namnen på människorna som du älskar.");
            Console.WriteLine("AVLUSTA MED ETT TOMT RAD.");
            string svarnamn = " ";

            while (svarnamn != "")
            {
                Console.WriteLine("Skriv in ett nytt namn.");
                svarnamn = Console.ReadLine();
                if (svarnamn != "")
                {
                    namnen.Add(svarnamn);
                }
            }
            Console.WriteLine("Här är namnen du angav:");

            namnen.Sort();
            foreach (string resultat in namnen)
            {
                Console.WriteLine(resultat);
            }

        }

    }
}

