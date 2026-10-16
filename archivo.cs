using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "carlossandoval.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("Valeria Ruiz,19,92");
            sw.WriteLine("Santiago Ortiz,20,88");
            sw.WriteLine("Carlos,19,90");
            sw.WriteLine("Daniela Gomez,21,85");
        }
        Console.WriteLine("Archivo creado exitosamente.");
    }
}
