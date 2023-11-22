using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class HDD : Storage
    {
        private double usbSpeed;
        private int partitions;
        private double partitionSize;

        public HDD(string name, string model, double usbSpeed, int partitions, double partitionSize)
        {
            this.name = name;
            this.model = model;
            this.usbSpeed = usbSpeed;
            this.partitions = partitions;
            this.partitionSize = partitionSize;
        }

        public override double GetMemory()
        {
            return partitions * partitionSize;
        }

        public override void CopyData(double dataSize)
        {
            Console.WriteLine($"Копирование данных в HDD. Размер данных: {dataSize} ГБ");
        }

        public override double GetFreeMemory()
        {
            return partitions * partitionSize; // Примерное значение свободной памяти
        }

        public override double CalculateTimeToCopy(double dataSize) //Количество времени для копирования
        {
            double usbSpeedInGBps = usbSpeed * 0.125; // Скорость в GB в секунду
            return dataSize / usbSpeedInGBps; // Время в секундах
        }

        public override int CalculateRequiredDevices(double dataSize) //Расчет необходимого количества носителей информации
        {
            return (int)Math.Ceiling(dataSize / partitionSize); // Округленное количество устройств
        }

        public override void GetDeviceInfo()
        {
            Console.WriteLine($"Информация о HDD - Наименование: {name}, Модель: {model}, Скорость USB: {usbSpeed}, Количество разделов: {partitions}, Объем разделов: {partitionSize} ГБ");
        }
    }
}
