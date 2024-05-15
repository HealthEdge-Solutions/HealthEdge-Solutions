using System.Collections.Generic;

public class TreatmentPlan
{
    public int TreatmentPlanId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string Description { get; set; }
    public List<string> MedicationsNeeded { get; set; }
    // Конструктор за замовчуванням
    public TreatmentPlan()
    {
        TreatmentPlanId = 0;
        PatientId = 0;
        DoctorId = 0;
        Description = "";
        MedicationsNeeded = new List<string>();
    }

    // Конструктор з параметрами
    public TreatmentPlan(int treatmentPlanId, int patientId, int doctorId, string description)
    {
        TreatmentPlanId = treatmentPlanId;
        PatientId = patientId;
        DoctorId = doctorId;
        Description = description;
        MedicationsNeeded = new List<string>();
    }
}