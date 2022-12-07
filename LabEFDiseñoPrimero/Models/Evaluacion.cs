using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEFDiseñoPrimero.Models
{
    public class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public int IdTipo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdDetalle { get; set; }
        public int Nota { get; set; }

    }
}
