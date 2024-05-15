using HealthEdge_Solutions.Controller_s;
using HealthEdge_Solutions.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

public class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Address { get; set; }
    public string InsurancePolicyNumber { get; set; }
    public MedicalRecord MedicalRecords { get; set; }


    public Patient(Patient patient)
    {
        this.PatientId = patient.PatientId;
        this.Name = patient.Name;
        this.DateOfBirth = patient.DateOfBirth;
        this.Address = patient.Address;
        this.InsurancePolicyNumber = patient.InsurancePolicyNumber;
        this.MedicalRecords = new MedicalRecord(patient.MedicalRecords);
    }

    // Конструктор за замовчуванням
    public Patient()
    {
        PatientId = 0; // або будь-яке значення за замовчуванням для int
        Name = ""; // або можна залишити null для string
        DateOfBirth = DateTime.MinValue; // або будь-яке значення за замовчуванням для DateTime
        Address = ""; // або можна залишити null для string
        InsurancePolicyNumber = ""; // або можна залишити null для string
        MedicalRecords = new MedicalRecord(); // викликаємо конструктор за замовчуванням MedicalRecord
    }

    // Конструктор з параметрами
    public Patient(int patientId, string name, DateTime dateOfBirth, string address, string insurancePolicyNumber)
    {
        PatientId = patientId;
        Name = name;
        DateOfBirth = dateOfBirth;
        Address = address;
        InsurancePolicyNumber = insurancePolicyNumber;
        MedicalRecords = new MedicalRecord();
    }


    public void MakeAppointment(Doctor doctor, DateTime dateTime)
    {

    }

    public void ViewAppointments()
    {
        AppointmentController appointmentController = new AppointmentController();
        List<Appointment> patientAppointments = appointmentController.GetAllAppointments().Where(appt => appt.PatientId == this.PatientId).ToList();

        if (patientAppointments.Count == 0)
        {
            Console.WriteLine("У вас немає записаних прийомів.");
        }
        else
        {
            Console.WriteLine("Ваші прийоми:");
            foreach (Appointment appointment in patientAppointments)
            {
                DoctorController doctorController = new DoctorController();
                Doctor doctor = doctorController.GetDoctorById(appointment.DoctorId); // Припустимо, що у нас є метод, який повертає лікаря за його ідентифікатором
                Console.WriteLine($"Прийом №{appointment.AppointmentId}: Лікар {doctor.Name}, Час {appointment.DateTime}");
            }
        }
    }

    public void ViewMedicalRecord()
    {
        MedicalRecordController medicalRecordController = new MedicalRecordController();
        MedicalRecord patientMedicalRecord = medicalRecordController.GetMedicalRecordByPatientId(this.PatientId);
        PatientController patientController = new PatientController();
        Patient patient = patientController.GetPatientById(patientMedicalRecord.PatientId);
        if (patientMedicalRecord == null)
        {
            Console.WriteLine("У вас ще немає медичної картки.");
        }
        else
        {
            Console.WriteLine("Ваша медична картка:");
            Console.WriteLine($"Ім'я: {patient.Name}");
            Console.WriteLine($"Адреса: {patient.Address}");
            Console.WriteLine($"Дата народження: {patient.DateOfBirth}");
            Console.WriteLine($"Дата виготовлення картки: {patientMedicalRecord.Date}");
            Console.WriteLine($"Діагнози: {patientMedicalRecord.Diagnosis}");
            Console.WriteLine($"Призначені ліки: {patientMedicalRecord.Medications}");

        }
    }

    public void ViewTreatmentPlans()
    {
        
    }

    public void ViewMedicalTests()
    {
        // Логіка для перегляду медичних тестів (аналізів) пацієнта
    }

    public void ViewMedicalInsurance()
    {
        // Логіка для перегляду медичного страхування пацієнта
    }

    public void ViewBillingInvoices()
    {
        // Логіка для перегляду рахунків пацієнта
    }

    public void ViewMedicalFacilityDetails()
    {
        // Логіка для перегляду деталей медичного закладу
    }
}