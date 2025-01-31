using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("INPUT: ");
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Lütfen bir metin giriniz: ");
            return;
        }

        string[] kelimeler = input.Split(' ');

        foreach (string kelime in kelimeler)
        {
            bool sessizHarf = SessizHarfDurumu(kelime);
            Console.Write(sessizHarf + " ");
        }
    }

    static bool SessizHarfDurumu(string kelime)
    {
        string sesliHarfler = "aeıioöuüAEIİOÖUÜ";
        for (int i = 0; i < kelime.Length - 1; i++)
        {
            if (!sesliHarfler.Contains(kelime[i]) && !sesliHarfler.Contains(kelime[i + 1])) 
            {
                return true;
            }
        }
        return false;
    }
}