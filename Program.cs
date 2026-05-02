using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<Producto> productos = new List<Producto>();

        ServicioUsuarios servicioUsuarios = new ServicioUsuarios(usuarios);
        ServicioAutenticacion servicioAuth = new ServicioAutenticacion(usuarios);
        ServicioProductos servicioProductos = new ServicioProductos(productos);

        Menu menu = new Menu(servicioUsuarios, servicioAuth, servicioProductos);

        menu.Mostrar();
    }
}