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
            int empHr;
            int empRatePerHr = 20;
            if (EmpCheck == empPresent)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            int totalWage = empRatePerHr * empHr;
            Console.WriteLine("Total wage is " + totalWage);
        }
    }
}
