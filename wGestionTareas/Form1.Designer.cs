namespace wGestionTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTituloTarea = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.datFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboPrioridad = new System.Windows.Forms.ComboBox();
            this.dtgGestionTareas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.btnFiltrarPrioridad = new System.Windows.Forms.Button();
            this.btnFiltrarEstado = new System.Windows.Forms.Button();
            this.btnGuardarTarea = new System.Windows.Forms.Button();
            this.btnEditarTarea = new System.Windows.Forms.Button();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnConsultarTarea = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestionTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloTarea
            // 
            this.lblTituloTarea.AutoSize = true;
            this.lblTituloTarea.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTarea.Location = new System.Drawing.Point(44, 81);
            this.lblTituloTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTarea.Name = "lblTituloTarea";
            this.lblTituloTarea.Size = new System.Drawing.Size(43, 18);
            this.lblTituloTarea.TabIndex = 0;
            this.lblTituloTarea.Text = "Titulo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(40, 108);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(74, 18);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVencimiento.Location = new System.Drawing.Point(37, 228);
            this.lblFechaVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(130, 18);
            this.lblFechaVencimiento.TabIndex = 2;
            this.lblFechaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridad.Location = new System.Drawing.Point(37, 259);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(60, 18);
            this.lblPrioridad.TabIndex = 3;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(38, 290);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(47, 18);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado";
            // 
            // datFechaVencimiento
            // 
            this.datFechaVencimiento.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFechaVencimiento.Location = new System.Drawing.Point(171, 230);
            this.datFechaVencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.datFechaVencimiento.Name = "datFechaVencimiento";
            this.datFechaVencimiento.Size = new System.Drawing.Size(201, 21);
            this.datFechaVencimiento.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(171, 83);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(204, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(40, 129);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(335, 89);
            this.txtDescripcion.TabIndex = 7;
//            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged_1);
            // 
            // cboPrioridad
            // 
            this.cboPrioridad.FormattingEnabled = true;
            this.cboPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cboPrioridad.Location = new System.Drawing.Point(171, 259);
            this.cboPrioridad.Margin = new System.Windows.Forms.Padding(2);
            this.cboPrioridad.Name = "cboPrioridad";
            this.cboPrioridad.Size = new System.Drawing.Size(201, 21);
            this.cboPrioridad.TabIndex = 8;
            this.cboPrioridad.SelectedIndexChanged += new System.EventHandler(this.cboPrioridad_SelectedIndexChanged);
            // 
            // dtgGestionTareas
            // 
            this.dtgGestionTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGestionTareas.Location = new System.Drawing.Point(40, 373);
            this.dtgGestionTareas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgGestionTareas.Name = "dtgGestionTareas";
            this.dtgGestionTareas.RowHeadersWidth = 51;
            this.dtgGestionTareas.RowTemplate.Height = 24;
            this.dtgGestionTareas.Size = new System.Drawing.Size(660, 223);
            this.dtgGestionTareas.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "MIS TAREAS";
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarFecha.Location = new System.Drawing.Point(430, 21);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(200, 59);
            this.btnFiltrarFecha.TabIndex = 12;
            this.btnFiltrarFecha.Text = "Filtrar por fecha";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // btnFiltrarPrioridad
            // 
            this.btnFiltrarPrioridad.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarPrioridad.Location = new System.Drawing.Point(430, 97);
            this.btnFiltrarPrioridad.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarPrioridad.Name = "btnFiltrarPrioridad";
            this.btnFiltrarPrioridad.Size = new System.Drawing.Size(200, 59);
            this.btnFiltrarPrioridad.TabIndex = 13;
            this.btnFiltrarPrioridad.Text = "Filtrar por prioridad";
            this.btnFiltrarPrioridad.UseVisualStyleBackColor = true;
            this.btnFiltrarPrioridad.Click += new System.EventHandler(this.btnFiltrarPrioridad_Click);
            // 
            // btnFiltrarEstado
            // 
            this.btnFiltrarEstado.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarEstado.Location = new System.Drawing.Point(430, 181);
            this.btnFiltrarEstado.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarEstado.Name = "btnFiltrarEstado";
            this.btnFiltrarEstado.Size = new System.Drawing.Size(200, 59);
            this.btnFiltrarEstado.TabIndex = 14;
            this.btnFiltrarEstado.Text = "Filtrar por estado";
            this.btnFiltrarEstado.UseVisualStyleBackColor = true;
            this.btnFiltrarEstado.Click += new System.EventHandler(this.btnFiltrarEstado_Click);
            // 
            // btnGuardarTarea
            // 
            this.btnGuardarTarea.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarTarea.Location = new System.Drawing.Point(62, 620);
            this.btnGuardarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarTarea.Name = "btnGuardarTarea";
            this.btnGuardarTarea.Size = new System.Drawing.Size(184, 36);
            this.btnGuardarTarea.TabIndex = 15;
            this.btnGuardarTarea.Text = "Guardar tarea";
            this.btnGuardarTarea.UseVisualStyleBackColor = true;
            this.btnGuardarTarea.Click += new System.EventHandler(this.btnGuardarTarea_Click);
            // 
            // btnEditarTarea
            // 
            this.btnEditarTarea.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTarea.Location = new System.Drawing.Point(280, 620);
            this.btnEditarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarTarea.Name = "btnEditarTarea";
            this.btnEditarTarea.Size = new System.Drawing.Size(184, 36);
            this.btnEditarTarea.TabIndex = 16;
            this.btnEditarTarea.Text = "Editar Tarea";
            this.btnEditarTarea.UseVisualStyleBackColor = true;
            this.btnEditarTarea.Click += new System.EventHandler(this.btnEditarTarea_Click);
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTarea.Location = new System.Drawing.Point(496, 620);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(184, 36);
            this.btnEliminarTarea.TabIndex = 17;
            this.btnEliminarTarea.Text = "Eliminar Tarea";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(171, 291);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(201, 20);
            this.txtEstado.TabIndex = 18;
            this.txtEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConsultarTarea
            // 
            this.btnConsultarTarea.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTarea.Location = new System.Drawing.Point(430, 260);
            this.btnConsultarTarea.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultarTarea.Name = "btnConsultarTarea";
            this.btnConsultarTarea.Size = new System.Drawing.Size(200, 59);
            this.btnConsultarTarea.TabIndex = 19;
            this.btnConsultarTarea.Text = "Consultar mis tareas";
            this.btnConsultarTarea.UseVisualStyleBackColor = true;
            this.btnConsultarTarea.Click += new System.EventHandler(this.btnConsultarTarea_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.btnGuardarTarea_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(150, 326);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(155, 31);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(730, 694);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultarTarea);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.btnEliminarTarea);
            this.Controls.Add(this.btnEditarTarea);
            this.Controls.Add(this.btnGuardarTarea);
            this.Controls.Add(this.btnFiltrarEstado);
            this.Controls.Add(this.btnFiltrarPrioridad);
            this.Controls.Add(this.btnFiltrarFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgGestionTareas);
            this.Controls.Add(this.cboPrioridad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.datFechaVencimiento);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloTarea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "frmGestionTareas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGestionTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTarea;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DateTimePicker datFechaVencimiento;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboPrioridad;
        private System.Windows.Forms.DataGridView dtgGestionTareas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.Button btnFiltrarPrioridad;
        private System.Windows.Forms.Button btnFiltrarEstado;
        private System.Windows.Forms.Button btnGuardarTarea;
        private System.Windows.Forms.Button btnEditarTarea;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnConsultarTarea;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

