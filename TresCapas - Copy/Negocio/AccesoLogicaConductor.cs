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
    public class AccesoLogicaConductor
    {
        public int Insert(int idcondu, string nombre, string tipolicencia, int idvehi, int idtipocondu)
        {
            AccesoDatosConductor acceso = new AccesoDatosConductor();
            return acceso.Insert(idcondu, nombre, tipolicencia, idvehi, idtipocondu);
        }

        public static DataTable ObtenerConductor()
        {
            return AccesoDatosConductor.ObtenerConductor();
        }

        public int Update(int idcondu, string nombre, string tipolicencia, int idvehi, int idtipocondu)
        {
            AccesoDatosConductor acceso = new AccesoDatosConductor();
            return acceso.updateConductor(idcondu, nombre, tipolicencia, idvehi, idtipocondu);
        }
        public int delete(int idcondu)
        {
            AccesoDatosConductor acceso = new AccesoDatosConductor();
            return acceso.deleteConductor(idcondu);
        }

    }
}
