using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Negocio
{
    public class AccesoLogicaVehiculo
    {
        public int Insert(int idvehi, string marca, string modelo, string matricula, int anio, int tipovehi)
        {
            AccesoDatosVehiculo acceso = new AccesoDatosVehiculo();
            return acceso.Insert(idvehi, marca, modelo, matricula, anio, tipovehi);
        }

        public static DataTable ObtenerVehiculo()
        {
            return AccesoDatosVehiculo.ObtenerVehiculo();
        }

        public int Update(int idvehi, string marca, string modelo, string matricula, int anio, int tipovehi)
        {
            AccesoDatosVehiculo acceso = new AccesoDatosVehiculo();
            return acceso.updateVehiculo(idvehi, marca, modelo, matricula, anio, tipovehi);
        }
        public int delete(int idvehi)
        {
            AccesoDatosVehiculo acceso = new AccesoDatosVehiculo();
            return acceso.deleteVehiculo(idvehi);
        }

    }
}
