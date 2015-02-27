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
    public partial class Frm_Seccion2 : Form
    {
        public Frm_Seccion2()
        {
            InitializeComponent();
        }
        private cl_Encuesta objEncuesta_Seccion2 = new cl_Encuesta();

        public Frm_Seccion2(cl_Encuesta encuesta)
        {
            InitializeComponent();
            objEncuesta_Seccion2 = encuesta;

            List<string> listaRespuestas2 = objEncuesta_Seccion2.ControlRptaS2;
            if (listaRespuestas2 != null)
            {


                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {

                        string nomControl = "chk" + i.ToString() + "_" + j.ToString();
                        Control[] controles = this.Controls.Find(nomControl, true);

                        if (null != controles && controles.Count() > 0)
                        {
                            if (controles[0] is CheckBox)
                            {
                                CheckBox chk = (CheckBox)controles[0];

                                for (int y = 0; y < listaRespuestas2.Count; y++)
                                {
                                    if (nomControl == listaRespuestas2[y])
                                    {
                                        chk.Checked = true;
                                    }

                                }

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

                for (int j = 1; j <= 4; j++)
                {

                    string nomControl = "chk" + i.ToString() + "_" + j.ToString();
                    Control[] controles = this.Controls.Find(nomControl, true);

                    if (null != controles && controles.Count() > 0)
                    {
                        if (controles[0] is CheckBox)
                        {
                            CheckBox ch = ((CheckBox)controles[0]);
                            if (ch.Checked == true)
                            {
                                misrpta.Add(nomControl);
                            }
                        }
                    }
                }
            }

            objEncuesta_Seccion2.ControlRptaS2 = misrpta;

            Frm_Seccion3 llamarSeccion_3 = new Frm_Seccion3(objEncuesta_Seccion2);
            llamarSeccion_3.Show();
            this.Close();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            frm_Seccion1 Objeto1 = new frm_Seccion1(objEncuesta_Seccion2);
            Objeto1.Show();
            this.Close();
        }
    }
}
