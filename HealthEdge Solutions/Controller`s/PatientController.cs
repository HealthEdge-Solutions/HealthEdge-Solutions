using HealthEdge_Solutions.Entity;
using System.Collections.Generic;
using System;
using System.Linq;

public class PatientController
{
    private Repository<Patient> patientRepository;

    public PatientController()
    {
        patientRepository = new Repository<Patient>();
        patientRepository.FilePath = "patients.json"; // Приклад шляху до файлу
    }

    public void AddPatient(Patient patient)
    {
        patientRepository.Add(patient);
    }

    public List<Patient> GetAllPatients()
    {
        return patientRepository.GetAll();
    }

    public Patient GetPatientById(int patientId)
    {
        return patientRepository.GetAll().FirstOrDefault(patient => patient.PatientId == patientId);
    }

    public void UpdatePatient(int patientId, Action<Patient> updateAction)
    {
        patientRepository.Update(pat => pat.PatientId == patientId, updateAction);
    }

    public void DeletePatient(int patientId)
    {
        patientRepository.Delete(pat => pat.PatientId == patientId);
    }
}
