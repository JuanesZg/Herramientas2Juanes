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
    public class AccesoDatosConductor
    {
        public int Insert(int idcondu, string nombre, string tipolicencia, int idvehi, int idtipocondu)
        {
            SqlCommand _comando = ConductorCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@id", idcondu);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipolicencia", tipolicencia);
            _comando.Parameters.AddWithValue("@idvehiculo", idvehi);
            _comando.Parameters.AddWithValue("@idtipocondu", idtipocondu);
            return ConductorCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerConductor()
        {
            SqlCommand _comando = ConductorCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM conductor";
            return ConductorCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateConductor(int idcondu, string nombre, string tipolicencia, int idvehi, int idtipocondu)
        {
            SqlCommand _comando = ConductorCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("@id", idcondu);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@tipolicencia", tipolicencia);
            _comando.Parameters.AddWithValue("@idvehiculo", idvehi);
            _comando.Parameters.AddWithValue("@idtipocondu", idtipocondu);
            return ConductorCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteConductor(int idcondu)
        {
            SqlCommand _comando = ConductorCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("@id", idcondu);

            return ConductorCRUD.EjecutaromandoDelete(_comando);
        }

    }
}