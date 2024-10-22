using System.Runtime.InteropServices.Marshalling;

namespace CSharpFirstAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab Assignments - 1


            #region 1- Calculate age in years, months and days with validation
            /*
            int currentDay = 16, currentMonth = 10, currentYear = 2024;
            int userBirthDay, userBirthMonth, userBirthYear;
            int userDays, userMonths, userYears;
            int monthEnd = 0;
            do
            {
                Console.WriteLine("Please enter your birth year between 1980->2024 ");
                userBirthYear = int.Parse(Console.ReadLine());
            } while (userBirthYear < 1980 || userBirthYear > 2024);
            do
            {
                Console.WriteLine("Please enter your birth Month between 1->12 ");
                userBirthMonth = int.Parse(Console.ReadLine());
            } while (userBirthMonth < 1 || userBirthMonth > 12);
            switch (userBirthMonth)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    do
                    {
                        Console.WriteLine("Please enter your birth day between 1->30");
                        userBirthDay = int.Parse(Console.ReadLine());
                    } while (userBirthDay > 30 || userBirthDay < 1);
                    break;
                case 2:
                    do
                    {
                        if (userBirthYear % 400 == 0 || (userBirthYear % 4 == 0 && userBirthYear % 100 != 0))
                        {
                            monthEnd = 29;
                        }
                        else { monthEnd = 28; }

                        Console.WriteLine($"Please enter your birth day between 1->{monthEnd}");
                        userBirthDay = int.Parse(Console.ReadLine());
                    } while (userBirthDay > monthEnd || userBirthDay < 1);
                    break;
                default:
                    do
                    {
                        Console.WriteLine("Please enter your birth day between 1->31");
                        userBirthDay = int.Parse(Console.ReadLine());
                    } while (userBirthDay > 31 || userBirthDay < 1);
                    break;
            }

            if (userBirthYear == currentYear) { userYears = 0; }
            else { userYears = currentYear - userBirthYear; }

            if (userBirthMonth > currentMonth) { --userYears; userMonths = (currentMonth - userBirthMonth) + 12; }
            else { userMonths = currentMonth - userBirthMonth; }

            if (userBirthDay > currentDay) { --userMonths; userDays = (currentDay - userBirthDay) + 30; }
            else { userDays = currentDay - userBirthDay; }

            Console.WriteLine($"You're {userYears} years, {userMonths} months, and {userDays} days old. ");
            */
            #endregion

            #region 2- Console Calculator      
            /*
            int num1, num2;
            int? result = 0;
            char operation;
            char again;
            bool isContinuing;

            Console.WriteLine("Welcome to our calculator app! \n");
            do
            {
                isContinuing = false;
                bool isNum = false;
                do
                {
                    Console.WriteLine("Please enter the first number");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out num1)) { isNum = true; } else { Console.WriteLine("Invalid input! Please enter a valid number between 0 to 9!"); }

                } while (!isNum);
                do
                {
                    isNum = false;
                    Console.WriteLine("Please enter the second number");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out num2)) { isNum = true; } else { Console.WriteLine("Invalid input! Please enter a valid number between 0 to 9!"); }

                } while (!isNum);
                Console.WriteLine("Please enter the operand you would like to perform: +, -, *, /");
                operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("You're attempting to divide by zero. Please start over!");
                            result = null;
                            break;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("You've entered an invalid operation. Please try again!");
                        break;
                }
                if (result == null) { Console.WriteLine($"{num1} {operation} {num2} = undefined!"); }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result}");
                }
                Console.WriteLine("Would you like to perfom another operation? Y/N");
                again = char.Parse(Console.ReadLine());
                if (char.ToUpper(again) == 'Y') { isContinuing = true; }
            }
            while (isContinuing);
            */
            #endregion

            #region 3- Insert into an array in runtime
            /// Arrays of 10 places of integer int arr[10]
            /// Read ALL Data From user in Runtime
            //XXX int arr[15] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            /*
              int[] arr = new int [10];
              for (int i = 0; i < arr.Length; i++)
              {
                  Console.WriteLine($"Please enter any number into index {i}");
                  arr [i] = int.Parse ( Console.ReadLine () );
              }
              for (int i = 0;i < arr.Length; i++)
              {
                  Console.WriteLine (arr [i]);
              }
            */
            #endregion


            //1D Array
            #region 4- Array min and max value
            /*            int[] arr = new int[5];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine($"Please enter any number into index {i}");
                            arr[i] = int.Parse(Console.ReadLine());
                        }
                        int max = int.MinValue, min = int.MaxValue;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] > max)
                            {
                                max = arr[i];
                            }
                            if (arr[i] < min)
                            {
                                min = arr[i];
                            }
                        }
                        Console.WriteLine($"Max value is: {max} and Min value is {min}");*/

            #endregion

            #region 5- Array sort same array
            //2 - Array sort same array | -11 | -1 | 3 | 5 | 6 |||||| no built in fn

            /* int[] arr = new int[5];
             int length = arr.Length;
             bool swapped = false;
             for (int i = 0; i < length; i++)
             {
                 Console.WriteLine($"Please enter any number into index {i}");
                 arr[i] = int.Parse(Console.ReadLine());
             }

             for (int i = 0; i < length - 1; i++)
             {
                 for (int j = 0; j < length - i - 1; j++)
                 {
                     if(arr[j] > arr[j + 1])
                     {
                         int tmp = arr[j];
                         arr[j] = arr[j + 1];
                         arr[j+1] = tmp;
                     }
                 }
             }
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.WriteLine(arr[i]);
             }
            */
            #endregion

            #region 6- Search an array and find the index
            /*            int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
                        int length = arr.Length;
                        Console.WriteLine($"Please enter the number you want to find");
                        int target = int.Parse(Console.ReadLine());
                        int res = -1;

                        int left = 0, right = length - 1;
                        while (left <= right)
                        {
                            int mid = left + (right - left) / 2;
                            if (arr[mid] == target)
                            {
                                res = mid;
                            }

                            if (arr[mid] > target)
                            { right = mid - 1; }
                            else { left = mid + 1; }
                        }
                        if (res == -1)
                        {
                            Console.WriteLine($"Target ({target}) was not found");
                        }
                        else
                        {
                            Console.WriteLine($"Target ({target}) was found at index {res}");
                        }*/
            #endregion


            //5 - 2D Array
            //array[3][4]
            //Sum of Rows
            #region 7- sum of rows in a 2D array

            /*            int[,] arr = { { 1, 2, 3, 4, }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
                        int[] sum = [0, 0, 0];

                        for (int i = 0; i < arr.GetLength(0); i++)
                        {

                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                sum[i] += arr[i, j];
                            }
                        }
                        for (int i = 0; i < sum.Length; i++)
                        {
                            Console.WriteLine(sum[i]);
                        }*/
            #endregion

            //6 - Bonus multiply 2 matrix
            //3 * 2 * 2 * 1 = 3 * 1
            #region Bonus - Multiply 2 Matrices
            /*
                        // 3x2 matrix
                        int[,] A = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
                        // 2x1 matrix
                        int[,] B = { { 7 }, { 8 } };
                        //According to linear algebara, the result would be a matrix of size 3*1
                        int[,] result = new int[3, 1];

                        for (int i = 0; i < 3; i++) // 3 rows in A
                        {
                            result[i, 0] = 0;
                            for (int j = 0; j < 1; j++) // 2 columns in A, 1 rows in B
                            {
                                result[i, 0] += A[i, j] * B[j, 0];
                            }
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(result[i, 0]);
                        }
                        */
            #endregion

            #region 7 - bonus 3 x 3    *     3 x 2 = 3 * 2 
            #endregion


            #endregion

        }
    }
}
