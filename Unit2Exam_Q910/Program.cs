using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit2Exam_Q910
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosts the Main method and MyMethod method that displays the properties and methods of the described classes
    // Restrictions: None
    internal class Program
    {
        // Method: Main
        // Purpose: Creating objects of the different drawings and calling MyMethod
        // Restrictions: None
        static void Main(string[] args)
        {
            Digital digital = new Digital();
            Pencil pencil = new Pencil();

            MyMethod(digital);
            MyMethod(pencil);

        }

        // Method: MyMethod
        // Purpose: Checks what type of object the passed argument is and displays output accordingly
        // Restrictions: Must pass an object
        static void MyMethod(object obj)
        {
            if (obj is Digital digital)
            {
                digital.drawType = "Fanart";
                Console.WriteLine("This digital drawing requires the following materials: " + digital.GetMaterials());
                Console.WriteLine("Type of Drawing: " + digital.drawType);
                digital.DrawStroke();
                digital.Undo();
            }
            else if (obj is Pencil pencil)
            {
                pencil.drawType = "Doodle";
                Console.WriteLine("This pencil drawing requires the following materials: " + pencil.GetMaterials());
                Console.WriteLine("Type of Drawing: " + pencil.drawType);
                pencil.SharpenPencil();
                pencil.UseEraser();
            }
            else
            {
                Console.WriteLine("Invalid object has been passed.");
            }

        }
    }

    // Class: Drawing
    // Author: Diya Iyer
    // Purpose: Abstract class that defines the type of drawing, if the drawing is in color, and what materials are being used
    // Restrictions: None
    public abstract class Drawing
    {
        public string drawType;
        public string color;

        public abstract string GetMaterials();
        public virtual void SetDrawingColor()
        {
            this.color = "black and white"; 
        }

    }
    // Interface: IDigital
    // Author: Diya Iyer
    // Purpose: Methods for digital drawings
    // Restrictions: None
    public interface IDigital
    {
        void DrawStroke();
        void Undo();
    }
    // Interface: IPencil
    // Author: Diya Iyer
    // Purpose: Methods for pencil drawings
    // Restrictions: None

    public interface IPencil
    {
        void SharpenPencil();
        void UseEraser();
    }

    // Class: Digital
    // Author: Diya Iyer
    // Purpose: The class that describes a drawing that is done digitally
    // Restrictions: None
    public class Digital : Drawing, IDigital
    {
        public void DrawStroke()
        {
            Console.WriteLine("It's so hard to draw a perfect straight line!");
        }

        public void Undo()
        {
            Console.WriteLine("Your previous action has been undone.");
        }

        public override string GetMaterials()
        {
            return ("Drawing tablet, stylus pen");
        }

        public override void SetDrawingColor()
        {
            base.color = "multi-color";
        }

    }

    // Class:Pencil
    // Author: Diya Iyer
    // Purpose: The class that describes a drawing that is done traditionally
    // Restrictions: None
    public class Pencil : Drawing, IPencil
    {
        public void SharpenPencil ()
        {
            Console.WriteLine("Your pencil tip has been sharpened to 0.5mm.");
        }

        public void UseEraser()
        {
            Console.WriteLine("Make sure to fully erase your lines!");
        }

        public override string GetMaterials() 
        {
            return ("Paper, pencil, eraser, sharpener");
        }
    }
}

 





