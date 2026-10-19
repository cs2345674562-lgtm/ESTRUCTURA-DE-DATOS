using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1\\Desktop\\Nueva carpeta\\carlos.csv"

        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);

            Console.WriteLine("--- VEHÍCULOS CON PRECIO MAYOR A $50,000,000 ---");

            // Iniciamos en i = 1 para omitir la fila de encabezados
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                double precio = double.Parse(campos[3]);

                if (precio > 50000000)
                {
                    Console.WriteLine($"Marca: {campos[1]} | Modelo: {campos[2]} | Precio: ${precio:N0}");
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo no existe.");
        }
    }
}
