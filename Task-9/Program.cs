using System;

namespace Task_9
{
    #region Problem-1

    //enum Weekdays
    //{
    //    Monday = 1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //}

    #endregion

    #region Problem-2

    //enum Grades : short
    //{
    //    F = 1,
    //    D,
    //    C,
    //    B,
    //    A
    //}

    #endregion

    #region Problem-3

    //class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string Department { get; set; }
    //}

    #endregion

    #region Problem-4

    //class Person
    //{
    //    public virtual decimal Salary { get; set; }
    //}

    //class Child : Person
    //{
    //    public sealed override decimal Salary { get; set; }

    //    public void DisplaySalary()
    //    {
    //        Console.WriteLine($"Salary: {Salary}");
    //    }
    //}

    #endregion

    #region Problem-5

    //class Utility
    //{
    //    public static double CalculatePerimeter(double length, double width)
    //    {
    //        return 2 * (length + width);
    //    }
    //}

    #endregion

    #region Problem-6

    //class ComplexNumber
    //{
    //    public double Real { get; set; }
    //    public double Imaginary { get; set; }

    //    public ComplexNumber(double real, double imaginary)
    //    {
    //        Real = real;
    //        Imaginary = imaginary;
    //    }

    //    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    //    {
    //        return new ComplexNumber(
    //            c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
    //            c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
    //        );
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Real} + {Imaginary}i";
    //    }
    //}

    #endregion

    #region Problem-7

    //enum GenderDefault
    //{
    //    Male,
    //    Female
    //}

    //enum Gender : byte
    //{
    //    Male,
    //    Female
    //}

    #endregion

    #region Problem-8

    //class Utility
    //{
    //    public static double CalculatePerimeter(double length, double width)
    //    {
    //        return 2 * (length + width);
    //    }

    //    public static double CelsiusToFahrenheit(double celsius)
    //    {
    //        return (celsius * 9 / 5) + 32;
    //    }

    //    public static double FahrenheitToCelsius(double fahrenheit)
    //    {
    //        return (fahrenheit - 32) * 5 / 9;
    //    }
    //}

    #endregion

    #region Problem-9

    //enum Grades
    //{
    //    F = 1,
    //    D,
    //    C,
    //    B,
    //    A
    //}

    #endregion

    #region Problem-10

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Employee employee)
    //        {
    //            return Id == employee.Id;
    //        }

    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return Id.GetHashCode();
    //    }

    //    public override string ToString()
    //    {
    //        return $"Id: {Id}, Name: {Name}";
    //    }
    //}

    //class Helper2<T>
    //{
    //    public static int SearchArray(T[] array, T value)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (array[i].Equals(value))
    //            {
    //                return i;
    //            }
    //        }

    //        return -1;
    //    }

    //    public static void ReplaceArray(T[] array, T oldValue, T newValue)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (array[i].Equals(oldValue))
    //            {
    //                array[i] = newValue;
    //            }
    //        }
    //    }
    //}

    #endregion

    #region Problem-11

    //class Helper<T> where T : IComparable<T>
    //{
    //    public static T Max(T value1, T value2)
    //    {
    //        return value1.CompareTo(value2) > 0 ? value1 : value2;
    //    }
    //}

    #endregion

    #region Problem-12

    //The ReplaceArray method replaces all occurrences of a specified value
    //in an array with another value.

    #endregion

    #region Problem-13

    //struct Rectangle
    //{
    //    public double Length { get; set; }
    //    public double Width { get; set; }

    //    public Rectangle(double length, double width)
    //    {
    //        Length = length;
    //        Width = width;
    //    }
    //}

    //class Helper3
    //{
    //    public static void Swap(ref Rectangle rectangle1, ref Rectangle rectangle2)
    //    {
    //        Rectangle temp = rectangle1;
    //        rectangle1 = rectangle2;
    //        rectangle2 = temp;
    //    }
    //}

    #endregion

    #region Problem-14

    //class Department
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Department department)
    //        {
    //            return Id == department.Id;
    //        }

    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return Id.GetHashCode();
    //    }
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Department Department { get; set; }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Employee employee)
    //        {
    //            return Department.Equals(employee.Department);
    //        }

    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return Department.GetHashCode();
    //    }
    //}

    #endregion
    #region Problem-15

    //struct Circle
    //{
    //    public double Radius { get; set; }
    //    public string Color { get; set; }

    //    public static bool operator ==(Circle c1, Circle c2)
    //    {
    //        return c1.Radius == c2.Radius && c1.Color == c2.Color;
    //    }

    //    public static bool operator !=(Circle c1, Circle c2)
    //    {
    //        return !(c1 == c2);
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Circle circle)
    //        {
    //            return Radius == circle.Radius && Color == circle.Color;
    //        }

    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return HashCode.Combine(Radius, Color);
    //    }
    //}

    //class CircleClass
    //{
    //    public double Radius { get; set; }
    //    public string Color { get; set; }
    //}
    #endregion
    // =================================================================================================
    //Part02

    #region Problem-1

    //class HelperReverse
    //{
    //    public static T[] ReverseArray<T>(T[] array)
    //    {
    //        T[] reversedArray = new T[array.Length];

    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            reversedArray[i] = array[array.Length - 1 - i];
    //        }

    //        return reversedArray;
    //    }
    //}

    #endregion


    #region Problem-2

    //class GenericStack<T>
    //{
    //    private T[] items;
    //    private int top;

    //    public GenericStack(int size)
    //    {
    //        items = new T[size];
    //        top = -1;
    //    }

    //    public void Push(T item)
    //    {
    //        if (top == items.Length - 1)
    //        {
    //            Console.WriteLine("Stack is full.");
    //            return;
    //        }

    //        top++;
    //        items[top] = item;
    //    }

    //    public T Pop()
    //    {
    //        if (top == -1)
    //        {
    //            Console.WriteLine("Stack is empty.");
    //            return default(T);
    //        }

    //        T item = items[top];
    //        top--;

    //        return item;
    //    }

    //    public T Peek()
    //    {
    //        if (top == -1)
    //        {
    //            Console.WriteLine("Stack is empty.");
    //            return default(T);
    //        }

    //        return items[top];
    //    }
    //}

    #endregion


    #region Problem-3

    //class HelperSwap
    //{
    //    public static void Swap<T>(T[] array, int index1, int index2)
    //    {
    //        T temp = array[index1];
    //        array[index1] = array[index2];
    //        array[index2] = temp;
    //    }
    //}

    #endregion


    #region Problem-4

    //class HelperMax
    //{
    //    public static T Max<T>(T[] array) where T : IComparable<T>
    //    {
    //        T max = array[0];

    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            if (array[i].CompareTo(max) > 0)
    //            {
    //                max = array[i];
    //            }
    //        }

    //        return max;
    //    }
    //}



    #endregion

    class Program
    {
        static void Main()
        {
            #region Problem-1

//foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//{
//    Console.WriteLine($"{day} = {(int)day}");
//}

#endregion

#region Problem-2

//foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//{
//    Console.WriteLine($"{grade} = {(short)grade}");
//}

#endregion

#region Problem-3

//Person person1 = new Person
//{
//    Name = "Rawda",
//    Age = 21,
//    Department = "Artificial Intelligence"
//};

//Person person2 = new Person
//{
//    Name = "Ahmed",
//    Age = 22,
//    Department = "Computer Science"
//};

//Console.WriteLine($"Name: {person1.Name}");
//Console.WriteLine($"Age: {person1.Age}");
//Console.WriteLine($"Department: {person1.Department}");

//Console.WriteLine();

//Console.WriteLine($"Name: {person2.Name}");
//Console.WriteLine($"Age: {person2.Age}");
//Console.WriteLine($"Department: {person2.Department}");

#endregion

#region Problem-4

//Child child = new Child();

//child.Salary = 15000;

//child.DisplaySalary();

#endregion

#region Problem-5

//double perimeter = Utility.CalculatePerimeter(10, 5);

//Console.WriteLine($"Perimeter = {perimeter}");

#endregion

#region Problem-6

//ComplexNumber num1 = new ComplexNumber(2, 3);
//ComplexNumber num2 = new ComplexNumber(4, 5);

//ComplexNumber result = num1 * num2;

//Console.WriteLine($"Result = {result}");

#endregion

#region Problem-7

//Console.WriteLine($"Default enum size: {sizeof(GenderDefault)} byte(s)");
//Console.WriteLine($"Byte enum size: {sizeof(Gender)} byte(s)");

#endregion

#region Problem-8

//double fahrenheit = Utility.CelsiusToFahrenheit(25);
//double celsius = Utility.FahrenheitToCelsius(77);

//Console.WriteLine($"25 Celsius = {fahrenheit} Fahrenheit");
//Console.WriteLine($"77 Fahrenheit = {celsius} Celsius");

#endregion

#region Problem-9

//Console.Write("Enter a grade: ");
//string input = Console.ReadLine();

//if (Enum.TryParse(input, true, out Grades grade))
//{
//    Console.WriteLine($"Valid Grade: {grade}");
//}
//else
//{
//    Console.WriteLine("Invalid Grade.");
//}

#endregion

#region Problem-10

//Employee[] employees =
//{
//    new Employee { Id = 1, Name = "Rawda" },
//    new Employee { Id = 2, Name = "Ahmed" },
//    new Employee { Id = 3, Name = "Sara" }
//};

//Employee searchEmployee = new Employee
//{
//    Id = 2,
//    Name = "Ahmed"
//};

//int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//if (index != -1)
//{
//    Console.WriteLine($"Employee found at index: {index}");
//    Console.WriteLine(employees[index]);
//}
//else
//{
//    Console.WriteLine("Employee not found.");
//}

#endregion

#region Problem-11

//int maxInt = Helper<int>.Max(10, 20);
//double maxDouble = Helper<double>.Max(15.5, 12.3);
//string maxString = Helper<string>.Max("Apple", "Orange");

//Console.WriteLine($"Max Integer: {maxInt}");
//Console.WriteLine($"Max Double: {maxDouble}");
//Console.WriteLine($"Max String: {maxString}");

#endregion

#region Problem-12

//int[] numbers = { 1, 2, 2, 3, 2, 4 };

//Helper2<int>.ReplaceArray(numbers, 2, 10);

//Console.WriteLine("Integer Array:");
//Console.WriteLine(string.Join(", ", numbers));

//string[] names = { "Rawda", "Ahmed", "Rawda", "Sara" };

//Helper2<string>.ReplaceArray(names, "Rawda", "Mona");

//Console.WriteLine("String Array:");
//Console.WriteLine(string.Join(", ", names));

#endregion

#region Problem-13

//Rectangle rectangle1 = new Rectangle(10, 5);
//Rectangle rectangle2 = new Rectangle(20, 8);

//Console.WriteLine($"Before Swap:");
//Console.WriteLine($"Rectangle 1: Length = {rectangle1.Length}, Width = {rectangle1.Width}");
//Console.WriteLine($"Rectangle 2: Length = {rectangle2.Length}, Width = {rectangle2.Width}");

//Helper3.Swap(ref rectangle1, ref rectangle2);

//Console.WriteLine();
//Console.WriteLine($"After Swap:");
//Console.WriteLine($"Rectangle 1: Length = {rectangle1.Length}, Width = {rectangle1.Width}");
//Console.WriteLine($"Rectangle 2: Length = {rectangle2.Length}, Width = {rectangle2.Width}");

#endregion

#region Problem-14

//Department department1 = new Department
//{
//    Id = 1,
//    Name = "Artificial Intelligence"
//};

//Department department2 = new Department
//{
//    Id = 2,
//    Name = "Computer Science"
//};

//Employee[] employees =
//{
//    new Employee { Id = 1, Name = "Rawda", Department = department1 },
//    new Employee { Id = 2, Name = "Ahmed", Department = department2 },
//    new Employee { Id = 3, Name = "Sara", Department = department1 }
//};

//Employee searchEmployee = new Employee
//{
//    Department = new Department
//    {
//        Id = 1,
//        Name = "Artificial Intelligence"
//    }
//};

//int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

//if (index != -1)
//{
//    Console.WriteLine($"Employee found at index: {index}");
//    Console.WriteLine($"Name: {employees[index].Name}");
//    Console.WriteLine($"Department: {employees[index].Department.Name}");
//}
//else
//{
//    Console.WriteLine("Employee not found.");
//}

#endregion
#region Problem-15

//Circle circle1 = new Circle
//{
//    Radius = 5,
//    Color = "Red"
//};

//Circle circle2 = new Circle
//{
//    Radius = 5,
//    Color = "Red"
//};

//Console.WriteLine($"Struct == : {circle1 == circle2}");
//Console.WriteLine($"Struct Equals : {circle1.Equals(circle2)}");

//CircleClass classCircle1 = new CircleClass
//{
//    Radius = 5,
//    Color = "Red"
//};

//CircleClass classCircle2 = new CircleClass
//{
//    Radius = 5,
//    Color = "Red"
//};

//Console.WriteLine($"Class == : {classCircle1 == classCircle2}");
//Console.WriteLine($"Class Equals : {classCircle1.Equals(classCircle2)}");

#endregion
//=====================================================
//Part02
#region Problem-1

//int[] numbers = { 1, 2, 3, 4, 5 };

//int[] reversedNumbers = HelperReverse.ReverseArray(numbers);

//Console.WriteLine("Reversed Integer Array:");
//Console.WriteLine(string.Join(", ", reversedNumbers));


//string[] names = { "Rawda", "Ahmed", "Sara" };

//string[] reversedNames = HelperReverse.ReverseArray(names);

//Console.WriteLine("Reversed String Array:");
//Console.WriteLine(string.Join(", ", reversedNames));

#endregion


#region Problem-2

//GenericStack<int> stack = new GenericStack<int>(5);

//stack.Push(10);
//stack.Push(20);
//stack.Push(30);

//Console.WriteLine($"Peek: {stack.Peek()}");
//Console.WriteLine($"Pop: {stack.Pop()}");
//Console.WriteLine($"Peek after Pop: {stack.Peek()}");

#endregion


#region Problem-3

//int[] numbers = { 10, 20, 30, 40 };

//Console.WriteLine("Before Swap:");
//Console.WriteLine(string.Join(", ", numbers));

//HelperSwap.Swap(numbers, 0, 2);

//Console.WriteLine("After Swap:");
//Console.WriteLine(string.Join(", ", numbers));

#endregion


#region Problem-4

//int[] numbers = { 10, 50, 20, 80, 30 };

//int maxNumber = HelperMax.Max(numbers);

//Console.WriteLine($"Maximum Integer: {maxNumber}");


//double[] values = { 10.5, 25.7, 15.2, 40.8 };

//double maxValue = HelperMax.Max(values);

//Console.WriteLine($"Maximum Double: {maxValue}");

#endregion