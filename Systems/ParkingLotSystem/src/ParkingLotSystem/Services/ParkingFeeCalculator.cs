namespace ParkingLotSystem.Services;

public class ParkingFeeCalculator
{
    public double CalculateFee(TimeSpan duration)
    {
        double total = 0;
        double[] rates = { 4.0, 3.5, 2.5 }; // 1st hour, 2nd-3rd hours, remaining hours
        int hours = (int)Math.Ceiling(duration.TotalHours);

        if (hours >= 1) total += rates[0];
        if (hours >= 2) total += rates[1];
        if (hours > 3) total += (hours - 3) * rates[2];

        return total;
    }
}
