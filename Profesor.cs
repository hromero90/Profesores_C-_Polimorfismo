namespace Profesores
{
    public class Profesor : Persona
    {
        private string idprofesor;

        public string IdProfesor
        {
            get => idprofesor;
            set => idprofesor = value;
        }

        public Profesor(string nombre, string apellido, int edad, string idprofesor) : base(nombre, apellido, edad)
        {
            this.IdProfesor = idprofesor;
        }

        public Profesor() : this("","",0,"Desconocido"){}

        public virtual string mostrarDatos()
        {
            return $"Datos Profesor, Profesor nombre: {Nombre} {Apellido} con Id de profesor: {IdProfesor}";
        }
    }
}