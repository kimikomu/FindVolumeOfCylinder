using System;

namespace FindVolumeOfCylinder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double pi = 3.142;

            // radius in centimeters
            double cylinderRadius = 3.0;

            // height in centimeters
            double cylinderHeight = 4.0;

            // area = pi * radius squared
            double area = pi * (cylinderRadius * cylinderRadius);

            // multiply the area by the height
            double cylinderVolume = cylinderHeight * area;

            Console.WriteLine($"Volume of the cylinder: {cylinderVolume}");
            Console.Read();
        }
    }
}
