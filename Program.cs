// Eine Übung aus einem Udemy Kurs um C# zu lernen.

using System;

namespace taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Einlesen der Summanten die Addiert werden sollen.

            Console.WriteLine("Bitte gib den ersten Summanden ein: ");
            string ersterSummant = Console.ReadLine();
            Console.WriteLine("Bitte gib den zweiten Summanden ein:");
            string zweiterSummant = Console.ReadLine();

            // Eingaben in Integer umwandeln

            int Zahl1 = Convert.ToInt32(ersterSummant);
            int Zahl2 = Convert.ToInt32(zweiterSummant);

            // Summe berechnen und ausgeben

            int ergebnis = Zahl1 + Zahl2;
            Console.WriteLine("Das Ergebis ist: " + ergebnis);
            Console.ReadLine();
        }
    }
}
