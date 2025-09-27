namespace S1LinqDay2
{
    internal class Program
    {
        #region SubRoutine - CoRoutine
        //SubRoutine [Inmediate Execution - Eager Execution]
        static IEnumerable<int> SubRoutine()
        {
            return new List<int> { 1, 2, 3, 4, 5 };
        }
        
        //CoRoutine[Defferred Execution]
        static IEnumerable<int> CoRoutine()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }

            yield return 10;
            //-------------------------------------------

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }

            yield return 20;
            //-------------------------------------------

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }
            yield return 30;
            //-------------------------------------------
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i);
            }
            yield return 40;
            //-------------------------------------------

        }
        #endregion

        static string GetNameProduct(Product product)
        {
            return product.Name;
        }

        static dynamic GetNameQuantityProduct(Product product)
        {
            return new { product.Name, product.Quantity };
        }

        static void Main(string[] args)
        {
            #region SubRoutine - CoRoutine
            //foreach (var item in SubRoutine())
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------------------------------");
            //foreach (var item in CoRoutine())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //List<int> list = new List<int>() { 40, -80, 90, -800, -900 };
            //var result1 = list.FilterV1(a => a > 0);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //var result2 = DataSource.Products.FilterV1(a=> a.Quantity >30);
            //var result3 = DataSource.Products.FilterV2(a => a.Quantity > 30);
            //foreach (var product in result3)
            //{
            //    Console.WriteLine(product);
            //}

            //var result4 = DataSource.Products.MySelect(GetNameProduct);
            //var result5 = DataSource.Products.MySelect(a => a.Name);
            //foreach (var item in result4)
            //{
            //    Console.WriteLine(item);
            //}

            //-------------------------------------

            //var result6 = DataSource.Products.MySelect(GetNameQuantityProduct);
            //var result7 = DataSource.Products.MySelect(a => new { a.Name, a.Quantity });
            //foreach (var item in result7)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Quantity);
            //}

            //--------------------------------------

            ////Invalid
            //var result8 = DataSource.Products
            // .MySelect(a => a.Name) // return IEnumerable<string>
            // .FilterV2(a => a.Quantity > 30); // string dosen't have Quantity property

            // //Valid
            //var result9 = DataSource.Products
            //    .MySelect(a => new { a.Name, a.Quantity }) // return IEnumerable<AnonymousType>
            //    .FilterV2(a => a.Quantity > 30); // Valid

            // //Valid
            //var result = DataSource.Products
            //    .FilterV2(a => a.Quantity > 30)
            //    .MySelect(a => a.Name);

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            //var result = DataSource.Products
            //    .Where(a => a.Quantity > 30) // Deferred 
            //    .Select(a => a.Name) // Deferred 
            //    .ToList();   //Eager
            //-----------------------------------------------

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}

            //var result = DataSource.Products
            //    .FilterV2(a => a.Quantity > 30)
            //    .MySelect(a => a.Name)
            //    .ToMyList();

            //----------------------------------------------

            //var result = DataSource.Products.MyFirst();
            //var result = DataSource.Products.MyFirst(a => a.Quantity >= 70);

            //var result = DataSource.Products.MyFirstOrDefault();
            //var result = DataSource.Products.MyFirstOrDefault(a => a.Quantity >= 70);

            //var result = DataSource.Products.First();
            //var result = DataSource.Products.First(a => a.Quantity >= 70);


            //var result = DataSource.Products.FirstOrDefault();
            //var result = DataSource.Products.FirstOrDefault(a => a.Quantity >= 70);

            //-----------------------------------------------

            //var result = DataSource.Products.MyLast();
            //var result = DataSource.Products.MyLast(a => a.Quantity == 50);

            //var result = DataSource.Products.MyLastOrDefault();
            //var result = DataSource.Products.MyLastOrDefault(a => a.Quantity == 50);


            //var result = DataSource.Products.Last();
            //var result = DataSource.Products.Last(a => a.Quantity == 50);

            //var result = DataSource.Products.LastOrDefault();
            //var result = DataSource.Products.LastOrDefault(a => a.Quantity == 50);

            //------------------------------------------------

            //var result = DataSource.Products.MyAny(a => a.Quantity >= 80);
            //var result = DataSource.Products.MyAll(a => a.Quantity >= 80);

            //var result = DataSource.Products.Any(a => a.Quantity >= 80);
            //var result = DataSource.Products.All(a => a.Quantity >= 80);


            //------------------------------------------------------

            //var result = DataSource.Products.MyCount();
            //var result = DataSource.Products.MyCount(a => a.Quantity == 60);

            //var result = DataSource.Products.Count();
            //var result = DataSource.Products.Count(a => a.Quantity == 60);

            //List<int> MyList = new List<int>();
            //MyList.Add(10);
            //MyList.Add(20);
            //MyList.Add(30);
            //var result = MyList.MyReverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------------------------------------");
            //var res2 = MyList.MyOrderBy(x => x);
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
