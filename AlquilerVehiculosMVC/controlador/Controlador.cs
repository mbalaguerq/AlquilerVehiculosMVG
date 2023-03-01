using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//para que el controlador pueda acceder a las carpetas hay que añadir el using y las carpetas
using AlquilerVehiculosMVC.vista;
using AlquilerVehiculosMVC.modelo;
using System.Collections;
using System.Runtime.CompilerServices;

namespace AlquilerVehiculosMVC.controlador
{
    internal class Controlador
    {
        Datos datos;
        View vista;

        public Controlador(Datos datos, View vista)
        {
            this.datos = datos;
            this.vista = vista;
        }
        public Controlador()
        {
            datos = new Datos();
            vista = new View();
        }
        public void gestionMenu()
        {
            bool salir = false;
            string opcion;

            Hashtable clienteHash;
            do
            {
                opcion = vista.vistaMenu();
                switch (opcion)
                {
                    case "1":

                        altaVehiculo();

                        break;
                    case "2":
                        clienteHash = ClienteView.hCliente();
                        datos.addCliente(clienteHash);
                        break;
                    case "3":
                        mostrarClientes();
                        break;



                    case "0":
                        salir = true;
                        break;
                }

            } while (!salir);



        }
        private void altaVehiculo()
        {
            int tipoVehiculo;
            Hashtable vehiculoHash;
            //Estamos accediendo a la clase sin hacer el new pq la clase es public static.
            //Esto se puede hacer cuando no hay que crear objetos de esta clase. 
            tipoVehiculo = VehiculosView.seleccionarTipoVehiculo();
            switch (tipoVehiculo)
            {
                case 1:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addCoche(vehiculoHash);
                    break;

                case 2:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addMoto(vehiculoHash);
                    break;

                case 3:
                    vehiculoHash = VehiculosView.addVehiculo(tipoVehiculo);
                    datos.addCamion(vehiculoHash);
                    break;
            }
        }

        private void mostrarClientes()
        {
            List<string> listaClientes = datos.listaClientes();
            ClienteView.mostrarClientes(listaClientes);

            ClienteView.mostrarClientes(datos.listaClientes());
        }
    }
}

