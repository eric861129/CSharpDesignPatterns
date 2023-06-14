using DesignPattern.Adapter_Bridge.Factory;

namespace DesignPattern.Models.Car
{
    public abstract class Car
    {
        protected ICarDataFactory _carDataFactory;
        public Car(ICarDataFactory carDataFactory)
        {
            _carDataFactory = carDataFactory;
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
        public abstract void SetCarInfo();
    }
}
