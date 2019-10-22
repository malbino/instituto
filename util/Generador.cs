using System;
using System.Collections.Generic;
using Instituto.Clases;

namespace Instituto.Util
{
    //clase Generador
    public static class Generador
    {

        //metodo que generar la institucion
        public static Institucion generarInstitucion()
        {
            //instanciando la Institucion
            return new Institucion(1, "Instituto Tecnológico Infocal", telefono1: 44265974, email: "sistemas@infocalcbba.edu.bo");

        }

        //metodo que genera las carreras
        public static List<Carrera> generarCarreras(Institucion institucion)
        {
            List<Carrera> l = new List<Carrera>();

            //instanciando las carreras
            Carrera sistemasInformaticos = new Carrera(1, "SI", "Sistemas Informáticos", institucion);
            l.Add(sistemasInformaticos);

            Carrera gastronomia = new Carrera(2, "GA", "Gastronomia", institucion);
            l.Add(gastronomia);

            return l;
        }

        //metodo que genera las materias
        public static List<Materia> generarMaterias(Carrera carrera)
        {
            List<Materia> l = new List<Materia>();

            for (int i = 1; i <= 30; i++)
            {
                //instanciando las materias
                Materia materia = new Materia(i, "MA-" + i, "Materia " + i, carrera);
                l.Add(materia);
            }

            return l;
        }

        //metodo que genera las gestion academica
        public static GestionAcademica generarGestionAcademica()
        {
            GestionAcademica gestionAcademica = new GestionAcademica(1, "I2019A");
            gestionAcademica.Inicio = new DateTime(2019, 2, 20);
            gestionAcademica.Fin = new DateTime(2019, 12, 6);

            return gestionAcademica;
        }

        //metodo que genera los grupos
        public static List<Grupo> generarGrupos(GestionAcademica gestionAcademica, Materia materia)
        {
            List<Grupo> l = new List<Grupo>();

            //instanciando grupos
            for (int i = 1; i <= 2; i++)
            {
                Grupo grupo = new Grupo(i, "M" + i, gestionAcademica, materia);
                l.Add(grupo);
            }

            return l;
        }
    }
}