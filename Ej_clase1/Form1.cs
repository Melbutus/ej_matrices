using Ej_clase1.Models;

namespace Ej_clase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Universidad uni = new Universidad();

        private void bt_simular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uni.simularJuego();

            string[] resultado = uni.Describir();

            foreach (string s in resultado)
            {
                listBox1.Items.Add(s);
            }
        }

        private void bt_ordenar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            uni.ordenar();

            string[] res = uni.Describir();
            
            foreach (string s in res)
            {
                listBox1.Items.Add(s);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
