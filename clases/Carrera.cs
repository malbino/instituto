using System;

namespace Instituto.Clases
{
    //clase Carrera
    public class Carrera
    {
        //atributos
        public int Id { get; set; }        
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Institucion Institucion { get; set; }
        

        //metodo constructor
        public Carrera(int id, string codigo, string nombre, Institucion institucion)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Institucion = institucion;

            Console.WriteLine("<" + Nombre + "> creado...");
        }

        //metodo destructor
        ~Carrera()
        {
            //hacer algo

            Console.WriteLine("<" + Nombre + "> destruido...");
        }
    }
}