using System;

public class Menu
{
    private ServicioUsuarios servicioUsuarios;
    private ServicioAutenticacion servicioAuth;
    private ServicioProductos servicioProductos;

    public Menu(ServicioUsuarios su, ServicioAutenticacion sa, ServicioProductos sp)
    {
        servicioUsuarios = su;
        servicioAuth = sa;
        servicioProductos = sp;
    }

    public void Mostrar()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== PUNTO DE VENTA ===");
            Console.WriteLine("1. Crear usuario");
            Console.WriteLine("2. Iniciar sesión");
            Console.WriteLine("3. Agregar producto");
            Console.WriteLine("4. Ver productos");
            Console.WriteLine("5. Salir");
            Console.Write("\nOpción: ");

            int.TryParse(Console.ReadLine(), out opcion);

            switch (opcion)
            {
                case 1:
                    servicioUsuarios.CrearUsuario();
                    break;

                case 2:
                    servicioAuth.IniciarSesion();
                    break;

                case 3:
                    servicioProductos.AgregarProducto();
                    break;

                case 4:
                    servicioProductos.VerProductos();
                    break;
            }

        } while (opcion != 5);
    }
}