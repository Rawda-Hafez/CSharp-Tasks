using System;

namespace Task_8
{
    #region Problem1

    //interface IVehicle
    //{
    //    void StartEngine();
    //    void StopEngine();
    //}

    //class Car : IVehicle
    //{
    //    public void StartEngine()
    //    {
    //        Console.WriteLine("Car engine started");
    //    }

    //    public void StopEngine()
    //    {
    //        Console.WriteLine("Car engine stopped");
    //    }
    //}

    //class Bike : IVehicle
    //{
    //    public void StartEngine()
    //    {
    //        Console.WriteLine("Bike engine started");
    //    }

    //    public void StopEngine()
    //    {
    //        Console.WriteLine("Bike engine stopped");
    //    }
    //}

    #endregion


    #region Problem2

    //abstract class Shape
    //{
    //    public abstract double GetArea();

    //    public void Display()
    //    {
    //        Console.WriteLine("This is a shape");
    //    }
    //}

    //class Rectangle : Shape
    //{
    //    public double Width { get; set; }
    //    public double Height { get; set; }

    //    public override double GetArea()
    //    {
    //        return Width * Height;
    //    }
    //}

    //class Circle : Shape
    //{
    //    public double Radius { get; set; }

    //    public override double GetArea()
    //    {
    //        return Math.PI * Radius * Radius;
    //    }
    //}

    #endregion


    #region Problem3

    //class Product : IComparable
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Price { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        Product other = (Product)obj;

    //        return Price.CompareTo(other.Price);
    //    }
    //}

    #endregion


    #region Problem4

    //class Address
    //{
    //    public string City { get; set; }
    //}

    //class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Grade { get; set; }
    //    public Address Address { get; set; }

    //    public Student(
    //        int id,
    //        string name,
    //        double grade,
    //        Address address)
    //    {
    //        Id = id;
    //        Name = name;
    //        Grade = grade;
    //        Address = address;
    //    }

    //    public Student(Student other)
    //    {
    //        Id = other.Id;
    //        Name = other.Name;
    //        Grade = other.Grade;

    //        Address = new Address
    //        {
    //            City = other.Address.City
    //        };
    //    }

    //    public Student ShallowCopy()
    //    {
    //        return (Student)this.MemberwiseClone();
    //    }
    //}

    #endregion


    #region Problem5

    //interface IWalkable
    //{
    //    void Walk();
    //}

    //class Robot : IWalkable
    //{
    //    public void Walk()
    //    {
    //        Console.WriteLine("Robot walks normally");
    //    }

    //    void IWalkable.Walk()
    //    {
    //        Console.WriteLine("Robot walks using IWalkable");
    //    }
    //}

    #endregion


    #region Problem6

    //struct Account
    //{
    //    private int accountId;
    //    private string accountHolder;
    //    private double balance;

    //    public int AccountId
    //    {
    //        get
    //        {
    //            return accountId;
    //        }
    //        set
    //        {
    //            accountId = value;
    //        }
    //    }

    //    public string AccountHolder
    //    {
    //        get
    //        {
    //            return accountHolder;
    //        }
    //        set
    //        {
    //            accountHolder = value;
    //        }
    //    }

    //    public double Balance
    //    {
    //        get
    //        {
    //            return balance;
    //        }
    //        set
    //        {
    //            balance = value;
    //        }
    //    }
    //}

    #endregion


    #region Problem7

    //interface ILogger
    //{
    //    void Log()
    //    {
    //        Console.WriteLine("Default logging");
    //    }
    //}

    //class ConsoleLogger : ILogger
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Console logging");
    //    }
    //}

    #endregion


    #region Problem8

    //class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }

    //    public Book()
    //    {
    //        Title = "Unknown";
    //        Author = "Unknown";
    //    }

    //    public Book(string title)
    //    {
    //        Title = title;
    //        Author = "Unknown";
    //    }

    //    public Book(string title, string author)
    //    {
    //        Title = title;
    //        Author = author;
    //    }
    //}

    #endregion


    #region Problem9

    //interface IShapeSeries
    //{
    //    int CurrentShapeArea { get; set; }

    //    void GetNextArea();

    //    void ResetSeries();
    //}

    //class SquareSeries : IShapeSeries
    //{
    //    private int side = 0;

    //    public int CurrentShapeArea { get; set; }

    //    public void GetNextArea()
    //    {
    //        side++;

    //        CurrentShapeArea = side * side;
    //    }

    //    public void ResetSeries()
    //    {
    //        side = 0;

    //        CurrentShapeArea = 0;
    //    }
    //}

    //class CircleSeries : IShapeSeries
    //{
    //    private int radius = 0;

    //    public int CurrentShapeArea { get; set; }

    //    public void GetNextArea()
    //    {
    //        radius++;

    //        CurrentShapeArea =
    //            (int)(Math.PI * radius * radius);
    //    }

    //    public void ResetSeries()
    //    {
    //        radius = 0;

    //        CurrentShapeArea = 0;
    //    }
    //}

    #endregion


    #region Problem10

    //class SortableShape : IComparable
    //{
    //    public string Name { get; set; }

    //    public double Area { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        SortableShape other =
    //            (SortableShape)obj;

    //        return Area.CompareTo(other.Area);
    //    }
    //}

    #endregion


    #region Problem11

    //abstract class GeometricShape
    //{
    //    public double Dimension1 { get; set; }

    //    public double Dimension2 { get; set; }

    //    public abstract double CalculateArea();

    //    public abstract double Perimeter { get; }
    //}

    //class Triangle : GeometricShape
    //{
    //    public override double CalculateArea()
    //    {
    //        return 0.5 * Dimension1 * Dimension2;
    //    }

    //    public override double Perimeter
    //    {
    //        get
    //        {
    //            return 0;
    //        }
    //    }
    //}

    //class GeometricRectangle : GeometricShape
    //{
    //    public override double CalculateArea()
    //    {
    //        return Dimension1 * Dimension2;
    //    }

    //    public override double Perimeter
    //    {
    //        get
    //        {
    //            return 2 * (Dimension1 + Dimension2);
    //        }
    //    }
    //}

    #endregion


    #region Problem12

    //public static void SelectionSort(int[] numbers)
    //{
    //    for (int i = 0; i < numbers.Length - 1; i++)
    //    {
    //        int minIndex = i;

    //        for (int j = i + 1; j < numbers.Length; j++)
    //        {
    //            if (numbers[j] < numbers[minIndex])
    //            {
    //                minIndex = j;
    //            }
    //        }

    //        int temp = numbers[i];

    //        numbers[i] = numbers[minIndex];

    //        numbers[minIndex] = temp;
    //    }
    //}

    #endregion


    #region Problem13

    //class ShapeFactory
    //{
    //    public GeometricShape CreateShape(
    //        string shapeType,
    //        double dim1,
    //        double dim2)
    //    {
    //        if (shapeType.ToLower() == "rectangle")
    //        {
    //            return new GeometricRectangle
    //            {
    //                Dimension1 = dim1,
    //                Dimension2 = dim2
    //            };
    //        }

    //        if (shapeType.ToLower() == "triangle")
    //        {
    //            return new Triangle
    //            {
    //                Dimension1 = dim1,
    //                Dimension2 = dim2
    //            };
    //        }

    //        return null;
    //    }
    //}

    #endregion


    class Program
    {
        static void Main()
        {
            #region Problem1

            //Console.WriteLine("===== Problem 1 =====");

            //IVehicle vehicle;

            //vehicle = new Car();

            //vehicle.StartEngine();

            //vehicle.StopEngine();

            //vehicle = new Bike();

            //vehicle.StartEngine();

            //vehicle.StopEngine();

            #endregion


            #region Problem2

            //Console.WriteLine("\n===== Problem 2 =====");

            //Shape rectangle = new Rectangle
            //{
            //    Width = 5,
            //    Height = 10
            //};

            //Shape circle = new Circle
            //{
            //    Radius = 5
            //};

            //rectangle.Display();

            //Console.WriteLine(
            //    "Rectangle Area = " +
            //    rectangle.GetArea()
            //);

            //circle.Display();

            //Console.WriteLine(
            //    "Circle Area = " +
            //    circle.GetArea()
            //);

            #endregion


            #region Problem3

            //Console.WriteLine("\n===== Problem 3 =====");

            //Product[] products =
            //{
            //    new Product
            //    {
            //        Id = 1,
            //        Name = "Laptop",
            //        Price = 30000
            //    },

            //    new Product
            //    {
            //        Id = 2,
            //        Name = "Mouse",
            //        Price = 500
            //    },

            //    new Product
            //    {
            //        Id = 3,
            //        Name = "Keyboard",
            //        Price = 1500
            //    },

            //    new Product
            //    {
            //        Id = 4,
            //        Name = "Monitor",
            //        Price = 8000
            //    }
            //};

            //Array.Sort(products);

            //Console.WriteLine(
            //    "Products sorted by price:"
            //);

            //foreach (Product product in products)
            //{
            //    Console.WriteLine(
            //        "Id: " + product.Id +
            //        ", Name: " + product.Name +
            //        ", Price: " + product.Price
            //    );
            //}

            #endregion


            #region Problem4

            //Console.WriteLine("\n===== Problem 4 =====");

            //Student student1 = new Student(
            //    1,
            //    "Ahmed",
            //    90,
            //    new Address
            //    {
            //        City = "Cairo"
            //    }
            //);

            //Student shallowCopy =
            //    student1.ShallowCopy();

            //Student deepCopy =
            //    new Student(student1);

            //shallowCopy.Address.City = "Giza";

            //Console.WriteLine(
            //    "Original Student:"
            //);

            //Console.WriteLine(
            //    "Name: " + student1.Name
            //);

            //Console.WriteLine(
            //    "City: " + student1.Address.City
            //);

            //Console.WriteLine(
            //    "\nShallow Copy:"
            //);

            //Console.WriteLine(
            //    "Name: " + shallowCopy.Name
            //);

            //Console.WriteLine(
            //    "City: " + shallowCopy.Address.City
            //);

            //Console.WriteLine(
            //    "\nDeep Copy:"
            //);

            //Console.WriteLine(
            //    "Name: " + deepCopy.Name
            //);

            //Console.WriteLine(
            //    "City: " + deepCopy.Address.City
            //);

            #endregion


            #region Problem5

            //Console.WriteLine("\n===== Problem 5 =====");

            //Robot robot = new Robot();

            //robot.Walk();

            //IWalkable walkable = robot;

            //walkable.Walk();

            #endregion


            #region Problem6

            //Console.WriteLine("\n===== Problem 6 =====");

            //Account account = new Account();

            //account.AccountId = 101;

            //account.AccountHolder = "Ahmed";

            //account.Balance = 5000;

            //Console.WriteLine(
            //    "Account ID: " +
            //    account.AccountId
            //);

            //Console.WriteLine(
            //    "Account Holder: " +
            //    account.AccountHolder
            //);

            //Console.WriteLine(
            //    "Balance: " +
            //    account.Balance
            //);

            #endregion


            #region Problem7

            //Console.WriteLine("\n===== Problem 7 =====");

            //ILogger logger =
            //    new ConsoleLogger();

            //logger.Log();

            #endregion


            #region Problem8

            //Console.WriteLine("\n===== Problem 8 =====");

            //Book book1 = new Book();

            //Book book2 =
            //    new Book("C# Programming");

            //Book book3 =
            //    new Book(
            //        "Clean Code",
            //        "Robert Martin"
            //    );

            //Console.WriteLine("Book 1:");

            //Console.WriteLine(
            //    "Title: " + book1.Title
            //);

            //Console.WriteLine(
            //    "Author: " + book1.Author
            //);

            //Console.WriteLine("\nBook 2:");

            //Console.WriteLine(
            //    "Title: " + book2.Title
            //);

            //Console.WriteLine(
            //    "Author: " + book2.Author
            //);

            //Console.WriteLine("\nBook 3:");

            //Console.WriteLine(
            //    "Title: " + book3.Title
            //);

            //Console.WriteLine(
            //    "Author: " + book3.Author
            //);

            #endregion


            #region Problem9

            //Console.WriteLine("\n===== Problem 9 =====");

            //IShapeSeries squareSeries =
            //    new SquareSeries();

            //Console.WriteLine(
            //    "Square Series:"
            //);

            //PrintTenShapes(squareSeries);

            //squareSeries.ResetSeries();

            //IShapeSeries circleSeries =
            //    new CircleSeries();

            //Console.WriteLine(
            //    "\nCircle Series:"
            //);

            //PrintTenShapes(circleSeries);

            #endregion


            #region Problem10

            //Console.WriteLine("\n===== Problem 10 =====");

            //SortableShape[] shapes =
            //{
            //    new SortableShape
            //    {
            //        Name = "Square",
            //        Area = 25
            //    },

            //    new SortableShape
            //    {
            //        Name = "Circle",
            //        Area = 12.5
            //    },

            //    new SortableShape
            //    {
            //        Name = "Rectangle",
            //        Area = 40
            //    },

            //    new SortableShape
            //    {
            //        Name = "Square",
            //        Area = 9
            //    }
            //};

            //Array.Sort(shapes);

            //Console.WriteLine(
            //    "Shapes sorted by area:"
            //);

            //foreach (SortableShape shape in shapes)
            //{
            //    Console.WriteLine(
            //        shape.Name +
            //        " - Area: " +
            //        shape.Area
            //    );
            //}

            #endregion


            #region Problem11

            //Console.WriteLine("\n===== Problem 11 =====");

            //GeometricShape triangle =
            //    new Triangle
            //    {
            //        Dimension1 = 10,
            //        Dimension2 = 6
            //    };

            //GeometricShape rectangle2 =
            //    new GeometricRectangle
            //    {
            //        Dimension1 = 5,
            //        Dimension2 = 10
            //    };

            //Console.WriteLine("Triangle:");

            //Console.WriteLine(
            //    "Area = " +
            //    triangle.CalculateArea()
            //);

            //Console.WriteLine(
            //    "Perimeter = " +
            //    triangle.Perimeter
            //);

            //Console.WriteLine("\nRectangle:");

            //Console.WriteLine(
            //    "Area = " +
            //    rectangle2.CalculateArea()
            //);

            //Console.WriteLine(
            //    "Perimeter = " +
            //    rectangle2.Perimeter
            //);

            #endregion


            #region Problem12

            //Console.WriteLine("\n===== Problem 12 =====");

            //int[] shapeAreas =
            //{
            //    25,
            //    12,
            //    40,
            //    9,
            //    36
            //};

            //Console.WriteLine(
            //    "Before Sorting:"
            //);

            //foreach (int area in shapeAreas)
            //{
            //    Console.WriteLine(area);
            //}

            //SelectionSort(shapeAreas);

            //Console.WriteLine(
            //    "\nAfter Sorting:"
            //);

            //foreach (int area in shapeAreas)
            //{
            //    Console.WriteLine(area);
            //}

            #endregion


            #region Problem13

            //Console.WriteLine("\n===== Problem 13 =====");

            //ShapeFactory factory =
            //    new ShapeFactory();

            //GeometricShape rectangle3 =
            //    factory.CreateShape(
            //        "rectangle",
            //        5,
            //        10
            //    );

            //GeometricShape triangle2 =
            //    factory.CreateShape(
            //        "triangle",
            //        10,
            //        6
            //    );

            //Console.WriteLine("Rectangle:");

            //Console.WriteLine(
            //    "Area = " +
            //    rectangle3.CalculateArea()
            //);

            //Console.WriteLine("\nTriangle:");

            //Console.WriteLine(
            //    "Area = " +
            //    triangle2.CalculateArea()
            //);

            #endregion
        }


        #region PrintTenShapes

        //static void PrintTenShapes(
        //    IShapeSeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        series.GetNextArea();

        //        Console.WriteLine(
        //            series.CurrentShapeArea
        //        );
        //    }
        //}

        #endregion


        #region SelectionSort

        //public static void SelectionSort(
        //    int[] numbers)
        //{
        //    for (
        //        int i = 0;
        //        i < numbers.Length - 1;
        //        i++
        //    )
        //    {
        //        int minIndex = i;

        //        for (
        //            int j = i + 1;
        //            j < numbers.Length;
        //            j++
        //        )
        //        {
        //            if (
        //                numbers[j] <
        //                numbers[minIndex]
        //            )
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        int temp = numbers[i];

        //        numbers[i] =
        //            numbers[minIndex];

        //        numbers[minIndex] =
        //            temp;
        //    }
        //}

        #endregion
    }
}