using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Storage
    {
        protected string name;
        protected string model;

        public abstract double GetMemory();
        public abstract void CopyData(double dataSize);
        public abstract double GetFreeMemory();
        public abstract void GetDeviceInfo();
    }
}
