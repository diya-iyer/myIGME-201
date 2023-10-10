using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace Traffic
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: 
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Creating new Vehicle objects and passing them through AddPassenger
        // Rstrictions: None
        static void Main(string[] args)
        {
            IPassengerCarrier pickup = new Pickup();
            IPassengerCarrier suv = new SUV();

            AddPassenger(pickup);
            AddPassenger(suv);

            // Created a syntax error, saying the method was unable to convert the interface of the freight train object
            IHeavyLoadCarrier freightTrain = new FreightTrain();
            // AddPassenger(freightTrain);
        }

        // Method: AddPassenger
        // Purpose: Calling the LoadPassenger method and printing the converted vehicleObject to the console
        // Restrictions: Must pass an object that implements the IPassengerCarrier interface
        static void AddPassenger (IPassengerCarrier vehicleObject)
        {
            vehicleObject.LoadPassenger();
            Console.WriteLine(vehicleObject.ToString());
        }
    }
}
