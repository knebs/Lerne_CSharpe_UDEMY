﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    /// <summary>
    /// Das ist eine Zusammenfassung für die Klasse
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //User Story: Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe zu berechnen.
            Console.Write("Bitte geben Sie den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte geben Sie den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            //Wandel Text in Ganzzahlen um
            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            //Berechnung ausführen
            int summe = ersterSummandAlsZahl + zweiterSummandAlsZahl;

            //Ausgabe
            Console.WriteLine("Die Summe ist " + summe);
            Console.ReadLine();
        }
    }
}
