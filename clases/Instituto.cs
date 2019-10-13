namespace Instituto.Clases
{
    //clase instituto
    public class Instituto
    {
        //atributos
        private int id;
        private string nombre;
        private string direccion;
        private int telefono1;
        private int telefono2;
        private string email;

        //metodo constructor
        public Instituto(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}