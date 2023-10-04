using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wGestionTareas
{
    internal class clsTareas
    {
        public string strTitulo { get; set; }/*se utiliza get y set por si en el futuro se necesita agregar alguna lógica especial cuando
                                           * alguien establezca u obtenga el valor de la  variable (get (obtener) y set (establecer)*/
        public string strDescripcion { get; set; }
        public DateTime datVencimiento { get; set; }
        public string strPrioridad { get; set; }
        public string strEstado { get; set; }


        public 
            clsTareas(string strTitulo, string strDescripcion, DateTime datFechaVencimiento, string strPrioridad, string strEstado)
        {
            this.strTitulo = strTitulo;
            this.strDescripcion = strDescripcion;
            this.datVencimiento = datFechaVencimiento;
            this.strPrioridad = strPrioridad;
            this.strEstado =strEstado;
           
        }

        public bool guardarDatos()
        {
            //Conexion a la BD
            SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
            conexion.Open();
            string insertar = "insert into tblTareas values (@strTitulo,@strDescripcion,@datFechaVencimiento,@strPrioridad,@strEstado)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strTitulo", this.strTitulo);
            sql.Parameters.AddWithValue("@strDescripcion", this.strDescripcion);
            sql.Parameters.AddWithValue("@datFechaVencimiento", this.datVencimiento);
            sql.Parameters.AddWithValue("@strPrioridad", this.strPrioridad);
            sql.Parameters.AddWithValue("@strEstado", this.strEstado);
            //Permite que se cierre la conexion
            sql.ExecuteNonQuery();
            return true;
        }

    }
}
