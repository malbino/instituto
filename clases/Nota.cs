using Instituo.Clases;

namespace Instituto.Clases
{
    //clase Nota
    public class Nota
    {
        //atributos
        private int id;
        private Grupo grupo;
        private Estudiante estudiante;
        int primerParcial;
        int segundoParcial;
        int tercerParcial;
        int cuartoParcial;
        int notaFinal;
        int notaRecuperatorio;

        //metodo constructor
        public Nota(int id, Grupo grupo, Estudiante estudiante, int primerParcial, int segundoParcial
        , int tercerParcial, int cuartoParcial, int notaFinal, int notaRecuperatorio)
        {
            this.id = id;
            this.grupo = grupo;
            this.estudiante = estudiante;
            this.primerParcial = primerParcial;
            this.segundoParcial = segundoParcial;
            this.tercerParcial = tercerParcial;
            this.cuartoParcial = cuartoParcial;
            this.notaFinal = notaFinal;
            this.notaRecuperatorio = notaRecuperatorio;
        }
    }
}