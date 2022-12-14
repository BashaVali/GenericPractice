using System;
using GenericDemo.GenericMethod;
using GenericDemo.NonGenericMethod;

namespace GenericDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Genereic & Non Generic Method");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("***Select Options:*** \n1.IntArray \n2.DoubleArray  \n3.CharArray \n4.GenericIntArray \n5.GenericDoubleArray \n6.GenericChararray   \n7.Exit");
                Console.Write("\nEnter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GenericOperation generic = new GenericOperation();
                        int[] intArr = { 1, 2, 3, 4, 5 };
                        generic.ToPrintArray(intArr);
                        break;
                    case 2:
                        GenericOperation generic1 = new GenericOperation();
                        double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                        generic1.ToPrintArray(doubleArr);
                        break;
                    case 3:
                        GenericOperation generic2 = new GenericOperation();
                        char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
                        generic2.ToPrintArray(charArr);
                        break;
                    case 4:
                        GenericOperations generic3 = new GenericOperations();
                        int[] intArrs = { 1, 2, 3, 4, 5 };
                        generic3.ToPrintArray<int>(intArrs);
                        break;
                    case 5:
                        GenericOperations generic4 = new GenericOperations();
                        double[] doubleArrs = { 1.1, 2.2, 3.3, 4.4, 5.5 };
                        generic4.ToPrintArray<double>(doubleArrs);
                        break;
                    case 6:
                        GenericOperations generic5 = new GenericOperations();
                        char[] charArrs = { 'a', 'b', 'c', 'd', 'e' };
                        generic5.ToPrintArray<char>(charArrs);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}