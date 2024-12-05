using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Estudiante
    {
        int codEstudiante;
        string nombres;
        string apellidos;
        string grado;
        string seccion;
        DateTime fecNacimiento;
        string noCarne;

        public Estudiante() { 
            codEstudiante = 0;
            nombres = "Jhon";
            apellidos = "Doe";
            grado = "Primaria";
            seccion = "B";
        }

        public Estudiante(int codEstudiante, string nombres, string apellidos)
        {
            this.codEstudiante = codEstudiante;
            this.nombres = nombres;
            this.apellidos = apellidos;
            grado = "Primaria";
            seccion = "B";
        }

        public Estudiante(int codEstudiante, string nombres, string apellidos,
            string grado, string seccion, DateTime fecNacimiento, string noCarne) { 

            this.codEstudiante = codEstudiante;
            this.nombres = nombres;
            this.noCarne = noCarne;
            this.apellidos = apellidos;
            this.grado = grado;
            this.seccion = seccion;
            this.fecNacimiento = fecNacimiento;
        }

        // Método que permite obtener los nombres y apellidos del estudiante
        public string obtNombreCompleto() {
            return $"{nombres} {apellidos}";
        }

        public void mostrarInformacionEstudiante()
        {
            Console.WriteLine($"COD Estudiante: {codEstudiante}");
            Console.WriteLine($"Nombre Completo: {nombres} {apellidos}");
            Console.WriteLine($"No. Carné: {noCarne}");
            Console.WriteLine($"Grado: {grado} - Sección: {seccion}");
            Console.WriteLine($"Edad del Estudiante: {obtEdad()}");
        }

        public int obtEdad() {
            DateTime fecHoy = DateTime.Today;

            int edad = fecHoy.Year - fecNacimiento.Year;

            return edad;
        } 
    }
}
