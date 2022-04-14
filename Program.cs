using System;

namespace ConsoleApp7
{
    class Program
    {
        private readonly IPoint _point;
        public Program (IPoint point)
        {
            _point = point;
        }

        static void Main(string[] args)
        {
            var point = new ReadInput();
            var logic = new Program(point);
            logic.Print();
            Console.ReadKey();
        }

        private void Print()
        {
            Console.WriteLine("Введите первую точку: ");
            var p1 = _point.Input();
            Console.WriteLine("Введите вторую точку: ");
            var p2 = _point.Input();
            var distance = Calculating.Distance(p1, p2);
            Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
        }

    }
}
