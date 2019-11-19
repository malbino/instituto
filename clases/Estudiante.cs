using System;
using Instituto.Interfaces;

namespace Instituto.Clases
{
    //clase Estudiante que hereda de la clase Persona
    public class Estudiante : Persona, IUbicacion
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        
        //metodos constructor heredado de la clase padre
        public Estudiante(int id, string nombre, string primerApellido, string segundoApellido) : base(id, nombre, primerApellido, segundoApellido)
        {
            Latitud = -12.1197;
            Longitud = -77.0225;
        }

        public string geolocalizacion()
        {
            return "Geolocalizacion: " + Latitud + ", " + Longitud;
        }
    }
}