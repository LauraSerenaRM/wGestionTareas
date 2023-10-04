using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace wGestionTareas
{
    /// <summary>
    /// Nombres: Laura Serena Rivera Mejia, Viviana Muñoz Castrillon, Samuel Galvis Céspedes.
    /// Descripción: Este programa agenda tareas usando conexiones a base de datos, simula notificaciones reales
    /// y recordatorios sus metodos de conexion, validar campos están probados bajo método de tecnica de desarollo
    /// de software TDD, y documentados usando XML Documentation Comments.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            btnGuardarTarea.Enabled = false;

            notificacion2();
        }
        public void validarCampo()
        {
            var validacion = clsValidacion.validarCampos(txtTitulo.Text, txtDescripcion.Text, cboPrioridad.Text, txtEstado.Text);
            btnGuardarTarea.Enabled = validacion;

        }

       
        public void notificacion()
        {
            notifyIcon1.Text = txtTitulo.Text;
            notifyIcon1.BalloonTipTitle = "Tarea creada con exito";
            notifyIcon1.BalloonTipText = txtTitulo.Text + " "  + "Fecha de vencimiento" + " " + datFechaVencimiento.Value;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(3000);
            

        }

        public void notificacion2()
        {
            notifyIcon1.Text = txtTitulo.Text;
            notifyIcon1.BalloonTipTitle = "Tareas pendientes";
            notifyIcon1.BalloonTipText =  "Tiene tareas pendientes proximas a vencer";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;

            notifyIcon1.Visible = true;

            notifyIcon1.ShowBalloonTip(3000);
        }
        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            


            //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
            //conexion.Open();

            DateTime datVencimiento = datFechaVencimiento.Value.Date;

            clsTarea oGuardarTarea = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);

            oGuardarTarea.guardarDatos();

            MessageBox.Show("Se ha agendado la tarea correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);


            notificacion();


        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            validarCampo();
        }

        private void btnConsultarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oConsulta = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                dtgGestionTareas.DataSource = oConsulta.consultarDato();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al consultar la tarea","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oEditarTarea = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                int intLecturaIdentity = Convert.ToInt32(dtgGestionTareas.SelectedRows[0].Cells[0].Value);
                oEditarTarea.editarDato(intLecturaIdentity);
                MessageBox.Show("Tarea modificada con exito","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgGestionTareas.DataSource = oEditarTarea.consultarDato();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cboPrioridad.SelectedIndex;

            switch (indice)
            {
                case 0:
                    txtEstado.Text = "Activa";
                    break;
                case 1:
                    txtEstado.Text = "Activa";
                    break;
                case 2:
                    txtEstado.Text = "Activa";
                    break;
            }

            validarCampo();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            

            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oEliminarTarea = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                int intLecturaIdentity = Convert.ToInt32(dtgGestionTareas.SelectedRows[0].Cells[0].Value);
                oEliminarTarea.eliminarDato(intLecturaIdentity);
                dtgGestionTareas.DataSource = oEliminarTarea.consultarDato();
                MessageBox.Show("Tarea eliminada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception)
            {

                MessageBox.Show("Error al eliminar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oConsultaPorFeccha = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                dtgGestionTareas.DataSource = oConsultaPorFeccha.consultarPorFecha();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al filtrar la tarea por fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFiltrarPrioridad_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oConsultaPorPrioridad = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                dtgGestionTareas.DataSource = oConsultaPorPrioridad.consultarPorPrioridad();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al filtrar la tarea por prioridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFiltrarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conexion = new SqlConnection("server=DESKTOP-KCEU6FQ;database=dboGestionTareas;integrated security=true");
                //conexion.Open();

                DateTime datVencimiento = datFechaVencimiento.Value.Date;

                clsTarea oConsultarPorEstado = new clsTarea(txtTitulo.Text, txtDescripcion.Text, datVencimiento, cboPrioridad.Text, txtEstado.Text);
                dtgGestionTareas.DataSource = oConsultarPorEstado.consultarPorEstado();

            }
            catch (Exception)
            {

                MessageBox.Show("Error al filtrar la tarea por estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            validarCampo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            cboPrioridad.SelectedIndex = -1;
            txtEstado.Clear();
        }

        
    }
}
