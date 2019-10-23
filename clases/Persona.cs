using System;

namespace Instituto.Clases
{
    //clase Persona, clase padre de Estudiante y Docente
    public class Persona
    {
        //atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string CI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public int Email { get; set; }

        //metodo constructor
        public Persona(int id, string nombre, string primerApellido, string segundoApellido)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.PrimerApellido = primerApellido;
            this.SegundoApellido = segundoApellido;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Nombre: " + Nombre + ", Primer Apellido: " + PrimerApellido + ", Segundo Apellido: " + SegundoApellido;
        }

        public string NombreCompleto()
        {
            string s = "Nombre Completo: " + Nombre + " " + PrimerApellido;
            if (SegundoApellido != null)
            {
                s += " " + SegundoApellido;
            }
            return s;
        }

        public string Edad()
        {
            DateTime nacimiento = new DateTime(FechaNacimiento.Year, FechaNacimiento.Month, FechaNacimiento.Day);
            return "Edad: " + (DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1).ToString();
        }

    }
}