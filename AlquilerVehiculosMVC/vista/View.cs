﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.vista
{
    internal class View
    {

        public string vistaMenu()
        {
            string opcion;
            Console.WriteLine("1. Alta vehiculos");
            Console.WriteLine("2. Alta clientes");
            Console.WriteLine("4.Listar clientes");
            Console.WriteLine("3. Mostrar vehiculos");
            Console.WriteLine("5. Mostrar solo coches");
            Console.WriteLine("6. Eliminar vehiculo");
            Console.WriteLine("7. Alta contrato");
            Console.WriteLine("8. Listar contratos");
           
            Console.WriteLine("0. Salir");
            opcion = pedirOpcionMenu();
            return opcion;
        }

        private string pedirOpcionMenu()
        {
            string opcion;
            do
            {
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();
            } while (!"012345678".Contains(opcion));

            return opcion;

        }
    }
}