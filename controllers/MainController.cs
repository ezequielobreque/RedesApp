using System.Collections.Generic;
using System.Linq;
using System;

namespace RedesApp.controllers
{

	public class ObjetoConexion
	{
		public string Vertex { get; set; }
		public string Distance { get; set; }
		public string Path { get; set; }

	}
	public class MainController
	{
		DBcontext context = new DBcontext();
		public Nodo[] getNodos()
		{
			Nodo[] nodos = context.Nodo.ToArray();


			return nodos;
		}

		public Conexion[] getConexions()
		{
			Conexion[] conexion = context.Conexion.ToArray();

			return conexion;
		}






		private static readonly int NO_PARENT = -1;

		// Function that implements Dijkstra's  
		// single source shortest path  
		// algorithm for a graph represented  
		// using adjacency matrix  
		// representation  
		public List<ObjetoConexion> dijkstra(int[,] adjacencyMatrix,
											int startVertex)
		{
			/*var grapho = grafo();
			var nodos = getNodos();
			int cantidad = nodos.Length;
			int V = cantidad;*/

			int nVertices = adjacencyMatrix.GetLength(0);

			// shortestDistances[i] will hold the  
			// shortest distance from src to i  
			int[] shortestDistances = new int[nVertices];

			// added[i] will true if vertex i is  
			// included / in shortest path tree  
			// or shortest distance from src to  
			// i is finalized  
			bool[] added = new bool[nVertices];

			// Initialize all distances as  
			// INFINITE and added[] as false  
			for (int vertexIndex = 0; vertexIndex < nVertices;
												vertexIndex++)
			{
				shortestDistances[vertexIndex] = int.MaxValue;
				added[vertexIndex] = false;
			}

			// Distance of source vertex from  
			// itself is always 0  
			shortestDistances[startVertex] = 0;

			// Parent array to store shortest  
			// path tree  
			int[] parents = new int[nVertices];

			// The starting vertex does not  
			// have a parent  
			parents[startVertex] = NO_PARENT;

			// Find shortest path for all  
			// vertices  
			for (int i = 1; i < nVertices; i++)
			{

				// Pick the minimum distance vertex  
				// from the set of vertices not yet  
				// processed. nearestVertex is  
				// always equal to startNode in  
				// first iteration.  
				int nearestVertex = -1;
				int shortestDistance = int.MaxValue;
				for (int vertexIndex = 0;
						vertexIndex < nVertices;
						vertexIndex++)
				{
					if (!added[vertexIndex] &&
						shortestDistances[vertexIndex] <
						shortestDistance)
					{
						nearestVertex = vertexIndex;
						shortestDistance = shortestDistances[vertexIndex];
					}
				}

				// Mark the picked vertex as  
				// processed  

				if (nearestVertex>-1){ added[nearestVertex] = true;


				// Update dist value of the  
				// adjacent vertices of the  
				// picked vertex.  
				for (int vertexIndex = 0;
						vertexIndex < nVertices;
						vertexIndex++)
				{
					int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

					if (edgeDistance > 0
						&& ((shortestDistance + edgeDistance) <
							shortestDistances[vertexIndex]))
					{
						parents[vertexIndex] = nearestVertex;
						shortestDistances[vertexIndex] = shortestDistance +
														edgeDistance;
					}
				} }

			}

			return printSolution(startVertex, shortestDistances, parents);




		}


		// A utility function to print  
		// the constructed distances  
		// array and shortest paths  
		public List<ObjetoConexion> printSolution(int startVertex,
										int[] distances,
										int[] parents)

		{
			List<ObjetoConexion> lista = new List<ObjetoConexion>();
			int nVertices = distances.Length;
			Console.Write("Vertex\t Distance\tPath");
			string str = "";
			for (int vertexIndex = 0;
					vertexIndex < nVertices;
					vertexIndex++)
			{
				if (vertexIndex != startVertex)
				{
					/*Console.Write("\n" + startVertex + " -> ");
					Console.Write(vertexIndex + " \t\t ");
										
					Console.Write(distances[vertexIndex] + "\t\t");
					printPath(vertexIndex, parents);*/

					str = printPath2(vertexIndex, parents);
					lista.Add(new ObjetoConexion { Vertex = $"{startVertex} -> {vertexIndex}", Distance = $"{distances[vertexIndex]}", Path = $"{str}" });

				}
			}
			return lista;
		}

		// Function to print shortest path  
		// from source to currentVertex  
		// using parents array  
		public void printPath(int currentVertex,
									int[] parents)
		{

			// Base case : Source node has  
			// been processed  
			if (currentVertex == NO_PARENT)
			{
				return;
			}
			printPath(parents[currentVertex], parents);
			Console.Write(currentVertex + " ");
		}

		public string printPath2(int currentVertex,
								int[] parents)
		{

			// Base case : Source node has  
			// been processed  
			if (currentVertex == NO_PARENT)
			{
				return "";
			}
			;
			return printPath2(parents[currentVertex], parents) + $"{currentVertex} ";
		}








		/*	public List<dynamic> algotimoDijkstra(int cantidad1)
			{

				var grapho = grafo();
				var nodos = getNodos();
				int cantidad = nodos.Length;
				int V = cantidad;
				int minDistance(int[] dist,
								bool[] sptSet)
				{
					// Initialize min value 
					int min = int.MaxValue, min_index = -1;

					for (int v = 0; v < V; v++)
						if (sptSet[v] == false && dist[v] <= min)
						{
							min = dist[v];
							min_index = v;
						}

					return min_index;
				}

				// A utility function to print 
				// the constructed distance array 
				void printSolution(int[] dist, int n)
				{
					Console.Write("Vertex	 Distance "
								+ "from Source\n");
					for (int i = 0; i < V; i++)
						Console.Write(i + " \t\t " + dist[i] + "\n");
				}

				// Function that implements Dijkstra's 
				// single source shortest path algorithm 
				// for a graph represented using adjacency 
				// matrix representation 
				void dijkstra(int[,] graph, int src)
				{
					int[] dist = new int[V]; // The output array. dist[i] 
											 // will hold the shortest 
											 // distance from src to i 

					// sptSet[i] will true if vertex 
					// i is included in shortest path 
					// tree or shortest distance from 
					// src to i is finalized 
					bool[] sptSet = new bool[V];

					// Initialize all distances as 
					// INFINITE and stpSet[] as false 
					for (int i = 0; i < V; i++)
					{
						dist[i] = int.MaxValue;
						sptSet[i] = false;
					}

					// Distance of source vertex 
					// from itself is always 0 
					dist[src] = 0;

					// Find shortest path for all vertices 
					for (int count = 0; count < V - 1; count++)
					{
						// Pick the minimum distance vertex 
						// from the set of vertices not yet 
						// processed. u is always equal to 
						// src in first iteration. 
						int u = minDistance(dist, sptSet);

						// Mark the picked vertex as processed 
						sptSet[u] = true;

						// Update dist value of the adjacent 
						// vertices of the picked vertex. 
						for (int v = 0; v < V; v++)

							// Update dist[v] only if is not in 
							// sptSet, there is an edge from u 
							// to v, and total weight of path 
							// from src to v through u is smaller 
							// than current value of dist[v] 
							if (!sptSet[v] && graph[u, v] != 0 &&
								dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
								dist[v] = dist[u] + graph[u, v];
					}

					// print the constructed distance array 
					printSolution(dist, V);
				}


				// Driver Code 
				/*public static void Main()
				{

					int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
										{ 4, 0, 8, 0, 0, 0, 0, 11, 0 },
										{ 0, 8, 0, 7, 0, 4, 0, 0, 2 },
										{ 0, 0, 7, 0, 9, 14, 0, 0, 0 },
										{ 0, 0, 0, 9, 0, 10, 0, 0, 0 },
										{ 0, 0, 4, 14, 10, 0, 2, 0, 0 },
										{ 0, 0, 0, 0, 0, 2, 0, 1, 6 },
										{ 8, 11, 0, 0, 0, 0, 1, 0, 7 },
										{ 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
				 GFG t = new GFG(); 
			t.dijkstra(graph, 0); 

				}*/

		//	dijkstra(grapho,0);
		/*object obj= { };
		return ;*/
		//	return null;
		//	}

		public int[,] grafo(Nodo[] nodoss, Conexion[] conexioness,string tipo)
		{
			
			var	nodos = nodoss;
			var conexiones = conexioness;
			//List<Nodo> nodos=new List<Nodo>();
			
		/*	foreach (var nod in nods)
            {
				var bol= false;
				foreach (var conex in conexiones)
				{
					if (conex.Nodo1 == nod || conex.Nodo2 == nod)
                    {
						bol = true;
                    }
				}
				if (bol == true) { nodos.Add(nod); };
			}*/
			/*	int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
										{ 4, 0, 8, 0, 0, 0, 0, 11, 0 },
										{ 0, 8, 0, 7, 0, 4, 0, 0, 2 },
										{ 0, 0, 7, 0, 9, 14, 0, 0, 0 },
										{ 0, 0, 0, 9, 0, 10, 0, 0, 0 },
										{ 0, 0, 4, 14, 10, 0, 2, 0, 0 },
										{ 0, 0, 0, 0, 0, 2, 0, 1, 6 },
										{ 8, 11, 0, 0, 0, 0, 1, 0, 7 },
										{ 0, 0, 2, 0, 0, 0, 6, 7, 0 } };*/
			int cantidad = nodos.Length;
			int[,] gra = new int[cantidad, cantidad];

			for (int x = 0; x < cantidad; x++)
			{
				for (int y = 0; y < cantidad; y++)
                {
					gra[x, y] = 0;
                }

			}

			if (tipo == "RIP")
			{
				foreach (var conex in conexiones)
				{

					gra[conex.Nodo1.nodo, conex.Nodo2.nodo] = 1;
					gra[conex.Nodo2.nodo, conex.Nodo1.nodo] = 1;

				}
			}else if(tipo == "OSPF")
            {

				foreach (var conex in conexiones)
				{

					gra[conex.Nodo1.nodo, conex.Nodo2.nodo] = conex.distancia;
					gra[conex.Nodo2.nodo, conex.Nodo1.nodo] = conex.distancia;

				}
			}
			
		

			/*foreach (var node in nodos)
			{

				for (int x = 0; x < 8; x++)
				{
					if (node.Conexiones.))
                    {

                    }	
                }
				

			}*/

			return gra;
		}

	}
}
