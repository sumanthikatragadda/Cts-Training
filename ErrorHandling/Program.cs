using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n / 2);
                try
                {
                    int[] a = new int[] { 2, 4, 5 };
                    Console.WriteLine(a[2]);
                }
                catch(IndexOutOfRangeException e)
                {

                    Console.WriteLine("inner"+e.Message + " " + e.Source + " " + e.StackTrace);
                }

            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " " + e.Source + " " + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("ended");
            }
            Console.ReadKey();

        }
    }
}
