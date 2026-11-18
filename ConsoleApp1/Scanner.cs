using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Scanner : Device
    {
        public int ResolutionDpi { get; }

        public Scanner(string model, int resolutionDpi) : base(model)
        {
            ResolutionDpi = resolutionDpi;
        }

        public override string GetStatus()
        {
            return $"Скан {Model} {ResolutionDpi}" +
                   (IsOn ? "готов к сканированию " : "выкл");
        }
    }
}
