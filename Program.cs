using System;

namespace Jurnal_Personal
{
    class Program
    {
        static void Main()
        {
            int optiune;

            do
            {
                Console.WriteLine("\n=== Jurnal-Personal ===");
                Console.WriteLine("1. Adauga notita");
                Console.WriteLine("2. Afiseaza notitele");
                Console.WriteLine("0. Iesire");
                Console.Write("Optiunea: ");
                if (!int.TryParse(Console.ReadLine(), out optiune))
                    optiune = -1;

                switch (optiune)
                {
                    case 1: Console.WriteLine("In lucru..."); break;
                    case 2: Console.WriteLine("In lucru..."); break;
                    case 0: break;
                    default: Console.WriteLine("Optiune invalida."); break;
                }
            } while (optiune != 0);

            Console.WriteLine("La revedere!");
        }
    }
}
