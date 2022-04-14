using System;

namespace ConsoleApp7
{
    public class Print
    {
        public double X { get; }
        public double Y { get; }
        public Print(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
        public static class Calculating
        {
            public static double Distance(Print p1, Print p2)
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X,2) + Math.Pow(p1.Y - p2.Y,2));
            }
        }
    

}
