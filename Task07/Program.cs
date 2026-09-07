using System;

namespace Task_7
{
    #region Problem-1

    //internal class Car
    //{
    //    public int Id { get; set; }
    //    public string Brand { get; set; }
    //    public decimal Price { get; set; }

    //    // Default Constructor
    //    public Car()
    //    {
    //        Id = 0;
    //        Brand = "Unknown";
    //        Price = 0;
    //    }

    //    // Constructor with Id
    //    public Car(int id) : this()
    //    {
    //        Id = id;
    //    }

    //    // Constructor with Id and Brand
    //    public Car(int id, string brand) : this(id)
    //    {
    //        Brand = brand;
    //    }

    //    // Constructor with Id, Brand and Price
    //    public Car(int id, string brand, decimal price)
    //    {
    //        Id = id;
    //        Brand = brand;
    //        Price = price;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Id: {Id}, Brand: {Brand}, Price: {Price}";
    //    }
    //}

    #endregion


    #region Problem-2

    //internal class Calculator
    //{
    //    // Add two integers
    //    public int Sum(int x, int y)
    //    {
    //        return x + y;
    //    }

    //    // Add three integers
    //    public int Sum(int x, int y, int z)
    //    {
    //        return x + y + z;
    //    }

    //    // Add two doubles
    //    public double Sum(double x, double y)
    //    {
    //        return x + y;
    //    }
    //}

    #endregion


    #region Problem-3

    //class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //}

    //class Child : Parent
    //{
    //    public int Z { get; set; }

    //    public Child(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //    }
    //}

    #endregion


    #region Problem-4

    //class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public virtual int Product()
    //    {
    //        return X * Y;
    //    }
    //}

    //class ChildNew : Parent
    //{
    //    public ChildNew(int x, int y) : base(x, y)
    //    {
    //    }

    //    // Method Hiding
    //    public new int Product()
    //    {
    //        return X * Y * 2;
    //    }
    //}

    //class ChildOverride : Parent
    //{
    //    public ChildOverride(int x, int y) : base(x, y)
    //    {
    //    }

    //    // Method Overriding
    //    public override int Product()
    //    {
    //        return X * Y * 2;
    //    }
    //}

    #endregion


    #region Problem-5

    //class Parent
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public Parent(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}

    //class Child : Parent
    //{
    //    public int Z { get; set; }

    //    public Child(int x, int y, int z) : base(x, y)
    //    {
    //        Z = z;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y}, {Z})";
    //    }
    //}

    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem-1

            //Car car1 = new Car();
            //Car car2 = new Car(1);
            //Car car3 = new Car(2, "Toyota");
            //Car car4 = new Car(3, "BMW", 1500000);

            //Console.WriteLine(car1);
            //Console.WriteLine(car2);
            //Console.WriteLine(car3);
            //Console.WriteLine(car4);

            #endregion


            #region Problem-2

            //Calculator calculator = new Calculator();

            //Console.WriteLine(calculator.Sum(10, 20));
            //Console.WriteLine(calculator.Sum(10, 20, 30));
            //Console.WriteLine(calculator.Sum(10.5, 20.5));

            #endregion


            #region Problem-3

            //Child child = new Child(10, 20, 30);

            //Console.WriteLine($"X = {child.X}");
            //Console.WriteLine($"Y = {child.Y}");
            //Console.WriteLine($"Z = {child.Z}");

            #endregion


            #region Problem-4

            //ChildNew childNew = new ChildNew(10, 20);
            //ChildOverride childOverride = new ChildOverride(10, 20);

            //Console.WriteLine(childNew.Product());
            //Console.WriteLine(childOverride.Product());

            #endregion


            #region Problem-5

            //Parent parent = new Parent(10, 20);
            //Parent child = new Child(10, 20, 30);

            //Console.WriteLine(parent);
            //Console.WriteLine(child);

            #endregion
        }
    }
}