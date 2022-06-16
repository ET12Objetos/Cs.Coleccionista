namespace EjercicioColeccionista
{
    public class Disco
    {
        private string nombre;
        private int lanzamiento;
        private string genero;
        private string selloDiscografico;
        private Artista artista;
        private List<Tema> temas;

        public Disco(string nombre, 
            int lanzamiento, 
            string genero, 
            string selloDiscografico, 
            string nombreArtista, 
            string nacionalidadArtista)
        {
            this.nombre = nombre;
            this.lanzamiento = lanzamiento;
            this.selloDiscografico = selloDiscografico;
            this.genero = genero;
            this.artista = new Artista(nombreArtista, nacionalidadArtista);
            this.temas = new List<Tema>();
        }

        public void AgregarUn(Tema tema)
        {
            this.temas.Add(tema);
        }
    }
}