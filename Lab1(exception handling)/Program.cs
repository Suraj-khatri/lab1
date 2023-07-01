using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_exception_handling_
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                int z = x/y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            Console.ReadKey();

        }
    }
}
