using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Flash : Storage
    {
        private double usbSpeed;
        private double memorySize;

        public Flash(string name, string model, double usbSpeed, double memorySize)
        {
            this.name = name;
            this.model = model;
            this.usbSpeed = usbSpeed;
            this.memorySize = memorySize;
        }

        public override double GetMemory()
        {
            return memorySize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование данных во флешку. Размер данных: {dataSize} ГБ");
        }

        public override double GetFreeMemory()
        {
            return memorySize; // Примерное значение свободной памяти
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Информация о флешке - Наименование: {name}, Модель: {model}, Скорость USB: {usbSpeed}, Размер свободной памяти: {memorySize} ГБ");
        }
    }
}
