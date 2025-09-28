using System.Linq;

namespace S1LinqDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Query Syntax - Method Syntax
            //// Query Syntax
            //var result = (from c in DataSource.Courses
            //             where c.Hours > 30
            //             select new { c.Hours, c.Name }).Take(2);

            //// Method Syntax 
            //var result2 = DataSource.Courses
            //             .Where(c => c.Hours > 30)
            //             .Select(c => new { c.Hours, c.Name })
            //             .Take(2); 
            #endregion

            #region Defferred Execution Methods 
            //[Take , Skip , Where , TakeLast, SkipLast , TakeWhile , SkipWhile]
            //var r1 = DataSource1.Courses
            //    .Where(a => a.Hours > 30)
            //    .Take(2)
            //    .ToList();

            //var r3 = DataSource1.Courses
            //    .Where(a => a.Hours > 30)
            //    .TakeLast(2)
            //    .ToList();

            //var r2 = DataSource1.Courses
            //    .Where(a => a.Hours > 30)
            //    .Skip(2)
            //    .ToList();

            //var r4 = DataSource1.Courses
            //   .Where(a => a.Hours > 30)
            //   .SkipLast(2)
            //   .ToList();

            //var r1 = DataSource1.Courses
            //   .Where(a => a.Hours > 30)
            //   .ToList();

            //var r2 = DataSource1.Courses
            //    .SkipWhile(a => a.Hours > 30)
            //    .ToList();

            //var r3 = DataSource1.Courses
            //   .TakeWhile(a => a.Hours > 30)
            //   .ToList();
            #endregion

            #region Pagination
            //var count = DataSource1.Courses.Count();

            //int pageSize = 2;
            //int totalPage = (int)Math.Ceiling((double)count / pageSize);

            //for (int counter = 0; counter < totalPage; counter++)
            //{
            //    var r3 = DataSource1.Courses
            //     .Skip(counter * pageSize)
            //     .Take(pageSize)
            //     .ToList();
            //}
            #endregion

            #region Eager Execution
            //[Sum , Count , Average , Max , MaxBy , Min , MinBy]
            //var r1 = DataSource1.Courses.Sum(a => a.Hours);
            //var r2 = DataSource1.Courses.Count();
            //var r3 = DataSource1.Courses.Where(a => a.Hours > 30).Count();
            //var r4 = DataSource1.Courses.Count(a => a.Hours > 30);
            //var avg = r1 / r2;

            //var r5 = DataSource1.Courses.Average(a => a.Hours);

            ////var max1 = DataSource1.Courses.Max(); //Implement Icomparable interface
            //var max2 = DataSource1.Courses.Max(a => a.Hours);
            //var max3 = DataSource1.Courses.MaxBy(a => a.Hours);

            ////var min1 = DataSource1.Courses.Min(); //Implement Icomparable interface
            //var min2 = DataSource1.Courses.Min(a => a.Hours);
            //var min3 = DataSource1.Courses.MinBy(a => a.Hours);
            #endregion

            #region Eager Execution [All , Any]
            //var r1 = DataSource1.Courses.All(a => a.Hours > 30); // reuten True if all courses have hours > 30
            //var r2 = DataSource1.Courses.Any(a => a.Hours > 30); // reuten True if any course have hours > 30
            #endregion

            #region Eager Execution 
            //[First , FirstOrDefault , Last , LastOrDefault , Single , SingleOrDefault ,ElementAt , ElementAtOrDefault]

            //var r1 = DataSource1.Courses.Where(a => a.Hours > 30).First(); //English Course
            //var r2 = DataSource1.Courses.Where(a => a.Hours > 90).First(); //Throw Exception Squenec Empty

            //var r3 = DataSource1.Courses.First(a => a.Hours > 30); //English Course
            //var r4 = DataSource1.Courses.First(a => a.Hours > 90); //Throw Exception Squenec Empty


            //var r1 = DataSource1.Courses.Where(a => a.Hours > 30).FirstOrDefault(); //English Course
            //var r2 = DataSource1.Courses.Where(a => a.Hours > 90).FirstOrDefault(); //Return Default Value [Null , Zero]

            //var r3 = DataSource1.Courses.FirstOrDefault(a => a.Hours > 30); //English Course
            //var r4 = DataSource1.Courses.FirstOrDefault(a => a.Hours > 90); //Return Default Value [Null , Zero]

            //-------------------------------------------

            //var r1 = DataSource.Courses.Where(a => a.Hours > 30).Last(); //C# Course
            //var r2 = DataSource.Courses.Where(a => a.Hours > 90).Last(); //Throw Exception Squenec Empty

            //var r3 = DataSource.Courses.Last(a => a.Hours > 30); //C# Course
            //var r4 = DataSource.Courses.Last(a => a.Hours > 90); //Throw Exception Squenec Empty

            //var r5 = DataSource.Courses.Where(a => a.Hours > 30).LastOrDefault(); //C# Course
            //var r6 = DataSource.Courses.Where(a => a.Hours > 90).LastOrDefault(); //Return Default Value [Null , Zero]

            //var r7 = DataSource.Courses.LastOrDefault(a => a.Hours > 30); //C# Course
            //var r8 = DataSource.Courses.LastOrDefault(a => a.Hours > 90); //Return Default Value [Null , Zero]

            //---------------------------------------------

            //var r9 =  DataSource1.Courses.Single(a => a.Hours == 60); //C# Course
            //var r10 = DataSource1.Courses.Single(a => a.Hours > 30); //Throw Exception More Than One Element
            //var r11 = DataSource1.Courses.Single(a => a.Hours > 90); //Throw Exception Squenec Empty

            //var r12 = DataSource1.Courses.SingleOrDefault(a => a.Hours == 60); //C# Course
            //var r13 = DataSource1.Courses.SingleOrDefault(a => a.Hours > 30); //Throw Exception More Than One Element
            //var r14 = DataSource1.Courses.SingleOrDefault(a => a.Hours > 90); //Return Default Value [Null , Zero]

            //---------------------------------------------

            //var r1 = DataSource.Courses.Where(a => a.Hours > 30).ElementAt(2); //Flash MX Course
            //var r2 = DataSource.Courses.Where(a => a.Hours > 30).ElementAt(5); //Throw Exception Index Not Found
            //var r3 = DataSource.Courses.Where(a => a.Hours > 30).ElementAtOrDefault(2); //Flash MX Course
            //var r4 = DataSource.Courses.Where(a => a.Hours > 30).ElementAtOrDefault(5); //Return Default Value [Null , Zero]

            #endregion

            #region First vs Take
            // //First[Eager Execution - Return One Object]
            // //Take[Defferred Execution - Return Collection]
            //var r1 = DataSource1.Courses.Where(a => a.Hours > 30).First();
            //var r2 = DataSource1.Courses.Where(a => a.Hours > 30).Take(1).ToList();

            #endregion

            #region Defferred Execution [  GroupBy ] 
            //var data = DataSource1.Courses.GroupBy(a => a.Hours).ToList();

            //var data2 = DataSource1.Courses
            //    .GroupBy(a => a.Hours)
            //    .Select(a => new
            //    {
            //        a.Key,
            //        count = a.Count()
            //    })
            //    .ToList();


            //var data3 = DataSource1.Courses
            //    .GroupBy(a => a.Hours)
            //    .Select(a => new
            //    {
            //        k = a.Key,
            //        count = a.Count()
            //    })
            //    .ToDictionary(a => a.k, a => a.count);

            #endregion

            #region Defferred Execution [Union , InterSect , Concat , Except , Distinct , DistinctBy] 
            //List<int> nums1 = new List<int> { 50, 80, 700, 10, 60 };
            //List<int> nums2 = new List<int> { 70, 80, 755, 833, 45 };

            //var r1 = nums1.Union(nums2);     //[50, 80, 700, 10, 60 , 70,  755, 833, 45 ]
            //var r2 = nums1.Intersect(nums2); // [80] 

            //var r3 = nums1.Concat(nums2);    //[50, 80, 700, 10, 60 ,70, 80, 755, 833, 45 ]
            //var r4 = nums1.Except(nums2);    //[50, 700, 10, 60]

            //var r5 = nums1.Distinct(); // [50, 80, 700, 10, 60]

            //var r7 = nums1.Concat(nums2).Distinct().ToList();//[50, 80, 700, 10, 60 , 70,  755, 833, 45 ]

            //var r6 = DataSource1.Courses.DistinctBy(a => a.Hours); //Distinct Course By Hours
            #endregion

            #region Defferred Execution [UnionBy , IntersectBy , ExceptBy]
            //var r1 = DataSource1.Courses.Where(a => a.Hours >= 45).ToList(); // [English,Flash MX,"C#"] [45,45,60]
            //var r2 = DataSource1.Courses.Where(a => a.Hours <= 45).ToList(); // [English,LINQ,Interview,Flash MX,Agile] [45,13,18,45,34]

            //var r4 = r1.Union(r2).ToList(); //[English,Flash MX,"C#",LINQ,Interview,Agile]
            //var r3 = r1.Intersect(r2).ToList(); //[English,Flash MX]
            //var r5 = r1.Concat(r2).ToList(); //[English,Flash MX,"C#",English,LINQ,Interview,Flash MX]
            //var r6 = r1.Except(r2).ToList(); // ["C#"]

            /*
             Name = "English",    Hours = 45,
             Name = "LINQ",       Hours = 13,
             Name = "Interview",  Hours = 18,
             Name = "Flash MX",   Hours = 45,
             Name = "C#",         Hours = 60,
             Name = "Agile",      Hours = 34,
             */

            //var r7 = r1.UnionBy(r2, a => a.Hours).ToList(); // Distinct Course By Hours Unionn R1 R2 but not Distinct Course By Hours
            //var r8 = r1.IntersectBy(r2.Select(a => a.Hours), a => a.Hours).ToList(); // Distinct Course By Hours InterSect R1 R2 but not Distinct Course By Hours [English]
            //var r9 = r1.ExceptBy(r2.Select(a => a.Hours), a => a.Hours).ToList(); // Distinct Course By Hours Except R1 R2 but not Distinct Course By Hours ["C#"]
            #endregion

            #region Deferred Execution Sorting [OrderBy , ThenBy , OrderByDescending , ThenByDescending]
            //var r1 = DataSource1.Courses.OrderBy(a => a.Hours); //Order by Acsending
            //var r2 = DataSource1.Courses.OrderByDescending(a => a.Hours); //Order by Decsending

            //var r11 = DataSource1.Courses.OrderBy(a => a.Hours).OrderBy(a => a.Name);//.Tolist(); //wrong 


            //var r12 = DataSource1.Courses.OrderBy(a => a.Hours).ThenBy(a => a.Name); //Order by Acsending First Sort by Hours if Hourse متكرر sort Name
            //var r13 = DataSource1.Courses.OrderBy(a => a.Hours).ThenByDescending(a => a.Name); //Order by Acsending
            //var r3 = DataSource1.Courses.OrderByDescending(a => a.Hours); //Order by Decsending
            //var r4 = DataSource1.Courses.OrderByDescending(a => a.Hours).ThenBy(a => a.Name); //Order by Decsending
            //var r5 = DataSource1.Courses.OrderByDescending(a => a.Hours).ThenByDescending(a => a.Name); //Order by Decsending

            ////var r14 = DataSource1.Courses.OrderBy(a => a.Hours).ThenBy(a => a.Name).ThenBy().ThenBy().ThenBy(); //Order by Acsending
            #endregion

            #region Eager Execution [Tolist , ToArray , ToDictionary , ToHashset]
            //var r1 = DataSource1.Courses.Where(a => a.Hours > 30).ToList();
            //var r2 = DataSource1.Courses.Where(a => a.Hours > 30).ToArray();

            //var r3 = DataSource1.Courses.Where(a => a.Hours > 30).ToDictionary(a => a.Name);

            //var r4 = DataSource1.Courses.Where(a => a.Hours > 30).ToDictionary(a => a.Name, b => new { b.Hours, b.Name });
            //var r5 = DataSource1.Courses.Where(a => a.Hours > 30).ToDictionary(a => a.Name, b => b.Hours);

            //var r6 = DataSource1.Courses.Where(a => a.Hours > 30).ToHashSet();
            #endregion

            #region [Contains , StartsWith , EndsWith]
            //var r1 = DataSource1.Courses.Where(a => a.Name.ToLower().StartsWith('a')).ToList();
            //var r2 = DataSource1.Courses.Where(a => a.Name.ToLower().EndsWith('h')).ToList();
            //var r3 = DataSource1.Courses.Where(a => a.Name.ToLower().Contains('i')).ToList();
            //var r4 = DataSource1.Courses
            //         .Where(a => a.Name.ToLower().Contains('i') ||
            //                     a.Name.ToLower().Contains('q') ||
            //                     a.Name.ToLower().Contains('h') ||
            //                     a.Name.ToLower().Contains('d') ||
            //                     a.Name.ToLower().Contains('u'))
            //         .ToList();

            //var r5 = DataSource1.Courses
            //   .Where(a => a.Name.ToLower().Contains('i') ||
            //               a.Hours > 30 ||
            //               a.Subject.Name.Contains('g') &&
            //               a.Department.Name.StartsWith('r') ||
            //               a.Name.ToLower().Contains('u'))
            //   .Select(a => new
            //   {
            //       CourseName = a.Name,
            //       CourseHours = a.Hours,
            //       DeptName = a.Department.Name,
            //       SubjectName = a.Subject.Name
            //   })
            //   .ToList();
            #endregion

            //var data = DataSource.Categories
            //    .Select(a => new
            //    {
            //        CategoryName = a.Name,
            //        TotalProduct = a.Products.Count,
            //    })
            //    .ToList();
        }
    }
}
