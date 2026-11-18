using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Printer : Device
    {
        public bool IsColor { get; set; }

        public Printer(string model, bool isColor) : base(model)
        {
            IsColor = isColor;
        }

        public void PrintTestPage()
        {
            if (!IsOn)
            {
                Console.WriteLine($"{Model}:питание выкл");
                return;
            }
            string color = IsColor ? "цветная" : "монохромная";
            Console.WriteLine($"{Model}: тест страница готова");
        }
        public override string GetStatus()
        {
            string color = IsColor ? "цветной" : "монохромный";
            return $"Принтер {Model}: " +
                   (IsOn ? "готов " : "выкл");
        }
    }
}
