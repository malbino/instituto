using Instituto.Clases;

namespace Instituto
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando la Institucion
            Institucion infocal = new Institucion(1, "Instituto Tecnológico Infocal");

            //instanciando las carreras
            Carrera sistemasInformaticos = new Carrera(1, "SI", "Sistemas Informáticos", infocal);
            Carrera gastronomia = new Carrera(2, "GA", "Gastronomia", infocal);

            //instanciando las materias
            Materia matemicasParaLaInformatica = new Materia(1, "MPI-101", "Matemáticas para la Informática", sistemasInformaticos);
            Materia programacion1 = new Materia(2, "PRG-102", "Programación I", sistemasInformaticos);
            Materia inglesTecnico = new Materia(3, "INT-103", "Inglés Técnico", sistemasInformaticos);
            Materia hardwareComputadoras = new Materia(4, "HDC-104", "Hardware de Computadoras", sistemasInformaticos);
            Materia tallerDeSistemasOperativos = new Materia(5, "TSO-105", "Taller de Sistemas Operativos", sistemasInformaticos);
            Materia informaticaAplicada = new Materia(6, "INA-106", "Informática Aplicada", sistemasInformaticos);
            Materia tecnologiaGraficaYMultimedia = new Materia(7, "TGM-107", "Tecnología Gráfica y Multimedia", sistemasInformaticos);
        }
    }
}
