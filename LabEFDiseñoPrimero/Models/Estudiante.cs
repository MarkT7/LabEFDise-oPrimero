using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEFDiseñoPrimero.Models
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public int IdLocalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
    }
}
