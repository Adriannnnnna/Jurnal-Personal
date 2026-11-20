# Jurnal-Personal

Aplicație consolă în C# care salvează notițe personale într-un fișier text (`jurnal.txt`).

## Ce face programul
1. **Adauga notita** – scrie notița în fișier, împreună cu data și ora;
2. **Afiseaza notitele** – arată toate notițele salvate, numerotate;
3. **Cauta in notite** – afișează notițele care conțin un cuvânt;
4. **Sterge toate notitele** – șterge fișierul, după confirmare (d/n).

Fișierul `jurnal.txt` este trecut în `.gitignore`, deci notițele personale nu ajung pe GitHub.

## Cum se rulează
1. Clonați repository-ul (aveți nevoie de acces, repository-ul este privat):
   ```
   git clone https://github.com/utilizator/Jurnal-Personal.git
   ```
2. Intrați în folder: `cd Jurnal-Personal`
3. Rulați comanda: `dotnet run`

Este nevoie de .NET SDK 8.0 sau mai nou.

## Autor
Cernopolc Adriana, grupa C-P-253-11
