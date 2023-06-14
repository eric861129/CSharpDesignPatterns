using DesignPattern.Adapter_Bridge.Factory;
using DesignPattern.Models.Enums;

namespace DesignPattern.Models.Car
{
    public class Car
    {
        protected ICarDataFactory _carDataFactory;
        protected CarType _CarType;
        public Car(ICarDataFactory carDataFactory, CarType CarType)
        {
            this._carDataFactory = carDataFactory;
            this._CarType = CarType;
        }
        /// <summary>
        /// 車名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 車色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 輪胎
        /// </summary>
        public Tire Tire { get; set; }
        /// <summary>
        /// 輪胎數
        /// </summary>
        public int NumOfTire { get; set; }
        /// <summary>
        /// 座位數
        /// </summary>
        public int NumOfSeat { get; set; }
        /// <summary>
        /// 設定車輛資訊
        /// </summary>
        public virtual void SetCarInfo()
        {
            this.NumOfSeat = _carDataFactory.GetCarNumOfSeat(_CarType);
            this.NumOfTire = _carDataFactory.GetCarNumOfTire(_CarType);
        }
    }
}
