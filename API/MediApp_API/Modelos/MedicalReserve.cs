﻿namespace MediApp_API.Modelos
{
    public class MedicalReserve
    {
        public int Id { get; set; }
        public int Id_Patient { get; set; }
        public int Id_Doctor { get; set; }
        public int Specialty { get; set; }
        public DateTime DateTime { get; set; }
        public int Id_Clinic { get; set; }

    }
}
