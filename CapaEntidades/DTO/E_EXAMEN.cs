using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.DTO
{
    public class E_EXAMEN
    {
        private int EX_IDEXAMEN;
        private String PREGUNTA;
        private String RESPUESTA;

        public int eX_IDEXAMEN { get => EX_IDEXAMEN; set => EX_IDEXAMEN = value; }
        public string pREGUNTA { get => PREGUNTA; set => PREGUNTA = value; }
        public string rESPUESTA { get => RESPUESTA; set => RESPUESTA = value; }
    }
}
