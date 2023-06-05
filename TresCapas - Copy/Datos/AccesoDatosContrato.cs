using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatosContrato
    {
        public int Insert(int idcontrato, int idvehi, int idcondu)
        {
            SqlCommand _comando = ContratoCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@id", idcontrato);
            _comando.Parameters.AddWithValue("@idvehi", idvehi);
            _comando.Parameters.AddWithValue("@idcondu", idcondu);
            return ContratoCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerContrato()
        {
            SqlCommand _comando = ContratoCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM contrato";
            return ContratoCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateContrato(int idcontrato, int idvehi, int idcondu)
        {
            SqlCommand _comando = ContratoCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("@id", idcontrato);
            _comando.Parameters.AddWithValue("@idvehi", idvehi);
            _comando.Parameters.AddWithValue("@idcondu", idcondu);
            return ContratoCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteContrato(int idcontrato)
        {
            SqlCommand _comando = ContratoCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("@id", idcontrato);
            return ContratoCRUD.EjecutaromandoDelete(_comando);
        }

    }
}
