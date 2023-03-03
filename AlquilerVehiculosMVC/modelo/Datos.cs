using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.modelo
//El namespace es nom projecte i nom carpeta
{
    internal class Datos
    {
        List<Vehiculo> vehiculos;
        List<Cliente> clientes;
        public Datos()
        {
            vehiculos = new List<Vehiculo>();
            clientes = new List<Cliente>();
        }
        public void addCoche(Hashtable vehiculoHash)
        {
            Coche coche = new Coche();
            coche.Matricula = (string)vehiculoHash["Matricula"];
            coche.Marca = (string)vehiculoHash["Marca"];
            coche.Model = (string)vehiculoHash["Model"];
            coche.Puertas = (int)vehiculoHash["Puertas"];
            coche.Plazas = (int)vehiculoHash["Plazas"];
            vehiculos.Add(coche);
        }
        public void addMoto(Hashtable vehiculoHash)
        {
            Moto moto = new Moto();
            moto.Matricula = (string)vehiculoHash["Matricula"];
            moto.Marca = (string)vehiculoHash["Marca"];
            moto.Model = (string)vehiculoHash["Model"];
            moto.Cc = (int)vehiculoHash["cc"];

            vehiculos.Add(moto);
        }
        public void addCamion(Hashtable vehiculoHash)
        {
            Camion camion = new Camion();
            camion.Matricula = (string)vehiculoHash["Matricula"];
            camion.Marca = (string)vehiculoHash["Marca"];
            camion.Model = (string)vehiculoHash["Model"];
            camion.Kg = (int)vehiculoHash["kg"];

            vehiculos.Add(camion);
        }
        public void addCliente(Hashtable clienteHash)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = (string)clienteHash["Nom"];
            cliente.Nif = (string)clienteHash["Nif"];
            clientes.Add(cliente);
        }
        public List<string> listaClientes()
        {
            List<string> listaClientes = new List<string>();

            foreach (Cliente cliente in clientes)
            {
                listaClientes.Add(cliente.ToString());
            }
            return listaClientes;
        }
        public List<string> listaVehiculos()
        {
            List<string> listavehiculos = new List<string>();

            foreach (Vehiculo veh in vehiculos)
            {
                listavehiculos.Add(veh.Matricula + "\t" + veh.Marca + "\t" + veh.Model + "\t" + veh.GetType().Name);
            }
            return listavehiculos;
        }
        public List<string> listaVehByTipo(int tipo)
        {
            List<string> vehEncontrado = new List<string>();
            switch (tipo)
            {
                case 1:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Coche)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
                case 2:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Moto)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
                case 3:
                    foreach (Vehiculo veh in vehiculos)
                    {
                        if (veh is Camion)
                        {
                            vehEncontrado.Add(veh.ToString());
                        }
                    }
                    break;
            }
            return vehEncontrado;
        }
        public List<string> existNif()
        {
            List<string> cliEncontrado = new List<string>();
            foreach(Cliente c in clientes)
            {
                cliEncontrado.Add(c.ToString());
            }
            return cliEncontrado;
        }
    }
}
