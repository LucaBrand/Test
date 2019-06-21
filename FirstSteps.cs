// this is how to write single line comments

/* This is how to write a multi line comment 
 * not 
 * code */

// consider a rectangle project fot c# syntax
using System;
namespace RectangleApp
{
    class rectangle
    {
        double len;
        double wid;

        public void GetDetails()
        {
            len = 4.5;
            wid = 3.4;
        }

        public double GetArea()
        {
            return len * wid;
        }

        public void PrintIt()
        {
            Console.WriteLine("Length of Rectangle = {0}", len);
            Console.WriteLine("Width of Rectangle = {0}", wid);
            Console.WriteLine("Area of Rectangle = {0}", GetArea());
        }
    }

    class ExecuteRect
    {
        static void Main(string[] args)     // Main function
        {
            rectangle r = new rectangle();
            r.GetDetails();
            r.PrintIt();
            Console.ReadLine();
        }
    }
}

