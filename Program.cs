using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Equinox";
            myCar.Year = 2013;

            Console.WriteLine(myCar.Model);

        }
    }
}
