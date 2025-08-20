namespace Assignment_7._4
{
    //Design a parking system for a parking lot. The parking lot has three kinds of
    //parking spaces: big, medium, and small, with a fixed number of slots for each size.
    //must implement ParkingSystem Class
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);

            Console.WriteLine(parkingSystem.AddCar(1)); // return true Big car

            Console.WriteLine(parkingSystem.AddCar(2)); // return true Med car

            Console.WriteLine(parkingSystem.AddCar(3)); // return false Small car

            Console.WriteLine(parkingSystem.AddCar(1)); // return false 2nd Big car
        }
    }
}
