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

        static void CautaNotite()
        {
            Console.Write("Cuvant cautat: ");
            string cuvant = (Console.ReadLine() ?? "").Trim();
            if (cuvant == "")
            {
                Console.WriteLine("Eroare: cuvantul nu poate fi gol.");
                return;
            }

            int gasite = 0;
            foreach (string notita in CitesteNotitele())
            {
                if (notita.IndexOf(cuvant, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(notita);
                    gasite++;
                }
            }
            Console.WriteLine($"Notite gasite: {gasite}");
        }

        static void StergeNotitele()
        {
            Console.Write("Sigur stergeti toate notitele? (d/n): ");
            if ((Console.ReadLine() ?? "").Trim().ToLower() == "d")
            {
                if (File.Exists(FisierJurnal))
                    File.Delete(FisierJurnal);
                Console.WriteLine("Toate notitele au fost sterse.");
            }
            else
            {
                Console.WriteLine("Stergerea a fost anulata.");
            }
        }

        static void Main()
        {
            int optiune;

            do
            {
                Console.WriteLine("\n=== Jurnal-Personal ===");
                Console.WriteLine("1. Adauga notita");
                Console.WriteLine("2. Afiseaza notitele");
                Console.WriteLine("3. Cauta in notite");
                Console.WriteLine("4. Sterge toate notitele");
                Console.WriteLine("0. Iesire");
                Console.Write("Optiunea: ");
                if (!int.TryParse(Console.ReadLine(), out optiune))
                    optiune = -1;

                switch (optiune)
                {
                    case 1: AdaugaNotita(); break;
                    case 2: AfiseazaNotitele(); break;
                    case 3: CautaNotite(); break;
                    case 4: StergeNotitele(); break;
                    case 0: break;
                    default: Console.WriteLine("Optiune invalida."); break;
                }
            } while (optiune != 0);

            Console.WriteLine("La revedere!");
        }
    }
}
