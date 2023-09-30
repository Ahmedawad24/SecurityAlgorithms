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
    public partial class Rc42 : Form
    {
        public List<int> LS = new List<int>();
        public List<int> LT = new List<int>();
        public List<int> LPlain = new List<int>();
        public Rc42()
        {
            InitializeComponent();
        }

        private void Rc42_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < LS.Count() ; i++)
            {
                if ( i < LS.Count - 1)
                {
                    textBox1.Text += LS[i].ToString() + ",";
                    textBox2.Text += LT[i].ToString() + ",";
                }
                else
                {
                    textBox1.Text += LS[i].ToString();
                    textBox2.Text += LT[i].ToString();
                }
            }
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rc43 F3 = new Rc43();
            F3.LS = this.LS;
            F3.LT = this.LT;
            F3.LPlain = this.LPlain;
            this.Close();
            F3.Show();
            
        }
    }
}
