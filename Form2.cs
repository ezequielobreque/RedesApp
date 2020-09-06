using RedesApp.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedesApp
{

    public partial class Form2 : Form
    {
        static DBcontext context = new DBcontext();

        MainController mainController = new MainController();
        Nodo[] lista;

        Conexion[] Conexiones;
        int[,] grapho;
        string tipo;
        public Form2(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* this.listBox1.DisplayMember = "nodo";
             this.listBox1.ValueMember = "Id";*/


            this.lista = mainController.getNodos();
            this.Conexiones = mainController.getConexions();
            this.grapho = mainController.grafo(this.lista, this.Conexiones, this.tipo);



            foreach (var i in this.lista)
            {
                this.listBox1.Items.Add($"Nodo {i.nodo}");
            }
        }

        private List<int> Nodoscompletos()
        {
            List<int> arr = new List<int>();

            foreach (var nod in lista)
            {
                var bol = false;
                foreach (var conex in Conexiones)
                {
                    if (conex.Nodo1 == nod || conex.Nodo2 == nod)
                    {
                        bol = true;
                    }
                }
                if (bol == false) { arr.Add(nod.nodo); };
            }


            return arr;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

       /* private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            var x = this.listBox1.SelectedIndex;
            foreach (var i in this.Conexiones)
            {
                if (i.Nodo1.nodo == x)
                {
                    this.listBox2.Items.Add($"Nodo {i.Nodo2.nodo}");
                }
                if (i.Nodo2.nodo == x)
                {
                    this.listBox2.Items.Add($"Nodo {i.Nodo1.nodo}");
                }

            }
        }*/

     

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var x = this.listBox1.SelectedIndex;
            var arr =Nodoscompletos();
            
            if (arr.Contains(x))
            {
                dataGridView1.Rows.Add("nodo caido", "desconectado", "Nodo desconectado o caido");
            }
            else { 
            
            List<ObjetoConexion> l = mainController.dijkstra(grapho, x);

            if (tipo == "RIP")
            {
                foreach (var lis in l)
                {

                    if (int.Parse(lis.Distance) == int.MaxValue) {

                        dataGridView1.Rows.Add(lis.Vertex, "desconectado", "Nodo desconectado o caido");

                    }
                    else if(int.Parse(lis.Distance) >= 15){

                        dataGridView1.Rows.Add(lis.Vertex, "16", "Inalcansable");
                    }
                    else
                    {
                        dataGridView1.Rows.Add(lis.Vertex, lis.Distance, lis.Path);
                    }

                }
                   
                

            }
            else if (tipo == "OSPF")
            {
                foreach (var lis in l)
                {
                    if (int.Parse(lis.Distance) == int.MaxValue)
                    {

                        dataGridView1.Rows.Add(lis.Vertex, "desconectado", "Nodo desconectado o caido");

                    }
                    else
                    {
                        dataGridView1.Rows.Add(lis.Vertex, lis.Distance, lis.Path);
                    }
                }

            }


            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
