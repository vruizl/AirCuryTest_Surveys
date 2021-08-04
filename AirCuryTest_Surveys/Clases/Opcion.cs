using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCuryTest_Surveys.Clases
{
    public class Opcion
    {
        public  Opcion() { }

        #region Propiedades
        public int IdOpcion { get; set; }
        public string TextoOpcion { get; set; }

        public bool Seleccionada { get; set; }
        #endregion


    }
}
