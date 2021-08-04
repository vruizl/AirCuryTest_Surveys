using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCuryTest_Surveys.Clases
{
    public class Pregunta
    {
        public Pregunta() { }

        private List<Opcion> opciones = new List<Opcion>();

        #region Propiedades
        public int IdPregunta { get; set; }
        public string DescPregunta {get;set;}
        public List<Opcion> Opciones {
            get {
                return opciones; 
            }
            set
            {
                opciones = value;
            }
        }
        #endregion
    }
}
