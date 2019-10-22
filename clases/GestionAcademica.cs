using System;

namespace Instituto.Clases
{
    //clase Gestion Académica
    public class GestionAcademica
    {
        //atributos
        private int id;
        private string codigo;
        public DateTime Inicio { protected get; set; }
        public DateTime Fin { protected get; set; }

        //metodo constructor
        public GestionAcademica(int id, string codigo)
        {
            this.id = id;
            this.codigo = codigo;
        }

        //metodo destructor
        ~GestionAcademica()
        {
            //hacer algo

            Console.WriteLine("<" + codigo + "> destruido...");
        }
    }
}