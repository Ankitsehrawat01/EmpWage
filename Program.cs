using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;

namespace DemoApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //constructor
            //Interface
            //static and final keyword

            //Console.WriteLine("Hello World !");
            //Console.Write("HellO World!");
            //Demo.Add();

            //Demo demoobj = new Demo();
            //demoobj.Add();


            ////concat 
            //string Fname = "Ankit";
            //string Lname = "Sehrawat";

            //Console.WriteLine("First Name = " + Fname + "Last name = " +  Lname);
            ////PlaceHolder
            //Console.WriteLine("First Name = {0} Last Name = {1}", Fname, Lname);

            //int num = 10;
            //float num2 = num;
            //Console.WriteLine(num2);

            //float num3 = 2.5f;
            ////int num4 = (int) num3;

            //int num4 = Convert.ToInt32(num3);

            //Console.WriteLine();
            //Console.WriteLine("Enter the First Numbe : ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the First Numbe : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine(c);


            //Selection  1 IF stateent 2. Switch
            //1 If= 1. if , 2. ifelse, 3. nested if else, 4, else if ladder

            //Console.WriteLine("Enter a Number");
            //int result = Convert.ToInt32(Console.ReadLine());

            //if(result == 10)
            //{
            //    Console.WriteLine("You Entered 10");
            //}
            //else if(result == 11)
            //{
            //    Console.WriteLine("You entered 11");
            //}
            //else
            //{
            //    Console.WriteLine("You entered a Different Number");
            //}


            //if(condition)
            //{
            //    if(condition)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
            //else
            //{

            //}

            //switch (condition)
            //{
            //    case 1:
            //        //statement
            //        break;
            //        case 2:
            //        //statement
            //        break;
            //        default:
            //        //statement
            //        break;

            //}

            //for(initilization; Condition; Increment/decrement)
            //{
            //    //statement
            //}

            //for (int i = 1;  i <=5;  i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("=============");
            //for (int i = 5; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}


            // initilization
            //while(condition)
            // {
            //     Increment/decrement
            // }

            //int i =0 ;
            //while (i<=5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Random random = new Random();
            //int result = random.Next(0, 2);


            Console.WriteLine("Welcome to Employee Wage Computation");

            const int Full_Time = 1;
            const int Emp_Rate_Per_Hour = 20;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == Full_Time)
            {
                //Console.WriteLine("Employee Is Present");
                empHrs = 8;
            }
            else
            {
                //Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Daily Wage is : " + empWage);
            Console.WriteLine("Employee Daily Wage is : {0}", empWage);
        }
    }
}