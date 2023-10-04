using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionTareas
{
    public abstract class clsValidacion
    {   //
        /// <summary>
        /// Este método válida los campos de los textbox del formulario y verifica si
        /// están nulos o vacios, de ser asi no permite guardar los datos, de lo contrario
        /// si están todos diligenciados, permite guardar los datos en la BD.
        /// </summary>
        /// <param name="titulo" value="Examen de Ingles">Corresponde al titulo de la tarea</param>
        /// <param name="descripcion" value="Speaking, Writing, Listening">Corresponde a la descripcion de la tarea</param>
        /// <param name="prioridad" value="Alta">Corresponde a la prioridad de la tarea</param>
        /// <param name="estado" value="Activa">Corresponde al estado de la tarea</param>
        /// <returns>!string.IsNullOrEmpty(titulo) &&
        ///  !string.IsNullOrEmpty(descripcion) &&
        ///  !string.IsNullOrEmpty(prioridad) &&
        ///  !string.IsNullOrEmpty(estado) = true</returns>
        /// 

        public static bool validarCampos(string titulo, string descripcion, string prioridad, string estado)
        {
            return !string.IsNullOrEmpty(titulo) &&
            !string.IsNullOrEmpty(descripcion) &&
            !string.IsNullOrEmpty(prioridad) &&
            !string.IsNullOrEmpty(estado);
        }
    }
}
