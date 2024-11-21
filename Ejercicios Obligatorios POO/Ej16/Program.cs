using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menus = new Dictionary<string, string[]>
           {
               { " DDL ", new[] { "Listar contactos", "Buscar contacto", "Agenda llena", "Huecos libres" ,"Salir" } },
               { " DML " , new[] { "Agregar contacto", "Eliminar contacto", "Salir" } },
           };

            var menuPrincipal = new MenuPrincipal(menus);

            List<Contacto> contactos = new List<Contacto>();
            Agenda agenda = new Agenda(contactos, 10);

            foreach (var subMenu in menus)
            {
                foreach (var opcion in subMenu.Value)
                {
                    if (opcion == "Salir")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine("Saliendo del programa...");
                            Environment.Exit(0);
                        });
                    }
                    else if(opcion == "Listar contactos")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            agenda.ListarContactos();
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Agregar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.Write("Ingrese el nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el teléfono: ");
                            int telefono = int.Parse(Console.ReadLine());
                            agenda.AgregarContacto(new Contacto(nombre, telefono));
                            Console.WriteLine($"La operación fue realizada con éxito.");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Eliminar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.Write("Ingrese el nombre del contacto que quiera eliminar: ");
                            string nombre = Console.ReadLine();
                            agenda.EliminarContacto(nombre);
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Agenda llena")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            if (!agenda.AgendaLlena())
                            {
                                Console.WriteLine("La agenda no está llena.");
                            }
                            else
                            {
                                Console.WriteLine("La agenda está llena");
                            }
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Buscar contacto")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            Console.Write("Ingrese el nombre a buscar: ");
                            string nombre = Console.ReadLine();
                            agenda.BuscaContacto(nombre);
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                    else if (opcion == "Huecos libres")
                    {
                        menuPrincipal.AsignarAccion(opcion, () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Ejecutando {opcion}");
                            agenda.HuecosLibres();
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        });
                    }
                }
            }

            var menuNavigator = new MenuNavegacion(menuPrincipal);
            menuNavigator.Iniciar();
        }
    }
}
