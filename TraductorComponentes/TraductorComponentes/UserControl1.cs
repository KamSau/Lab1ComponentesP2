using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraductorComponentes
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto = this.textBox1.Text;
            switch (texto)
            {
                case "hola":
                    this.label1.Text = "hello";
                    break;

                case "adios":
                    this.label1.Text = "bye";
                    break;

                case "azul":
                    this.label1.Text = "blue";
                    break;

                case "amarillo":
                    this.label1.Text = "yellow";
                    break;

                case "rojo":
                    this.label1.Text = "red";
                    break;

                case "negro":
                    this.label1.Text = "black";
                    break;

                case "botella":
                    this.label1.Text = "bottle";
                    break;

                case "agua":
                    this.label1.Text = "water";
                    break;

                case "perro":
                    this.label1.Text = "dog";
                    break;

                case "gato":
                    this.label1.Text = "cat";
                    break;

                default:
                    this.label1.Text = "N/A";
                    break;
            }

        }
    }
}
