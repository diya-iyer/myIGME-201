using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Q5_FinalExam
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
            /*green*/
            null
        };

        static List<Node> colorNodes = new List<Node>();
        static void Main(string[] args)
        {
            LoadNodesAndEdges();
            List<Node> shortestPath = GetShortestPathDijkstra();
            Console.WriteLine("Shortest path from Red to Green : ");
            Console.WriteLine("");
            Console.WriteLine("");
            string path = "";
            foreach (Node node in shortestPath)
            {
                if (path.Length > 0) path += " --> ";
                path += ((Colors)node.currentNode).ToString();
            }
            Console.Write(path);
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void LoadNodesAndEdges()
        {
            Node node;

            node = new Node((int)Colors.red);
            colorNodes.Add(node);
            node = new Node((int)Colors.darkblue);
            colorNodes.Add(node);
            node = new Node((int)Colors.lightblue);
            colorNodes.Add(node);
            node = new Node((int)Colors.grey);
            colorNodes.Add(node);
            node = new Node((int)Colors.orange);
            colorNodes.Add(node);
            node = new Node((int)Colors.purple);
            colorNodes.Add(node);
            node = new Node((int)Colors.yellow);
            colorNodes.Add(node);
            node = new Node((int)Colors.green);
            colorNodes.Add(node);

            colorNodes[(int)Colors.red].AddEdge(1, colorNodes[(int)Colors.darkblue]);
            colorNodes[(int)Colors.red].AddEdge(5, colorNodes[(int)Colors.grey]);
            colorNodes[(int)Colors.red].edges.Sort();

            colorNodes[(int)Colors.darkblue].AddEdge(1, colorNodes[(int)Colors.lightblue]);
            colorNodes[(int)Colors.darkblue].AddEdge(8, colorNodes[(int)Colors.yellow]);
            colorNodes[(int)Colors.darkblue].edges.Sort();

            colorNodes[(int)Colors.lightblue].AddEdge(1, colorNodes[(int)Colors.darkblue]);
            colorNodes[(int)Colors.lightblue].AddEdge(0, colorNodes[(int)Colors.grey]);
            colorNodes[(int)Colors.lightblue].edges.Sort();

            colorNodes[(int)Colors.grey].AddEdge(1, colorNodes[(int)Colors.orange]);
            colorNodes[(int)Colors.grey].AddEdge(0, colorNodes[(int)Colors.lightblue]);
            colorNodes[(int)Colors.grey].edges.Sort();

            colorNodes[(int)Colors.orange].AddEdge(1, colorNodes[(int)Colors.purple]);

            colorNodes[(int)Colors.purple].AddEdge(1, colorNodes[(int)Colors.yellow]);

            colorNodes[(int)Colors.yellow].AddEdge(6, colorNodes[(int)Colors.green]);
        }

        static private void DijkstraSearch()
        {
            Node start = colorNodes[(int)Colors.red];

            start.minCostToStart = 0;
            List<Node> priorityQueue = new List<Node>();
            priorityQueue.Add(start);

            do
            {
                // sort our priorityQueue by minCostToStart
                priorityQueue.Sort();

                Node node = priorityQueue.First();
                priorityQueue.Remove(node);
                foreach (Edge edge in node.edges)
                {
                    // look at the neighbor connected to this edge
                    Node neighborNode = edge.connectedNode;
                    if (neighborNode.visited)
                    {
                        // skip if we already visited this neighbor
                        continue;
                    }

                    // if this neighbor has not been evaluated yet or
                    // it is closer than the current path to start
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + edge.cost < neighborNode.minCostToStart)
                    {
                        // update the cost to start
                        neighborNode.minCostToStart = node.minCostToStart + edge.cost;

                        // set the node heading back to start from this neighbor to the 
                        // node we got here by
                        neighborNode.nearestToStart = node;

                        // if we don't have this neighbor in our queue
                        if (!priorityQueue.Contains(neighborNode))
                        {
                            // add it
                            priorityQueue.Add(neighborNode);
                        }
                    }
                }

                // set this node as visited
                node.visited = true;

                // if we reached the target node
                if (node == colorNodes[(int)Colors.green])
                {
                    // we're done!
                    return;
                }

                // stay in this loop while there are any items left in our queue
            } while (priorityQueue.Any());
        }

        static public List<Node> GetShortestPathDijkstra()
        {
            // set up all distances from every vertex to the start vertex
            DijkstraSearch();

            // the list of nodes that will be the shortest path from the start
            List<Node> shortestPath = new List<Node>();

            // add the target node
            shortestPath.Add(colorNodes[(int)Colors.green]);

            // populate the List of nodes from the target node back to the start
            BuildShortestPath(shortestPath, colorNodes[(int)Colors.green]);

            // reverse the List to give the path from the start to the finish
            shortestPath.Reverse();

            return shortestPath;
        }

        // Recursively build the short path to the target color
        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

    }

    public class Node : IComparable<Node>
    {
        public int currentNode;
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int currentNode)
        {
            this.currentNode = currentNode;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }
}
