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

    public partial class Form1 : Form
    {
       static DBcontext context = new DBcontext();
        public List<Nodo> lista = context.Nodo.Where(s => s.nodo >= 0).ToList();

        public List<Conexion> Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
        Conexion distan=null;
        public Form1()
            {
            
            MainController mainController = new MainController();
            InitializeComponent();
            /*var grapho = mainController.grafo();
            mainController.dijkstra(grapho, 0);*/
        }

        public void getConexiones()
        {
            this.Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
        }

        public void getListas()
        {
            this.lista = context.Nodo.Where(s => s.nodo >= 0).ToList();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
           /* this.listBox1.DisplayMember = "nodo";
            this.listBox1.ValueMember = "Id";*/

            foreach (var i in this.lista)
            {
                this.listBox1.Items.Add($"Nodo {i.nodo}");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.distancia.Text="";
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
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         this.distancia.Text = "";
            string x="";
            try{
                x = listBox2.SelectedItem.ToString();
                int item = int.Parse(x.Substring(5));

                var y = this.listBox1.SelectedIndex;
                foreach (var i in this.Conexiones)
                {
                    if ((i.Nodo1.nodo == y && i.Nodo2.nodo == item) || (i.Nodo1.nodo == item && i.Nodo2.nodo == y)) {
                        this.distancia.Text = i.distancia.ToString();
                        distan = i;
                    }

                } 
            }
            catch
            {
            }
        }

        private void ModificarC_Click(object sender, EventArgs e)
        {
            if (distan != null)
            {
                var x = listBox2.SelectedItem.ToString();
                int item = int.Parse(x.Substring(5));

                var y = this.listBox1.SelectedIndex;

                distan.distancia = int.Parse(this.distancia.Text);
                context.SaveChanges();
                getListas();
                getConexiones();
            }
            
            
        }

        private void agregarN_Click(object sender, EventArgs e)
        {
            context.Nodo.Add(new Nodo { nodo = this.lista.Count() });
            context.SaveChanges();
           this.lista = context.Nodo.Where(s => s.nodo >= 0).ToList();
            this.getConexiones();
            listBox1.Items.Add($"Nodo {this.lista.Count()-1}");
        }

        private void EliminarN_Click(object sender, EventArgs e)
        {
            context.Nodo.Remove(lista.Last());
            context.SaveChanges();
            this.lista = context.Nodo.Where(s => s.nodo >= 0).ToList();
            this.getConexiones();
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);
        }

        private void NuevaC_Click(object sender, EventArgs e)
        {
            //this.Hide();
            dialog dia = new dialog(this);
            dia.ShowDialog();
            
        }

        private void RIP_Click(object sender, EventArgs e)
        {


            /*if (Nodoscompletos() == true)
            {*/
                Form2 form2 = new Form2("RIP");
                form2.ShowDialog();

            /*}
            else
            {
            MessageBox.Show("Todos los deben estar conectados para poder continuar", "Error de conexiones en los nodos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
           }*/

        }

        private bool Nodoscompletos()
        {
            var nodoscomple = true;

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
                if (bol == false) { nodoscomple = false; };
            }


            return nodoscomple;
        }

        private void OSPF_Click(object sender, EventArgs e)
        {
           

            /*if (Nodoscompletos() == true)
            {*/
                Form2 form2 = new Form2("OSPF");
                form2.ShowDialog();

           /* }
            else
            {
                MessageBox.Show("Todos los deben estar conectados para poder continuar", "Error de conexiones en los nodos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void EliminarC_Click(object sender, EventArgs e)
        {
            this.lista = context.Nodo.Where(s => s.nodo >= 0).ToList();
            this.Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
            var x = listBox2.SelectedItem.ToString();
            int item = int.Parse(x.Substring(5));
            Conexion no= new Conexion();
            var y = this.listBox1.SelectedIndex;
            foreach (var i in this.Conexiones)
            {
                if ((i.Nodo1.nodo == y && i.Nodo2.nodo == item) || (i.Nodo1.nodo == item && i.Nodo2.nodo == y))
                {
                    no = i;
                }

            }
            context.Conexion.Remove(no);
            context.SaveChanges();
            this.Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
