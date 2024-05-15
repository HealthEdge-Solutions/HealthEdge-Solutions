using HealthEdge_Solutions.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Controller_s
{
    public class MedicalRecordController
    {
        private Repository<MedicalRecord> medicalRecordRepository;

        public MedicalRecordController()
        {
            medicalRecordRepository = new Repository<MedicalRecord>();
            medicalRecordRepository.FilePath = "medical_records.json"; // Приклад шляху до файлу
        }

        public MedicalRecord GetMedicalRecordByPatientId(int patientId)
        {
            return medicalRecordRepository.GetAll().FirstOrDefault(record => record.PatientId == patientId);
        }
    }
}
