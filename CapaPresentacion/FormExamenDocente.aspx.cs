using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class FormExamenDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarExamen();
        }

        public void cargarExamen()
        {
            List<E_EXAMEN> Lista = null;
            N_Examen n_examen = new N_Examen();

            Lista = n_examen.listarExamen();

            int c = 0;
            foreach (E_EXAMEN aPart in Lista)
            {
                if (c == 0)
                {
                    
                } else
                {

                }
                c++;
            }
        }
    }
}