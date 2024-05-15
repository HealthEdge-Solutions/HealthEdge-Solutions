using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Entity
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime DateTime { get; set; }

        public Appointment()
        {
            AppointmentId = 0;
            PatientId = 0;
            DoctorId = 0;
            DateTime = DateTime.MinValue;
        }

        // Конструктор з параметрами
        public Appointment(int appointmentId, int patientId, int doctorId, DateTime dateTime)
        {
            AppointmentId = appointmentId;
            PatientId = patientId;
            DoctorId = doctorId;
            DateTime = dateTime;
        }
    }
}
