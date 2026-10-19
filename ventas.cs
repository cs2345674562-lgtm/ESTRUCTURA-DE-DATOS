using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "ventas.txt";

        if (!File.Exists(ruta))
        {
            File.WriteAllLines(ruta, new string[] {
                "Teclado Gamer: 14",
                "Mouse Inalámbrico: 25",
                "Silla Ergonómica: 8",
                "Audífonos Bluetooth: 32",
                "Monitor 24: 11"
            });
        }

        string[] lineas = File.ReadAllLines(ruta);
        
        int totalVentas = 0;
        int maxCantidad = -1;
        string productoMasVendido = "";

        // Recorrido secuencial línea por línea
        foreach (string linea in lineas)
        {
            if (string.IsNullOrWhiteSpace(linea)) continue;

            string[] campos = linea.Split(':');
            string producto = campos[0].Trim();
            int cantidad = int.Parse(campos[1].Trim());

            totalVentas += cantidad;

            if (cantidad > maxCantidad)
            {
                maxCantidad = cantidad;
                productoMasVendido = producto;
            }
        }

        Console.WriteLine($"--- REPORTE DE VENTAS ---");
        Console.WriteLine($"Total de unidades vendidas: {totalVentas}");
        Console.WriteLine($"Producto más vendido: {productoMasVendido} con {maxCantidad} unidades.");
    }
}
