using System;

namespace CanHazSourceLink.Oranges
{
    public class OrangesClass
    {
        public void MyMethod()
        {
            if (!string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("ORANGES")))
            {
                Console.WriteLine("oranges");
            }
        }
    }
}
