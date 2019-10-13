using System;

namespace Instituto.Clases
{
    //clase Materia
    public class Materia
    {
        //atributos
        private int id;
        private string codigo;
        private string nombre;
        private Carrera carrera;

        //metodo constructor
        public Materia(int id, string codigo, string nombre, Carrera carrera)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.carrera = carrera;

            Console.WriteLine("<" + nombre + "> creado...");
        }
    }
}