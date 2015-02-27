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
    public partial class FrmResultados : Form
    {
        public FrmResultados()
        {
            InitializeComponent();
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            StreamReader MiStreamReader = new StreamReader("Test_File.txt");
            
            txtNC.Text = MiStreamReader.ReadLine();
            txtAC.Text = MiStreamReader.ReadLine();
            txtCN.Text = MiStreamReader.ReadLine();
            txtEdad.Text = MiStreamReader.ReadLine();
            txtPregrado.Text = MiStreamReader.ReadLine();
            
        }

      
    }

}

