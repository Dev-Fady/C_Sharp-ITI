namespace method
{
    internal class MyClass
    {
        #region Method In Memeory
        //static void PrintMessage(string message)
        //{
        //    message = "world";
        //    Console.WriteLine(message);
        //}
        //static int Add(int a, int b)
        //{
        //    int s = a + b;
        //    return s;
        //}
        //static int PrintAndAdd(int a, int b, string msg)
        //{
        //    PrintMessage(msg);
        //    msg = "aa";
        //    int s = a + b;
        //    return s;
        //} 
        #endregion
        #region Paramter Value Type (ref)
        //static void Swap(int a,int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static void Swap1(ref int a,ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //} 
        #endregion
        #region  Partamter Refence Type
        //static int Sumarr(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        //static int SumarrRef(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        #endregion
        #region Paramater  Reference Type v2
        //static int SumArr(int[] arr)
        //{
        //    int sum= 0;
        //    //arr[0] = 100;
        //    arr =new[]{10, 20, 30};
        //    //arr[0] = 100;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        //static int SumArr2(ref int[] arr)
        //{
        //    int sum = 0;
        //    //arr[0] = 100;
        //    arr = new[] { 10, 20, 30 };
        //    //arr[0] = 100;
        //    foreach (var item in arr)
        //    {
        //        sum += item;
        //    }
        //    return sum;
        //}
        #endregion
        #region Pass By Reference , OutPut Paramter , InPUT Paratmter
        // error invalid 
        //static int SumSubMulti(int a, int b) { 
        //    return a + b;
        //    return a - b;
        //    return a * b;
        //}
        //static int SumSubMulti(int a, int b,ref int sum,ref int sub) {
        //    sum = a + b;
        //    sub = a - b;
        //    return a * b;
        //}
        //static int SumSubMulti1(in int a, int b, out int sum, out int sub)
        //{
        //    sum = a + b;
        //    sub = a - b;
        //    return a * b;
        //}
        #endregion
        #region Optional Paratmer [ Default paratmter]
        //// static void sum(int a = 10, int b = 20)
        ////static void sum(int a , int b = 20)
        //static void sum(int a, int b = 20, int c = 50)
        //{
        //    Console.WriteLine(a + b+c);
        //}
        #endregion
        #region Pass Params Paramater and null
        //static void ArrSum(string? msg, params int[][] arr)
        //{
        //    int sum = 0;
        //    foreach (var item in arr)
        //    {
        //        foreach (var item1 in item)
        //        {
        //            sum += item1;
        //        }
        //    }
        //    Console.WriteLine(msg ?? "null value");
        //    Console.WriteLine(sum);
        //}
        //static void ArrSum2(string msg, int[] arr, params string[] aar)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    Console.WriteLine(sum);
        //}
        #endregion
        static int sum1(int a, int b) //Tradtional Method
        {
            return a + b;
        }
        static int sum2(int a, int b) => a + b; //Method Expression

        static void Main(string[] args)
        {
            #region Method In Memeory
            //PrintMessage("fady emil");
            //int x= Add(1, 2);
            //Console.WriteLine(x);
            //int xx = PrintAndAdd(5, 10, "fady Emil");
            //Console.WriteLine(xx); 
            #endregion
            #region Paramter Value Type (ref)
            //int x = 0 , y=5;
            //Swap(x,y);
            //Console.WriteLine($"x = {x} \t y ={y} ") ;
            //Swap1(ref y, ref x);
            //Console.WriteLine($"x = {x} \t y ={y} "); 
            #endregion
            #region Partamter Refence Type
            //int[] arr = {1,2,3,4};
            //int sum = Sumarr(arr);
            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"first item = {arr[0]}");

            //int[] arrRef = { 1, 2, 3, 4 };
            //int sum2 = SumarrRef(ref arrRef);
            //Console.WriteLine($"sum = {sum2}");
            //Console.WriteLine($"first item = {arrRef[0]}");
            #endregion
            #region Paramater  Reference Type v2
            //int[] arr = { 1, 2, 3 };
            //int sum = SumArr( arr);
            //Console.WriteLine($"sum = {sum}");
            //Console.WriteLine($"first item = {arr[0]}");
            //Console.WriteLine("========================");
            //int[] arr2 = { 1, 2, 3 };
            //int sum2 = SumArr2(ref arr2);
            //Console.WriteLine($"ref sum = {sum2}");
            //Console.WriteLine($"REF first item = {arr2[0]}");
            #endregion
            #region Pass By Reference , OutPut Paramter , InPUT Paratmter
            //int x = 5, y = 3;
            //int sum = 0;
            //int sub = 0;
            //int mul=SumSubMulti(x, y, ref sum, ref sub);
            //Console.WriteLine($"sum = {sum} \t sub = {sub} \t mlu = {mul}");
            //Console.WriteLine("=============================");

            //int a = 10;
            //int b = 20;
            //int sum1;
            //int sub1;
            //int multiply = SumSubMulti1(a, b, out sum1, out sub1);
            //Console.WriteLine($"sum = {sum1} \t sub = {sub1} \t mlu = {multiply}");

            #endregion
            #region Pass Paratmter (BY POSTIOTION , BY NAME)
            //int x = 10;
            //int y = 20;
            //sum(x, y);

            ////by position 
            //sum(x, y);

            ////by name
            //sum(a: x, b: y);
            //sum(b: y, a: x);
            #endregion
            #region Pass Params Paramater
            //ArrSum(null,1,2,3,4,5); //valid 
            //ArrSum("fady", 4, 2, 5, 1); // valid
            //ArrSum(null,{1 ,2 ,3,4}); //!  invalid
            //ArrSum(null,new[] { 1, 2, 3, 4 }); //valid
            //int[] aa = { 1, 2, 3, 4, 5 };
            //int[] bb = { 1, 2, 3, 4, 5 };
            //int[] cc = { 1, 2, 3, 4, 5 };
            //int[] dd = { 1, 2, 3, 4, 5 };
            //ArrSum(null, aa, bb,cc,dd,12,5,4); //! invalid
            //ArrSum(null, aa, bb,cc,dd); // valid
            //ArrSum( "ahmed",aa , 2 , 5, 6);// ! invalid
            //ArrSum("ahmed", 2, 5, 6, aa);//  ! invalid
            //ArrSum("ahmed", bb, aa); //     valild
            #endregion
        }
    }
}