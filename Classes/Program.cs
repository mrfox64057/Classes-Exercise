namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dreamCar1 = new Car();
            dreamCar1.Make = "Toyota";
            dreamCar1.Model = "Supra Mk III";
            dreamCar1.Year = 1989;
            Console.WriteLine(dreamCar1.Make + " " + dreamCar1.Model + " " + dreamCar1.Year);

            var dreamCar2 = new Car();
            dreamCar2.Make = "Toyota";
            dreamCar2.Model = "Supra";
            dreamCar2.Year = 1992;
            Console.WriteLine($"{dreamCar2.Make} {dreamCar2.Model} {dreamCar2.Year}");

            var dreamCar3 = new Car();
            dreamCar3.Make = "Toyota";
            dreamCar3.Model = "Celica Supra";
            dreamCar3.Year = 1985;
            Console.Write(dreamCar3.Make +" "); 
            Console.Write(dreamCar3.Model + " "); 
            Console.Write(dreamCar3.Year + " ");
            
        }

           
    }
}
