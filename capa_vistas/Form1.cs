using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capa_vistas
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            if ((usuario.Text == "admin1" && contraseña.Text == "1234") || (usuario.Text == "admin2" && contraseña.Text == "5678") || (usuario.Text == "admin3" && contraseña.Text == "2468"))
            {
                MessageBox.Show("Bienvenid@");
                this.Hide();
                Form2 aux = new Form2();
                aux.Show();
            }
            
            else
            {

                MessageBox.Show("Error al ingresar usuario y/o contraseña");
                MessageBox.Show("Si ingresa en 3 ocasiones el usuario y/o contraseña de manera erronea se cerrara el programa");
                
            }
        }
    }
}
