using System;

namespace brueche_kürzen
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "y";

            while (start == "y")
            {
                try
                {


                    Console.Write("Numerator:");
                    int numerator = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Denominator:");
                    int denominator = Convert.ToInt32(Console.ReadLine());

                    int teiler = functionggt(numerator, denominator);

                    Console.WriteLine("Die kleinste Variante ihres Bruches ist: " + numerator / teiler + "/" + denominator / teiler + "");

                    Console.Write("Wollen sie einen weiteren Bruch kürzen?[y/n]");
                    start = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Ihre Eingabe ist ungültig!");
                }
            }
        }

        static int functionggt (int zahl1, int zahl2)
        {
            if(zahl2 == 0)
            {
                return zahl1;
            }

            else
            {
                return functionggt(zahl2, zahl1 % zahl2);
            }
        }

    }
}
