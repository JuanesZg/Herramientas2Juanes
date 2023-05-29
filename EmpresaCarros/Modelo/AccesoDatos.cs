using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Modelo
{
    public class AccesoDatos
    {
        public int Insert(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@Idtipo", idtipo);
            _comando.Parameters.AddWithValue("@Nombretipo", nombretipo);

            return TipoVehiCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable ObtenerTiposVehiculo()
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComando();
            _comando.CommandText = "SELECT * FROM Tipo_Vehiculo";
            return TipoVehiCRUD.EjecutarComandoSelect(_comando);
        }

        //Operacion Update
        public int updateTipoVehi(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("IdTipo", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipo", nombretipo);

            return TipoVehiCRUD.EjecutarcomandoUpdate(_comando);
        }
        //Operacion delete
        public int deleteTipoVehi(int idtipo)
        {
            SqlCommand _comando = TipoVehiCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("IdTipo", idtipo);

            return TipoVehiCRUD.EjecutaromandoDelete(_comando);
        }

    }
}
