using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Exam_Q14
{
    // Changing the struct to a class

    // Class: Friend 
    // Author: Diya Iyer
    // Purpose: Setting properties to the Friend object
    // Restrictions: None
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;
    }

    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosting the Main method
    // Restrictions: None
    class Program
    {
        static void Main(string[] args)
        {
            Friend friend = new Friend(); // Instantiate a new instance of Friend
            Friend enemy = new Friend(); // Instantiate a new instance of Friend

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy = friend; // This will create a reference to the same object

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
