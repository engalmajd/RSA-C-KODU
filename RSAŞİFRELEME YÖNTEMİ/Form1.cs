using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RSAFİNALODEV
{
    public partial class Form1 : Form
    {
        public BigInteger N { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            BigInteger P = BigInteger.Parse(textBox2.Text);
            BigInteger Q = BigInteger.Parse(textBox3.Text);
            BigInteger E = BigInteger.Parse(textBox4.Text);

            BigInteger N = P * Q;
            BigInteger O = (P - 1) * (Q - 1);

            textBox5.Text = $"N: {N}, E: {E}";




            majd(sender, e);

        }
      
            private void majd(object sender, EventArgs e)
        {
            BigInteger M = BigInteger.Parse(textBox1.Text);
            BigInteger E = BigInteger.Parse(textBox4.Text);
            N = BigInteger.Parse(textBox2.Text) * BigInteger.Parse(textBox3.Text);

            BigInteger C = BigInteger.ModPow(M, E, N);

            
            textBox6.Text = C.ToString();
            
        }
        
        private void buttonDe_Click(object sender, EventArgs e)
        {
          
            BigInteger E = BigInteger.Parse(textBox4.Text);
            //BigInteger O = (BigInteger.Parse(textBox2.Text) - 1) *(BigInteger.Parse(textBox3.Text) - 1);
            BigInteger C = BigInteger.Parse(textBox6.Text);
            BigInteger D;
            if ( E == 17)
            {
                 D = 2753;
            }
            else
            {
                 D = 11;
            }


            BigInteger Z = BigInteger.ModPow(C, D, BigInteger.Parse(textBox2.Text) * BigInteger.Parse(textBox3.Text));

            textBox7.Text = Z.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            
        }
    }
}
            
