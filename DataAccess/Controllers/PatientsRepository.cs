using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Controllers
{
    public class PatientsRepository : IRepository<Patient>
    {
        private readonly string filePath = "patients.json"; // шлях до файлу JSON

        public List<Patient> GetAll()
        {
            if (!File.Exists(filePath))
                return new List<Patient>();

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<Patient>>(json);
        }

        public void Add(Patient patient)
        {
            List<Patient> patients = GetAll();
            patients.Add(patient);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(patients));
        }
    }
}
