
public class CarModel{
    public string Brand {get;set;}
    public string CarType {get;set;}
    public int seat {get;set;}
    public Datetime ManufactureDate{get;set;}
    public string ManufactureYearStr{
        get{
            return ManufactureDate.Tostring("yyyy")
        }
    }
    public Decimal Price{get;set;}
}

var MazdaM3 = new CarModel(){
	Brand = "Mazda",
	CarType = "Hatchback",
	seat = 5,
	ManufactureDate = DateTime.Parse("2020/10/10"),
	Price = 990000
}

var BMWX5 =new CarModel(){
	Brand = "BMW",
	CarType = "SUV",
	seat = 5,
	ManufactureDate = DateTime.Parse("2018/10/10"),
	Price = 2590000
}

public class CarModel{
    public string Brand {get;set;}
    public string CarType {get;set;}
    public int seat {get;set;}
    public Datetime ManufactureDate{get;set;}
    public string ManufactureYearStr{
        get{
            return ManufactureDate.Tostring("yyyy")
        }
    }
    public Decimal Price{get;set;}
}

public class TaxiModel : CarModel{
		public string DriverName{get;set;}
		public int Seniority{get;set;}
}

var ToyotaAltisTaxi = new TaxiModel (){
	Brand = "Toyota",
	CarType = "Hatchback",
	seat = 5,
	ManufactureDate = DateTime.Parse("2019/02/10"),
	Price = 700000,
	DriverName = "小明",
	Seniority = 10
}