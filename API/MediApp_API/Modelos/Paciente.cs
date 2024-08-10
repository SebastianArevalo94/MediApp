namespace MediApp_API.Modelos
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public int Telefono { get; set; }
        public int TipoPerfil { get; set; }
    }
}
