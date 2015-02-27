using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Encuesta
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("Campos incompletos", "Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtUsuario.Text == "admin" && txtContraseña.Text == "admin")
            {

                MessageBox.Show("Bienvenido " + txtUsuario.Text, "Autenticacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Frm_Informacion_Basica Objeto = new Frm_Informacion_Basica();
                Objeto.Show();
                this.Visible = false;
            }
            else {

                MessageBox.Show("Datos Invalidos","Autenticacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
    }
}
