﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_FinalExam
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
            // Mark all the vertices as not visited 
            // (set as false by default) 
            bool[] visited = new bool[diGraphList.Length];
            Console.WriteLine(" Depth First Search Output: ");
            Console.WriteLine("");
            DFS(0, visited);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        // The function to do DFS traversal recursively. 
        static void DFS(int vertexIndex, bool[] visited)
        {
            string colorName = ((Colors)vertexIndex).ToString();

            // Mark the current node as visited 
            visited[vertexIndex] = true;

            // print the current node 
            if (vertexIndex > 0) Console.Write(" --> ");
            Console.Write(colorName + " ");

            // Recur for all the vertices 
            // adjacent to this vertex if there are any
            int[] vertexList = diGraphList[vertexIndex];
            if (vertexList != null)
            {
                foreach (int nextVertex in vertexList)
                {
                    if (!visited[nextVertex])
                    {
                        DFS(nextVertex, visited);
                    }
                }
            }
        }
    }
}
