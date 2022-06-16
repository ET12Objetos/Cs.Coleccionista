namespace EjercicioColeccionista
{
    public class Vinilo : Disco
    {
        public Vinilo(string nombre, 
            int lanzamiento, 
            string genero, 
            string selloDiscografico, 
            string nombreArtista, 
            string nacionalidadArtista) : 
            base(nombre, lanzamiento, genero, selloDiscografico, nombreArtista, nacionalidadArtista)
        {
        }
    }
}