using System.Diagnostics.Metrics;
using System.Text;

namespace solve_task_8
{
    internal class Program
    {
        private static IEnumerable<object> geoShapes;

        static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();
            Console.WriteLine($"\n--- {series.GetType().Name} ---");
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.Write($"{series.CurrentShapeArea}  ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region problem_1
            //Ivehicle[] vehicles = { new Car(), new Bike() };
            //foreach (var v in vehicles) { v.Start_Engine(); v.Stop_Engine(); }

            //Coding against an interface is better because it provides flexibility and loose coupling.
            //Reduces dependency on concrete implementations
            //Improves testability using mocking
            #endregion

            #region problem_2
            //Console.WriteLine();
            //Shape[] shapes = { new Rectangle(5, 3), new Circle(4) };
            //foreach (var s in shapes)
            //{
            //    s.Display();
            //}
            //Use an abstract class when:
            //You need shared implementation
            //You need fields or constructors
            #endregion

            #region problem_3 

            //    Product[] products =
            //{
            //    new Product(1, "Laptop", 999),
            //    new Product(2, "Mouse",  25),
            //    new Product(3, "Keyboard", 75)
            //};
            //    Array.Sort(products);
            //    foreach (var p in products) 
            //    { Console.WriteLine(p); }
            //IComparable allows objects to define their own comparison logic.
            //
            #endregion

            #region problem_4
            //Student s1 = new Student(1, "Ali", 90);
            //Student s2 = new Student(s1);      // copy constructor
            //Console.WriteLine($"Original: {s1}");
            //Console.WriteLine($"Copy:     {s2}");
            //The main purpose is to create a new object as a copy of an existing object.
            //Prevent reference sharing
            //Support deep copy or shallow copy
            #endregion

            #region problem_5
            //var robot = new Robot();
            //robot.Walk();                       
            //((IWalkable)robot).Walk();
            //It allows implementing methods with the same name from different interfaces without conflict.
            #endregion

            #region problem_6
            //Account acc = new Account(101, "Ahmed", 5000);
            //Console.WriteLine(acc);
            //The key difference:
            //  Struct:
            // Value type
            // Copied completely when assigned
            //Class:
            // Reference type
            //Only reference is copied
            #endregion

            #region problem_8
            //Console.WriteLine(new Book());
            //Console.WriteLine(new Book("Clean Code"));
            //Console.WriteLine(new Book("Clean Code", "Robert C. Martin"));
            //Constructor overloading improves class usability by allowing objects to be created in different ways depending on available data.
            #endregion

            #region Part_2
            //Q2
            //Reduces tight coupling
            //Allows changing implementation without modifying client code
            //Improves testability(mocking)
            //Supports polymorphism

            //Q3
            //Abstraction is an OOP principle that means hiding implementation details and exposing only essential functionality.
            //Goals of abstraction:
            //Reduce complexity
            //Protect data
            //Improve flexibility
            //Support dependency on abstractions instead of concrete classes

            //Create a Shape Series 
            #region problem_1
            //PrintTenShapes(new SquareSeries());
            //PrintTenShapes(new CircleSeries());
            #endregion

            #region problem_2
            //    Console.WriteLine("\n--- Shapes sorted by area ---");
            //    ShapeItem[] shapeItems =
            //    {
            //    new ShapeItem("Square",    16),
            //    new ShapeItem("Circle",    50.27),
            //    new ShapeItem("Rectangle", 24),
            //    new ShapeItem("Triangle",  6)
            //};
            //    Array.Sort(shapeItems);
            //    foreach (var si in shapeItems) Console.WriteLine(si);
            #endregion

            #region problem_3
            //    Console.WriteLine("\n--- Geometric Shapes ---");
            //    GeometricShape[] geoShapes =
            //    {
            //    new Triangle(6, 4),
            //    new Rectangle2(5, 3)
            //};
            //    foreach (var g in geoShapes)
            //        Console.WriteLine($"{g.GetType().Name} | Area={g.CalculateArea():F2} | Perimeter={g.Perimeter:F2}");
            #endregion
            #region problem_4
            //Console.WriteLine("\n--- Selection Sort ---");
            //int[] areas = geoShapes.Select(static g => (int)g.CalculateArea()).ToArray();
            //Sorter.SelectionSort(areas);
            //Console.WriteLine("Sorted areas: " + string.Join(", ", areas));
            #endregion

            #endregion
        }
    }
}
