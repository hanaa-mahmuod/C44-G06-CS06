namespace Demo
{
    internal class Program
    { // public static void PrintShape(int count ,string shape="kk")
    //    {
    //        for(int i = 0;i< count; i++)
    //        {
    //         Console.WriteLine(shape);
    //        }
    //    }
    //public static void swap(ref int a,ref int b)
    //{
    //    int temp = a;
    //    a = b;
    //    b = temp;   
    //}

//public static int ArraySum(ref int[] arr)
//        {
//            arr = [ 10, 20, 30, 40, 50 ]; // This line reassigns the reference to a new array.
//            int sum = 0;
//            foreach (int num in arr)
//            {
//                sum += num;
//            }
//            //arr[0] = 30;
//            Console.WriteLine($"Sum of array elements: {sum}.......{arr[0]}.........{arr.GetHashCode()}");
//            return sum;
//        }
//public static void multisum(int a, int b, out int multi,out int sum)
//        {
//           multi=a * b;
//            sum = a + b;
//        }   
        static void Main(string[] args)
        {
            #region functions
            //PrintShape(shape: "hana", count:5);
            //int a=10, b=20; 
            //swap(ref a, ref b); 
            //Console.WriteLine($"a = {a}, b = {b}"); // This will still print a=10, b=20 because integers are passed by value.

            //int[]arr = { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Sum of array elements: .......{arr[0]}.........{arr.GetHashCode()}");

            //int sum = ArraySum(ref arr);
            //Console.WriteLine($"Sum of array elements: {sum}.......{arr[0]}.........{arr.GetHashCode()}");
            //        int multi, sum; 

            //        multisum(10, 20, out  multi, out  sum);
            //        Console
            //.WriteLine($"Multiplication: {multi}, Sum: {sum}"); 



            #endregion
            //#region boxing and unboxing 
            //int x= 10;
            //// Boxing: Converting a value type to an object type
            //object obj = x; // Implicit boxing
            //Console.WriteLine($"Boxed value: {obj}, Type: {obj.GetType()}");
            //x=obj is int ? (int)obj : 0; // Unboxing with type check
            //                             // Unboxing: Converting an object type back to a value type 
            //#endregion
            #region nulable
            int? y = null;
            //int z = y; // This will cause a compile-time error because y is nullable.
            Console.WriteLine();
            string name = null; // Nullable string
            #endregion

        }
    }
}
