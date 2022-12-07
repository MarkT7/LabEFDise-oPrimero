using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEFDiseñoPrimero.Models
{
    public class Planilla
    {
        public int IdPlanilla { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public int IdProfesor { get; set; }
        public int IdCurso { get; set; }
        public DateTime Fecha { get; set; }
    }
}
