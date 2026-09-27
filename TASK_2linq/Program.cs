using System;
using System.Linq;
using day10_G01;

namespace TASK_2linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            
            #region Question 01 - Find all products that are out of stock

            // Fluent Syntax
            var outOfStockFluent = ListGenerators.ProductList
                                                 .Where(p => p.UnitsInStock == 0);

            Console.WriteLine("--- Result using Fluent Syntax ---");
            foreach (var product in outOfStockFluent)
            {
                Console.WriteLine(product);
            }

            // Query Syntax
            var outOfStockQuery = from p in ListGenerators.ProductList
                                  where p.UnitsInStock == 0
                                  select p;

            Console.WriteLine("\n--- Result using Query Syntax ---");
            foreach (var product in outOfStockQuery)
            {
                Console.WriteLine(product);
            }
            #endregion

            #region Question 02 - Find all products that are in stock and cost more than 3.00 per unit
            Console.WriteLine("\n==================================================");
            Console.WriteLine("Question 02: Find all products that are in stock and cost more than 3.00 per unit");
            Console.WriteLine("==================================================\n");

            // Fluent Syntax
            var inStockCostMoreThan3Fluent = ListGenerators.ProductList
                                                          .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);

            Console.WriteLine("--- Result using Fluent Syntax ---");
            foreach (var product in inStockCostMoreThan3Fluent)
            {
                Console.WriteLine(product);
            }

            // Query Syntax
            var inStockCostMoreThan3Query = from p in ListGenerators.ProductList
                                           where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
                                           select p;

            Console.WriteLine("\n--- Result using Query Syntax ---");
            foreach (var product in inStockCostMoreThan3Query)
            {
                Console.WriteLine(product);
            }
            #endregion

            #region Question 03 - Returns digits whose name is shorter than their value
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var shortDigitsFluent = Arr.Where((name, index) => name.Length < index);

            Console.WriteLine("--- Result using Fluent Syntax (Indexed Where) ---");
            foreach (var digit in shortDigitsFluent)
            {
                Console.WriteLine(digit);
            }

            // 2. Query Syntax
            var shortDigitsQuery = from item in Arr.Select((name, index) => new { Name = name, Value = index })
                                   where item.Name.Length < item.Value
                                   select item.Name;

            Console.WriteLine("\n--- Result using Query Syntax ---");
            foreach (var digit in shortDigitsQuery)
            {
                Console.WriteLine(digit);
            }
            #endregion

            #endregion
            #region LINQ - Element Operators 
            #region 1. Get first Product out of Stock  
            var result = ListGenerators.ProductList
                           .First(p => p.UnitsInStock == 0);
            Console.WriteLine(result);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var result = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            Console.WriteLine(result);
            #endregion
            #region 3. Retrieve the second number greater than 5

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = Arr
                .Where(x => x > 5)
                .ElementAt(1);

            Console.WriteLine(result);

            #endregion
            #endregion
            #region LINQ - Aggregate Operators 
            #region 1. Uses Count to get the number of odd numbers in the array
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Count(x => x % 2 != 0);

            #endregion
            #region 2. Return a list of customers and how many orders each has

            var result = ListGenerators.CustomerList
                                       .Select(c => new
                                       {
                                           Customer = c,
                                           OrdersCount = c.Orders.Count
                                       });

            #endregion
            #region 3. Return a list of categories and how many products each has
            var result = ListGenerators.ProductList
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    ProductsCount = g.Count()

                });
            #endregion
            #region 4. Get the total of the numbers in an array

            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = Arr.Sum();

            #endregion
            #region 5. Get the total number of characters of all words

            string[] words = File.ReadAllLines("dictionary_english.txt");

            var result = words.Sum(word => word.Length);

            #endregion
            #endregion       
            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name
            var result = ListGenerators.ProductList
                                       .OrderBy(p => p.ProductName);
            #endregion
            #region 2. Case-insensitive sort

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest.
            var result = ListGenerators.ProductList 
                .OrderByDescending(p => p.UnitsInStock);
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };

            var result = Arr.OrderBy(x => x.Length).ThenBy(x => x);
            #endregion
            #region 5. Sort first by word length and then by a case-insensitive sort

            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = words
                .OrderBy(x => x.Length)
                .ThenBy(x => x, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var result = ListGenerators.ProductList .OrderBy(p=>p.Category).ThenByDescending(p => p.UnitPrice);

            #endregion
            #region 7. Sort first by word length and then by a case-insensitive descending sort

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var result = Arr
                .OrderBy(x => x.Length)
                .ThenByDescending(x => x, StringComparer.OrdinalIgnoreCase);

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the  order in the original array.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };
            var result = Arr
                .Where(x => x[1] == 'i').Reverse();
            #endregion



            #endregion
            #region LINQ – Transformation Operators 
            #region 1. Return a sequence of just the names of a list of products.
            var result = ListGenerators.ProductList
                .Select(p => p.ProductName);
            #endregion
            #region 2. Uppercase and lowercase versions

            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            var result = words.Select(word => new
            {
                Upper = word.ToUpper(),
                Lower = word.ToLower()
            });

            #endregion
            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var result = ListGenerators.ProductList.Select(p => new
            {
                ProductName = p.ProductName,
                Category = p.Category,
                Price = p.UnitPrice
            });
            #endregion
            #region 4. Determine if the value of ints in an array match their position in the array. 
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = Arr.Select((x, index) => new
            {
                Number = x,
                InPlace = x == index
            });
            #endregion
            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var result = numbersA
    .SelectMany(a => numbersB
        .Where(b => a < b)
        .Select(b => new { a, b }));
            #endregion
            #region 6. Select all orders where the order total is less than 500.00.
            var result = orders
    .Where(o => o.Total < 500);
            #endregion
            #region 7. Select all orders where the order was made in 1998 or later.
            var result = orders
    .Where(o => o.OrderDate.Year >= 1998);
            #endregion
            #endregion
            #region LINQ - Partitioning Operators 
            #region 1. Get the first 3 orders from customers in Washington 
            var result = Customers
    .Where(c => c.Region == "WA")
    .SelectMany(c => c.Orders)
    .Take(3);
            #endregion
            #region 2. Get all but the first 2 orders from customers in Washington.
            var result = Customers
    .Where(c => c.Region == "WA")
    .SelectMany(c => c.Orders)
    .Skip(2);
            #endregion
            #region 3. Return elements starting from the beginning of the array until a number is hit that is  less than its position in the array. 
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var result = numbers.TakeWhile((num, index) => num >= index);
            #endregion
