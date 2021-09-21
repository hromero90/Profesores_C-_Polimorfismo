namespace Profesores
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;

        }
    }
}