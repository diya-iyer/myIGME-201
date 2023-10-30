using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Exam_Q4567
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosting the Main method and UsePhone method
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Calling UsePhone method with the Tardis and PhoneBooth objects
        // Restrictions: None
        static void Main(string[] args)
        {
            // creating new objects to pass through UsePhone
            Tardis myTardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(myTardis);
            UsePhone(phoneBooth);
        }

        // Method: UsePhone
        // Purpose: Calling object's methods through interface as well as object specific ones
        // Restrictions: None
        static void UsePhone(object obj)
        {
            if (obj is PhoneInterface iPhone)
            {
                iPhone.MakeCall(); 
                iPhone.HangUp();
            }
            else
            {
                Console.WriteLine("Object is not of type PhoneInterface.");
            }

            if (obj is PhoneBooth phoneBooth)
            {
                phoneBooth.OpenDoor();
            }
            else if (obj is Tardis myTardis)
            {
                myTardis.TimeTravel();
            }
        }
    }

    // Below is the converted schUML to C# code for Question 4

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber;

        public abstract void Connect();


        public abstract void Disconnect();
       
    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }
        public override void Connect()
        {
            
        }

        public override void Disconnect()
        {
            
        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }
        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;

        public byte WhichDrWho { set { whichDrWho = value; } }
        public string FemaleSideKick { set { femaleSideKick = value; } }
        public void TimeTravel()
        {

        }

        // Overloads all the stated bool operators and makes sure the value of 10 in whichDrWho evaluates to greater than
        public static bool operator ==(Tardis t1, Tardis t2)
        {
            return t1.whichDrWho == t2.whichDrWho;
        }

        public static bool operator !=(Tardis t1, Tardis t2)
        {
            return t1.whichDrWho != t2.whichDrWho;
        }

        public static bool operator <(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return false;
            }
            else if (t2.whichDrWho == 10)
            {
                return true;
            }
            return t1.whichDrWho < t2.whichDrWho;
        }

        public static bool operator >(Tardis t1, Tardis t2)
        {
            if (t1.whichDrWho == 10)
            {
                return true;
            }
            else if (t2.whichDrWho == 10)
            {
                return false;
            }
            return t1.whichDrWho > t2.whichDrWho;
        }

        public static bool operator <=(Tardis t1, Tardis t2)
        {
            
            if (t1.whichDrWho == 10)
            {
                if (t1.whichDrWho == t2.whichDrWho )
                {
                    return true;
                }
                return false;
            }
            else if (t2.whichDrWho == 10)
            {
                return true;
            }
            return t1.whichDrWho <= t2.whichDrWho;
        }

        public static bool operator >=(Tardis t1, Tardis t2)
        {

            if (t1.whichDrWho == 10)
            {
                if (t1.whichDrWho == t2.whichDrWho)
                {
                    return true;
                }
                return true;
            }
            else if (t2.whichDrWho == 10)
            {
                return false;
            }
            return t1.whichDrWho >= t2.whichDrWho;
        }

    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }

        public void CloseDoor()
        {

        }
    }
}
