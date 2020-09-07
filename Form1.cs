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
        public List<Nodo> lista = context.Nodo.Where(s => s.nodo >= 0).OrderBy(s=>s.nodo).ToList();

        public List<Conexion> Conexiones = context.Conexion.Where(s => s.Id >= 0).OrderBy(s =>s.Id).ToList();
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
            this.Conexiones = context.Conexion.Where(s => s.Id >= 0).OrderBy(s =>s.Id).ToList();
        }

        public void getListas()
        {
            this.lista = context.Nodo.Where(s => s.nodo >= 0).OrderBy(s => s.nodo).ToList();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            /* this.listBox1.DisplayMember = "nodo";
             this.listBox1.ValueMember = "Id";*/
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

            foreach (var i in this.lista)
            {
                this.listBox1.Items.Add($"Nodo {i.nodo}");
                this.listBox3.Items.Add(i.activado);
            }
            
        }
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        // función privada usada para mover el formulario actual

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.distancia.Text="";
            this.listBox2.Items.Clear();
            this.listBox4.Items.Clear();
            var x = this.listBox1.SelectedIndex;
            foreach (var i in this.Conexiones)
            {
                if (i.Nodo1.nodo == x)
                {
                    this.listBox2.Items.Add($"Nodo {i.Nodo2.nodo}");
                   
                     this.listBox4.Items.Add(i.activado);
                    
                }
                if (i.Nodo2.nodo == x)
                {
                    this.listBox2.Items.Add($"Nodo {i.Nodo1.nodo}");
                    this.listBox4.Items.Add(i.activado);
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
                MessageBox.Show("Conexion modificada", "Conexion Modificada",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         

        }

        private void agregarN_Click(object sender, EventArgs e)
        {
            context.Nodo.Add(new Nodo { nodo = this.lista.Count(),activado=true });
            context.SaveChanges();
            this.getListas();
            this.getConexiones();
            listBox1.Items.Add($"Nodo {this.lista.Count()-1}");
            this.listBox3.Items.Add("true");
        }

        private void EliminarN_Click(object sender, EventArgs e)
        {
            context.Nodo.Remove(lista.Last());
            context.SaveChanges();
            this.getListas();
            this.getConexiones();
            listBox1.Items.RemoveAt(listBox1.Items.Count-1);
            listBox3.Items.RemoveAt(listBox1.Items.Count-1);

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
            this.getListas();
            this.getConexiones();
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
            getConexiones();
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            this.listBox4.Items.Clear();
            foreach (var i in this.Conexiones)
            {
                this.listBox4.Items.Add(i.activado);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void DesactivarButton_Click(object sender, EventArgs e)
        {
            var x = listBox1.SelectedItem.ToString();
            int item = int.Parse(x.Substring(5));


            var nod =context.Nodo.Where(c => c.nodo == item).FirstOrDefault();
            if (nod.activado == true) { nod.activado = false; } else { nod.activado = true; }
            context.SaveChanges();
            getListas();
            getConexiones();
            listBox3.Items.Clear();

            foreach (var i in this.lista)
            {
                this.listBox3.Items.Add(i.activado);
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void desactivarConexion_Click(object sender, EventArgs e)
        {


            try { 

            
            if (this.distan.activado == true) { this.distan.activado = false; } else { this.distan.activado = true; }
            context.SaveChanges();
            getListas();
            getConexiones();
            listBox4.Items.Clear();

         

            this.listBox4.Items.Clear();
            var x = this.listBox1.SelectedIndex;
            foreach (var i in this.Conexiones)
            {
                if (i.Nodo1.nodo == x)
                {
                    this.listBox4.Items.Add(i.activado);
                }
                if (i.Nodo2.nodo == x)
                {
                    this.listBox4.Items.Add(i.activado);
                }

            }
        MessageBox.Show("Conexion Des/Activada", "Conexion Des/Activada",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }
    }
}
