﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public abstract class Conexion
    {
        private readonly string conexionString;

        public Conexion()
        {
            conexionString = "Server=(local); DataBase=EXAMEN_FINAL; integrated security=true; User ID=sa; Password=sa";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
