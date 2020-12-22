using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace Sala_espera
{
    public partial class Form1 : Form
    {
        // Variable de instancia
        Queue<string> ColaInstancia = new Queue<string>();
        bool Inicio = false;
        

        public Form1()
        {
            InitializeComponent();
            LlenarCola(ColaInstancia);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Declaracion de variables
            string[] arrCola = ColaInstancia.ToArray<string>();
            List<Label> listaLabel = new List<Label>();
            Label[] arrLabel = { label1, label2, label3 };

            // Imprimir la label atendido en blanco en la primera corrida del programa
            if (Inicio == false)
            {
                labelAtendido.Text = string.Empty;
            }

            // Asignar una cadena en blanco a todas las labels
            foreach (Label lbl in arrLabel)
                lbl.Text = string.Empty;

            // Asignar a las labels el valor correspondiente de la cola
            int i = 0;
            while(i < arrCola.Length && i < arrLabel.Length)
            {
                arrLabel[i].Text = arrCola[i];
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ColaInstancia.Count > 0)
            {
                labelAtendido.Text = ColaInstancia.Dequeue();
                Inicio = true;
                Form1_Load(sender, e);
            }
            else
            {
                labelAtendido.Text = string.Empty;
                MessageBox.Show("No hay mas personas en la fila");
            }
            
        }

        private void LlenarCola(Queue<string> cola)
        {
            string[] arr = { "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete" };
            foreach (string elm in arr)
                cola.Enqueue(elm);
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxAgregar.Text == string.Empty)
                MessageBox.Show("Ingresa un dato valido");
            else
            {
                ColaInstancia.Enqueue(textBoxAgregar.Text);
                textBoxAgregar.Text = string.Empty;
                textBoxAgregar.Focus();
            }
        }
    }
}
