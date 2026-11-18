using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Device
    {
        public string Model { get; }
        public bool IsOn { get; set; }
        public Device(string model)
        {
            Model = model;
            IsOn = false;
        }

        public void PowerOn()
        {
            IsOn = true;
        }

        public abstract string GetStatus();
    }
}
