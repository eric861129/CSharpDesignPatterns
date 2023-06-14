using DesignPattern.Models.Enums;

namespace DesignPattern.Models.Car
{
    public class Tire
    {
        public string Name { get; set; }
        public TireType TireType { get; set; }
        public int TireSize { get; set; }
    }
}
