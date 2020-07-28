using CapaEntidades.DTO;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaPresentacion
{
    public partial class FormRegistrarDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtApePa.Text != "" || txtApeMa.Text != "" || txtNumDoc.Text != "" ||
                txtNaci.Text != "" || txtTelefono.Text != "" || txtDireccion.Text != "")
            {
                N_Docente n_alumno = new N_Docente();

                E_PERSONA e_persona = new E_PERSONA(txtNombre.Text, txtApePa.Text, txtApeMa.Text, txtNumDoc.Text, txtNaci.Text, txtTelefono.Text, txtDireccion.Text, txtSexo.Text, "A");

                n_alumno.insertarAlumno(e_persona);

                limpiarCampos();
            }
            else
            {
                Response.Write("<script>alert('INGRESE TODOS LOS CAMPOS')</script>");
            }
        }

        protected void btnCancelarAlumno_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApePa.Text = "";
            txtApeMa.Text = "";
            txtNumDoc.Text = "";
            txtNaci.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtSexo.Text = "";
        }


        [WebMethod]
        public static List<E_PERSONA> ListarAlumnos()
        {
            List<E_PERSONA> Lista = null;
            N_Docente n_alumno = new N_Docente();

            try
            {
                Lista = n_alumno.listarAlumnos();
            }
            catch
            {
                return null;
            }
            return Lista;
        }

        [WebMethod]
        public static void ActualizarAlumno(String id, String nom, String pat, String mat, String dni, String fecha, String tel, String direccion)
        {
            N_Docente n_alumno = new N_Docente();

            E_PERSONA e_persona = new E_PERSONA(Convert.ToInt32(id), nom, pat, mat, dni, fecha, tel, direccion, "A");

            n_alumno.actualizarAlumno(e_persona);

        }

        [WebMethod]
        public static void EliminarAlumno(String id)
        {
            N_Docente n_alumno = new N_Docente();

            E_PERSONA e_persona = new E_PERSONA(Convert.ToInt32(id));

            n_alumno.eliminarAlumno(e_persona);

        }
    }
}