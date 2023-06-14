using DesignPattern.Adapter_Bridge.DataGenerator;
using DesignPattern.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter_Bridge.Factory
{
    public class ConstructionVehicleDataFactory : ICarDataFactory
    {
        public ConstructionVehicleDataFactory()
        {
        }
        /// <summary>
        /// 取得工程車座位數
        /// </summary>
        /// <param name="carType"></param>
        /// <returns></returns>
        public int GetCarNumOfSeat(CarType carType)
        {
            var constructionVehicle_CarDataGenerator = new ConstructionVehicle_CarDataGenerator();
            return constructionVehicle_CarDataGenerator.GetCarNumOfSeat();
        }
        /// <summary>
        /// 取得工程車輪胎數
        /// </summary>
        /// <param name="carType"></param>
        /// <returns></returns>
        public int GetCarNumOfTire(CarType carType)
        {
            var constructionVehicle_CarDataGenerator = new ConstructionVehicle_CarDataGenerator();
            return constructionVehicle_CarDataGenerator.GetCarNumOfTire();
        }

        /// <summary>
        /// 工具限重
        /// </summary>
        /// <param name="ToolSize"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int GetToolWeightLimit(ToolSize ToolSize)
        {
            switch (ToolSize)
            {
                case ToolSize.Small:
                    return 100;
                case ToolSize.Medium:
                    return 200;
                case ToolSize.Large:
                    return 300;
                default:
                    throw new Exception("ToolSize not found");
            }
        }
    }
}
