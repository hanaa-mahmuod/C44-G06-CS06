using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ASSIGNMENT6
{
    internal class Program
    {
        #region Q1
        // //example of pass value type by value
        //         public static void sum(int a, int b)
        // {
        //     a = 10;
        //     b = 20;
        //     Console.WriteLine($"Inside function: a = {a}, b = {b}");
        // }
        //// example of pass value type by reference
        //         public static void sum(ref int a, ref int b)
        // {
        //     a = 10;
        //     b = 20;
        //     Console.WriteLine($"Inside function: a = {a}, b = {b}");
        // }

        #endregion
        #region Q2
        ///example of pass reference type by value
        //public static void modifyarray(int[] arr)
        //{
        //               arr[0] = 100; // This modifies the original array
        //    Console.WriteLine($"Inside function: arr[0] = {arr[0]}........{arr.GetHashCode()}");

        //}
        /////example of pass reference type by reference
        //public static void modifyarray(ref int[] arr)
        //{
        //    arr[0] = 100; // This modifies the original array
        //    Console.WriteLine($"Inside function: arr[0] = {arr[0]}........{arr.GetHashCode()}");

        //}
        #endregion

        #region Q3
        //public static void SumAndSubtract(int a, int b, out int sum, out int subtract)
        //{
        //    sum = a + b;
        //    subtract = a - b;
        //}
        #endregion
        #region Q4
        //public static int SumOfDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10; // Add the last digit to sum
        //        number /= 10; // Remove the last digit
        //    }
        //    return sum;
        //}
        #endregion
        #region Q5
        //public static bool IsPrime(int number)
        //{


        //    if (number <= 1) return false; // 0 and 1 are not prime numbers
        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false; // If divisible by any number other than 1 and itself, it's not prime
        //    }
        //    return true; // If no divisors found, it's prime
        //}
        #endregion
        #region Q6
        //public static void MinMaxArray(ref int[]arr,out int minn,out int maxx)
        //{
        //    Array.Sort(arr);
        //    minn = arr[0];
        //     maxx = arr[arr.Length - 1];
        //}
        #endregion
        #region Q7

        //public static int Factorial(int n)
        //{
        //    if (n == 0 || n == 1)
        //        return 1; // Base case: 0! = 1 and 1! = 1
        //    else

        //    {// return n * Factorial(n - 1);

        //        int f = 1;
        //        for (int i=1;i<=n;i++)
        //        {
        //            f *= i;

        //        }
        //        return f;

        //    }
        //}
        #endregion
        #region MyRegion
        //public static StringBuilder ChangeChar(StringBuilder s,int pos,char newchar)
        //{

        //    s[pos]= newchar;
        //    return s;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //pass by value pass copy of value not address of it so any changes in value in function do not affect the original value
            //    pass by reference pass address of value so any changes in value in function affect the original value

            //int a = 5, b = 15;
            //sum(a, b);
            //Console.WriteLine($"Outside function: a = {a}, b = {b}"); // This will still print a=5, b=15 because integers are passed by value.

            //int a = 5, b = 15;
            //sum(ref a, ref b);
            //Console.WriteLine($"Outside function: a = {a}, b = {b}");

            #endregion




            #region Q2
            ////pass reference type by value and reference are same they are change of original value 
            //int [] arr = { 1, 2, 3, 4, 5 }; 
            //modifyarray(arr);
            //Console.WriteLine($"Outside function: arr[0] = {arr[0]}........{arr.GetHashCode()}"); // This will print the modified value of arr[0] because arrays are reference types.

            //modifyarray(ref arr);
            //Console.WriteLine($"Outside function: arr[0] = {arr[0]}........{arr.GetHashCode()}");


            #endregion

            #region Q3
            //int a = 10, b = 5,sum, subtract;  
            //  SumAndSubtract(a, b, out sum, out subtract);    
            //  Console.WriteLine($"Sum: {sum}, Subtract: {subtract}"); // This will print the sum and subtract of a and b.
            #endregion
            #region Q4
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //int sum = SumOfDigits(number);
            //Console.WriteLine($"Sum of digits: {sum}"); // This will print the sum of digits of the number.
            #endregion
            #region Q5
            //int number;
            //int.TryParse(Console.ReadLine(), out number);
            //bool isPrime = IsPrime(number); // Change the number to test different cases
            //if (isPrime)
            //{
            //    Console.WriteLine("The number is prime.");
            //}
            //else
            //{
            //    Console.WriteLine("The number is not prime.");
            //}
            #endregion
            #region Q6
            //int[]arr= { 10, 20, 30, 40, 50 };
            //int min, max;
            //MinMaxArray(ref arr, out min, out max);
            //Console.WriteLine($"Minimum: {min}, Maximum: {max}"); // This will print the minimum and maximum values of the array.
            #endregion
            #region Q7
            //int result= Factorial(5); 
            //Console.WriteLine($"Factorial: {result}"); // This will print the factorial of the number.
            #endregion

            #region q8
            //Console.WriteLine("Enter a string:");
            //StringBuilder input = new StringBuilder(Console.ReadLine());
            //Console.WriteLine("Enter the position of the character to change (0-based index):");
            //int position= int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the new character:");
            //char newChar =char.Parse(Console.ReadLine());
            //StringBuilder modifiedString = ChangeChar(input, position, newChar);
            //Console.WriteLine($"Modified string: {modifiedString}"); // This will print the modified string with the character changed at the specified position.
            #endregion

        }
    }
}
