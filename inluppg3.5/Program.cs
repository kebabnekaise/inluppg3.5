using System;

namespace inluppg3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ett tal");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett till tal");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Välj en aritmetisk operation:\n1. Addition\n2. Subtraktion\n3. Multiplikation\n4. Division");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Svar: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Svar: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Svar: " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Svar: " + (num1 / num2));
                    break;
            }
        }
    }
}