using Instituo.Clases;

namespace Instituto.Clases
{
    //clase Grupo
    public class Grupo
    {
        //atributos
        private int id;
        private string codigo;
        private GestionAcademica gestionAcademica;
        private Materia materia;
        private Docente docente;

        //metodo constructor
        public Grupo(int id, string codigo, GestionAcademica gestionAcademica, Materia  materia)
        {
            this.id = id;
            this.codigo = codigo;
            this.gestionAcademica = gestionAcademica;
            this.materia = materia;
        }
    }
}