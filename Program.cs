using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int empPresent = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (EmpCheck == empPresent)
            {
                Console.WriteLine("Employee Present");
            }
            else
            {
                Console.WriteLine("Employee Absent");
            }
        }
    }
}
