using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Exam_Q4567
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

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
