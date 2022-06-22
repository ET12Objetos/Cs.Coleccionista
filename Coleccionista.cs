namespace EjercicioColeccionista
{
    public class Coleccionista
    {
        private List<Disco> discos;

        public Coleccionista()
        {
            discos = new List<Disco>();
        }

        public void AgregarUn(Disco disco) => discos.Add(disco);

        public void EliminarUn(string nombre)
        {
            var disco = discos.Find(d => d.Nombre == nombre);
            discos.Remove(disco);
        }

        public int CantidadDeDiscos() => discos.Count;

        public Disco BuscarUn(string nombre)
        {
            var disco = discos.Find(disco => disco.Nombre == nombre);
            return disco;
        }

    }
}