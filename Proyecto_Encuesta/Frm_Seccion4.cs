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
    public partial class Frm_Seccion4 : Form
    {
        public Frm_Seccion4()
        {
            InitializeComponent();
        }

        private cl_Encuesta objEncuesta_Seccion4 = new cl_Encuesta();
        public Frm_Seccion4(cl_Encuesta objEncuesta) {

            InitializeComponent();
            objEncuesta_Seccion4 = objEncuesta;
            List<string> listaRespuestas = objEncuesta_Seccion4.ControlRptaS4;
            if (listaRespuestas != null)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        string nomcontrol = "rd" + i.ToString() + "_" + j.ToString();
                        Control[] controles = this.Controls.Find(nomcontrol, true);

                        if (null != controles && controles.Count() > 0)
                        {
                            if (controles[0] is RadioButton)
                            {
                                RadioButton rd = (RadioButton)controles[0];

                                for (int y = 0; y < listaRespuestas.Count; y++)
                                {
                                    if (nomcontrol == listaRespuestas[y])
                                    {
                                        rd.Checked = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            cl_Encuesta encuesta = new cl_Encuesta();
            List<string> misrpta = new List<string>();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    string nomControl = "rd" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = ((RadioButton)controles[0]);
                            if (rd.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }

            objEncuesta_Seccion4.ControlRptaS4 = misrpta;
            FrmResultados llamarResultados = new FrmResultados();
            llamarResultados.Show();
            this.Close();
            
      }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Frm_Seccion3 ObjetoSeccion3 = new Frm_Seccion3(objEncuesta_Seccion4);
            this.Close();
            ObjetoSeccion3.Show();
            
        }
    }
}
