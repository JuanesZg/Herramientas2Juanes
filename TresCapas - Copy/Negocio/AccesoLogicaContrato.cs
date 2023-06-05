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
    public class AccesoLogicaContrato
    {
        public int Insert(int idcontrato, int idvehi, int idcondu)
        {
            AccesoDatosContrato acceso = new AccesoDatosContrato();
            return acceso.Insert(idcontrato, idvehi, idcondu);
        }

        public static DataTable ObtenerContrato()
        {
            return AccesoDatosContrato.ObtenerContrato();
        }

        public int Update(int idcontrato, int idvehi, int idcondu)
        {
            AccesoDatosContrato acceso = new AccesoDatosContrato();
            return acceso.updateContrato(idcontrato, idvehi, idcondu);
        }
        public int delete(int idcontrato)
        {
            AccesoDatosContrato acceso = new AccesoDatosContrato();
            return acceso.deleteContrato(idcontrato);
        }

    }
}
