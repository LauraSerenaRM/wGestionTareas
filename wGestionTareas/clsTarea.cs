using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wGestionTareas
{
    public class clsTarea
    {
        public string strTitulo { get; set; }/*se utiliza get y set por si en el futuro se necesita agregar alguna lógica especial cuando
                                           * alguien establezca u obtenga el valor de la  variable (get (obtener) y set (establecer)*/
        public string strDescripcion { get; set; }
        public DateTime datVencimiento { get; set; }
        public string strPrioridad { get; set; }
        public string strEstado { get; set; }
        public string intCodigoTarea { get; set; }


        public clsTarea(string strTitulo, string strDescripcion, DateTime datVencimiento, string strPrioridad, string strEstado)
        {
            this.strTitulo = strTitulo;
            this.strDescripcion = strDescripcion;
            this.datVencimiento = datVencimiento;
            this.strPrioridad = strPrioridad;
            this.strEstado =strEstado;
            this.intCodigoTarea = intCodigoTarea;

        }

        //
        /// <summary>
        /// Este método INICIA una conexion con la base de datos.
        /// </summary>
        /// <returns>conexion=new SqlConnection(...);</returns>
        /// 
        public SqlConnection abrirConexion()
        {
            SqlConnection conexion = new SqlConnection("server=LAUDESKTOP;database=dboGestionTareas;integrated security=true");
            conexion.Open();
            return conexion;

        }
        //
        /// <summary>
        /// Este método INSERTA una fila en la base de datos.
        /// </summary>
        /// <returns>sql.ExecuteNonQuery();</returns>
        /// 

        public int guardarDatos()
        {
            //Conexion a la BD
            SqlConnection conexion = abrirConexion();
            string insertar = "insert into tblTareas values (@strTitulo,@strDescripcion,@datFechaVencimiento,@strPrioridad,@strEstado)";
            SqlCommand sql = new SqlCommand(insertar, conexion);

            sql.Parameters.AddWithValue("@strTitulo", this.strTitulo);
            sql.Parameters.AddWithValue("@strDescripcion", this.strDescripcion);
            sql.Parameters.AddWithValue("@datFechaVencimiento", this.datVencimiento);
            sql.Parameters.AddWithValue("@strPrioridad", this.strPrioridad);
            sql.Parameters.AddWithValue("@strEstado", this.strEstado);
            //Permite que se cierre la conexion
            return sql.ExecuteNonQuery();
        }
        //
        /// <summary>
        /// Este método CONSULTA las filas agregadas en la base de datos
        /// y las muestra en un DataGridView.
        /// </summary>
        /// <returns>dt=DataTable</returns>
        /// 
        public DataTable consultarDato()
        {
            //Conexion a la BD
            SqlConnection conexion = abrirConexion();

            DataTable dt = new DataTable();
            string consulta = "select * from tblTareas";
            SqlCommand cmd = new SqlCommand(consulta, conexion);// sqlcommand es una clase en C# que representa una instrucción de SQL que se va a ejecutar en una base de datos
            // para que muestre la consulta en el datagrewviw
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        //
        /// <summary>
        /// Este método EDITA las filas agregadas en la base de datos que concuerden
        /// con la primary key.
        /// </summary>
        /// <param name="intCodigoTarea" value="2">Equivale a la llave identity de la BD</param>
        /// Esto se repite cuantos parametros tenga
        /// <returns>sql.ExecuteNonQuery();</returns>
        /// 
        public int editarDato(int intCodigoTarea)
        {
            SqlConnection conexion = abrirConexion();
            string insertar = "update tblTareas set strTitulo = @strTitulo, strDescripcion = @strDescripcion,datVencimiento = @datVencimiento,strPrioridad = @strPrioridad,strEstado = @strEstado where intCodigoTarea = @intCodigoTarea";

            SqlCommand sql = new SqlCommand(insertar, conexion);
            sql.Parameters.AddWithValue("@strTitulo", this.strTitulo);
            sql.Parameters.AddWithValue("@strDescripcion", this.strDescripcion);
            sql.Parameters.AddWithValue("@datVencimiento", this.datVencimiento);
            sql.Parameters.AddWithValue("@strPrioridad", this.strPrioridad);
            sql.Parameters.AddWithValue("@strEstado", this.strEstado);
            sql.Parameters.AddWithValue("@intCodigoTarea", intCodigoTarea);
            
            return sql.ExecuteNonQuery();

        }
        //
        /// <summary>
        /// Este método ELIMINA las filas en la base de datos que concuerden
        /// con la primary key.
        /// </summary>
        /// <param name="intCodigoTarea" value="2">Equivale a la llave identity de la BD</param>
        /// Esto se repite cuantos parametros tenga
        /// <returns>sql.ExecuteNonQuery();</returns>
        ///
        public int eliminarDato(int intCodigoTarea)
        {
            SqlConnection conexion = abrirConexion();
            //Eliminar por ID, código

            this.intCodigoTarea = Convert.ToString(intCodigoTarea);
            string eliminar = "Delete tblTareas where intCodigoTarea=@intCodigoTarea";
            SqlCommand sql = new SqlCommand(eliminar, conexion);
            sql.Parameters.AddWithValue("@intCodigoTarea", this.intCodigoTarea);
            
            return sql.ExecuteNonQuery(); 
        }
        //
        /// <summary>
        /// Este método CONSULTA las filas agregadas en la base de datos por su fecha
        /// y las muestra en un DataGridView.
        /// </summary>
        /// <returns>oConsultar=DataTable</returns>
        /// 
        public DataTable consultarPorFecha()
        {
            //Conexion a la BD
            SqlConnection conexion = abrirConexion();

            DataTable oConsultar = new DataTable();
            string consulta = "select intCodigoTarea,strTitulo,datVencimiento from tblTareas";
            SqlCommand cmd = new SqlCommand(consulta, conexion);// sqlcommand es una clase en C# que representa una instrucción de SQL que se va a ejecutar en una base de datos
            // para que uestre la consulta en el datagrewviw
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(oConsultar);
            
            return oConsultar;
        }
        //
        /// <summary>
        /// Este método CONSULTA las filas agregadas en la base de datos por su prioridad
        /// y las muestra en un DataGridView.
        /// </summary>
        /// <returns>oConsultar=DataTable</returns>
        /// 
        public DataTable consultarPorPrioridad()
        {
            //Conexion a la BD
            SqlConnection conexion = abrirConexion();

            DataTable oConsultar = new DataTable();
            string consulta = "select intCodigoTarea,strTitulo,strPrioridad from tblTareas";
            SqlCommand cmd = new SqlCommand(consulta, conexion);// sqlcommand es una clase en C# que representa una instrucción de SQL que se va a ejecutar en una base de datos
            // para que uestre la consulta en el datagrewviw
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(oConsultar);
            return oConsultar;
        }
        //
        /// <summary>
        /// Este método CONSULTA las filas agregadas en la base de datos por su estado
        /// y las muestra en un DataGridView.
        /// </summary>
        /// <returns>oConsultar=DataTable</returns>
        public DataTable consultarPorEstado()
        {
            //Conexion a la BD
            SqlConnection conexion = abrirConexion();

            DataTable oConsultar = new DataTable();
            string consulta = "select intCodigoTarea,strTitulo,strEstado from tblTareas";
            SqlCommand cmd = new SqlCommand(consulta, conexion);// sqlcommand es una clase en C# que representa una instrucción de SQL que se va a ejecutar en una base de datos
            // para que uestre la consulta en el datagrewviw
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(oConsultar);
            return oConsultar;
        }

        

    }
}
