using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    class Estudiante
    {
        public int codEstudiante { get; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string grado { get; set; }
        public string seccion { get; set; }
        public DateTime fecNacimiento { get; set; }
        public string noCarne { get; set; }
    }
}
