using System;

namespace HexaDecimalNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "asd" , "sdad"};
            double value = 0.00;
            foreach(string i in a)
            {
                foreach (char j in i)
                {
                    value += Convert.ToInt32(j);
                }
            }

            Console.WriteLine("sum Of two hexa decimal num:" + value);
        }
    }
}
