using System;

class Program
{
    static void Main()
    {
        const int diakSzam = 5;
        string[] diakNevek = new string[diakSzam];
        int[] pontszamok = new int[diakSzam];

        for (int i = 0; i < diakSzam; i++)
        {
            Console.Write($"Kérem, adja meg a {i + 1}. diák nevét: ");
            diakNevek[i] = Console.ReadLine();

            Console.Write($"Kérem, adja meg a(z) {diakNevek[i]} pontszámát: ");
            pontszamok[i] = int.Parse(Console.ReadLine());
        }

       
        double atlag = 0;
        int legmagasabb = pontszamok[0];
        int legalacsonyabb = pontszamok[0];
        string legmagasabbDiak = diakNevek[0];
        string legalacsonyabbDiak = diakNevek[0];

        for (int i = 0; i < diakSzam; i++)
        {
            atlag += pontszamok[i];

            if (pontszamok[i] > legmagasabb)
            {
                legmagasabb = pontszamok[i];
                legmagasabbDiak = diakNevek[i];
            }
            if (pontszamok[i] < legalacsonyabb)
            {
                legalacsonyabb = pontszamok[i];
                legalacsonyabbDiak = diakNevek[i];
            }
        }

        atlag /= diakSzam; 

       
        Console.WriteLine($"\nÁtlagpontszám: {atlag:F2}");
        Console.WriteLine($"Legmagasabb pontszám: {legmagasabb} (Diák: {legmagasabbDiak})");
        Console.WriteLine($"Legalacsonyabb pontszám: {legalacsonyabb} (Diák: {legalacsonyabbDiak})");

        
        foreach (var pontszam in pontszamok)
        {
            if (pontszam < 50)
            {
                Console.WriteLine("Van elégtelen pontszám!");
                break;
            }
        }
    }
}
