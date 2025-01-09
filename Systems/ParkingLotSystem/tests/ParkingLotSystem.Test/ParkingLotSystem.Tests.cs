using System;
using System.Collections.Generic;
using Xunit;

namespace ParkingLotSystem.Tests
{
    public class ParkingLotTests
    {
        [Fact]
        public void ParkVehicle_ShouldReturnTicket_WhenSpotIsAvailable()
        {
            // Arrange
            var hourlyRates = new Dictionary<VehicleType, double>
            {
                { VehicleType.Bike, 1.0 },
                { VehicleType.Car, 2.0 },
                { VehicleType.Truck, 3.0 }
            };

            var rateCalculator = new ParkingRateCalculator(hourlyRates);

            var floor = new ParkingFloor("TestFloor", new List<IParkingSpot>
            {
                new ParkingSpot("S1", ParkingSpotType.Medium)
            });

            var parkingLot = new ParkingLot("TestLot", new List<ParkingFloor> { floor }, rateCalculator);

            var vehicle = new Vehicle("ABC123", VehicleType.Car);

            // Act
            var ticket = parkingLot.ParkVehicle(vehicle);

            // Assert
            Assert.NotNull(ticket);
            Assert.Equal(vehicle, ticket.Vehicle);
        }

        [Fact]
        public void ReleaseVehicle_ShouldReturnCharges_WhenVehicleIsReleased()
        {
            // Arrange
            var hourlyRates = new Dictionary<VehicleType, double>
            {
                { VehicleType.Bike, 1.0 },
                { VehicleType.Car, 2.0 },
                { VehicleType.Truck, 3.0 }
            };

            var rateCalculator = new ParkingRateCalculator(hourlyRates);

            var floor = new ParkingFloor("TestFloor", new List<IParkingSpot>
            {
                new ParkingSpot("S1", ParkingSpotType.Medium)
            });

            var parkingLot = new ParkingLot("TestLot", new List<ParkingFloor> { floor }, rateCalculator);

            var vehicle = new Vehicle("ABC123", VehicleType.Car);
            var ticket = parkingLot.ParkVehicle(vehicle);

            // Simulate parking duration
            System.Threading.Thread.Sleep(1000); // 1 second

            // Act
            var charges = parkingLot.ReleaseVehicle(ticket);

            // Assert
            Assert.True(charges > 0);
            Assert.Equal(TicketStatus.Paid, ticket.Status);
        }

        [Fact]
        public void ParkVehicle_ShouldThrowException_WhenNoSpotsAvailable()
        {
            // Arrange
            var hourlyRates = new Dictionary<VehicleType, double>
            {
                { VehicleType.Bike, 1.0 },
                { VehicleType.Car, 2.0 },
                { VehicleType.Truck, 3.0 }
            };

            var rateCalculator = new ParkingRateCalculator(hourlyRates);

            var floor = new ParkingFloor("TestFloor", new List<IParkingSpot>()); // No spots

            var parkingLot = new ParkingLot("TestLot", new List<ParkingFloor> { floor }, rateCalculator);

            var vehicle = new Vehicle("ABC123", VehicleType.Car);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => parkingLot.ParkVehicle(vehicle));
        }
    }
}
