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
    public class AccesoLogicaTipoConduc
    {
        public int Insert(int idtipo, string nombretipo)
        {
            AccesoDatosTipoConduc acceso = new AccesoDatosTipoConduc();
            return acceso.Insert(idtipo, nombretipo);
        }

        public static DataTable ObtenerTiposConduc()
        {
            return AccesoDatosTipoConduc.ObtenerTiposConduc();
        }

        public int Update(int idtipo, string nombretipo)
        {
            AccesoDatosTipoConduc acceso = new AccesoDatosTipoConduc();
            return acceso.updateTipoConduc(idtipo, nombretipo);
        }
        public int delete(int idtipo)
        {
            AccesoDatosTipoConduc acceso = new AccesoDatosTipoConduc();
            return acceso.deleteTipoConduc(idtipo);
        }

    }
}
