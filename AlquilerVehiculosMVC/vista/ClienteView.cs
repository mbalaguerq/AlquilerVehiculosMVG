using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal static class ClienteView
    {
        public static Hashtable hCliente()
        {
            Hashtable clienteHash = new Hashtable();

            Console.Write("Nom: ");
            string nom = Console.ReadLine();
            Console.Write("Nif: ");
            string nif = Console.ReadLine();
            clienteHash.Add("Nom", nom);
            clienteHash.Add("Nif", nif);


        return clienteHash;
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
