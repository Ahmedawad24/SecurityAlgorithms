using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Encryption_Decryption
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        double P, Q, N, EU;
        double E = 2;
        double D = 0;
        public int[] Binary = new int[10];
        public int[] Binary2 = new int[10];

        public int[] BinDecrypt = new int[10];
        public int[] BinDecrypt2 = new int[10];
        
        Random random = new Random();
        private double GeneratePrimeNumber()
        {
            while (true)
            {
                
                int number = random.Next(2, 100);

                if (number % 2 == 0 && number != 2)
                {
                    continue;
                }

                int m = number / 2;
                bool isPrime = true;
                for (int i = 2; i <= m; i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    return number;
                }
            }
        }
        
        
        private void eButton_Click(object sender, EventArgs e)
        {
            E =int.Parse(EText.Text);

            GenerateE(E, EU);

            eProduct.Text = E.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random Rp = new Random();
            int RandP = Rp.Next(1, 10);
            P = GeneratePrimeNumber();
            Q = GeneratePrimeNumber();
            N = P * Q;
            EU = (P - 1) * (Q - 1);
            
            PTextBox.Text = P.ToString();
            QTextBox.Text = Q.ToString();
        }

        private void EUButton_Click(object sender, EventArgs e)
        {
            P = Int32.Parse(PTextBox.Text);
            Q = Int32.Parse(QTextBox.Text);
            EU = (P - 1) * (Q - 1);
            EUProduct.Text = EU.ToString();
        }

        private void DButton_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < EU; i++)
            {
                if (((E % EU) * (i % EU)) % EU == 1)
                {
                    D = i;
                }
            }
            DLabel.Text = D.ToString();
                
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        int Ciphertext = 1;
        int MessageM = 1;
        private void EncryptButton_Click(object sender, EventArgs e)
        {
           int i;
           string message = EncryptText.Text;
           int Mess = Convert.ToInt32(message);
           int Enew = Convert.ToInt32(E);
           for( i = 0; Enew > 0; i++)
           {
                Binary[i] = Enew % 2;
                Enew = Enew / 2;

           }
            int k = i-1;
           for (int j =0; j < i; j++)
           {
                Binary2[j] = Binary[k];
                k--;
           }
           
           for (int l = 0; l < i; l++)
           {
                if(Binary2[l] == 1)
                {
                    Ciphertext = (Ciphertext * Ciphertext) % Convert.ToInt32(N);
                    Ciphertext = (Ciphertext * Mess) % Convert.ToInt32(N);
                }
                if (Binary2[l] == 0)
                {
                    if(l == 0)
                    {
                        Ciphertext = 0;
                        break;
                    }
                    else
                    {
                        Ciphertext = (Ciphertext * Ciphertext) % Convert.ToInt32(N);
                    }
                }
           }
            MessageBox.Show("Your Ciphertext = " + Ciphertext);

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            int i;
            int Dnew = Convert.ToInt32(D);
            string cipher = DecryptText.Text;
            int ciph = Convert.ToInt32(cipher);
            for (i = 0; Dnew > 0; i++)
            {
                BinDecrypt[i] = Dnew % 2;
                Dnew = Dnew / 2;
            }
            int k = i - 1;
            for (int j = 0; j < i; j++)
            {
                BinDecrypt2[j] = BinDecrypt[k];
                k--;
            }

            for (int l = 0; l < i; l++)
            {
                if (BinDecrypt2[l] == 1)
                {
                    MessageM = (MessageM * MessageM) % Convert.ToInt32(N);
                    MessageM = (MessageM * ciph) % Convert.ToInt32(N);
                }
                if (BinDecrypt2[l] == 0)
                {
                    if (l == 0)
                    {
                        MessageM = 0;
                        break;
                    }
                    else
                    {
                        MessageM = (MessageM * MessageM) % Convert.ToInt32(N);
                    }
                }
            }
            MessageBox.Show("Your Decrypted Message = " + MessageM);
        }

        private void NProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void CalculateNButton_Click(object sender, EventArgs e)
        {
            P = Int32.Parse(PTextBox.Text);
            Q = Int32.Parse(QTextBox.Text);
            N = P * Q;
            NProduct.Text = N.ToString();
            
        }
        void GenerateE(double E, double EU)
        {
            if (1 < E && E < EU)
            {
                for ( ; ; )
                {
                    if (E > EU)
                    {
                        E = E - EU;
                    }
                    else
                    {
                        EU = EU - E;
                    }
                    if (E == 1 || EU == 1)
                    {
                        eProduct.Text = E.ToString();
                        break;
                    }
                    if (E < 1 || EU < 1)
                    {
                        MessageBox.Show("Invalid E, Try Again");
                        break;
                    }
                   
                }
            }
        }
    }
}
