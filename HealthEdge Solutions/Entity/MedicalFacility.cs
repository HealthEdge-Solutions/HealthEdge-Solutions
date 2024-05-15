using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class MedicalFacility
    {
        public int MedicalFacilityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Doctor> Doctors { get; set; }

        // Конструктор за замовчуванням
        public MedicalFacility()
        {
            MedicalFacilityId = 0;
            Name = "";
            Address = "";
            Doctors = new List<Doctor>();
        }

        // Конструктор з параметрами
        public MedicalFacility(int medicalFacilityId, string name, string address)
        {
            MedicalFacilityId = medicalFacilityId;
            Name = name;
            Address = address;
            Doctors = new List<Doctor>();
        }
    }
}
