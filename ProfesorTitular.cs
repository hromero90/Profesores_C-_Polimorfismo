using System;
using System.Data;

namespace Profesores
{
    public class ProfesorTitular : Profesor
    {
        private DateTime fechatitular;
        public DateTime FechaTitular
        {
            get => fechatitular;
            set => fechatitular = value;
        }

        public ProfesorTitular(string nombre, string apellido, int edad, string idprofesor) : base (nombre, apellido, edad, idprofesor)
        {
            FechaTitular = System.DateTime.Now;
        }

        public override string mostrarDatos()
        {
            DateTime date = FechaTitular.Date;
            return "Datos Profesor Titular. "+ "Nombre: "+ Nombre + " Apellido: " + Apellido + " con Id de Profesor: " + IdProfesor + " Comienzo titularidad: " + date.ToString("d");
        }
    }
}