using RedesApp.controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace RedesApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            /* using (var context = new DBcontext())
             {
                 for( int x=0; x < 4; x++) {

                     Nodo nodo = new Nodo { nodo = x };
                     context.Nodo.Add(nodo);
                 }


                 context.SaveChanges();
             }*/


            //Nodo[] variables;
            /* using (var context = new DBcontext())
             {
                 variables = context.Nodo.ToArray();

                 Conexion conexion1 = new Conexion { Nodo1 = variables[0], Nodo2 = variables[1] ,distancia=3};

                 context.Conexion.Add(conexion1);
                 Conexion conexion2 = new Conexion { Nodo1 = variables[1], Nodo2 = variables[2], distancia = 2 };

                 context.Conexion.Add(conexion2);
                 Conexion conexion3 = new Conexion { Nodo1 = variables[2], Nodo2 = variables[3], distancia = 1 };

                 context.Conexion.Add(conexion3);

                 Conexion conexion4 = new Conexion { Nodo1 = variables[0], Nodo2 = variables[3], distancia = 1 };

                 context.Conexion.Add(conexion4);
                 context.SaveChanges();
             }*/


          /* MainController mainController = new MainController();
            var nodos= mainController.getNodos();
            var conexiones = mainController.getConexions();
            var grapho = mainController.grafo(nodos,conexiones);*/
            //Console.WriteLine("hola");
          //  List<ObjetoConexion> lista= mainController.dijkstra(grapho, 1);
//Console.ReadLine();
           Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Form1());

        }
    }
}
