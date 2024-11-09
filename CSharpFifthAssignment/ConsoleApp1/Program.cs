namespace CSharpSecondAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GeoShape g1 = new GeoShape(); -->> Error!: Cannot create an instance of the abstract Type or interface

            GeoShape g1 = new Rect(2, 4);
            Console.WriteLine(g1.CalcArea());

            GeoShape g2 = new Square(2);
            Console.WriteLine(g2.CalcArea());

            GeoShape g3 = new Triangle(2, 4);
            Console.WriteLine(g3.CalcArea());

            GeoShape g4 = new Circle(2);
            Console.WriteLine(g4.CalcArea());

            Base b1 = new Derived();
            Console.WriteLine(b1.Show()); //Hi from base

            Derived d1 = new Derived2();
            Console.WriteLine(d1.Show()); //Hi from Derived

            Derived2 d22 = new Derived2();
            Console.WriteLine(d22.Show()); // Hi from derived2!

        }
    }
}