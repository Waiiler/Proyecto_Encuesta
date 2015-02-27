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
    public partial class Frm_Seccion3 : Form
    {
        public Frm_Seccion3()
        {
            InitializeComponent();
        }
        private cl_Encuesta objEncuesta_Seccion3 = new cl_Encuesta();

        public Frm_Seccion3(cl_Encuesta objEncuesta) {
            InitializeComponent();
            objEncuesta_Seccion3 = objEncuesta;

            List<string> listaRespuestas3 = objEncuesta_Seccion3.ControlRptaS3;
            if (listaRespuestas3 != null)
            {
                for (int i = 1; i <= 4; i++)
                {
                    string nomControl = "txt_1" + i.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);
                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is TextBox)
                        {
                            TextBox txt = (TextBox)controles[0];
                            for (int y = 0; y < listaRespuestas3.Count; y++)
                            {
                                //txt.Text == "";


                            }
                        }
                    }
                }
            }
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            List<string> misrpta = new List<string>();
            for (int i = 1; i <= 4; i++)
            {

                string nomControl = "txt" + i.ToString();
                Control[] controles = this.Controls.Find(nomControl, true);

                if (controles != null && controles.Count() > 0)
                {
                    if (controles[0] is TextBox)
                    {
                        TextBox text = ((TextBox)controles[0]);
                        if (text.Text != "")
                        {
                            misrpta.Add(text.Text);
                        }
                    }
                }
            }
            objEncuesta_Seccion3.ControlRptaS3 = misrpta;


            Frm_Seccion4 llamarSeccion_4 = new Frm_Seccion4(objEncuesta_Seccion3);
            llamarSeccion_4.Show();
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Frm_Seccion2 Objeto2 = new Frm_Seccion2(objEncuesta_Seccion3);
            this.Close();
            Objeto2.Show();
            
        }
    }
}
