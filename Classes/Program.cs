namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car firstCar = new Car();
            firstCar.Make = "Honda";
            firstCar.Model = "Accord";
            firstCar.Year = 2001;
            Console.WriteLine($"My first car was a {firstCar.Year} {firstCar.Make} {firstCar.Model}!");
        }
    }
}
