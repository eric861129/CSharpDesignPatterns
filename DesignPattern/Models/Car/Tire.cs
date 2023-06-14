using DesignPattern.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Models.Car
{
    public class Tire
    {
        public string Name { get; set; }
        public TireType TireType { get; set; }
        public int TireSize { get; set; }
    }
}
