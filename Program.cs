using EjercicioColeccionista;

Coleccionista coleccionista = new Coleccionista();

Vinilo vinilo = new Vinilo("Mystère", 2016, "rock", "Born Bad Records", "La Femme", "Francesa");
vinilo.AgregarUn(new Tema("Sphynx", 180));
vinilo.AgregarUn(new Tema("Le vide est ton nouveau prénom", 200));

Compacto compacto = new Compacto("Hologram EP", 2021, "post punk", "Dedstrange", "La Femme", "Francesa");
compacto.AgregarUn(new Tema("Où va le monde", 190));
compacto.AgregarUn(new Tema("End of the Night", 150));

Cassette cassette = new Cassette("Hologram EP", 2021, "post punk", "Dedstrange", "A Place To Bury Strangers", "Norteamericana");
cassette.AgregarUn(new Tema("End of the Night", 160));
cassette.AgregarUn(new Tema("Playing The Part", 176));

coleccionista.AgregarUn(vinilo);
coleccionista.AgregarUn(compacto);
coleccionista.AgregarUn(cassette);
int cantidad = coleccionista.CantidadDeDiscos();
System.Console.WriteLine($"Cantidad de discos: {cantidad}");
coleccionista.BuscarUn("Hologram EP");
coleccionista.BuscarUn("Paradigmes");
coleccionista.EliminarUn("Mystère");
cantidad = coleccionista.CantidadDeDiscos();
System.Console.WriteLine($"Cantidad de discos: {cantidad}");