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

            Console.WriteLine($"Итоговое количество памяти всех устройств : {totalMemory} ГБ");

            double dataSizeToCopy = 565; // Размер данных для копирования в GB

            foreach (var device in devices)
            {
                device.GetDeviceInfo();
                device.CopyData(dataSizeToCopy);
                double timeToCopy = device.CalculateTimeToCopy(dataSizeToCopy);
                Console.WriteLine($"Время для копирования: {timeToCopy} секунд");
                int requiredDevices = device.CalculateRequiredDevices(dataSizeToCopy);
                Console.WriteLine($"Необходимое количество носителей: {requiredDevices}");
                Console.WriteLine();
            }
        }
    }
}
