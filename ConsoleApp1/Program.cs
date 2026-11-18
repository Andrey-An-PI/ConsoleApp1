using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Show_Statuses(IEnumerable<Device> devices)
        {
            foreach (Device d in devices)
            {
                Console.WriteLine(d.GetStatus());
            }
        }
        static void Main()
        {
            Device device = new Printer("TEXNIKA", false);
            device.PowerOn();
            Console.WriteLine(device.GetStatus());

          
            Printer printer_1 = new Printer("Pri_1", true);
            printer_1.PrintTestPage();
            printer_1.PowerOn();
            printer_1.PrintTestPage();

            Printer Printer_2 = new Printer("Pri_2", false);
            Printer_2.PowerOn();
            Printer_2.PrintTestPage();

         
            printer_1.PowerOn();
            Printer_2.PowerOn();
            Console.WriteLine(printer_1.GetStatus());
            Console.WriteLine(Printer_2.GetStatus());

            Scanner scan = new Scanner("Cajh", 60);
            Console.WriteLine(scan.GetStatus());

         
            List<Device> devices = new List<Device> { printer_1, Printer_2, scan };
            scan.PowerOn();
            Show_Statuses(devices);

         
            Scanner scanner200 = new Scanner("200-scan-ylra mega scaner", 100);
            devices.Add(scanner200);
            Show_Statuses(devices);
        }
    }


}


