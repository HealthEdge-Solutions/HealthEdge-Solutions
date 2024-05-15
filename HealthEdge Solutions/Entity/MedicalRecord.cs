using System;
using System.Collections.Generic;

public class MedicalRecord
{
    public int MedicalRecordId { get; set; }
    public int PatientId { get; set; }
    public DateTime Date { get; set; }
    public List<string> Diagnosis { get; set; }
    public List<string> Medications { get; set; }

    public MedicalRecord(MedicalRecord medicalRecord)
    {
        this.MedicalRecordId = medicalRecord.MedicalRecordId;
        this.PatientId = medicalRecord.PatientId;
        this.Date = medicalRecord.Date;
        this.Diagnosis = new List<string>(medicalRecord.Diagnosis);
        this.Medications = new List<string>(medicalRecord.Medications);
    }

    // Конструктор за замовчуванням 
    public MedicalRecord()
    {
        MedicalRecordId = 0; // або будь-яке значення за замовчуванням для int
        PatientId = 0; // або будь-яке значення за замовчуванням для int
        Date = DateTime.MinValue; // або будь-яке значення за замовчуванням для DateTime
        Diagnosis = new List<string>();
        Medications = new List<string>();
    }

    // Конструктор з параметрами
    public MedicalRecord(int medicalRecordId, int patientId, DateTime date, string diagnosis)
    {
        MedicalRecordId = medicalRecordId;
        PatientId = patientId;
        Date = date;
        Diagnosis = new List<string>();
        Medications = new List<string>();
    }
}