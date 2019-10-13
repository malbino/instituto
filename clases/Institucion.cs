using System;

namespace Instituto.Clases
{
    //clase Institucion
    public class Institucion
    {
        //atributos
        private int id;
        private string nombre;
        private string direccion;
        private int telefono1;
        private int telefono2;
        private string email;

        //metodo constructor
        public Institucion(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;

            Console.WriteLine("<" + nombre + "> creado...");
        }
    }
}