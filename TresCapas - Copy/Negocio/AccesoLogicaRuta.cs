using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Negocio
{
    public class AccesoLogicaRuta
    {
        public int Insert(int idruta, string estacion, int vehiculo)
        {
            AccesoDatosRuta acceso = new AccesoDatosRuta();
            return acceso.Insert(idruta, estacion, vehiculo);
        }

        public static DataTable ObtenerRuta()
        {
            return AccesoDatosRuta.ObtenerRuta();
        }

        public int Update(int idruta, string estacion, int vehiculo)
        {
            AccesoDatosRuta acceso = new AccesoDatosRuta();
            return acceso.updateRuta(idruta, estacion, vehiculo);
        }
        public int delete(int idruta)
        {
            AccesoDatosRuta acceso = new AccesoDatosRuta();
            return acceso.deleteRuta(idruta);
        }

    }
}
