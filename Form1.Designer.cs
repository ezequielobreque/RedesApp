namespace RedesApp
{
    public partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EliminarN = new FontAwesome.Sharp.IconButton();
            this.agregarN = new FontAwesome.Sharp.IconButton();
            this.EliminarC = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.NuevaC = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.distancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModificarC = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RIP = new System.Windows.Forms.Button();
            this.OSPF = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DesactivarButton = new FontAwesome.Sharp.IconButton();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.desactivarConexion = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // EliminarN
            // 
            this.EliminarN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.EliminarN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EliminarN.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarN.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.EliminarN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.EliminarN.IconSize = 30;
            this.EliminarN.Location = new System.Drawing.Point(188, 676);
            this.EliminarN.Margin = new System.Windows.Forms.Padding(7);
            this.EliminarN.Name = "EliminarN";
            this.EliminarN.Rotation = 0D;
            this.EliminarN.Size = new System.Drawing.Size(161, 55);
            this.EliminarN.TabIndex = 0;
            this.EliminarN.Text = "Eliminar";
            this.EliminarN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarN.UseVisualStyleBackColor = true;
            this.EliminarN.Click += new System.EventHandler(this.EliminarN_Click);
            // 
            // agregarN
            // 
            this.agregarN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.agregarN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.agregarN.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.agregarN.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.agregarN.IconSize = 30;
            this.agregarN.Location = new System.Drawing.Point(22, 676);
            this.agregarN.Margin = new System.Windows.Forms.Padding(7);
            this.agregarN.Name = "agregarN";
            this.agregarN.Rotation = 0D;
            this.agregarN.Size = new System.Drawing.Size(152, 55);
            this.agregarN.TabIndex = 1;
            this.agregarN.Text = "Agregar";
            this.agregarN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.agregarN.UseVisualStyleBackColor = false;
            this.agregarN.Click += new System.EventHandler(this.agregarN_Click);
            // 
            // EliminarC
            // 
            this.EliminarC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.EliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EliminarC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.EliminarC.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.EliminarC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.EliminarC.IconSize = 30;
            this.EliminarC.Location = new System.Drawing.Point(1095, 323);
            this.EliminarC.Margin = new System.Windows.Forms.Padding(7);
            this.EliminarC.Name = "EliminarC";
            this.EliminarC.Rotation = 0D;
            this.EliminarC.Size = new System.Drawing.Size(379, 55);
            this.EliminarC.TabIndex = 2;
            this.EliminarC.Text = "Eliminar Conexion";
            this.EliminarC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EliminarC.UseVisualStyleBackColor = true;
            this.EliminarC.Click += new System.EventHandler(this.EliminarC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nodos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(22, 66);
            this.listBox1.Margin = new System.Windows.Forms.Padding(7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 593);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(581, 66);
            this.listBox2.Margin = new System.Windows.Forms.Padding(7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(321, 593);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // NuevaC
            // 
            this.NuevaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.NuevaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevaC.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.NuevaC.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.NuevaC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.NuevaC.IconSize = 30;
            this.NuevaC.Location = new System.Drawing.Point(1095, 254);
            this.NuevaC.Margin = new System.Windows.Forms.Padding(7);
            this.NuevaC.Name = "NuevaC";
            this.NuevaC.Rotation = 0D;
            this.NuevaC.Size = new System.Drawing.Size(379, 55);
            this.NuevaC.TabIndex = 6;
            this.NuevaC.Text = "Nueva conexion";
            this.NuevaC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevaC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuevaC.UseVisualStyleBackColor = true;
            this.NuevaC.Click += new System.EventHandler(this.NuevaC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conexiones";
            // 
            // distancia
            // 
            this.distancia.BackColor = System.Drawing.SystemColors.Info;
            this.distancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.distancia.Location = new System.Drawing.Point(1095, 66);
            this.distancia.Margin = new System.Windows.Forms.Padding(7);
            this.distancia.Name = "distancia";
            this.distancia.Size = new System.Drawing.Size(379, 38);
            this.distancia.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1089, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Distancia";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ModificarC
            // 
            this.ModificarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModificarC.Location = new System.Drawing.Point(1095, 185);
            this.ModificarC.Margin = new System.Windows.Forms.Padding(7);
            this.ModificarC.Name = "ModificarC";
            this.ModificarC.Size = new System.Drawing.Size(379, 55);
            this.ModificarC.TabIndex = 10;
            this.ModificarC.Text = "Modificar conexion";
            this.ModificarC.UseVisualStyleBackColor = true;
            this.ModificarC.Click += new System.EventHandler(this.ModificarC_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1095, 424);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Simular";
            // 
            // RIP
            // 
            this.RIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RIP.Location = new System.Drawing.Point(1095, 462);
            this.RIP.Margin = new System.Windows.Forms.Padding(7);
            this.RIP.Name = "RIP";
            this.RIP.Size = new System.Drawing.Size(379, 55);
            this.RIP.TabIndex = 12;
            this.RIP.Text = "RIP";
            this.RIP.UseVisualStyleBackColor = true;
            this.RIP.Click += new System.EventHandler(this.RIP_Click);
            // 
            // OSPF
            // 
            this.OSPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OSPF.Location = new System.Drawing.Point(1095, 531);
            this.OSPF.Margin = new System.Windows.Forms.Padding(7);
            this.OSPF.Name = "OSPF";
            this.OSPF.Size = new System.Drawing.Size(379, 55);
            this.OSPF.TabIndex = 13;
            this.OSPF.Text = "OSPF";
            this.OSPF.UseVisualStyleBackColor = true;
            this.OSPF.Click += new System.EventHandler(this.OSPF_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(1456, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(44, 49);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DesactivarButton
            // 
            this.DesactivarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.DesactivarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesactivarButton.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DesactivarButton.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesactivarButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.DesactivarButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.DesactivarButton.IconSize = 30;
            this.DesactivarButton.Location = new System.Drawing.Point(363, 676);
            this.DesactivarButton.Margin = new System.Windows.Forms.Padding(7);
            this.DesactivarButton.Name = "DesactivarButton";
            this.DesactivarButton.Rotation = 0D;
            this.DesactivarButton.Size = new System.Drawing.Size(199, 55);
            this.DesactivarButton.TabIndex = 15;
            this.DesactivarButton.Text = "Des/Activar";
            this.DesactivarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DesactivarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DesactivarButton.UseVisualStyleBackColor = true;
            this.DesactivarButton.Click += new System.EventHandler(this.DesactivarButton_Click);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.listBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Location = new System.Drawing.Point(363, 66);
            this.listBox3.Margin = new System.Windows.Forms.Padding(7);
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox3.Size = new System.Drawing.Size(199, 593);
            this.listBox3.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // desactivarConexion
            // 
            this.desactivarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desactivarConexion.Location = new System.Drawing.Point(1095, 118);
            this.desactivarConexion.Margin = new System.Windows.Forms.Padding(7);
            this.desactivarConexion.Name = "desactivarConexion";
            this.desactivarConexion.Size = new System.Drawing.Size(379, 55);
            this.desactivarConexion.TabIndex = 18;
            this.desactivarConexion.Text = "desactivar conexion";
            this.desactivarConexion.UseVisualStyleBackColor = true;
            this.desactivarConexion.Click += new System.EventHandler(this.desactivarConexion_Click);
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.listBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Location = new System.Drawing.Point(902, 66);
            this.listBox4.Margin = new System.Windows.Forms.Padding(7);
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(179, 593);
            this.listBox4.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1499, 745);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.desactivarConexion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.DesactivarButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OSPF);
            this.Controls.Add(this.RIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModificarC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NuevaC);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarC);
            this.Controls.Add(this.agregarN);
            this.Controls.Add(this.EliminarN);
            this.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton EliminarN;
        private FontAwesome.Sharp.IconButton agregarN;
        private FontAwesome.Sharp.IconButton EliminarC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private FontAwesome.Sharp.IconButton NuevaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox distancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModificarC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RIP;
        private System.Windows.Forms.Button OSPF;
        private System.Windows.Forms.Button ExitButton;
        private FontAwesome.Sharp.IconButton DesactivarButton;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button desactivarConexion;
        private System.Windows.Forms.ListBox listBox4;
    }
}

