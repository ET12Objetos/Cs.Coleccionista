namespace EjercicioColeccionista
{
    public class Tema
    {
        private string nombre;

        private int duracion;

        public Tema(string nombre, int duracion)
        {
            this.nombre = nombre;
            this.duracion = duracion;
        }

        public string Nombre() => this.nombre;
        public int Duracion() => this.duracion;
    }
}