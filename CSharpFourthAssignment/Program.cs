namespace CSharpFourthAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle r2 = new Rectangle(1, 2, 3, 4);
            Rectangle r1 = new Rectangle();

            Line l2 = new Line(1, 2, 3, 4);


            Line l1 = new Line();

            Point p1 = new Point(1, 2);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);


            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(p1, p2, p3);

            t1.P1 = p1;
            t1.P2 = p2;
            t1.P3 = p3;

            Circle c1 = new Circle(p1, 5);


            Console.WriteLine(c1.Print());
            Console.WriteLine(r2.Print());
            Console.WriteLine(l2.Print());
            Console.WriteLine(t2.Print());
        }
    }
}
