using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades.DTO;

namespace CapaNegocio
{
    public class N_Examen
    {
        D_Examen examenDAO = new D_Examen();

        public List<E_EXAMEN> listarExamen()
        {
            return examenDAO.listarExamen();
        }
    }
}
