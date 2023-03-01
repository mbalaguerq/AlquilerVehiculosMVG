using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.modelo
//El namespace es nom projecte i nom carpeta
{
    internal class Moto : Vehiculo
    {
        private int cc;

        public int Cc { get => cc; set => cc = value; }

        public override string ToString()
        {
            return base.ToString() + " cc: " + cc;
        }
    }
}
