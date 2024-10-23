namespace SecondAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region array of 10 employees and choose index to enter
            ////employees |#|#|A|#|#|S|#|#|#|#|
            ///choose index 0->9
            ///2
            ///enter id 1
            ///enter name ali
            ///enter age 22
            ///enter salary 1234
            ///continue y or n ? y
            ///choose index
            ///5
            ///enter id 2
            ///enter name Sara
            ///enter age 23
            ///enter salary 4234
            ///continue y or n ? n
            ///print Sara and ali ONLY

            /*Employee[] employees = new Employee[3];
            int index;
            string flag;
            do
            {
                do
                {
                    Console.WriteLine("Choose index 0->2");
                    index = int.Parse(Console.ReadLine());
                } while (index < 0 || index > 9);

                employees[index] = new Employee();
                //
                Console.WriteLine("Enter id");
                employees[index].SetId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter name");
                employees[index].SetName(Console.ReadLine());
                do
                {
                    Console.WriteLine("Enter age");
                    employees[index].SetAge(int.Parse(Console.ReadLine()));
                }
                while (employees[index].GetAge() < 18 || employees[index].GetAge() > 60);

                Console.WriteLine("Enter salary");
                employees[index].SetSalary(decimal.Parse(Console.ReadLine()));

                Console.WriteLine("Continue , yes or no");
                flag = Console.ReadLine();

            }
            while (flag.ToLower() == "yes");

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null) {
                    Console.WriteLine(employees[i].PrintV2()); ;
                }
            }*/

            #endregion

            #region Complex Class Adding Imaginary and Real Numbers
/*            Complex c1 = new Complex();
            c1.SetReal(3);
            c1.SetImg(4);
            Console.WriteLine(c1.Print());  

            Complex c2 = new Complex();
            c2.SetReal(3);
            c2.SetImg(-4);
            Console.WriteLine(c2.Print());  

            Complex c3 = new Complex();
            c3.SetReal(3);
            c3.SetImg(1);
            Console.WriteLine(c3.Print());  

            Complex c4 = new Complex();
            c4.SetReal(3);
            c4.SetImg(-1);
            Console.WriteLine(c4.Print());  

            Complex c5 = new Complex();
            c5.SetReal(0);
            c5.SetImg(1);
            Console.WriteLine(c5.Print());  

            Complex c6 = new Complex();
            c6.SetReal(0);
            c6.SetImg(-1);
            Console.WriteLine(c6.Print());  

            Complex c7 = new Complex();
            c7.SetReal(0);
            c7.SetImg(-4);
            Console.WriteLine(c7.Print());  

            Complex c8 = new Complex();
            c8.SetReal(0);
            c8.SetImg(0);
            Console.WriteLine(c8.Print());  

            Complex c9 = new Complex();
            c9.SetReal(10);
            c9.SetImg(0);
            Console.WriteLine(c9.Print()); */ 
            #endregion
        }
    }
}
