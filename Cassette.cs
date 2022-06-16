namespace EjercicioColeccionista
{
    public class Cassette : Disco
    {
        public Cassette(string nombre, 
            int lanzamiento, 
            string genero, 
            string selloDiscografico, 
            string nombreArtista, 
            string nacionalidadArtista) 
            : base(nombre, lanzamiento, genero, selloDiscografico, nombreArtista, nacionalidadArtista)
        {
        }
    }
}