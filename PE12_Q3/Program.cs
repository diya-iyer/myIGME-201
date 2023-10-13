using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE12_Q3
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosting main method 
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Testing the GetString() method 
        // Restrictions: None
        static void Main(string[] args)
        {
            // new derived class object
            MyDerivedClass derivedObj = new MyDerivedClass();
            // setting value
            derivedObj.MyString = "Hello world!";
            string result = derivedObj.GetString();
            Console.WriteLine(result); // has the extra message in parentheses
        }
    }

    // Class: MyClass
    // Author: Diya Iyer
    // Purpose: Returns the defined string
    // Restrictions: None
    public class MyClass
    {
        private string myString;

        public virtual string GetString()
        {
            return myString;
        }
         
        public string MyString
        {
            // making myString write only
            set
            {
                myString = value;
            }
        }
    }

    // Class: MyDerivedClass
    // Author: Diya Iyer
    // Purpose: Overrides GetString method from parent MyClass
    // Restrictions: None
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            // accessing using base
            string baseString = base.GetString(); 
            return baseString + " (output from the derived class)";
        }
    }

}
