using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebService03Cliente
{
    public partial class Form1 : Form
    {

        private ListasWs.WebServiceListas listas;

        public Form1()
        {
            InitializeComponent();
            listas = new ListasWs.WebServiceListas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = listas.ListaSimple();

            string msg = "";

            foreach(int x in data)
            {
                msg += x + "\r\n";
            }

            textBox1.Text = msg;
        }
    }
}
