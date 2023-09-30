using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_rc4
{
    public partial class Rc41 : Form
    {
        public List<int> LKey = new List<int>();
        public List<int> LPlain = new List<int>();
        public List<int> LS = new List<int>();
        public List<int> LT = new List<int>();

        public Rc41()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            textBox2.KeyPress += TextBox2_KeyPress;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b01234567 ".Contains(e.KeyChar);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b01234567 ".Contains(e.KeyChar);
        }

        private void Rc41_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] stringKey = textBox1.Text.Split(' ');
            string[] stringPlain = textBox2.Text.Split(' ');

            for (int i = 0; i < stringKey.Length; i++)
            {
                LKey.Add(Int32.Parse(stringKey[i]));
                LPlain.Add(Int32.Parse(stringPlain[i]));
            }
            
            for (int i = 0; i < 8; i++)
            {
                LS.Add(i);
                if (i < 4)
                {
                    LT.Add(LKey[i]);
                }
                else
                {
                    LT.Add(LKey[0]);
                    LT.Add(LKey[1]);
                    LT.Add(LKey[2]);
                    LT.Add(LKey[3]);
                }
            }

            Rc42 F = new Rc42();
            F.LS = this.LS;
            F.LT = this.LT;
            F.LPlain = this.LPlain;

            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
