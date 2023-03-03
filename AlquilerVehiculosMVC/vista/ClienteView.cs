using AlquilerVehiculosMVC.controlador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal  class ClienteView
    {
        public Hashtable altaCliente(ClienteController cliController)
        {
            // recibimos por parametro el objeto del controlador ClienteController

            Hashtable clienteHash = new Hashtable();
            Console.Write("Nif: ");
            string nif = Console.ReadLine();

            // para comprobar si el cliente ya existe
            // llamamos al método getNombre que está en el contolador ClienteControler
            // y le enviamos el nif com parámwtro

            string nombre = cliController.getNombre(nif);
            if (!nombre.Equals(""))
            {
                // si el método getNombre nos devuelve un valor distinto de "" es que ya existe
                Console.WriteLine("El cliente con nif " + nif + " ya extiste con nombre: " + nombre);
                return null;
            }
            else
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                clienteHash.Add("Nif", nif);
                clienteHash.Add("Nombre", nombre);
                return clienteHash;
            }

        }
        public static void mostrarClientes(List<string> listaClientes)
        {
            Console.WriteLine("Nif     \tNombre");

            foreach(string clienteString in listaClientes)
            { 
                Console.WriteLine(clienteString); 
            }
        }
       
    }
}
