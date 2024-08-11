using Microsoft.EntityFrameworkCore;

namespace MediApp_API.Modelos
{
    public partial class DataBaseContext:DbContext
    {

        public DataBaseContext()
        {

        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options): base(options)
        {

        }

        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<MedicalReserve> MedicalReserves { get; set; }
        public virtual DbSet<MedicalSpecialty> MedicalSpecialties { get; set; }
        public virtual DbSet<Profile_Type> Profile_Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
