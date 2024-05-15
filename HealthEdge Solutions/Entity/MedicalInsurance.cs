using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class MedicalInsurance
    {
        public string InsurancePolicyNumber { get; set; }
        public int PatientId { get; set; }
        public string Company { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        // Конструктор за замовчуванням
        public MedicalInsurance()
        {
            InsurancePolicyNumber = "";
            PatientId = 0;
            Company = "";
            ValidFrom = DateTime.MinValue;
            ValidTo = DateTime.MinValue;
        }

        // Конструктор з параметрами
        public MedicalInsurance(string insurancePolicyNumber, int patientId, string company, DateTime validFrom, DateTime validTo)
        {
            InsurancePolicyNumber = insurancePolicyNumber;
            PatientId = patientId;
            Company = company;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }
    }
}
