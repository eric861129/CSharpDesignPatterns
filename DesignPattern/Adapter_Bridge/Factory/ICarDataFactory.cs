using DesignPattern.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Bridge.Factory
{
    public interface ICarDataFactory
    {
        public int GetCarNumOfSeat(CarType carType);
        public int GetCarNumOfTire(CarType carType);
    }
}
