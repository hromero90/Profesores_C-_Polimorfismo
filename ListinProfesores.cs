using System;
using System.Collections.Generic;

namespace Profesores
{
    public class ListinProfesores
    {
        private List<Profesor> listinProfesores;

        public ListinProfesores()
        {
            listinProfesores = new List<Profesor>();
        }

        public void addProfesor(Profesor profesor)
        {
            listinProfesores.Add(profesor);
        }

        public void listar()
        {
            foreach (var item in listinProfesores)
            {
                Console.WriteLine(item.mostrarDatos());
            }
        }
    }
}