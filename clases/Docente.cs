using System;
using Instituto.Interfaces;
using Instituto.Util;

namespace Instituto.Clases
{
    //clase Docente que herda de la calse Persona
    public class Docente : Persona, IUbicacion
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        //metodo constructor heredado de la clase padre
        public Docente(int id, string nombre, string primerApellido, string segundoApellido) : base(id, nombre, primerApellido, segundoApellido)
        {
            Latitud = -12.199;
            Longitud = -77.0352;
        }

        public string geolocalizacion()
        {
            return "Geolocalizacion: " + Latitud + ", " + Longitud;
        }

    }
}