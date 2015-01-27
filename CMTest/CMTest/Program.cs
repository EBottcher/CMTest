using System;

namespace CMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Business.FizzBuzzService();

            var retList = service.GetFizzBuzzList(1, 100);

            foreach (var s in retList)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
