﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Configuracion
    {
        static string cadenaConexion = @"Data Source=JUANESPC\SQLEXPRESS;Initial Catalog=Carros;Trusted_Connection=true";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }

    }
}
