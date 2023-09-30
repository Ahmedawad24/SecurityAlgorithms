using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S_rc4;
using SAES;
using Playfair;
using RSA_Encryption_Decryption;

namespace Security_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playfairButton_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
        }

        private void SDESButton_Click(object sender, EventArgs e)
        {
            SDESForm form = new SDESForm();
            form.Show();
        }

        private void SAESButton_Click(object sender, EventArgs e)
        {
            S_AES form = new S_AES();
            form.Show();
        }

        private void simplifiedRC4Button_Click(object sender, EventArgs e)
        {
            Rc41 form = new Rc41();
            form.Show();
        }

        private void RSAButton_Click(object sender, EventArgs e)
        {
            RSA form = new RSA();
            form.Show();
        }
    }
}
