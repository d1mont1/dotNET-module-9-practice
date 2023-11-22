using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DVD : Storage
    {
        private double readWriteSpeed;
        private string type;

        public DVD(string name, string model, double readWriteSpeed, string type)
        {
            this.name = name;
            this.model = model;
            this.readWriteSpeed = readWriteSpeed;
            this.type = type;
        }

        public override double GetMemory()
        {
            return (type == "односторонний") ? 4.7 : 9; // Размер DVD в зависимости от типа
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование данных в DVD. Размер данных: {dataSize} ГБ");
        }

        public override double GetFreeMemory()
        {
            return GetMemory(); // Примерное значение свободной памяти
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Информация о DVD - Наименование: {name}, Модель: {model}, Скорость чтения/записи: {readWriteSpeed}, Тип: {type}");
        }
    }
}
