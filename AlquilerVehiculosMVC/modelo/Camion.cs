using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerVehiculosMVC.modelo
//El namespace es nom projecte i nom carpeta
{
    internal class Camion : Vehiculo
    {
        private int kg;

        public int Kg { get => kg; set => kg = value; }

        public override string ToString()
        {
            return base.ToString() + " kg: " + kg;
        }
    }
}
