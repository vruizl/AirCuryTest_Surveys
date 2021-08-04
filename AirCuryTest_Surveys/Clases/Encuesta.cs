using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCuryTest_Surveys.Clases
{
    public class Encuesta
    {
        public Encuesta() { }

        private List<Pregunta> preguntas = new List<Pregunta>();

        #region Propiedades
        public int IdEncuesta { get; set; }
        public string TituloEncuesta { get; set; }
        public string DescEncuesta { get; set; }

        public List<Pregunta> Preguntas
        {
            get
            {
                return preguntas;
            }
            set
            {
                preguntas = value;
            }
        }
        #endregion
    }
}
