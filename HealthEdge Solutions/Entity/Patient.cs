﻿using System;
using System.Collections.Generic;

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


    public void MakeAppointment()
    {
        // Логіка для запису на прийом
    }

    public void ViewAppointments()
    {
        // Логіка для перегляду прийомів пацієнта
    }

    public void ViewMedicalRecord()
    {
        // Логіка для перегляду медичної картки пацієнта
    }

    public void ViewTreatmentPlans()
    {
        // Логіка для перегляду планів лікування пацієнта
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