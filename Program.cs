using System;

namespace Profesores
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesor _Hector = new Profesor("Hector","Romero",32,"Desconocido");
            _Hector.IdProfesor = "Prof 20-08-2021_TIC";
            DateTime fecha_actual = DateTime.Now;
            fecha_actual = new DateTime(2021,09,20);

            ProfesorTitular _Ethan = new ProfesorTitular("Ethan","Romero",25,"Desconocido");
            _Ethan.IdProfesor = "Prof 10-05-2001_PROG";
            _Ethan.FechaTitular = fecha_actual;


            ProfesorInterino _JuanInterino = new ProfesorInterino("Juan","Perez",25,"Desconocido");
            _JuanInterino.FechaInterinidad = fecha_actual;

            ListinProfesores listin1 = new ListinProfesores();
            listin1.addProfesor(_Hector);
            listin1.addProfesor(_JuanInterino);
            listin1.addProfesor(_Ethan);
            listin1.listar();
        }
    }
}
