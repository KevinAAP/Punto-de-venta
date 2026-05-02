using System;
using System.Collections.Generic;
using System.Linq;

public class ServicioUsuarios
{
    private List<Usuario> usuarios;

    public ServicioUsuarios(List<Usuario> usuarios)
    {
        this.usuarios = usuarios;
    }

    public void CrearUsuario()
    {
        Console.Clear();
        Console.WriteLine("=== CREAR USUARIO ===");

        Console.Write("Nombre de usuario: ");
        string nombre = Console.ReadLine();

        Console.Write("Contraseña: ");
        string contra = Console.ReadLine();

        if (usuarios.Any(u => u.NombreUsuario == nombre))
        {
            Console.WriteLine("El usuario ya existe.");
        }
        else
        {
            usuarios.Add(new Usuario(nombre, contra));
            Console.WriteLine("Usuario creado correctamente.");
        }

        Console.ReadLine();
    }
}