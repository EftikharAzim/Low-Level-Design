namespace ParkingLotSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the ParkingLotSystem System!");

            // Setup hourly rates
            var hourlyRates = new Dictionary<VehicleType, double>
            {
                { VehicleType.Bike, 1.0 },
                { VehicleType.Car, 2.0 },
                { VehicleType.Truck, 3.0 }
            };

            // Create ParkingLotSystem
            var rateCalculator = new ParkingRateCalculator(hourlyRates);

            var floor1 = new ParkingFloor("Floor1", new List<IParkingSpot>
            {
                new ParkingSpot("S1", ParkingSpotType.Small),
                new ParkingSpot("M1", ParkingSpotType.Medium),
                new ParkingSpot("L1", ParkingSpotType.Large),
            });

            var floor2 = new ParkingFloor("Floor2", new List<IParkingSpot>
            {
                new ParkingSpot("S2", ParkingSpotType.Small),
                new ParkingSpot("M2", ParkingSpotType.Medium),
                new ParkingSpot("L2", ParkingSpotType.Large),
            });

            var parkingLot = new ParkingLot("Main ParkingLotSystem", new List<ParkingFloor> { floor1, floor2 }, rateCalculator);

            // Simulate parking a vehicle
            var vehicle = new Vehicle("ABC123", VehicleType.Car);
            var ticket = parkingLot.ParkVehicle(vehicle);
            Console.WriteLine($"Vehicle {vehicle.LicensePlate} parked. Ticket ID: {ticket.Id}");

            // Simulate releasing a vehicle
            Console.WriteLine("Press any key to release the vehicle...");
            Console.ReadKey();
            var charges = parkingLot.ReleaseVehicle(ticket);
            Console.WriteLine($"Vehicle {vehicle.LicensePlate} released. Total Charges: ${charges:F2}");
        }
    }
}
