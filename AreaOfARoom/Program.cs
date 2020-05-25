using System;

namespace AreaOfARoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Area of a Room Calculator");
            Console.WriteLine("What is the length of the room(in feet)?");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the room(in feet)?");
            int width = Int32.Parse(Console.ReadLine());

            int area = length * width;
            double areaInMeters = area * 0.09290304;

            Console.WriteLine($"You entered dimensions {length} feet by {width} feet. The area is {area} square feet or {areaInMeters} square meters");


        }
    }
}
