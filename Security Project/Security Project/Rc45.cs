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
    public partial class Rc45 : Form
    {
        public List<int> LC = new List<int>();

        public Rc45()
        {
            InitializeComponent();
        }

        private void Rc45_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i < 3)
                    textBox1.Text += LC[i].ToString() + ",";
                else
                    textBox1.Text += LC[i].ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
