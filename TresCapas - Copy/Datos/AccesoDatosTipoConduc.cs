using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatosTipoConduc
    {
        public int Insert(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoConducCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@id", idtipo);
            _comando.Parameters.AddWithValue("@nombre", nombretipo); 
            return TipoConducCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerTiposConduc()
        {
            SqlCommand _comando = TipoConducCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM tipo_conductor";
            return TipoConducCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateTipoConduc(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoConducCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("@id", idtipo);
            _comando.Parameters.AddWithValue("@nombre", nombretipo);

            return TipoConducCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteTipoConduc(int idtipo)
        {
            SqlCommand _comando = TipoConducCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("@id", idtipo);

            return TipoConducCRUD.EjecutaromandoDelete(_comando);
        }

    }
}
