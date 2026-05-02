using System;
using System.Collections.Generic;
using System.Linq;

public class ServicioAutenticacion
{
    private List<Usuario> usuarios;

    public ServicioAutenticacion(List<Usuario> usuarios)
    {
        this.usuarios = usuarios;
    }

    public void IniciarSesion()
    {
        Console.Clear();
        Console.WriteLine("=== INICIAR SESIÓN ===");

        Console.Write("Usuario: ");
        string nombre = Console.ReadLine();

        Console.Write("Contraseña: ");
        string contra = Console.ReadLine();

        var usuario = usuarios.FirstOrDefault(u =>
            u.NombreUsuario == nombre && u.Contrasena == contra);

        if (usuario != null)
        {
            Console.WriteLine("Inicio de sesión exitoso.");
        }
        else
        {
            Console.WriteLine("Datos incorrectos.");
        }

        Console.ReadLine();
    }
}