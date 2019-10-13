using System;

namespace Instituto.Clases
{
    //clase Docente
    public class Docente
    {
        //atributos
        private int id;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string ci;
        private DateTime fechaNacimiento;
        private string direccion;
        private int telefono;
        private int celular;
        private string email;
        
        //metodo constructor
        public Docente(int id, string nombre, string primerApellido, string segundoApellido)
        {
            this.id = id;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
        }
        
    }
}