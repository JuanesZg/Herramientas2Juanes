using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Datos
{
    public class AccesoDatosVehiculo
    {
        public int Insert(int idvehi, string marca, string modelo, string matricula, int anio, int tipovehi)
        {
            SqlCommand _comando = VehiculoCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@id", idvehi);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@tipovehiculo", tipovehi);
            return VehiculoCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerVehiculo()
        {
            SqlCommand _comando = VehiculoCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM vehiculo";
            return VehiculoCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateVehiculo(int idvehi, string marca, string modelo, string matricula, int anio, int tipovehi)
        {
            SqlCommand _comando = VehiculoCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("@id", idvehi);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@modelo", modelo);
            _comando.Parameters.AddWithValue("@matricula", matricula);
            _comando.Parameters.AddWithValue("@anio", anio);
            _comando.Parameters.AddWithValue("@tipovehiculo", tipovehi);
            return VehiculoCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteVehiculo(int idvehi)
        {
            SqlCommand _comando = VehiculoCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("@id", idvehi);

            return VehiculoCRUD.EjecutaromandoDelete(_comando);
        }

    }
}