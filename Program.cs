using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Исключения
{
    internal class Program
    {
        delegate void SumDelegate(int a, int b);
        static void Main(string[] args)
        {

            SumDelegate sumDelegate = Sum1;
            sumDelegate += Sum2;
            sumDelegate -= Sum2;
            sumDelegate.Invoke(10, 5);
            Console.WriteLine(sumDelegate);
            Console.ReadKey();









            /*try 
            {
                
                throw new RankException("Oshibka");
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType());
                
            }
            finally { Console.Read(); }*/


        }
        static void Sum1(int a, int b)
        {
            int c = a - b;
            Console.WriteLine(c);
        }
        static void Sum2(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
   
}
