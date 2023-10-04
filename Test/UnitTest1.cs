using wGestionTareas;
using System.Data.SqlClient;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void testConexion()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento","Tema: Empresa Libre elección", DateTime.Now, "Alta","Activa");
            try
            {
                SqlConnection conexion = tarea.abrirConexion();
                Assert.Equal(System.Data.ConnectionState.Open, conexion.State);
            }
            catch (Exception ex)
            {
                Assert.Fail("No se pudo obtener la conexion a la base de datos" + ex.Message);
            }
            
        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //o el número de filas agregadas no corresponde con el número de filas de 
        //la prueba.
        [Fact]
        public void testGuardarDatos()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento", "Tema: Empresa Libre elección", DateTime.Now, "Alta", "Activa");
            try
            {
                Assert.Equal(1, tarea.guardarDatos());
            }
            catch (Exception ex)
            {
                Assert.Fail("No se obtuvo el numero esperado de filas afectadas: " + ex.Message);
            }

        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //o el número de filas agregadas no corresponde con el número de filas de 
        //la prueba, la compara con 1, y el parametro a validar es la identity,
        // si no existe la identity tambien debe fallar
        [Fact]
        public void testActualizarDatos()
        {
            clsTarea tarea = new clsTarea("Examen Ingles", "Speaking, Writing, Listening", DateTime.Now, "Baja", "Activa");
            try
            {
                Assert.Equal(1, tarea.editarDato(1));
            }
            catch (Exception ex)
            {
                Assert.Fail("No se obtuvo el numero esperado de filas afectadas: " + ex.Message);
            }

        }

        //Si la conexion no es correcta (CADENA DE CONEXION)
        //o el número de filas eliminadas no corresponde con el número de filas de 
        //la prueba, la compara con 1, y el parametro a validar es la identity,
        // si no existe la identity tambien debe fallar.
        [Fact]
        public void testEliminarDatos()
        {
            clsTarea tarea = new clsTarea("", "", DateTime.Now, "", "");
            try
            {
                Assert.Equal(1, tarea.eliminarDato(1));
            }
            catch (Exception ex)
            {
                Assert.Fail("No se obtuvo el numero esperado de filas afectadas: " + ex.Message);
            }

        }
        //Valida si todo los textbox están diligenciados, si se mandan parametros vacios la prueba debe fallar.
        [Fact]
        public void testValidarCampos()
        {
            Assert.True(clsValidacion.validarCampos("Taller Base de Datos", "Subconsultas", "Alta", "Activa"));
           
        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //Tratamos de hacer la consulta, si se hace correctamente asigna la variable consultaFueExitosa true y pasa
        //la prueba de lo contrario falla y va a la clausula catch.
        [Fact]
        public void testConsultar()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento", "Tema: Empresa Libre elección", DateTime.Now, "Alta", "Activa");
            bool consultaFueExitosa;
            try
            {   
                tarea.consultarDato();
                consultaFueExitosa = true;
                Assert.True(consultaFueExitosa);

            }
            catch (Exception ex)
            {
                Assert.Fail("Hubo problemas con la consulta" + ex.Message);
            }
        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //Tratamos de hacer la consulta, si se hace correctamente asigna la variable consultaPorFecha true y pasa
        //la prueba de lo contrario falla y va a la clausula catch.
        [Fact]
        public void testConsultarPorFecha()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento", "Tema: Empresa Libre elección", DateTime.Now, "Alta", "Activa");
            bool consultaFueExitosa = false;
            try
            {
                tarea.consultarPorFecha();
                consultaFueExitosa = true;
                Assert.True(consultaFueExitosa);

            }
            catch (Exception ex)
            {
                Assert.Fail("Hubo problemas con la consulta" + ex.Message);
            }
        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //Tratamos de hacer la consulta, si se hace correctamente asigna la variable consultaPorEstado true y pasa
        //la prueba de lo contrario falla y va a la clausula catch.
        [Fact]
        public void testConsultarPorEstado()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento", "Tema: Empresa Libre elección", DateTime.Now, "Alta", "Activa");
            bool consultaFueExitosa = false;
            try
            {
                tarea.consultarPorEstado();
                consultaFueExitosa = true;
                Assert.True(consultaFueExitosa);

            }
            catch (Exception ex)
            {
                Assert.Fail("Hubo problemas con la consulta" + ex.Message);
            }
        }
        //Si la conexion no es correcta (CADENA DE CONEXION)
        //Tratamos de hacer la consulta, si se hace correctamente asigna la variable consultaPorPrioidad true y pasa
        //la prueba de lo contrario falla y va a la clausula catch.
        [Fact]
        public void testConsultarPorPrioridad()
        {
            clsTarea tarea = new clsTarea("Exposicion Emprendimiento", "Tema: Empresa Libre elección", DateTime.Now, "Alta", "Activa");
            bool consultaFueExitosa = false;
            try
            {
                tarea.consultarPorPrioridad();
                consultaFueExitosa = true;
                Assert.True(consultaFueExitosa);

            }
            catch (Exception ex)
            {
                Assert.Fail("Hubo problemas con la consulta" + ex.Message);
            }
        }
    }
}