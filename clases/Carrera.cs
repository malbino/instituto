using System;

namespace Instituto.Clases
{
    //clase Carrera
    public class Carrera
    {
        //atributos
        private int id;
        private string codigo;
        private string nombre;
        private Institucion institucion;

        //metodo constructor
        public Carrera(int id, string codigo, string nombre, Institucion institucion)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.institucion = institucion;

            Console.WriteLine("<" + nombre + "> creado...");
        }
    }
}