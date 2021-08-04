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
    public partial class FormPpal : Form
    {
        private List<Encuesta> listadoEncuestas = new List<Encuesta>();
        private EncuestaService es = new EncuestaService();
        public FormPpal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cargar todas las encuestas.
            //Por cada una que nos devuelva la consulta se crea un botón que permita seleccionarla
            listadoEncuestas = es.GetEncuestasSinDetalle();
            int idx = 1;
            foreach(Encuesta en in listadoEncuestas)
            {
                Button bt = new Button();
                bt.Text = en.TituloEncuesta;
                bt.Name = string.Format("button{0}", en.IdEncuesta);
                bt.Size = new System.Drawing.Size(150, 25);
                bt.Location = new System.Drawing.Point(15, 40 *(idx));
                bt.Click += Bt_Click;
                this.gbEncuestas.Controls.Add(bt);
                idx++;
            }

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            //sender.Name contiene el IdEncuesta vinculado ya que se construye como button{idEncuesta}
            string name = (sender as Button).Name;
            int id = Convert.ToInt32(name.Substring(6));
            
            FormDatosEncuesta fde = new FormDatosEncuesta(id);
            fde.Text = listadoEncuestas.Where(en => en.IdEncuesta == id).Select(en => en.TituloEncuesta).ToList()[0];
            fde.ShowDialog();
        }
    }
}
