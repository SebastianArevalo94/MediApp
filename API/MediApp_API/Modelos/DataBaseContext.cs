using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Modelos
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
