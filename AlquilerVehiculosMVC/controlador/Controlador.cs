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
                        clienteHash = ClienteView.altaCliente();
                        datos.addCliente(clienteHash);
                        break;
                    case "4":
                        mostrarClientes();
                        break;
                    case "3":
                        mostrarVehiculos();
                        break;
                    case "5":
                        mostrarVehByTipo();
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
        private void altaCliente()
        {
            // 1) derivar la logica/control a un controlador especifico de clientes
            // no podemos hacer un new datos ya que perderiamos todos los datos
            // por lo tanto hay que enviar por parámetro el objeto datos al nuevo
            // controlador
            ClienteController clienteController = new ClienteController(datos);
            clienteController.altaCliente();
        }
        private void mostrarClientes()
        {
            List<string> listaClientes = datos.listaClientes();
            ClienteView.mostrarClientes(listaClientes);

            //
            //ClienteView.mostrarClientes(datos.listaClientes());
        }
        private void mostrarVehiculos()
        {            
            List<string> listaVehiculos= datos.listaVehiculos();
            VehiculosView.mostrarVehiculos(listaVehiculos,4);
            //VehiculosView.mostrarVehiculo(datos.listaVehiculos());
        }
        private void mostrarVehByTipo()
        {
            int tipovehiculo;
            tipovehiculo=VehiculosView.seleccionarTipoVehiculo();
            List<string> listaveh = datos.listaVehByTipo(tipovehiculo);
            VehiculosView.mostrarVehiculos(listaveh, tipovehiculo);
            //VehiculosView.mostrarVehiculo(datos.listaVehiculos());
        }
    }
}

