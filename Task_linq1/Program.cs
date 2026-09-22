using System;
using System.Collections;
using System.Collections.Generic;
using T_1;

namespace T_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            PrintHeader("DotNetWithElwakeel - C# Assignment (Day 01)");

            // =========================================================================
            // Part 1 — Implicitly Typed Local Variables (var)
            // =========================================================================
            PrintSectionTitle("Part 1: Implicitly Typed Local Variables (var)");

            // 1. Basic var usage
            Console.WriteLine("--- Question 1: Basic var usage & .GetType() ---");
            var myInt = 42;
            var myString = "Kemet Nile";
            var myDouble = 3.14159;
            var myBool = true;
            var myArray = new int[] { 10, 20, 30 };

            Console.WriteLine($"myInt value: {myInt,-15} | Type: {myInt.GetType()}");
            Console.WriteLine($"myString value: {myString,-12} | Type: {myString.GetType()}");
            Console.WriteLine($"myDouble value: {myDouble,-12} | Type: {myDouble.GetType()}");
            Console.WriteLine($"myBool value: {myBool,-14} | Type: {myBool.GetType()}");
            Console.WriteLine($"myArray value: {"int[]",-13} | Type: {myArray.GetType()}");
            Console.WriteLine();

            // 2. var vs explicit type
            Console.WriteLine("--- Question 2: var vs Explicit Type ---");
            // Version A: Explicit types
            int countA = 100;
            string titleA = "Software Engineer";
            double rateA = 75.50;

            // Version B: Implicitly typed (var)
            var countB = 100;
            var titleB = "Software Engineer";
            var rateB = 75.50;

            /*
             * EXPLANATION:
             * Why is the result exactly the same at compile time?
             * In C#, 'var' is NOT dynamic and does not defer type checking to runtime.
             * Instead, the C# compiler infers the exact type at compile-time from the
             * right-hand side expression (e.g., 100 is inferred as System.Int32).
             * When the IL (Intermediate Language) code is generated, 'var countB = 100;'
             * produces the EXACT same IL instructions as 'int countA = 100;'.
             * Therefore, there is zero performance difference and 100% type safety.
             */
            Console.WriteLine($"Explicit: count={countA} ({countA.GetType()}), title={titleA}, rate={rateA}");
            Console.WriteLine($"var:      count={countB} ({countB.GetType()}), title={titleB}, rate={rateB}");
            Console.WriteLine();


            // =========================================================================
            // Part 2 — Anonymous Types
            // =========================================================================
            PrintSectionTitle("Part 2: Anonymous Types");

            // 3. Anonymous type basics
            Console.WriteLine("--- Question 3: Product Anonymous Type ---");
            var product = new
            {
                Name = "Egyptian Papyrus Notebook",
                Price = 149.99m,
                Quantity = 5
            };
            Console.WriteLine($"Product Name     : {product.Name}");
            Console.WriteLine($"Product Price    : {product.Price:C}");
            Console.WriteLine($"Product Quantity : {product.Quantity}");
            Console.WriteLine();

            // 4. Array of anonymous types
            Console.WriteLine("--- Question 4: Array of Anonymous Types (Students) ---");
            var students = new[]
            {
                new { Name = "Mariam Ahmed", Grade = 95.5 },
                new { Name = "Omar Hassan",  Grade = 88.0 },
                new { Name = "Sara Youssef",  Grade = 92.3 }
            };

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student #{i + 1} -> Name: {students[i].Name,-14} | Grade: {students[i].Grade}");
            }
            Console.WriteLine();

            // 5. Nested anonymous type
            Console.WriteLine("--- Question 5: Nested Anonymous Type (Order & Customer) ---");
            var order = new
            {
                OrderId = 10024,
                OrderDate = DateTime.Now.ToShortDateString(),
                TotalAmount = 750.00m,
                Customer = new
                {
                    Name = "Ziad El-Sayed",
                    City = "Alexandria"
                }
            };
            Console.WriteLine($"Order ID       : {order.OrderId}");
            Console.WriteLine($"Order Date     : {order.OrderDate}");
            Console.WriteLine($"Total Amount   : {order.TotalAmount:C}");
            Console.WriteLine($"Customer Name  : {order.Customer.Name}");
            Console.WriteLine($"Customer City  : {order.Customer.City}");
            Console.WriteLine();


            // =========================================================================
            // Part 3 — Extension Methods
            // =========================================================================
            PrintSectionTitle("Part 3: Extension Methods");

            // 6. String extension method IsPalindrome()
            Console.WriteLine("--- Question 6: String Extension (IsPalindrome) ---");
            string[] testWords = { "Radar", "Level", "Kemet", "Madam", "Egyptian", "noon" };
            foreach (var word in testWords)
            {
                Console.WriteLine($"Is '{word}' a palindrome? -> {word.IsPalindrome()}");
            }
            Console.WriteLine();

            // 7. Int extension method IsPrime()
            Console.WriteLine("--- Question 7: Int Extension (IsPrime) ---");
            int[] testNumbers = { 1, 2, 7, 9, 13, 25, 29, 31, 40 };
            foreach (var num in testNumbers)
            {
                Console.WriteLine($"Is {num,2} a prime number? -> {num.IsPrime()}");
            }
            Console.WriteLine();

            // 8. Array extension method Sum()
            Console.WriteLine("--- Question 8: Array Extension (Sum) ---");
            int[] values = { 10, 25, 5, 40, 20 };
            int arraySum = values.Sum(); // Calls custom Extension Method
            Console.WriteLine($"Array elements: [{string.Join(", ", values)}]");
            Console.WriteLine($"Custom Sum calculated: {arraySum}");
            Console.WriteLine();


            // =========================================================================
            // Part 4 — Collections: List, Hashtable, Dictionary
            // =========================================================================
            PrintSectionTitle("Part 4: Collections: List, Hashtable, Dictionary");

            // 9. List basics
            Console.WriteLine("--- Question 9: List<string> Basics ---");
            List<string> employees = new List<string> { "Ahmed", "Mona", "Ali", "Tarek" };
            Console.WriteLine("Initial List: " + string.Join(", ", employees));

            employees.Add("Hassan");
            Console.WriteLine("After Adding 'Hassan': " + string.Join(", ", employees));

            employees.Remove("Ali");
            Console.WriteLine("After Removing 'Ali': " + string.Join(", ", employees));

            // Search for a name using a loop (NO LINQ)
            string searchTarget = "Mona";
            bool isFound = false;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Equals(searchTarget, StringComparison.OrdinalIgnoreCase))
                {
                    isFound = true;
                    Console.WriteLine($"Search: Found '{searchTarget}' at index {i} (via manual loop).");
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"Search: '{searchTarget}' was not found.");
            }

            Console.WriteLine("Final Employee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine($" - {emp}");
            }
            Console.WriteLine();

            // 10. List of custom objects
            Console.WriteLine("--- Question 10: List<Employee> Filter by Salary ---");
            List<Employee> employeeList = new List<Employee>
            {
                new Employee("Hoda Salem", 8500m),
                new Employee("Kareem Nabil", 12000m),
                new Employee("Farida Adel", 6000m),
                new Employee("Mostafa Kamal", 15500m)
            };

            decimal salaryThreshold = 8000m;
            Console.WriteLine($"Employees with salary above {salaryThreshold:C}:");
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (employeeList[i].Salary > salaryThreshold)
                {
                    Console.WriteLine($" [MATCH] {employeeList[i].Name} - Salary: {employeeList[i].Salary:C}");
                }
            }
            Console.WriteLine();

            // 11. Dictionary basics
            Console.WriteLine("--- Question 11: Dictionary<string, int> Basics ---");
            Dictionary<string, int> productPrices = new Dictionary<string, int>
            {
                { "Papyrus Canvas", 250 },
                { "Alabaster Vase", 450 },
                { "Silver Scarab Amulet", 600 }
            };
            productPrices.Add("Egyptian Cotton Scarf", 180);

            foreach (KeyValuePair<string, int> item in productPrices)
            {
                Console.WriteLine($"Product: {item.Key,-25} | Price: {item.Value} EGP");
            }
            Console.WriteLine();

            // 12. Dictionary lookup with TryGetValue
            Console.WriteLine("--- Question 12: Dictionary Lookup using TryGetValue ---");
            Dictionary<int, string> studentDirectory = new Dictionary<int, string>
            {
                { 101, "Youssef Ibrahim" },
                { 102, "Nourhan Mahmoud" },
                { 103, "Khaled Saeed" },
                { 104, "Salma Gamal" }
            };

            int[] testIds = { 102, 999 };
            foreach (var id in testIds)
            {
                if (studentDirectory.TryGetValue(id, out string? studentName))
                {
                    Console.WriteLine($"Lookup ID {id}: SUCCESS -> Found Student '{studentName}'");
                }
                else
                {
                    Console.WriteLine($"Lookup ID {id}: FAILED  -> No student found with this ID.");
                }
            }
            Console.WriteLine();

            // 13. Hashtable basics
            Console.WriteLine("--- Question 13: Hashtable with Mixed Types ---");
            Hashtable mixedTable = new Hashtable();
            mixedTable.Add(1, "First Entry (Int key -> String value)");
            mixedTable.Add("ConfigKey", 2026);
            mixedTable.Add("IsActive", true);
            mixedTable.Add(10.5, "Double Key Value");

            foreach (DictionaryEntry entry in mixedTable)
            {
                Console.WriteLine($"Key: [{entry.Key} ({entry.Key?.GetType().Name})] -> Value: [{entry.Value} ({entry.Value?.GetType().Name})]");
            }
            Console.WriteLine();

            // 14. Dictionary vs Hashtable
            Console.WriteLine("--- Question 14: Dictionary vs Hashtable Comparison ---");
            Dictionary<string, string> typedDictionary = new Dictionary<string, string>();
            typedDictionary.Add("EG", "Egypt");
            typedDictionary.Add("FR", "France");

            Hashtable nonTypedHashtable = new Hashtable();
            nonTypedHashtable.Add("EG", "Egypt");
            nonTypedHashtable.Add("FR", "France");

            string valDict = typedDictionary["EG"]; // Direct, strongly typed, NO cast required
            string valHash = (string)nonTypedHashtable["EG"]!; // Explicit casting required

            Console.WriteLine($"Dictionary lookup: {valDict} (Retrieved with strong typing)");
            Console.WriteLine($"Hashtable lookup : {valHash} (Retrieved via explicit casting)");
            Console.WriteLine();

            PrintHeader("Assignment Completed Successfully!");
        }

        static void PrintHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================================================================================");
            Console.WriteLine($"   {title}");
            Console.WriteLine("================================================================================");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void PrintSectionTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n>>> {title} <<<");
            Console.ResetColor();
        }
    }
}
