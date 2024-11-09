namespace CSharpThirdAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Queue:");

            // Queue Test Cases
            Queue queue = new Queue(3);

            // Test Enqueue and Dequeue under normal conditions
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            Console.WriteLine(queue.Dequeue() == 10 ? "Pass" : "Fail"); // Expected: 10
            Console.WriteLine(queue.Dequeue() == 20 ? "Pass" : "Fail"); // Expected: 20

            // Test Queue Overflow
            queue.Enqueue(40);
            queue.Enqueue(50); // Should display "Queue Is Full!"

            // Test Queue Underflow
            queue.Dequeue(); // Expected: 30
            queue.Dequeue(); // Expected: 40
            Console.WriteLine(queue.Dequeue() == null ? "Pass" : "Fail"); // Expected: Queue is empty message and returns null


            Console.WriteLine("\nTesting Stack:");

            // Stack Test Cases
            Stack stack = new Stack(3);

            // Test Push and Pop under normal conditions
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            Console.WriteLine(stack.Pop() == 15 ? "Pass" : "Fail"); // Expected: 15
            Console.WriteLine(stack.Pop() == 10 ? "Pass" : "Fail"); // Expected: 10

            // Test Stack Overflow
            stack.Push(20);
            stack.Push(25);
            try
            {
                stack.Push(30); // Should throw exception: Stack Is Full!
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message == "Stack Is Full!" ? "Pass" : "Fail");
            }

            // Test Stack Underflow
            stack.Pop(); // Expected: 20
            stack.Pop(); // Expected: 5
            try
            {
                stack.Pop(); // Should throw exception: Stack Is Empty!
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message == "Stack Is Empty!" ? "Pass" : "Fail");
            }


            Console.WriteLine("\nTesting Complex:");

            // Complex Test Cases

            // Test default constructor
            Complex c1 = new Complex();
            Console.WriteLine(c1.print() == "0" ? "Pass" : "Fail"); // Expected: "0"

            // Test custom constructor and print
            Complex c2 = new Complex(3, 4);
            Console.WriteLine(c2.print() == "3+4i" ? "Pass" : "Fail"); // Expected: "3+4i"

            // Test cases with special imaginary parts
            Complex c3 = new Complex(0, -1);
            Console.WriteLine(c3.print() == "-i" ? "Pass" : "Fail"); // Expected: "-i"

            Complex c4 = new Complex(2, 1);
            Console.WriteLine(c4.print() == "2+i" ? "Pass" : "Fail"); // Expected: "2+i"

            Complex c5 = new Complex(5, -3);
            Console.WriteLine(c5.print() == "5-3i" ? "Pass" : "Fail"); // Expected: "5-3i"

            // Test addition of complex numbers
            Complex c6 = c2.Add(c5); // (3+4i) + (5-3i)
            Console.WriteLine(c6.print() == "8+i" ? "Pass" : "Fail"); // Expected: "8+i"
        }


    }

}
