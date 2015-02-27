using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Encuesta
{
    public partial class Frm_Informacion_Basica : Form
    {
        public Frm_Informacion_Basica()
        {
            InitializeComponent();
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            StreamWriter File = new StreamWriter("Test_File.txt");
            File.Write(txtNombre.Text + ("\n"));
            File.Write(txtApellido.Text + ("\n"));
            File.Write(cmbCiudades.Text + ("\n"));
            File.Write(txtEdad.Text + ("\n"));
            File.Write(chkList_Pregrado.Text + ("\n"));

            File.Close();
            //FrmResultados llamarResultados = new FrmResultados();
            //llamarResultados.Show();
            frm_Seccion1 llamarSeccion1 = new frm_Seccion1();
            llamarSeccion1.Show();
            this.Close();

            
        }

        private void dtFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = (DateTime.Today.AddTicks(-dtFechaNacimiento.Value.Ticks).Year - 1).ToString();

        }

       
    }
}
