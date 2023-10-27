using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfile
{
   
    static class Program
    {
        static void Main()
        {

            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            friendBirthdays["Diya"] = new DateTime(2004, 6, 10);
            friendBirthdays["Teddy"] = new DateTime(2015, 3, 5);
            friendBirthdays["friend3"] = new DateTime(2004, 11, 27);

            foreach (KeyValuePair<string, DateTime> kvp in friendBirthdays)
            {
                Console.WriteLine(kvp.Key + "'s birthday is: " + kvp.Value.ToString("MM/dd/yyyy"));
            }



        }
    }

}
