namespace EjercicioColeccionista
{
    public class Artista
    {
        private string nombre;
        private string nacionalidad;

        public Artista(string nombre, string nacionalidad)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }

        public string Nombre() => this.nombre;

        public string Nacionalidad()
        {
            return this.nacionalidad;
        }
            
    }
}