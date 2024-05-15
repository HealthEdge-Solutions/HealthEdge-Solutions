using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class MedicalTest
    {
        public int MedicalTestId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Type { get; set; }
        public string Results { get; set; }

        // Конструктор за замовчуванням
        public MedicalTest()
        {
            MedicalTestId = 0;
            PatientId = 0;
            DoctorId = 0;
            Type = "";
            Results = "";
        }

        // Конструктор з параметрами
        public MedicalTest(int medicalTestId, int patientId, int doctorId, string type, string results)
        {
            MedicalTestId = medicalTestId;
            PatientId = patientId;
            DoctorId = doctorId;
            Type = type;
            Results = results;
        }
    }
}
