﻿using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades.Cache;

namespace CapaDatos
{
    public class D_PersonaDAO : Conexion
    {

        public E_PERSONA perfilPersona()
        {
            E_PERSONA persona = new E_PERSONA();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_MOSTRAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_IDPERSONA", UsuarioLoginCache.PE_IDPERSONA);
                    comand.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        persona.pE_NOMBRE = reader.GetString(0);
                        persona.pE_APELLIDOPAT = reader.GetString(1);
                        persona.pE_APELLIDOMAT = reader.GetString(2);
                        persona.pE_IDENTIFICACION = reader.GetString(3);
                        persona.pE_FECHANAC = reader.GetDateTime(4) + "";
                        persona.pE_TELEFONO = reader.GetString(5);
                        persona.pE_DIRECCION = reader.GetString(6);
                    }
                    return persona;

                }
            }
        }    

    }
}
