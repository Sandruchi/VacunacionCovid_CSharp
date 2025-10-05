using System;
using System.Collections.Generic;

class VacunacionCovid
{
    static void Main()
    {
        // Generar 500 ciudadanos ficticios
        HashSet<string> todosCiudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            todosCiudadanos.Add("Ciudadano " + i);
        }

        // Generar 75 vacunados con Pfizer
        HashSet<string> vacunadosPfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            vacunadosPfizer.Add("Ciudadano " + i);
        }

        // Generar 75 vacunados con AstraZeneca
        HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++)
        {
            vacunadosAstraZeneca.Add("Ciudadano " + i);
        }

        // Ciudadanos vacunados con ambas dosis (intersección)
        HashSet<string> ambasDosis = new HashSet<string>(vacunadosPfizer);
        ambasDosis.IntersectWith(vacunadosAstraZeneca);

        // Ciudadanos solo con Pfizer (diferencia)
        HashSet<string> soloPfizer = new HashSet<string>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos solo con AstraZeneca (diferencia)
        HashSet<string> soloAstraZeneca = new HashSet<string>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Ciudadanos no vacunados (diferencia)
        HashSet<string> vacunadosTotales = new HashSet<string>(vacunadosPfizer);
        vacunadosTotales.UnionWith(vacunadosAstraZeneca);
        HashSet<string> noVacunados = new HashSet<string>(todosCiudadanos);
        noVacunados.ExceptWith(vacunadosTotales);

        // Mostrar resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        foreach (var c in noVacunados) Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos con ambas dosis: " + ambasDosis.Count);
        foreach (var c in ambasDosis) Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos solo con Pfizer: " + soloPfizer.Count);
        foreach (var c in soloPfizer) Console.WriteLine(c);

        Console.WriteLine("\nCiudadanos solo con AstraZeneca: " + soloAstraZeneca.Count);
        foreach (var c in soloAstraZeneca) Console.WriteLine(c);
    }
}
