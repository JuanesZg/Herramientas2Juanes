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
    public class AccesoLogicaTipoVehi
    {
        public int Insert(int idtipo, string nombretipo)
        {
            AccesoDatosTipoVehi acceso = new AccesoDatosTipoVehi();
            return acceso.Insert(idtipo, nombretipo);
        }

        public static DataTable ObtenerTiposVehiculo()
        {
            return AccesoDatosTipoVehi.ObtenerTiposVehiculo();
        }

        public int Update(int idtipo, string nombretipo)
        {
            AccesoDatosTipoVehi acceso = new AccesoDatosTipoVehi();
            return acceso.updateTipoVehi(idtipo, nombretipo);
        }
        public int delete(int idtipo)
        {
            AccesoDatosTipoVehi acceso = new AccesoDatosTipoVehi();
            return acceso.deleteTipoVehi(idtipo);
        }

    }
}
