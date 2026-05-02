using System;
using System.Collections.Generic;
using System.Linq;

public class ServicioProductos
{
    private List<Producto> productos;

    public ServicioProductos(List<Producto> productos)
    {
        this.productos = productos;
    }

    public void AgregarProducto()
    {
        Console.Clear();
        Console.WriteLine("=== AGREGAR PRODUCTO ===");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Precio: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        Console.Write("Stock: ");
        int stock = int.Parse(Console.ReadLine());

        productos.Add(new Producto(nombre, precio, stock));

        Console.WriteLine("Producto agregado correctamente.");
        Console.ReadLine();
    }

    public void VerProductos()
    {
        Console.Clear();
        Console.WriteLine("=== LISTA DE PRODUCTOS ===");

        foreach (var p in productos)
        {
            Console.WriteLine($"{p.Nombre} - ${p.Precio} - Stock: {p.Stock}");
        }

        Console.ReadLine();
    }
}