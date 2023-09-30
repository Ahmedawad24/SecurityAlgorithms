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
    public partial class Rc43 : Form
    {
        public List<int> LS = new List<int>();
        public List<int> LT = new List<int>();
        public List<int> LPlain = new List<int>();
        List<int> LJ = new List<int>();
        List<List<int>> LST = new List<List<int>>();

        public Rc43()
        {
            InitializeComponent();
        }

        void writeS (int x)
        {
            if(x ==0)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox1.Text += LST[0][i].ToString() + ",";
                    else
                        textBox1.Text += LST[0][i].ToString();
                }
            }
            if (x == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox2.Text += LST[1][i].ToString() + ",";
                    else
                        textBox2.Text += LST[1][i].ToString();
                }
            }
            if (x == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox3.Text += LST[2][i].ToString() + ",";
                    else
                        textBox3.Text += LST[2][i].ToString();
                }
            }
            if (x == 3)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox4.Text += LST[3][i].ToString() + ",";
                    else
                        textBox4.Text += LST[3][i].ToString();
                }
            }
            if (x == 4)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox5.Text += LST[4][i].ToString() + ",";
                    else
                        textBox5.Text += LST[4][i].ToString();
                }
            }
            if (x == 5)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox6.Text += LST[5][i].ToString() + ",";
                    else
                        textBox6.Text += LST[5][i].ToString();
                }
            }
            if (x == 6)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox7.Text += LST[6][i].ToString() + ",";
                    else
                        textBox7.Text += LST[6][i].ToString();
                }
            }
            if (x == 7)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox8.Text += LST[7][i].ToString() + ",";
                    else
                        textBox8.Text += LST[7][i].ToString();
                }
            }
        }
        void writemod()
        {
            textBox9.Text =  LJ[0].ToString();
            textBox10.Text = LJ[1].ToString();
            textBox11.Text = LJ[2].ToString();
            textBox12.Text = LJ[3].ToString();
            textBox13.Text = LJ[4].ToString();
            textBox14.Text = LJ[5].ToString();
            textBox15.Text = LJ[6].ToString();
            textBox16.Text = LJ[7].ToString();
        }
        private void Rc43_Load(object sender, EventArgs e)
        {
            int j = 0;
            for (int i = 0; i < 8; i++)
            {
                j = (j + LS[i] + LT[i]) % 8;
                LJ.Add(j);
                int tmp = LS[i];
                LS[i] = LS[j];
                LS[j] = tmp;
                LST.Add(LS);

                writeS(i);
            }

            writemod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rc44 F4 = new Rc44();
            F4.LS = LS;
            F4.LT = LT;
            F4.LPlain = this.LPlain;
            this.Close();
            F4.Show();
            

        }
    }
}
