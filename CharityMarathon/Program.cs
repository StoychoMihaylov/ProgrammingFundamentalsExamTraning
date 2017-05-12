using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int maratonDays = int.Parse(Console.ReadLine());
            long participants = long.Parse(Console.ReadLine());
            int laps = int.Parse(Console.ReadLine());
            long lengthOfTheTrack = long.Parse(Console.ReadLine());
            int capacityOfTheTrack = int.Parse(Console.ReadLine());
            double moneyDonatedPerKilometer = double.Parse(Console.ReadLine());

            int maximumRunners = capacityOfTheTrack * maratonDays;
            if (participants > maximumRunners)
            {
                participants = maximumRunners;
            }

            long totalMeters = participants * laps * lengthOfTheTrack;
            long totalKilometers = totalMeters / 1000;
            double moneyRaisedForMarathon = totalKilometers * moneyDonatedPerKilometer;
            Console.WriteLine("Money raised: {0:F2}", moneyRaisedForMarathon);
        }
    }
}
