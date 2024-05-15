using HealthEdge_Solutions.Entity;
using System.Collections.Generic;
using System;
using System.Linq;

public class DoctorController
{
    private Repository<Doctor> doctorRepository;

    public DoctorController()
    {
        doctorRepository = new Repository<Doctor>();
        doctorRepository.FilePath = "doctors.json"; // Приклад шляху до файлу
    }

    public void AddDoctor(Doctor doctor)
    {
        doctorRepository.Add(doctor);
    }

    public List<Doctor> GetAllDoctors()
    {
        return doctorRepository.GetAll();
    }

    public void UpdateDoctor(int doctorId, Action<Doctor> updateAction)
    {
        doctorRepository.Update(doc => doc.DoctorId == doctorId, updateAction);
    }

    public void DeleteDoctor(int doctorId)
    {
        doctorRepository.Delete(doc => doc.DoctorId == doctorId);
    }

    public Doctor GetDoctorById(int doctorId)
    {
        return doctorRepository.GetAll().FirstOrDefault(doc => doc.DoctorId == doctorId);
    }
}