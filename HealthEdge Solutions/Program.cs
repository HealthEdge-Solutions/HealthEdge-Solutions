
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthEdge_Solutions
{

    internal class Program
    {
        public static void PrintName()
        {
            Console.WriteLine("\r\n  _    _            _ _   _     ______    _               _____       _       _   _                 \r\n | |  | |          | | | | |   |  ____|  | |             / ____|     | |     | | (_)                \r\n | |__| | ___  __ _| | |_| |__ | |__   __| | __ _  ___  | (___   ___ | |_   _| |_ _  ___  _ __  ___ \r\n |  __  |/ _ \\/ _` | | __| '_ \\|  __| / _` |/ _` |/ _ \\  \\___ \\ / _ \\| | | | | __| |/ _ \\| '_ \\/ __|\r\n | |  | |  __/ (_| | | |_| | | | |___| (_| | (_| |  __/  ____) | (_) | | |_| | |_| | (_) | | | \\__ \\\r\n |_|  |_|\\___|\\__,_|_|\\__|_| |_|______\\__,_|\\__, |\\___| |_____/ \\___/|_|\\__,_|\\__|_|\\___/|_| |_|___/\r\n                                             __/ |                                                  \r\n                                            |___/                                                   \r\n");
        }
        
        static void Main(string[] args)
        {
            PrintName();

            // Створюємо об'єкт пацієнта (припустимо, що він вже існує)
            Patient patient = new Patient();

            // Основне меню
            while (true)
            {
                Console.WriteLine("Оберіть опцію:");
                Console.WriteLine("1. Записатись на прийом");
                Console.WriteLine("2. Переглянути свої прийоми");
                Console.WriteLine("3. Подивитися свою медичну картку");
                Console.WriteLine("4. Подивитися свої плани лікування");
                Console.WriteLine("5. Подивитися свої медичні тести (аналізи)");
                Console.WriteLine("6. Подивитися своє медичне страхування");
                Console.WriteLine("7. Переглянути відомості про свої рахунки");
                Console.WriteLine("8. Подивитися відомості про медичний заклад");
                Console.WriteLine("9. Вийти");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //patient.MakeAppointment();
                        break;
                    case "2":
                        patient.ViewAppointments();
                        break;
                    case "3":
                        patient.ViewMedicalRecord();
                        break;
                    case "4":
                        patient.ViewTreatmentPlans();
                        break;
                    case "5":
                        patient.ViewMedicalTests();
                        break;
                    case "6":
                        patient.ViewMedicalInsurance();
                        break;
                    case "7":
                        patient.ViewBillingInvoices();
                        break;
                    case "8":
                        patient.ViewMedicalFacilityDetails();
                        break;
                    case "9":
                        Console.WriteLine("Дякую за використання нашої програми. До побачення!");
                        return;
                    default:
                        Console.WriteLine("Невідома опція. Будь ласка, спробуйте ще раз.");
                        break;
                }
            }

            Console.ReadKey();


        }
    }
}