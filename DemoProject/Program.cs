using System;
using System.Runtime.CompilerServices;

namespace DemoProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        #region main method
        static void Main(string[] args)
        {
            //print helo world
            Console.WriteLine("Hello World!");
            /*Hello
             * 
             * Hello
             * */

            string firstname;
            firstname = "Darshani";
            Console.WriteLine(firstname);

            int number = 7;
            float myFloat = 5.56f;
            double myDouble = 1.223;
            decimal myDecimal = 1.23423423424m;

            Console.WriteLine(number);

            //operators

            int num1 = 15;
            int num2 = 9;
            int result = num1 * num2;

            Console.WriteLine("Value is "+result);

           
            //increment //decrement
            result--;
            --result;
          /* 
           * Pre / Post
           * result++;
            result++; */
            Console.WriteLine(result);

            //type casting
            //imlicite casting 
            int num3 = 3;
            double num4 = 7.78;

            double num5 = num4;
            int num6 = (int)num5;
            int num7 = (int)(num4 + num2);
            Console.WriteLine(num7);




        }
        #endregion
    }
}