using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Q3
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosts both main method and MyMethod
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Creates a Soup and Salad object and uses MyMethod to call the corresponding method
        // Restrictions: None
        static void Main(string[] args)
        {
            Soup mySoup = new Soup();
            Salad mySalad = new Salad();

            Console.WriteLine("Calling MyMethod with Soup object:");
            MyMethod(mySoup);

            Console.WriteLine("Calling MyMethod with Salad object:");
            MyMethod(mySalad);

        }

        // Method: MyMethod()
        // Purpose: Employs the IDinner interface to call the method both classes share
        // Restrictions: Only accepts a class object
        public static void MyMethod(object myObject)
        {
            // checking if the object is part of the IDinner interface
            if (myObject is IDinner dinner)
            {
                dinner.serve();
            }
            else
            {
                Console.WriteLine("Object is not of type iDinner.");
            }
        }
    }

    public interface IDinner {
        void serve();
    }

    public class Soup : IDinner
    {
        public void serve()
        {
            Console.WriteLine("Careful! Don't drink it while the soup is too hot!");
        }
    }

    public class Salad : IDinner
    {
        public void serve()
        {
            Console.WriteLine("This salad could use more dressing, don't you think?");
        }
    }
}
