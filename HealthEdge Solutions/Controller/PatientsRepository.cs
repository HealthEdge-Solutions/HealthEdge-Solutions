using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

public class PatientRepository : IRepository<Patient>
{
    private readonly string filePath = "patients.json"; // шлях до файлу JSON

    public void Add(Patient patient)
    {
        List<Patient> patients = GetAll();
        patients.Add(patient);
        File.WriteAllText(filePath, JsonConvert.SerializeObject(patients));
    }
    public List<Patient> GetAll()
    {
        if (!File.Exists(filePath))
        {
            // Якщо файл не існує, повертаємо пустий список пацієнтів
            return new List<Patient>();
        }

        string json = File.ReadAllText(filePath);
        return JsonConvert.DeserializeObject<List<Patient>>(json);
    }
}
