using System;
using Instituto.Clases;

namespace Instituto
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando la Institucion
            Institucion infocal = new Institucion(1, "Instituto Tecnológico Infocal", telefono1: 44265974, email: "sistemas@infocalcbba.edu.bo");

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

            //instanciando la gestion academica
            GestionAcademica gestionAcademica = new GestionAcademica(1, "I2019A");
            gestionAcademica.Inicio = new DateTime(2019, 2, 20);
            gestionAcademica.Fin = new DateTime(2019, 12, 6);

            //instanciando grupos
            for (int i = 1; i <= 10; i++)
            {
                Grupo programacion1Mi = new Grupo(i, "M" + i, gestionAcademica, programacion1);
            }

            Grupo programacion1M11 = new Grupo(11, "M11", gestionAcademica, programacion1);
            Grupo programacion1M12 = new Grupo(12, "M12", gestionAcademica, programacion1);
            Grupo programacion1M13 = new Grupo(13, "M13", gestionAcademica, programacion1);
            Grupo programacion1M14 = new Grupo(14, "M14", gestionAcademica, programacion1);
            Grupo programacion1M15 = new Grupo(15, "M15", gestionAcademica, programacion1);

            //forzamos la ejecucion del recolector de basura
            GC.Collect();
        }
    }
}
