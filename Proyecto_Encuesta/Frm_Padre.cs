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
    public partial class Frm_Padre : Form
    {
        public Frm_Padre()
        {
            InitializeComponent();
        }

        private void iniciarEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Seccion1 llamarSeccion1 = new frm_Seccion1();
            llamarSeccion1.MdiParent = this;
            llamarSeccion1.Show();
            
        }
        private void informacionBasicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Informacion_Basica llamarInformacionBasica = new Frm_Informacion_Basica();
            llamarInformacionBasica.MdiParent = this;
            llamarInformacionBasica.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
