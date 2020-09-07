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

    public partial class dialog : Form
    {
        static DBcontext context = new DBcontext();
        Nodo[] lista = context.Nodo.Where(s => s.nodo >= 0).ToArray();

        List<Conexion> Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
        Form1 form;
        public dialog(Form1 fo)
            {
            
            MainController mainController = new MainController();
            InitializeComponent();
            form = fo;
            /*var grapho = mainController.grafo();
            mainController.dijkstra(grapho, 0);*/
        }

       // private void Form1_Load(object sender, EventArgs e)
       // {
           /* this.listBox1.DisplayMember = "nodo";
            this.listBox1.ValueMember = "Id";*/

          /*  foreach (var i in this.lista)
            {
                this.listBox1.Items.Add($"Nodo {i.nodo}");
            }
            
        }*/

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void dialog_Load(object sender, EventArgs e)
        {
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            foreach (var i in this.lista)
            {
                this.comboBox1.Items.Add($"Nodo {i.nodo}");
                this.comboBox2.Items.Add($"Nodo {i.nodo}");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            var Nodo1 = lista[this.comboBox1.SelectedIndex];
            var Nodo2 = lista[this.comboBox2.SelectedIndex];
            var existe = false;
           foreach(var x in Conexiones)
            {

                if ((x.Nodo1 == Nodo1 && x.Nodo2 == Nodo2) || (x.Nodo1 == Nodo2 && x.Nodo2 == Nodo1)) {
                    existe = true;
                } 
            }
            if (Nodo1 == Nodo2)
            {

                MessageBox.Show("Los nodos no pueden ser iguales", "Error creacion conexion",
               MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(existe==true){
                MessageBox.Show("Ya existe esa conexion", "Error creacion conexion",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                context.Conexion.Add(new Conexion { Nodo1 = Nodo1, Nodo2 = Nodo2, distancia = int.Parse(distancia.Text),activado=true });
                context.SaveChanges();
                this.form.lista = context.Nodo.Where(s => s.nodo >= 0).ToList();


                this.form.Conexiones = context.Conexion.Where(s => s.Id >= 0).ToList();
                this.Close();
            }
        
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*  private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
