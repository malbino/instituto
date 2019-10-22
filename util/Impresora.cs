using System;

namespace Instituto.Util
{
    //clase Impresora
    public static class Impresora
    {
        //metodos para imprimir un titulo en consola
        public static void imprimirTitulo(string cadena)
        {
            Console.Write("+");
            for (int i = 0; i < cadena.Length + 8; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
            Console.WriteLine("|    " + cadena + "    |");
            Console.Write("+");
            for (int i = 0; i < cadena.Length + 8; i++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }

        //metodo para imprimir una linea en consola
        public static void imprimirLinea(string cadena)
        {
            Console.WriteLine("-> " + cadena);
        }
    }
}