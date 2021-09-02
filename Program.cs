using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTimePresent = 1;
            int partTimePresent = 2;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            int empHr;
            int empRatePerHr = 20;
            if (EmpCheck == fullTimePresent)
            {
                empHr = 16;
            }
            else if (EmpCheck == partTimePresent)
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
