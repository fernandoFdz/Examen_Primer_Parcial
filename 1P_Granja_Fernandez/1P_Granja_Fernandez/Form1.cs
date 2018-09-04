using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1P_Granja_Fernandez
{
    public partial class Form1 : Form
    {

     
        public string cadena;
        private Comprueba cambia;

        public Form1()
        {
            InitializeComponent();
            cambia = new Comprueba(lb3, lb2, labelE);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static void verifica(object sender, EventArgs e)
        {
            Comprueba c = (Comprueba)sender;
            MessageBox.Show("el estado contiene una e");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cadena = lb1.SelectedItem.ToString();
            cambia.agrega(cadena);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            cambia.elimina();               
        }

        
        

        
    }
}
