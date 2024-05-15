using DataAccess.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions
{

    internal class Program
    {
        public static void PrintName()
        {
            Console.WriteLine("\r\n  _    _            _ _   _     ______    _               _____       _       _   _                 \r\n | |  | |          | | | | |   |  ____|  | |             / ____|     | |     | | (_)                \r\n | |__| | ___  __ _| | |_| |__ | |__   __| | __ _  ___  | (___   ___ | |_   _| |_ _  ___  _ __  ___ \r\n |  __  |/ _ \\/ _` | | __| '_ \\|  __| / _` |/ _` |/ _ \\  \\___ \\ / _ \\| | | | | __| |/ _ \\| '_ \\/ __|\r\n | |  | |  __/ (_| | | |_| | | | |___| (_| | (_| |  __/  ____) | (_) | | |_| | |_| | (_) | | | \\__ \\\r\n |_|  |_|\\___|\\__,_|_|\\__|_| |_|______\\__,_|\\__, |\\___| |_____/ \\___/|_|\\__,_|\\__|_|\\___/|_| |_|___/\r\n                                             __/ |                                                  \r\n                                            |___/                                                   \r\n");
        }
        static void Main(string[] args)
        {
            PrintName();
            // Створення репозиторіїв
            IRepository<MedicalRecord> medicalRecordsRepository = new MedicalRecordsRepository();
            IRepository<Patient> patientsRepository = new PatientsRepository();

            // Додавання деяких медичних записів
            medicalRecordsRepository.Add(new MedicalRecord
            {
                MedicalRecordId = 1,
                PatientId = 1,
                Date = DateTime.Now,
                Diagnosis = new List<string> { "Headache", "Fever" },
                Medications = new List<string> { "Ibuprofen", "Paracetamol" }
            });

            medicalRecordsRepository.Add(new MedicalRecord
            {
                MedicalRecordId = 2,
                PatientId = 2,
                Date = DateTime.Now,
                Diagnosis = new List<string> { "Sprained ankle" },
                Medications = new List<string> { "Rest", "Ice", "Compression", "Elevation" }
            });

            // Додавання деяких пацієнтів
            patientsRepository.Add(new Patient
            {
                PatientId = 1,
                Name = "John Doe",
                DateOfBirth = new DateTime(1980, 1, 1),
                Address = "123 Main St",
                InsurancePolicyNumber = "12345"
            });

            patientsRepository.Add(new Patient
            {
                PatientId = 2,
                Name = "Jane Smith",
                DateOfBirth = new DateTime(1990, 5, 10),
                Address = "456 Elm St",
                InsurancePolicyNumber = "67890"
            });

            // Вивід усіх медичних записів
            Console.WriteLine("Medical Records:");
            foreach (var record in medicalRecordsRepository.GetAll())
            {
                Console.WriteLine($"Record ID: {record.MedicalRecordId}");
                Console.WriteLine($"Patient ID: {record.PatientId}");
                Console.WriteLine($"Date: {record.Date}");
                Console.WriteLine($"Diagnosis: {string.Join(", ", record.Diagnosis)}");
                Console.WriteLine($"Medications: {string.Join(", ", record.Medications)}");
                Console.WriteLine();
            }

            // Вивід усіх пацієнтів
            Console.WriteLine("Patients:");
            foreach (var patient in patientsRepository.GetAll())
            {
                Console.WriteLine($"Patient ID: {patient.PatientId}");
                Console.WriteLine($"Name: {patient.Name}");
                Console.WriteLine($"Date of Birth: {patient.DateOfBirth}");
                Console.WriteLine($"Address: {patient.Address}");
                Console.WriteLine($"Insurance Policy Number: {patient.InsurancePolicyNumber}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}