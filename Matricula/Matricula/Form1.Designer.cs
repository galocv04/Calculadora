namespace Matricula
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
            this.grpInformacion = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.grpModalidad = new System.Windows.Forms.GroupBox();
            this.rdbPresencial = new System.Windows.Forms.RadioButton();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.rdbVirtual = new System.Windows.Forms.RadioButton();
            this.rdbHibrida = new System.Windows.Forms.RadioButton();
            this.chkNotificaciones = new System.Windows.Forms.CheckBox();
            this.chkTerminos = new System.Windows.Forms.CheckBox();
            this.grpCursos = new System.Windows.Forms.GroupBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpInformacion.SuspendLayout();
            this.grpModalidad.SuspendLayout();
            this.grpCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformacion
            // 
            this.grpInformacion.Controls.Add(this.cmbCiudad);
            this.grpInformacion.Controls.Add(this.lblCiudad);
            this.grpInformacion.Controls.Add(this.lblCorreo);
            this.grpInformacion.Controls.Add(this.lblNombre);
            this.grpInformacion.Controls.Add(this.txtCorreo);
            this.grpInformacion.Controls.Add(this.txtNombre);
            this.grpInformacion.Location = new System.Drawing.Point(12, 21);
            this.grpInformacion.Name = "grpInformacion";
            this.grpInformacion.Size = new System.Drawing.Size(257, 175);
            this.grpInformacion.TabIndex = 0;
            this.grpInformacion.TabStop = false;
            this.grpInformacion.Text = "Información del Estudiante";
            this.grpInformacion.Enter += new System.EventHandler(this.grpInformacion_Enter);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(139, 79);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(17, 86);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 13);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electrònico";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(17, 136);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(55, 13);
            this.lblCiudad.TabIndex = 6;
            this.lblCiudad.Text = "Direcciòn:";
            // 
            // grpModalidad
            // 
            this.grpModalidad.Controls.Add(this.rdbHibrida);
            this.grpModalidad.Controls.Add(this.rdbPresencial);
            this.grpModalidad.Controls.Add(this.rdbVirtual);
            this.grpModalidad.Location = new System.Drawing.Point(315, 21);
            this.grpModalidad.Name = "grpModalidad";
            this.grpModalidad.Size = new System.Drawing.Size(263, 53);
            this.grpModalidad.TabIndex = 8;
            this.grpModalidad.TabStop = false;
            this.grpModalidad.Text = "Modalidad";
            this.grpModalidad.Enter += new System.EventHandler(this.grpModalidad_Enter);
            // 
            // rdbPresencial
            // 
            this.rdbPresencial.AutoSize = true;
            this.rdbPresencial.Location = new System.Drawing.Point(17, 30);
            this.rdbPresencial.Name = "rdbPresencial";
            this.rdbPresencial.Size = new System.Drawing.Size(74, 17);
            this.rdbPresencial.TabIndex = 9;
            this.rdbPresencial.TabStop = true;
            this.rdbPresencial.Text = "Presencial";
            this.rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(139, 131);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(100, 21);
            this.cmbCiudad.TabIndex = 9;
            // 
            // rdbVirtual
            // 
            this.rdbVirtual.AutoSize = true;
            this.rdbVirtual.Location = new System.Drawing.Point(108, 30);
            this.rdbVirtual.Name = "rdbVirtual";
            this.rdbVirtual.Size = new System.Drawing.Size(54, 17);
            this.rdbVirtual.TabIndex = 10;
            this.rdbVirtual.TabStop = true;
            this.rdbVirtual.Text = "Virtual";
            this.rdbVirtual.UseVisualStyleBackColor = true;
            // 
            // rdbHibrida
            // 
            this.rdbHibrida.AutoSize = true;
            this.rdbHibrida.Location = new System.Drawing.Point(188, 30);
            this.rdbHibrida.Name = "rdbHibrida";
            this.rdbHibrida.Size = new System.Drawing.Size(60, 17);
            this.rdbHibrida.TabIndex = 11;
            this.rdbHibrida.TabStop = true;
            this.rdbHibrida.Text = "Híbrida";
            this.rdbHibrida.UseVisualStyleBackColor = true;
            // 
            // chkNotificaciones
            // 
            this.chkNotificaciones.AutoSize = true;
            this.chkNotificaciones.Location = new System.Drawing.Point(23, 255);
            this.chkNotificaciones.Name = "chkNotificaciones";
            this.chkNotificaciones.Size = new System.Drawing.Size(156, 17);
            this.chkNotificaciones.TabIndex = 9;
            this.chkNotificaciones.Text = "Desea recibir notificaciones";
            this.chkNotificaciones.UseVisualStyleBackColor = true;
            // 
            // chkTerminos
            // 
            this.chkTerminos.AutoSize = true;
            this.chkTerminos.Location = new System.Drawing.Point(23, 292);
            this.chkTerminos.Name = "chkTerminos";
            this.chkTerminos.Size = new System.Drawing.Size(122, 17);
            this.chkTerminos.TabIndex = 10;
            this.chkTerminos.Text = "Acepto los Términos";
            this.chkTerminos.UseVisualStyleBackColor = true;
            this.chkTerminos.CheckedChanged += new System.EventHandler(this.chkTerminos_CheckedChanged);
            // 
            // grpCursos
            // 
            this.grpCursos.Controls.Add(this.lstCursos);
            this.grpCursos.Controls.Add(this.lblCursos);
            this.grpCursos.Location = new System.Drawing.Point(315, 100);
            this.grpCursos.Name = "grpCursos";
            this.grpCursos.Size = new System.Drawing.Size(396, 172);
            this.grpCursos.TabIndex = 11;
            this.grpCursos.TabStop = false;
            this.grpCursos.Text = "Seleccionar Cursos";
            // 
            // lblCursos
            // 
            this.lblCursos.AutoSize = true;
            this.lblCursos.Location = new System.Drawing.Point(14, 31);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(99, 13);
            this.lblCursos.TabIndex = 10;
            this.lblCursos.Text = "Cursos Disponibles:";
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(119, 31);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(120, 95);
            this.lstCursos.TabIndex = 12;
            this.lstCursos.SelectedIndexChanged += new System.EventHandler(this.lstCursos_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(315, 316);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(443, 316);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.grpCursos);
            this.Controls.Add(this.chkTerminos);
            this.Controls.Add(this.chkNotificaciones);
            this.Controls.Add(this.grpModalidad);
            this.Controls.Add(this.grpInformacion);
            this.Name = "Form1";
            this.Text = "Registro del Curso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInformacion.ResumeLayout(false);
            this.grpInformacion.PerformLayout();
            this.grpModalidad.ResumeLayout(false);
            this.grpModalidad.PerformLayout();
            this.grpCursos.ResumeLayout(false);
            this.grpCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacion;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.GroupBox grpModalidad;
        private System.Windows.Forms.RadioButton rdbPresencial;
        private System.Windows.Forms.RadioButton rdbVirtual;
        private System.Windows.Forms.RadioButton rdbHibrida;
        private System.Windows.Forms.CheckBox chkNotificaciones;
        private System.Windows.Forms.CheckBox chkTerminos;
        private System.Windows.Forms.GroupBox grpCursos;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

