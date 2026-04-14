Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

class EulerGraph
{
    static void Main()
    {
        // 1. Definiramo graf pomoću liste susjedstva
        // Ključ je čvor, a lista su susjedni čvorovi
        var graph = new Dictionary<int, List<int>>()
        {
            { 1, new List<int> { 2, 3 } },
            { 2, new List<int> { 1, 3, 4, 5 } },
            { 3, new List<int> { 1, 2, 4, 5 } },
            { 4, new List<int> { 2, 3 } },
            { 5, new List<int> { 2, 3 } }
        };

        Console.WriteLine("--- Pr0vjera Eulerovog Grafa ---");

        // 2. Logika: Prebroji čvorove s neparnim brojem veza
        int oddDegreeNodes = 0;
        foreach (var node in graph)
        {
            int degree = node.Value.Count;
            Console.WriteLine($"Čvor {node.Key} ima degree: {degree}");

            if (degree % 2 != 0) oddDegreeNodes++;
        }

        // 3. Zaključak
        Console.WriteLine("\nREZULTAT:");
        if (oddDegreeNodes == 0)
            Console.WriteLine("Graf ima Eulerov krug (savršen je!).");
        else if (oddDegreeNodes == 2)
            Console.WriteLine("Graf ima Eulerov put (može se nacrtati u jednom potezu).");
        else
            Console.WriteLine("Graf nije Eulerov.");

        Console.ReadKey();
        Console.WriteLine("Test nove grane");
    }
}