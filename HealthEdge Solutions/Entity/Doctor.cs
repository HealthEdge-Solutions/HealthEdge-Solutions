using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public int MedicalFacilityId { get; set; }
        public List<Appointment> Appointments { get; set; }

        public Doctor()
        {
            DoctorId = 0;
            Name = "";
            Specialization = "";
            MedicalFacilityId = 0;
            Appointments = new List<Appointment>();
        }

        // Конструктор з параметрами
        public Doctor(int doctorId, string name, string specialization, int medicalFacilityId)
        {
            DoctorId = doctorId;
            Name = name;
            Specialization = specialization;
            MedicalFacilityId = medicalFacilityId;
            Appointments = new List<Appointment>();
        }
    }
}
