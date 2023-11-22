using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_9_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage[] devices = new Storage[]
        {
            new Flash("FlashDrive", "ABC123", 3.0, 64),
            new DVD("DVD-RW", "XYZ789", 6, "двусторонний"),
            new HDD("ExternalHDD", "DEF456", 2.0, 2, 500)
        };

            double totalMemory = 0;
            foreach (var device in devices)
            {
                device.GetDeviceInfo();
                totalMemory += device.GetMemory();
            }

            Console.WriteLine($"Итоговое количество памяти всех устройств : {totalMemory} ГБ");
        }
    }
}
