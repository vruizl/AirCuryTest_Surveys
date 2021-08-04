using AirCuryTest_Surveys.Clases;
using AirCuryTest_Surveys.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirCuryTest_Surveys
{
    public partial class FormDatosEncuesta : Form
    {
        private Encuesta datosEncuesta;
        private EncuestaService es = new EncuestaService();
        public FormDatosEncuesta()
        {
            InitializeComponent();
        }

        public FormDatosEncuesta(int idEncuesta)
        {
            InitializeComponent();
            datosEncuesta = es.GetDatosEncuesta(idEncuesta);
        }

        private void FormDatosEncuesta_Load(object sender, EventArgs e)
        {
            int idx = 0;
            int idxrb;
            GroupBox gb;
            Label lb;
            RadioButton rb;
            //Un groupbox de preguntas / opciones por cada una
            foreach (Pregunta p in datosEncuesta.Preguntas)
            {
                gb = new GroupBox();
                gb.Location = new System.Drawing.Point(15, 15 +(140 * (idx)));
                gb.Name = string.Format("gbPregunta{0}", idx+1);
                gb.Text = string.Format("Pregunta {0}", idx+1);
                lb = new Label();
                lb.Text = p.DescPregunta;
                lb.Location = new System.Drawing.Point(10, 15);
                gb.Controls.Add(lb);
                idxrb = 1;
                foreach (Opcion op in p.Opciones)
                {
                    rb = new RadioButton();
                    rb.Name = string.Format("Opcion{0}", op.IdOpcion);
                    rb.Text = op.TextoOpcion;
                    rb.Location = new System.Drawing.Point(10, 15 +(25 * (idxrb)));
                    gb.Controls.Add(rb);
                    idxrb++;
                }
                gb.Size = new Size(250, idxrb * 30);
                this.Controls.Add(gb);
                idx++;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRespuestas_Click(object sender, EventArgs e)
        {
            //Enviar resultados a base de datos 
            //En los documentos no está indicado que  interesa guardar:
                //-respuestas para cada usuario
                //-sin importar usuario, para cada encuesta resultados agregados
                //-...
        }
    }
}
