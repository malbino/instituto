using System;

namespace Instituto.Clases
{
    //clase Gestion Académica
    public class GestionAcademica
    {
        //atributos
        private int id;
        private string codigo;
        DateTime inicio;
        DateTime fin;

        //metodo constructor
        public GestionAcademica(int id, string codigo)
        {
            this.id = id;
            this.codigo = codigo;
        }
    }
}