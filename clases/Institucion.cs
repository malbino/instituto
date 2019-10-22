using System;

namespace Instituto.Clases
{
    //clase Institucion
    public class Institucion
    {
        //atributos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Email { get; set; }


        //metodo constructor
        public Institucion(int id, string nombre, string direccion = "", int telefono1 = 0, int telefono2 = 0, string email = "")
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono1 = telefono1;
            this.Telefono2 = telefono2;
            this.Email = email;
        }

        //metodo destructor
        ~Institucion()
        {
            //hacer algo

            Console.WriteLine("<" + Nombre + "> destruido...");
        }

        //sobreescribios el metodo ToString de Object
        public override string  ToString()
        {
            return "Id: " + Id + ", Nombre: " + Nombre;
        }

    }
}