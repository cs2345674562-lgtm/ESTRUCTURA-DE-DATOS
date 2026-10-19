using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = string ruta = "C:\\Users\\SALA-1\\Desktop\\Nueva carpeta\\carlos.csv"

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Codigo,Producto,Talla,Cantidad");
            sw.WriteLine("CAM-01,Camisa Polo,M,15");
            sw.WriteLine("JEA-02,Jean Slim Fit,L,6");
            sw.WriteLine("CHA-03,Chaqueta Cuero,S,4");
            sw.WriteLine("ZAP-04,Zapatos Deportivos,41,20");
        }

        // 2. Lectura y filtrado de productos con cantidad menor a 10
        if (File.Exists(ruta))
        {
            string[] lineas = File.ReadAllLines(ruta);

            Console.WriteLine("--- PRODUCTOS CON STOCK MENOR A 10 ---");

            // Empezamos en i = 1 para saltar el encabezado
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                int cantidad = int.Parse(campos[3]);

                if (cantidad < 10)
                {
                    Console.WriteLine($"Producto: {campos[1]} ({campos[2]}) | Stock actual: {cantidad}");
                }
            }
        }
        else
        {
            Console.WriteLine("El archivo no pudo ser encontrado.");
        }
    }
}
