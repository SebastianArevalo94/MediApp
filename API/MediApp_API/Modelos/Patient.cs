using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Modelos
{
    public class Patient
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Last_Names { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Phone_Number { get; set; }
        public int Profile_Type { get; set; }
        public DbSet<Patient> Patients { get; set; }
    }
}
