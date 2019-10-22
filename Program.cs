using System;
using System.Collections.Generic;
using Instituto.Clases;
using Instituto.Util;

namespace Instituto
{
    class Program
    {
        static void Main(string[] args)
        {
            Impresora.imprimirTitulo("Institucion");
            Institucion institucion = Generador.generarInstitucion();
            Impresora.imprimirLinea(institucion.ToString());

            Impresora.imprimirTitulo("Carreras");
            List<Carrera> carreras = Generador.generarCarreras(institucion);
            foreach (Carrera carrera in carreras)
            {
                Impresora.imprimirLinea(carrera.ToString());
            }

            Impresora.imprimirTitulo("Materias");
            List<Materia> materias = new List<Materia>();
            foreach (Carrera carrera in carreras)
            {
                List<Materia> materiasCarrera = Generador.generarMaterias(carrera);
                materias.AddRange(materiasCarrera);
            }
            foreach (Materia materia in materias)
            {
                Impresora.imprimirLinea(materia.ToString());
            }

            Impresora.imprimirTitulo("Gestión Académica");
            GestionAcademica gestionAcademica = Generador.generarGestionAcademica();
            Impresora.imprimirLinea(gestionAcademica.ToString());

            Impresora.imprimirTitulo("Grupos");
            List<Grupo> grupos = new List<Grupo>();
            foreach (Materia materia in materias)
            {
                grupos.AddRange(Generador.generarGrupos(gestionAcademica, materia));
            }
            foreach (Grupo grupo in grupos)
            {
                Impresora.imprimirLinea(grupo.ToString());
            }
        }
    }
}
