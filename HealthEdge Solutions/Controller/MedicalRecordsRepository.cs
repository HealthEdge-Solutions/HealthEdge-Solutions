using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class MedicalRecordsRepository : IRepository<MedicalRecord>
{
    private readonly string filePath = "medicalRecords.json"; // шлях до файлу JSON

    public List<MedicalRecord> GetAll()
    {
        if (!File.Exists(filePath))
            return new List<MedicalRecord>();

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<MedicalRecord>>(json);
    }

    public void Add(MedicalRecord medicalRecord)
    {
        List<MedicalRecord> medicalRecords = GetAll();
        medicalRecords.Add(medicalRecord);
        File.WriteAllText(filePath, JsonConvert.SerializeObject(medicalRecords));
    }
}