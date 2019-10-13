namespace Instituto.Clases
{
    //clase Carrera
    public class Carrera
    {
        //atributos
        private int id;
        private string codigo;
        private string nombre;
        private Instituto instituto;

        //metodo constructor
        public Carrera(int id, string codigo, string nombre, Instituto instituto)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.instituto = instituto;
        }
    }
}