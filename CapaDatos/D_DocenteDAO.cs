﻿using CapaEntidades.Cache;
using CapaEntidades.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class D_DocenteDAO : Conexion
    {
        public void insertarAlumno(E_PERSONA persona)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_INSERTAR_PERSONA_ADM_DOC";
                    comand.Parameters.AddWithValue("@PE_NOMBRE", persona.pE_NOMBRE);
                    comand.Parameters.AddWithValue("@PE_APELLIDOPAT", persona.pE_APELLIDOPAT);
                    comand.Parameters.AddWithValue("@PE_APELLIDOMAT", persona.pE_APELLIDOMAT);
                    comand.Parameters.AddWithValue("@PE_IDENTIFICACION", persona.pE_IDENTIFICACION);
                    comand.Parameters.AddWithValue("@PE_FECHANAC", Convert.ToDateTime(persona.pE_FECHANAC));
                    comand.Parameters.AddWithValue("@PE_TELEFONO", persona.pE_TELEFONO);
                    comand.Parameters.AddWithValue("@PE_DIRECCION", persona.pE_DIRECCION);
                    comand.Parameters.AddWithValue("@PE_SEXO", persona.pE_SEXO);
                    comand.Parameters.AddWithValue("@PE_ESTADO", persona.pE_ESTADO);
                    comand.Parameters.AddWithValue("@IDUSURIO", 2);                    

                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
        }

        public List<E_PERSONA> listarAlumnos()
        {
            List<E_PERSONA> Lista = new List<E_PERSONA>();
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_MOSTRAR_DOCENTE";
                    comand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader dr = comand.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            E_PERSONA alumno = new E_PERSONA();
                            alumno.pE_IDPERSONA = Convert.ToInt32(dr["ID"]);
                            alumno.pE_NOMBRE = dr["NOMBRE"].ToString();
                            alumno.pE_APELLIDOPAT = dr["APELLIDO PAT"].ToString();
                            alumno.pE_APELLIDOMAT = dr["APELLIDO MAT"].ToString();
                            alumno.pE_IDENTIFICACION = dr["IDENTIFICACION"].ToString();
                            alumno.pE_FECHANAC = dr["FECHA NAC"].ToString();
                            alumno.pE_TELEFONO = dr["TELEFONO"].ToString();
                            alumno.pE_DIRECCION = dr["DIRECCION"].ToString();

                            Lista.Add(alumno);
                        }

                    }

                }
            }
            return Lista;
        }

        public void actualizarAlumno(E_PERSONA persona)
        {

            using (var conexion = GetConnection())
            {

                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_EDITAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_IDPERSONA", persona.pE_IDPERSONA);
                    comand.Parameters.AddWithValue("@PE_NOMBRE", persona.pE_NOMBRE);
                    comand.Parameters.AddWithValue("@PE_APELLIDOPAT", persona.pE_APELLIDOPAT);
                    comand.Parameters.AddWithValue("@PE_APELLIDOMAT", persona.pE_APELLIDOMAT);
                    comand.Parameters.AddWithValue("@PE_IDENTIFICACION", persona.pE_IDENTIFICACION);
                    comand.Parameters.AddWithValue("@PE_FECHANAC", Convert.ToDateTime(persona.pE_FECHANAC));
                    comand.Parameters.AddWithValue("@PE_TELEFONO", persona.pE_TELEFONO);
                    comand.Parameters.AddWithValue("@PE_DIRECCION", persona.pE_DIRECCION);
                    comand.Parameters.AddWithValue("@PE_ESTADO", persona.pE_ESTADO);



                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }
            
        }

        public void eliminarAlumno(E_PERSONA persona)
        {

            using (var conexion = GetConnection())
            {

                conexion.Open();
                using (var comand = new SqlCommand())
                {
                    comand.Connection = conexion;
                    comand.CommandText = "SP_ELIMINAR_PERSONA";
                    comand.Parameters.AddWithValue("@PE_IDPERSONA", persona.pE_IDPERSONA);

                    comand.CommandType = CommandType.StoredProcedure;
                    comand.ExecuteNonQuery();
                }
            }

        }
    }
}
