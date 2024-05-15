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
            
            Console.ReadKey();
        }
    }
}
