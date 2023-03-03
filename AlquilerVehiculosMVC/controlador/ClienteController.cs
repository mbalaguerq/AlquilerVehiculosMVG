using AlquilerVehiculosMVC.modelo;
using AlquilerVehiculosMVC.vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.controlador
{
    internal class ClienteController
    {
        Datos datos;
        ClienteView clienteView;

        public ClienteController(Datos pDatos)
        {
            // no hacemos un new datos , sino que recibimos el objeto datos
            // porr parametro con sus List/arraylist llenos de datos
            datos = pDatos;
        }

        public void altaCliente()
        {
            // llamamos al método altaCliente de la vista de clientes y
            // le enviamos (con this) el objeto de este controlador,
            // es decir clienteControler
            Hashtable clienteHash = clienteView.altaCliente(this);
            datos.addCliente(clienteHash);
        }
        public string getNombre(string nif)
        {
            
string nombre=datos.get
        }
    }
}

