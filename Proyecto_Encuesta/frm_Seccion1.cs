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
    public partial class frm_Seccion1 : Form
    {
        public frm_Seccion1()
        {
            InitializeComponent();
            objEncuesta_Seccion1 = new cl_Encuesta();
        }

        private cl_Encuesta objEncuesta_Seccion1 = new cl_Encuesta();

        public frm_Seccion1(cl_Encuesta objEncuesta) {

            InitializeComponent();
            objEncuesta_Seccion1 = objEncuesta;

            List<string> listaRespuestas = objEncuesta_Seccion1.ControlRptaS1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    string nomControl = "rd" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];
                            for (int y = 0; y < listaRespuestas.Count; y++) {
                                if (nomControl == listaRespuestas[y]) {
                                    rd.Checked = true;
                                }
                            
                            }
                            
                        }
                    }

                }
                
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //cl_Encuesta Encuesta = new cl_Encuesta();
            List<string> misrpta = new List<string>();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {

                    string nomControl = "rd" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is RadioButton)
                        {
                            RadioButton rd = (RadioButton)controles[0];
                            if (rd.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }

            objEncuesta_Seccion1.ControlRptaS1 = misrpta;

            Frm_Seccion2 llamarFrm2 = new Frm_Seccion2(objEncuesta_Seccion1);
            llamarFrm2.Show();
            this.Close();
       }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Frm_Informacion_Basica Objeto1 = new Frm_Informacion_Basica();
            Objeto1.Show();
            this.Hide();
            

        }
    }
}
