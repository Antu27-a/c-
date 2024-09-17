using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using Sector_Datos;


namespace capa_vistas
{
    public partial class Form2 : Form
    {
        Crud_paciente cru = new Crud_paciente();
        public Form2()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                cru.Registrar_Paciente(dni.Text, nombre.Text, fecha.Text, edad.Text,genero.Text,nacionalidad.Text,provincia.Text,partido.Text,localidad.Text,direccion.Text,correo.Text,telefono.Text,obra.Text,codigo.Text);
                MessageBox.Show("Datos Registrados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            try
            {
                cru.Modificar_Paciente(dni.Text, nombre.Text, fecha.Text, edad.Text, genero.Text, nacionalidad.Text, provincia.Text, partido.Text, localidad.Text, direccion.Text, correo.Text, telefono.Text, obra.Text, codigo.Text);
                MessageBox.Show("Datos Modificados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void turnos_Click(object sender, EventArgs e)
        {
            Form3 aui= new Form3();
            this.Hide();
            aui.Show();
        }
    }
}
