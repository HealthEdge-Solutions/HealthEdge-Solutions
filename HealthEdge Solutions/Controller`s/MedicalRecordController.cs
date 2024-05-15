using HealthEdge_Solutions.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions.Controller_s
{
    public class AppointmentController
    {
        private Repository<Appointment> appointmentRepository;

        public AppointmentController()
        {
            appointmentRepository = new Repository<Appointment>();
            appointmentRepository.FilePath = "appointments.json"; // Приклад шляху до файлу
        }

        public void AddAppointment(Appointment appointment)
        {
            appointmentRepository.Add(appointment);
        }

        public List<Appointment> GetAllAppointments()
        {
            return appointmentRepository.GetAll();
        }

        public void UpdateAppointment(int appointmentId, Action<Appointment> updateAction)
        {
            appointmentRepository.Update(appt => appt.AppointmentId == appointmentId, updateAction);
        }

        public void DeleteAppointment(int appointmentId)
        {
            appointmentRepository.Delete(appt => appt.AppointmentId == appointmentId);
        }
    }
}
