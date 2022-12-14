using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo.NonGenericMethod
{
    public class GenericOperation
    {
        public void ToPrintArray(int[] intArr)
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(double[] doubleArr)
        {
            foreach (var data in doubleArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(char[] charArr)
        {
            foreach (var data in charArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}