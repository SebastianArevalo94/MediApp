using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Modelos
{
    public class Doctor
    {
        public int Id { get; set; }
        public string First_Names { get; set; } = string.Empty;
        public string Last_Names { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public DbSet<Doctor> doctors { get; set; }
    }
}
