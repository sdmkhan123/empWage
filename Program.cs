using System;

namespace empWage
{
    class Program
    {
        public const int fullTimePresent = 1;
        public const int partTimePresent = 2;
        public const int empRatePerHr = 20;
        static void Main(string[] args)
        {
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            int empHr;
            int empRatePerHr = 20;
            switch (EmpCheck)
            {
                case fullTimePresent:
                    empHr = 8;
                    break;
                case partTimePresent:
                    empHr = 4;
                    break;
                default:
                    empHr = 0;
                    break;
            }
            int totalWage = empRatePerHr * empHr;
            Console.WriteLine("Total wage is " + totalWage);
        }
    }
}
