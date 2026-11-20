using System;
using System.IO;

namespace Jurnal_Personal
{
    class Program
    {
        // Fisierul in care se salveaza notitele (este in .gitignore, nu ajunge pe GitHub)
        const string FisierJurnal = "jurnal.txt";

        static void AdaugaNotita()
        {
            Console.Write("Scrieti notita: ");
            string text = (Console.ReadLine() ?? "").Trim();
            if (text == "")
            {
                Console.WriteLine("Eroare: notita nu poate fi goala.");
                return;
            }

            string linie = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] {text}";
            File.AppendAllText(FisierJurnal, linie + Environment.NewLine);
            Console.WriteLine("Notita a fost salvata.");
        }

        static string[] CitesteNotitele()
        {
            if (!File.Exists(FisierJurnal))
                return new string[0];
            return File.ReadAllLines(FisierJurnal);
        }

        static void AfiseazaNotitele()
        {
            string[] notite = CitesteNotitele();
            if (notite.Length == 0)
            {
                Console.WriteLine("Jurnalul este gol.");
                return;
            }

            Console.WriteLine("=== Notitele mele ===");
            for (int i = 0; i < notite.Length; i++)
                Console.WriteLine($"{i + 1}. {notite[i]}");
        }

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
                    case 1: AdaugaNotita(); break;
                    case 2: AfiseazaNotitele(); break;
                    case 0: break;
                    default: Console.WriteLine("Optiune invalida."); break;
                }
            } while (optiune != 0);

            Console.WriteLine("La revedere!");
        }
    }
}
