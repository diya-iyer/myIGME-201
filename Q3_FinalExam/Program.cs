using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_FinalExam
{
    enum Colors
    {
        red,
        darkblue,
        lightblue,
        grey,
        orange,
        purple,
        yellow,
        green
    }
    static class Program
    {
        // Adjacency matrix representation for the digraph
        static bool[,] diGraphMatrix = new bool[,]
        {
                        //red   darkblue    lightblue   grey    orange  purple  yellow  green
        /* red */       {false, true,       false,      true,   false,  false,  false,  false },
        /* darkblue */  {false, false,      true,      false,   false,  false,  true,  false },
        /* lightblue */ {false, true,       false,     true,    false,  false,  false,  false },
        /* grey */      {false, false,      true,      false,   true,   false,  false,  false },
        /* orange */    {false, false,      false,     false,   false,  true,  false,  false },
        /* purple */    {false, false,      false,     false,   false,  false, true,  false },
        /* yellow */    {false, false,      false,     false,   false,  false,  false,  true },
        /* green */     {false, false,      false,     false,   false,  false, false,  false}
        };

        // Adjacency list representation for the digraph
        static int[][] diGraphList = new int[][]
        {
            /*red*/ new int[] {(int)Colors.darkblue, (int)Colors.grey},
            /*darkblue*/ new int[] {(int)Colors.lightblue, (int)Colors.yellow},
            /*lightblue*/ new int[]{(int)Colors.darkblue, (int)Colors.grey}, 
            /*grey*/ new int[] {(int)Colors.lightblue, (int)Colors.orange},
            /*orange*/ new int[] {(int)Colors.purple },
            /*purple*/ new int[] {(int)Colors.yellow},
            /*yellow*/ new int[] {(int)Colors.green},
            /*green*/ null
        };

        static void Main(string[] args)
        {
        }
    }
}
