using DesignPattern.Adapter_Bridge.Factory;
using DesignPattern.Adapter_Bridge.Models;
using DesignPattern.Models.Car;
using DesignPattern.Models.Enums;

namespace DesignPattern.Adapter_Bridge
{
    public class Example
    {
        private readonly ICarDataFactory _carDataFactory;
        public Example(ICarDataFactory carDataFactory)
        {
            _carDataFactory = carDataFactory;
        }
        public Car GenSuvCarExample()
        {
            var X1 = new Car(_carDataFactory, CarType.SUV);

            return X1;
        }
        public ConstructionVehicle_Car GenConstructionVehicleExample()
        {
            var ConstructionVehicleDataFactory = new ConstructionVehicleDataFactory();
            var ConstructionVehicleTool = new ConstructionVehicleTool() { ToolName = "吊臂", ToolSize = ToolSize.Medium };
            var Crane = new ConstructionVehicle_Car(_carDataFactory, CarType.ConstructionVehicle, ConstructionVehicleTool, ConstructionVehicleDataFactory);
            return Crane;
        }
    }
}
