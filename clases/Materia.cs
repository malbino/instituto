using System;

namespace Instituto.Clases
{
    //clase Materia
    public class Materia
    {
        //atributos
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Carrera Carrera { get; set; }

        //metodo constructor
        public Materia(int id, string codigo, string nombre, Carrera carrera)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Carrera = carrera;
        }

        //metodo destructor
        ~Materia()
        {
            //hacer algo

            Console.WriteLine("<" + Nombre + "> destruido...");
        }

        //sobreescribios el metodo ToString de Object
        public override string ToString()
        {
            return "Id: " + Id + ", Nombre: " + Nombre + ", Carrera: " + Carrera.Nombre;
        }
    }
}