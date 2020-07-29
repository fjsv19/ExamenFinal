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
    public class D_Examen : Conexion
    {
        public List<E_EXAMEN> listarExamen()
        {
            List<E_EXAMEN> Lista = new List<E_EXAMEN>();
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
                            E_EXAMEN examen = new E_EXAMEN();
                            examen.eX_IDEXAMEN = Convert.ToInt32(dr["EX_NOMBRE"]);
                            examen.rESPUESTA = dr["PR_PREGUNTA"].ToString();
                            examen.pREGUNTA = dr["RE_RESPUESTA"].ToString();

                            Lista.Add(examen);
                        }

                    }

                }
            }
            return Lista;
        }
    }
}
