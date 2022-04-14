using System;

namespace ConsoleApp7
{
    public interface IPoint
    {
        Print Input();
    }
    public class ReadInput : IPoint
    {
        public Print Input()
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            return new Print(x, y);
        }
    }
}
