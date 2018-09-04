using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1P_Granja_Fernandez
{
    class Comprueba
    {
        public ListBox Mayor;
        public ListBox Menor;
        public Label Lal;
        /* public delegate void realiza(string cad);
         public event realiza Pasar;*/

        public Comprueba(ListBox lb3, ListBox lb2, Label l)
        {
            this.Mayor = lb3;
            this.Menor = lb2;
            this.Lal = l;
        }


        public void agrega(string edo)
        {
            Lal.Text = "";
            if (Menor.Items.Contains(edo))
            {
                MessageBox.Show("ya esta el estado: " + edo + " en la lista");
            }

            else
            {
                int i = edo.Length;
                if (i <= 7)
                {
                    MessageBox.Show("corto");
                    Mayor.Items.Add(edo);
                    if (edo.Contains("e"))
                    {
                        Lal.Text = ("la palabra contiene la vocal e..");
                    }
                }
                else
                {
                    MessageBox.Show("LARGO");
                    Menor.Items.Add(edo);
                }
            }


        }



        public void elimina()
        {
            try
            {
                if (Menor.Items.Count > 0)
                {
                    Menor.Items.RemoveAt(Menor.SelectedIndex);
                }
                if (Mayor.Items.Count > 0)
                {
                    Mayor.Items.RemoveAt(Mayor.SelectedIndex);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Selecciona un Valor antes de eliminar");
            }
        }
    }
}
