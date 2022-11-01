using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logın_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string kullanici_adi, sifre;
            kullanici_adi = textBox1.Text;
            sifre = textBox2.Text;
            if (kullanici_adi == "emirhanutas" && sifre == "utasemirhan")
            {
                f2.Show();
                MessageBox.Show("Hoşgeldiniz :)");
            }
            else
            {
                MessageBox.Show(" Üzgünüm, kullanıcı adı veya şifre hatalı! :( ");
            }

        }
    }
}
