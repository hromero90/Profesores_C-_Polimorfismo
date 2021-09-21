using System;
using System.Data;


namespace Profesores
{
    public class ProfesorInterino : Profesor
    {
        private DateTime fechainterinidad;
        public DateTime FechaInterinidad
        {
            get => fechainterinidad;
            set => fechainterinidad = value;
        }

        public ProfesorInterino(string nombre, string apellido, int edad, string idprofesor) : base(nombre, apellido, edad, idprofesor)
        {
            FechaInterinidad = System.DateTime.Now;
        }

        public override string mostrarDatos()
        {
            DateTime date = FechaInterinidad.Date;
            return "Datos Profesor Interino. Comienzo interinidad: " + date.ToString("d");

        }
    }
    
}