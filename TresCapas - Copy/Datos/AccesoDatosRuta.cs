using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatosRuta
    {
        public int Insert(int idruta, string estacion, int vehiculo)
        {
            SqlCommand _comando = RutaCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@id", idruta);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@vehiculo", vehiculo);
            return RutaCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerRuta()
        {
            SqlCommand _comando = RutaCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM ruta";
            return RutaCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateRuta(int idruta, string estacion, int vehiculo)
        {
            SqlCommand _comando = RutaCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("@id", idruta);
            _comando.Parameters.AddWithValue("@estacion", estacion);
            _comando.Parameters.AddWithValue("@vehiculo", vehiculo);
            return RutaCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteRuta(int idruta)
        {
            SqlCommand _comando = RutaCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("@id", idruta);
            return RutaCRUD.EjecutaromandoDelete(_comando);
        }

    }
}
