using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades.DTO;

namespace CapaNegocio
{
    public class N_Docente
    {
        D_DocenteDAO alumnoDAO = new D_DocenteDAO();
        public void insertarAlumno(E_PERSONA persona)
        {
            alumnoDAO.insertarAlumno(persona);
        }

        public List<E_PERSONA> listarAlumnos()
        {
            return alumnoDAO.listarAlumnos();
        }

        public void actualizarAlumno(E_PERSONA persona)
        {
            alumnoDAO.actualizarAlumno(persona);
        }

        public void eliminarAlumno(E_PERSONA persona)
        {
            alumnoDAO.eliminarAlumno(persona);
        }
    }
}
