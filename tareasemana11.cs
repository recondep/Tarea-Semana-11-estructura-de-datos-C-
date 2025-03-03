using System;
using System.Collections.Generic;

class Traductor
{
    static void Main(string[] args)
    {
        // Diccionario inicial con traducciones de inglés a español
        Dictionary<string, string> diccionario = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"time", "tiempo"},
            {"person", "persona"},
            {"year", "año"},
            {"way", "camino"},
            {"day", "día"},
            {"thing", "cosa"},
            {"man", "hombre"},
            {"world", "mundo"},
            {"life", "vida"},
            {"hand", "mano"},
            {"company", "empresa"}
        };

        while (true)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("************ TRADUCTOR INGLÉS-ESPAÑOL *********");
            Console.WriteLine("================================================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Agregar palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la frase: ");
                    string entrada = Console.ReadLine();
                    string[] palabrasEntrada = entrada.Split(' ');
                    string resultado = "";

                    // Traducción palabra por palabra
                    foreach (string palabra in palabrasEntrada)
                    {
                        string palabraMinuscula = palabra.ToLower();
                        if (diccionario.ContainsKey(palabraMinuscula))
                        {
                            resultado += diccionario[palabraMinuscula] + " ";
                        }
                        else
                        {
                            resultado += palabra + " "; // Conservar palabra original
                        }
                    }
                    Console.WriteLine($"Frase traducida: {resultado.Trim()}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Ingrese la palabra en inglés: ");
                    string nuevaPalabraIng = Console.ReadLine().ToLower();
                    Console.Write("Ingrese la traducción en español: ");
                    string nuevaPalabraEsp = Console.ReadLine().ToLower();

                    if (!diccionario.ContainsKey(nuevaPalabraIng))
                    {
                        diccionario.Add(nuevaPalabraIng, nuevaPalabraEsp);
                        Console.WriteLine("Palabra añadida al diccionario.");
                    }
                    else
                    {
                        Console.WriteLine("La palabra ya existe en el diccionario.");
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
              
       
        
