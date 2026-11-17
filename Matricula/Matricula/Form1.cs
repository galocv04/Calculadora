using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpModalidad_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCiudad.Items.Add("Quito"); 
            cmbCiudad.Items.Add("Guayaquil"); 
            cmbCiudad.Items.Add("Cuenca"); 
            cmbCiudad.Items.Add("Manta"); 
            cmbCiudad.Items.Add("Portoviejo"); 
            //Agregar cursos
            lstCursos.Items.Add("Programación"); 
            lstCursos.Items.Add("Base de datos");
            lstCursos.Items.Add("Redes"); 
            lstCursos.Items.Add("Sistemas operativos"); 
            lstCursos.Items.Add("Inteligencia artificial"); 
            // Permitir seleccionar varios cursos
            lstCursos.SelectionMode = SelectionMode.MultiExtended; 
            // Desactivar el botón de registro
            btnRegistrar.Enabled = false;
        }


        private void chkTerminos_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Enabled = chkTerminos.Checked;
        }

        private void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Ingrese el correo electrónico.");
                txtCorreo.Focus();
                return;
            }
            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo electrónico válido."); txtCorreo.Focus(); return;
            }
            if (cmbCiudad.SelectedIndex == -1) {
                MessageBox.Show("Seleccione una ciudad.");
                return; 
            }

            string modalidad = ""; 
            if (rdbPresencial.Checked) modalidad = "Presencial"; 
            else if (rdbVirtual.Checked) modalidad = "Virtual";
            else if (rdbHibrida.Checked) modalidad = "Híbrida";
            else {
                MessageBox.Show("Seleccione una modalidad."); 
                return; 
            }

            if (lstCursos.SelectedItems.Count == 0) { 
                MessageBox.Show("Seleccione al menos un curso."); 
                return; 
            }

            string cursos = ""; 
            foreach (var curso in lstCursos.SelectedItems) 
            { cursos += curso.ToString() + "\n"; 
            }
            string notificaciones = chkNotificaciones.Checked ? "Sí" : "No";
            string mensaje = "REGISTRO DEL ESTUDIANTE\n\n" 
                + "Nombre: " 
                + txtNombre.Text 
                + "\n" + "Correo: " 
                + txtCorreo.Text 
                + "\n" + "Ciudad: "
                + cmbCiudad.SelectedItem + "\n"
                + "Modalidad: " + modalidad + "\n" + "Notificaciones: " + notificaciones + "\n\n" + "Cursos seleccionados:\n" + cursos;
            MessageBox.Show(mensaje);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear(); 
            txtCorreo.Clear(); 
            cmbCiudad.SelectedIndex = -1;
            rdbPresencial.Checked = false; 
            rdbVirtual.Checked = false; 
            rdbHibrida.Checked = false; 
            chkNotificaciones.Checked = false; 
            chkTerminos.Checked = false; 
            lstCursos.ClearSelected(); 
            txtNombre.Focus();
        }
    }
}
