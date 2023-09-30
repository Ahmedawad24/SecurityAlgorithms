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
    public partial class Rc44 : Form
    {
        public List<int> LS = new List<int>();
        public List<int> LT = new List<int>();
        public List<int> LPlain = new List<int>();
        public List<int> LC = new List<int>();

        List<int> Li = new List<int>();
        List<int> Lj = new List<int>();
        List<int> LTm = new List<int>();
        List<int> LKey = new List<int>();

        List<string> LOK = new List<string>();
        List<string> LOP = new List<string>();
        List<string> LXor = new List<string>();

        public Rc44()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        
        string GetOct ( int x )
        {
            string Tmp="";
            if ( x == 0)
            {
                Tmp = "000";
            }
            if (x == 1)
            {
                Tmp = "001";
            }
            if (x == 2)
            {
                Tmp = "010";
            }
            if (x == 3)
            {
                Tmp = "011";
            }
            if (x == 4)
            {
                Tmp = "100";
            }
            if (x == 5)
            {
                Tmp = "101";
            }
            if (x == 6)
            {
                Tmp = "110";
            }
            if (x == 7)
            {
                Tmp = "111";
            }

            return Tmp;
        }
        string GetXor ( string x , string y)
        {
            string tmp = "";
            for (int i = 0; i < x.Length; i++)
            {
                if(x[i] == '0' && y[i]=='0' || x[i] == '1' && y[i] == '1')
                {
                    tmp += '0';
                }
                if (x[i] == '1' && y[i] == '0' || x[i] == '0' && y[i] == '1')
                {
                    tmp += '1';
                }

            }

            return tmp;
        }
        int getDec ( string x)
        {
            int Tmp = 0;
            if (x == "000")
            {
                Tmp = 0;
            }
            if (x == "001")
            {
                Tmp = 1 ;
            }
            if (x == "010")
            {
                Tmp = 2;
            }
            if (x == "011")
            {
                Tmp = 3;
            }
            if (x == "100")
            {
                Tmp = 4;
            }
            if (x == "101")
            {
                Tmp = 5;
            }
            if (x == "110")
            {
                Tmp = 6;
            }
            if (x == "111")
            {
                Tmp = 7;
            }

            return Tmp;
        }
        void start()
        {
            for (int i = 0; i < 8; i++)
            {
                if (i < 7)
                    textBox1.Text += LS[i].ToString() + ",";
                else
                    textBox1.Text += LS[i].ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                if (i < 7)
                    textBox2.Text += LT[i].ToString() + ",";
                else
                    textBox2.Text += LT[i].ToString();
            }

            for (int i = 0; i < 4; i++)
            {
                if (i < 3)
                    textBox3.Text += LPlain[i].ToString() + ",";
                else
                    textBox3.Text += LPlain[i].ToString();
            }


        }
        void writeS(int x)
        {
            if (x == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox6.Text += LS[i].ToString() + ",";
                    else
                        textBox6.Text += LS[i].ToString();
                }
            }
            if (x == 1)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox19.Text += LS[i].ToString() + ",";
                    else
                        textBox19.Text += LS[i].ToString();
                }
            }
            if (x == 2)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox28.Text += LS[i].ToString() + ",";
                    else
                        textBox28.Text += LS[i].ToString();
                }
            }
            if (x == 3)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (i < 7)
                        textBox37.Text += LS[i].ToString() + ",";
                    else
                        textBox37.Text += LS[i].ToString();
                }
            }
        }
        void step(int trav)
        {
            if (trav == 0)
            {
                textBox4.Text = Li[trav].ToString();
                textBox5.Text = Lj[trav].ToString();
                textBox7.Text = LTm[trav].ToString();
                textBox8.Text = LKey[trav].ToString();
                textBox9.Text = LOK[trav];
                textBox10.Text = LOP[trav];
                textBox11.Text = LXor[trav];
                textBox12.Text = LC[trav].ToString();
            }

            if(trav == 1)
            {
                textBox21.Text = Li[trav].ToString();
                textBox20.Text = Lj[trav].ToString();
                textBox18.Text = LTm[trav].ToString();
                textBox17.Text = LKey[trav].ToString();
                textBox16.Text = LOK[trav];
                textBox15.Text = LOP[trav];
                textBox14.Text = LXor[trav];
                textBox13.Text = LC[trav].ToString();
            }

            if (trav == 2)
            {
                textBox30.Text = Li[trav].ToString();
                textBox29.Text = Lj[trav].ToString();
                textBox27.Text = LTm[trav].ToString();
                textBox26.Text = LKey[trav].ToString();
                textBox25.Text = LOK[trav];
                textBox24.Text = LOP[trav];
                textBox23.Text = LXor[trav];
                textBox22.Text = LC[trav].ToString();
            }

            if (trav == 3)
            {
                textBox39.Text = Li[trav].ToString();
                textBox38.Text = Lj[trav].ToString();
                textBox36.Text = LTm[trav].ToString();
                textBox35.Text = LKey[trav].ToString();
                textBox34.Text = LOK[trav];
                textBox33.Text = LOP[trav];
                textBox32.Text = LXor[trav];
                textBox31.Text = LC[trav].ToString();
            }

        }
        private void Rc44_Load(object sender, EventArgs e)
        {
            start();
            int trav = 0;
            int i = 0, j = 0;
            while ( trav < LPlain.Count)
            {
                i = (i+1) % 8;
                Li.Add(i);

                j = (j + LS[i]) % 8;
                Lj.Add(j);

                int tmp = LS[i];
                LS[i] = LS[j];
                LS[j] = tmp;
                writeS(trav);

                int tmp2 = (LS[i] + LS[j]) % 8;
                LTm.Add(tmp2);

                int Key = LS[tmp2];
                LKey.Add(Key);

                string T1 = GetOct(Key);
                LOK.Add(T1);

                string T2 = GetOct(LPlain[trav]);
                LOP.Add(T2);

                string T3 = GetXor(T1, T2);
                LXor.Add(T3);

                int t4 = getDec(T3);
                LC.Add(t4);

                step(trav);

                trav++;
           }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rc45 F5 = new Rc45();
            F5.LC = LC;
            this.Close();
            F5.Show();
        }
    }
}
