using System;

namespace Instituto.Clases
{
    //clase Estudiante que hereda de la clase Persona
    public class Estudiante : Persona
    {
        //metodos constructor heredado de la clase padre
        public Estudiante(int id, string nombre, string primerApellido, string segundoApellido) : base(id, nombre, primerApellido, segundoApellido)
        {
        }
    }
}