using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Modelos
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Specialty { get; set; }
    }
}
