namespace TaskMethodDay3CSharp
{
    internal class Program
    {
        #region Task 1: Method with Optional Parameters
        static decimal CalculateTotalPrice(decimal price, int quantity = 1, decimal discountPercentage = 0)
        {
            decimal totalBeforeDiscount = price * quantity;
            decimal discountAmount = (totalBeforeDiscount * discountPercentage) / 100;
            return totalBeforeDiscount - discountAmount;
        }
        #endregion
      
        #region Task 2: Method with Out Parameter
        static bool TryDivide(int numerator, int denominator, out int res)
        {
            if (denominator != 0)
            {
                res = numerator / denominator;
                return true;
            }
            res = 0;
            return false;
        }
        #endregion

        #region Task 3: Method with Ref Parameter
        static void SwapValues(ref int  first,ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
        #endregion
        static void Main(string[] args)
        {
             #region Task 1: Method with Optional Parameters
           Console.WriteLine($" test 1  {CalculateTotalPrice(100)}"); // returns 100
           Console.WriteLine($"test 2 {CalculateTotalPrice(100, 2)}"); // returns 200
           Console.WriteLine($"test 3 {CalculateTotalPrice(100, 2, 10)}"); // returns 180
            #endregion
            #region Task 2: Method with Out Parameter
            if (TryDivide(10, 2, out int result))
                Console.WriteLine(result); // 5
            else
                Console.WriteLine("Cannot divide by zero.");
            #endregion

            #region Task 3: Method with Ref Parameter
            int a = 5, b = 10;
            SwapValues(ref a, ref b);
            Console.WriteLine($"a is {a} \t b is {b}");
            #endregion
        }
    }
}
