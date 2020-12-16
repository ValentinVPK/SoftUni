using System;

namespace _8.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double maxVolume = 0.0;
            string maxVolumeModel = "";

            for (int index = 1; index <= numberOfKegs; index++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * kegRadius * kegRadius * kegHeight;
                if (kegVolume >= maxVolume)
                {
                    maxVolume = kegVolume;
                    maxVolumeModel = kegModel;
                }
            }
            Console.WriteLine(maxVolumeModel);
        }
    }
}
