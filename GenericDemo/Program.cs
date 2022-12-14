using GenericDemo.NonGenericMethod;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Non Generic Method");
        bool flag = true;
        while (flag)
        {


            Console.WriteLine("***Select Options:*** \n1.IntArray \n2.DoubleArray  \n3.CharArray  \n4.Exit");
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
                    flag = false;
                    break;
            }
        }
    }
}