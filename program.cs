using System;
using System.IO;

class Program
{
    static void Main()
    {
        string ruta = "C:\\Users\\SALA-1\\Desktop\\carlos\\productos.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio");
            sw.WriteLine("1,sara blonder,1200");
            sw.WriteLine("2,Mouse Logitech,25");
            sw.WriteLine("3,Monitor esperanza gomez,300");
            sw.WriteLine("4,Silla Gamer RGB,150");
            sw.WriteLine("5,Laptop hp Gamer,1200");
            sw.WriteLine("6,Mouse ,25");
            sw.WriteLine("7,Monitor Samsung Curvo,300");
            sw.WriteLine("8,pc Gamer RGB,150");
            sw.WriteLine("9,Laptop Dell Gamer,1200");
            sw.WriteLine("10,Mouse Logitech,25");
            sw.WriteLine("11,Monitor Samsung,300");
            sw.WriteLine("12,miakhalifa RGB,150");
        }

        Console.WriteLine("Reporte de Carlos - 19 años - Productos > 100:");
        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double precio = double.Parse(campos[2]);
            if (precio > 100)
            {
                Console.WriteLine($"{campos[1]} - ${precio}");
            }
        }
    }
}
