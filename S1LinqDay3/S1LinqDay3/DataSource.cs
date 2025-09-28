using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1LinqDay3
{
    public class Department
    {
        public String Name { get; set; }
        public String Address { get; set; }
    }
    public class Course
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public Subject Subject { get; set; }
        public Department Department { get; set; }
    }
    public class Subject
    {
        public String Name { get; set; }
        public String Description { get; set; }
    }


    public static class DataSource1
    {
        public static List<Subject> Subjects = new List<Subject>
        {
            new Subject { Name = "Programming", Description = "Development Courses" },
            new Subject { Name = "Soft Skills", Description = "HR Courses" },
            new Subject { Name = "Language", Description = "Language Courses" }
        };

        public static List<Department> Departments = new List<Department>
        {
            new Department { Name = "SD", Address = "Assiut" },
            new Department { Name = "Unix", Address = "Alex" },
            new Department { Name = "Java", Address = "Cairo" },
            new Department { Name = "E-Learning", Address = "Alex" }
        };

        public static List<Course> Courses = new List<Course>
        {
            new Course { Name = "English",    Hours = 45, Subject = Subjects[2], Department = Departments[2] },
            new Course { Name = "LINQ",       Hours = 13, Subject = Subjects[0], Department = Departments[0] },
            new Course { Name = "Interview",  Hours = 18, Subject = Subjects[1], Department = Departments[1] },
            new Course { Name = "Flash MX",   Hours = 45, Subject = Subjects[0], Department = Departments[3] },
            new Course { Name = "C#",         Hours = 60, Subject = Subjects[0], Department = Departments[0] },
            new Course { Name = "Agile",      Hours = 34, Subject = Subjects[1], Department = Departments[1] },
        };
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }
    }

    public static class DataSource
    {
        public static List<Category> Categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Beverages", Description = "Soft drinks, coffee, tea, juices" },
            new Category { Id = 2, Name = "Bakery", Description = "Bread, cakes, pastries" },
            new Category { Id = 3, Name = "Dairy", Description = "Milk, cheese, yogurt, butter" },
            new Category { Id = 4, Name = "Meat", Description = "Beef, chicken, fish, seafood" },
            new Category { Id = 5, Name = "Produce", Description = "Fruits and vegetables" },
            new Category { Id = 6, Name = "Frozen Foods", Description = "Frozen meals, ice cream, frozen vegetables" },
            new Category { Id = 7, Name = "Snacks", Description = "Chips, nuts, cookies, candy" },
            new Category { Id = 8, Name = "Pantry", Description = "Rice, pasta, canned goods, sauces" },
            new Category { Id = 9, Name = "Personal Care", Description = "Shampoo, soap, toothpaste" },
            new Category { Id = 10, Name = "Household", Description = "Cleaning supplies, detergents, paper products" }
        };

        public static List<Product> Products = new List<Product>()
        {
            // Beverages
            new Product { Id = 1, Name = "Coca-Cola 1L", Price = 1.99, Quantity = 50, Category = Categories[0] },
            new Product { Id = 2, Name = "Pepsi 1L", Price = 1.89, Quantity = 60, Category = Categories[0] },
            new Product { Id = 3, Name = "Orange Juice", Price = 2.49, Quantity = 40, Category = Categories[0] },
            new Product { Id = 4, Name = "Green Tea", Price = 3.99, Quantity = 30, Category = Categories[0] },
            new Product { Id = 5, Name = "Coffee Powder 200g", Price = 5.49, Quantity = 25, Category = Categories[0] },
            new Product { Id = 6, Name = "Mineral Water 1.5L", Price = 0.99, Quantity = 100, Category = Categories[0] },
            new Product { Id = 7, Name = "Energy Drink", Price = 2.99, Quantity = 45, Category = Categories[0] },
            new Product { Id = 8, Name = "Herbal Tea", Price = 4.29, Quantity = 35, Category = Categories[0] },
            new Product { Id = 9, Name = "Milkshake Bottle", Price = 2.79, Quantity = 40, Category = Categories[0] },
            new Product { Id = 10, Name = "Iced Coffee Can", Price = 3.49, Quantity = 50, Category = Categories[0] },

            // Bakery
            new Product { Id = 11, Name = "White Bread", Price = 1.49, Quantity = 80, Category = Categories[1] },
            new Product { Id = 12, Name = "Brown Bread", Price = 1.69, Quantity = 75, Category = Categories[1] },
            new Product { Id = 13, Name = "Croissant", Price = 2.19, Quantity = 40, Category = Categories[1] },
            new Product { Id = 14, Name = "Muffin", Price = 2.49, Quantity = 50, Category = Categories[1] },
            new Product { Id = 15, Name = "Chocolate Cake", Price = 9.99, Quantity = 20, Category = Categories[1] },
            new Product { Id = 16, Name = "Baguette", Price = 1.99, Quantity = 60, Category = Categories[1] },
            new Product { Id = 17, Name = "Donut", Price = 1.29, Quantity = 90, Category = Categories[1] },
            new Product { Id = 18, Name = "Apple Pie", Price = 7.99, Quantity = 25, Category = Categories[1] },
            new Product { Id = 19, Name = "Cheese Roll", Price = 2.99, Quantity = 35, Category = Categories[1] },
            new Product { Id = 20, Name = "Cinnamon Roll", Price = 3.49, Quantity = 30, Category = Categories[1] },

            // Dairy
            new Product { Id = 21, Name = "Whole Milk 1L", Price = 1.29, Quantity = 100, Category = Categories[2] },
            new Product { Id = 22, Name = "Cheddar Cheese", Price = 4.99, Quantity = 40, Category = Categories[2] },
            new Product { Id = 23, Name = "Butter 200g", Price = 2.79, Quantity = 50, Category = Categories[2] },
            new Product { Id = 24, Name = "Yogurt Cup", Price = 0.99, Quantity = 120, Category = Categories[2] },
            new Product { Id = 25, Name = "Cream Cheese", Price = 3.49, Quantity = 35, Category = Categories[2] },
            new Product { Id = 26, Name = "Mozzarella Cheese", Price = 5.29, Quantity = 25, Category = Categories[2] },
            new Product { Id = 27, Name = "Ice Cream Tub", Price = 6.99, Quantity = 30, Category = Categories[2] },
            new Product { Id = 28, Name = "Whipping Cream", Price = 2.99, Quantity = 40, Category = Categories[2] },
            new Product { Id = 29, Name = "Greek Yogurt", Price = 1.89, Quantity = 60, Category = Categories[2] },
            new Product { Id = 30, Name = "Skimmed Milk 1L", Price = 1.19, Quantity = 80, Category = Categories[2] },

            // Meat
            new Product { Id = 31, Name = "Chicken Breast", Price = 7.99, Quantity = 50, Category = Categories[3] },
            new Product { Id = 32, Name = "Ground Beef", Price = 8.49, Quantity = 45, Category = Categories[3] },
            new Product { Id = 33, Name = "Salmon Fillet", Price = 12.99, Quantity = 25, Category = Categories[3] },
            new Product { Id = 34, Name = "Shrimps 1kg", Price = 14.99, Quantity = 20, Category = Categories[3] },
            new Product { Id = 35, Name = "Lamb Chops", Price = 15.49, Quantity = 15, Category = Categories[3] },
            new Product { Id = 36, Name = "Beef Steak", Price = 13.99, Quantity = 20, Category = Categories[3] },
            new Product { Id = 37, Name = "Turkey Slices", Price = 6.99, Quantity = 40, Category = Categories[3] },
            new Product { Id = 38, Name = "Sausages Pack", Price = 5.49, Quantity = 35, Category = Categories[3] },
            new Product { Id = 39, Name = "Bacon Pack", Price = 4.99, Quantity = 30, Category = Categories[3] },
            new Product { Id = 40, Name = "Fish Fillet", Price = 9.99, Quantity = 25, Category = Categories[3] },

            // Produce
            new Product { Id = 41, Name = "Bananas 1kg", Price = 1.59, Quantity = 100, Category = Categories[4] },
            new Product { Id = 42, Name = "Apples 1kg", Price = 2.49, Quantity = 90, Category = Categories[4] },
            new Product { Id = 43, Name = "Oranges 1kg", Price = 2.29, Quantity = 80, Category = Categories[4] },
            new Product { Id = 44, Name = "Tomatoes 1kg", Price = 1.99, Quantity = 100, Category = Categories[4] },
            new Product { Id = 45, Name = "Potatoes 1kg", Price = 1.49, Quantity = 110, Category = Categories[4] },
            new Product { Id = 46, Name = "Carrots 1kg", Price = 1.39, Quantity = 90, Category = Categories[4] },
            new Product { Id = 47, Name = "Onions 1kg", Price = 1.29, Quantity = 85, Category = Categories[4] },
            new Product { Id = 48, Name = "Lettuce", Price = 1.99, Quantity = 70, Category = Categories[4] },
            new Product { Id = 49, Name = "Cucumber 1kg", Price = 2.19, Quantity = 75, Category = Categories[4] },
            new Product { Id = 50, Name = "Grapes 1kg", Price = 3.99, Quantity = 60, Category = Categories[4] },

        };
    }

}
