using System;
namespace classExample
{
    public class Car
    {
		public string brand;
		public string model;
		public string type;
		public double displacement;
		public int cylinders;
		public string transmission;
        public int year;
		public string vin;

        public Car()
		{
			
		}
        public Car(string carBrand, string carModel, string carType, double fuelDisplacement, int engCylinders, string trans, int modelYear, string carVIN)
		{
			this.brand = carBrand;
			this.model = carModel;
			this.type = carType;
			this.displacement = fuelDisplacement;
			this.cylinders = engCylinders;
			this.transmission = trans;
			this.year = modelYear;
			this.vin = carVIN;
		}
        public string showCar()
		{
			Console.WriteLine("Brand: " + brand);
			Console.WriteLine("Model: " + model);
			Console.WriteLine("Type: " + type);
			Console.WriteLine("Displacement: " + displacement + "L");
			Console.WriteLine("V" + cylinders);
			Console.WriteLine("Transmission: " + transmission);
			Console.WriteLine("Model Year: " + year);
			Console.WriteLine("Vehicle ID Number: " + vin);
			return "Here is your car";
		}
        
    }
    public class MyClass 
	{
		static void Main(string[] args)
        {
            Car chevyCorvette = new Car("Chevy", "Corvette", "Coupe", 6.0, 8, "Manual", 2019, "1GCEC14C1FF381516");
            chevyCorvette.showCar();

			Car dodgeCoronet = new Car("Dodge", "Coronet", "Coupe", 6.0, 8, "Manual", 2019, "1GCEC14C1FF381516");
			dodgeCoronet.showCar();
        }
	}
}
