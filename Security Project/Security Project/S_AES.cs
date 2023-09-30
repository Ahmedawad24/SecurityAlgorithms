using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAES
{
    public partial class S_AES : Form
    {
        public S_AES()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string plain = textBox1.Text;
            char[] plainarray = plain.ToCharArray();
            int count = 0;

            int pi = 0;
            int pi2 = 0;
            int pi3 = 0;
            int pi4 = 0;

            if (plainarray.Length > 16)
            {
                MessageBox.Show("Error");
            }
            else
            {
                richTextBox1.AppendText("Plain Text = ");
                for (int i = 0; i < plainarray.Length; i++)
                {
                    if (Convert.ToInt32(plainarray[i].ToString()) == 1 || Convert.ToInt32(plainarray[i].ToString()) == 0)
                    {
                        richTextBox1.AppendText(""+ plainarray[i]);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        break;
                    }
                }
            }

           

            string key = textBox2.Text;
            char[] keyarray = key.ToCharArray();

            if(keyarray.Length > 16)
            {
                MessageBox.Show("Error");
            }
            else
            {
                richTextBox1.AppendText(Environment.NewLine);
                richTextBox1.AppendText("Key = ");
                for (int i = 0; i < keyarray.Length; i++)
                {
                    
                    if (Convert.ToInt32(keyarray[i].ToString()) == 1 || Convert.ToInt32(keyarray[i].ToString()) == 0)
                    {
                        
                        richTextBox1.AppendText(""+keyarray[i]);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        break;
                    }
                }
            }

            string w0 = "";
            string w1 = "";


            
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            for (int i = 0; i < 8; i++)
            {
                w0 += keyarray[i];
            }
            for (int i = 8; i < 16; i++)
            {
                w1 += keyarray[i];
            }

            richTextBox1.AppendText("w0 = ");
            richTextBox1.AppendText("" + w0);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("w1 = ");
            richTextBox1.AppendText("" + w1);
            richTextBox1.AppendText(Environment.NewLine);

            char[] w0array = w0.ToCharArray();
            char[] w1array = w1.ToCharArray();

            

            string const1 = "10000000";

            char[] const1array = const1.ToCharArray();

            string w2xor1 = "";

            for(int i = 0; i < const1array.Length; i++)
            {
                if (Convert.ToInt32(w0array[i].ToString()) == Convert.ToInt32(const1array[i].ToString()))
                {
                    w2xor1 += "0";
                }
                else
                {
                    w2xor1 += "1";
                }
            }
           

            char[] w2xor1array = w2xor1.ToCharArray();

            string rotnib1 = "";
            for(int i = 4; i < w1array.Length; i++ )
            {
                rotnib1 += w1array[i];
            }

            for (int i = 0; i < 4; i++)
            {
                rotnib1 += w1array[i];
            }

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("rotnib1 = ");
            richTextBox1.AppendText("" + rotnib1);

            char[] rotnib1array = rotnib1.ToCharArray();


            int[,] nibble = new int[15, 4] {
                {0,0,0,0},
                {0,0,0,1},
                {0,0,1,0},
                {0,0,1,1},
                {0,1,0,0},
                {0,1,0,1},
                {0,1,1,0},
                {0,1,1,1},
                {1,0,0,0},
                {1,0,0,1},
                {1,0,1,0},
                {1,0,1,1},
                {1,1,0,0},
                {1,1,0,1},
                {1,1,1,1},
                                             
                                                         };

            int[,] sbox = new int[15, 4] {
                {1,0,0,1},
                {0,1,0,0},
                {1,0,1,0},
                {1,0,1,1},
                {1,1,0,1},
                {0,0,0,1},
                {1,0,0,0},
                {0,1,0,1},
                {0,1,1,0},
                {0,0,1,0},
                {0,0,0,0},
                {0,0,1,1},
                {1,1,0,0},
                {1,1,1,0},
                {0,1,1,1},

                                                         };


            for(int i = 0; i < 15 ; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(rotnib1array[j].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j]);
                        count++;
                        if (count == 4)
                        {
                            pi = i;
                            
                        }

                    }

                }
                count = 0;
            }

           /* richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("pi = ");
            richTextBox1.AppendText("" + pi+ "    ");*/

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(rotnib1array[j+4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi2 = i;

                        }

                    }

                }
                count = 0;
            }

            /*richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("pi = ");
            richTextBox1.AppendText("" + pi2);

            richTextBox1.AppendText("" + sbox[14 , 1]);*/
            string subnib1 = "";

            for(int i = 0; i<4;i++)
            {
                subnib1 += sbox[pi, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib1 += sbox[pi2, i];
            }



            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("subnib1 = ");
            richTextBox1.AppendText("" + subnib1);


            char[] subnib1array = subnib1.ToCharArray();


            string w2 = "";

            for (int i = 0; i < subnib1array.Length; i++)
            {
                if (Convert.ToInt32(subnib1array[i].ToString()) == Convert.ToInt32(w2xor1array[i].ToString()))
                {
                    w2 += "0";
                }
                else
                {
                    w2 += "1";
                }
            }
            richTextBox1.AppendText(Environment.NewLine);
            

            richTextBox1.AppendText("w2 = ");
            richTextBox1.AppendText("" + w2);

            char[] w2array = w2.ToCharArray();

            string w3 = "";

            for (int i = 0; i < w2array.Length; i++)
            {
                if (Convert.ToInt32(w2array[i].ToString()) == Convert.ToInt32(w1array[i].ToString()))
                {
                    w3 += "0";
                }
                else
                {
                    w3 += "1";
                }
            }

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);



            richTextBox1.AppendText("w3 = ");
            richTextBox1.AppendText("" + w3);
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);
            char[] w3array = w3.ToCharArray();

            string w4xor1 = "";
            string const2 = "00110000";
            char[] const2array = const2.ToCharArray();

            for (int i = 0; i < const2array.Length; i++)
            {
                if (Convert.ToInt32(w2array[i].ToString()) == Convert.ToInt32(const2array[i].ToString()))
                {
                    w4xor1 += "0";
                }
                else
                {
                    w4xor1 += "1";
                }
            }

            char[] w4xor1array = w4xor1.ToCharArray();

            string rotnib2 = "";
            for (int i = 4; i < w3array.Length; i++)
            {
                rotnib2 += w3array[i];
            }

            for (int i = 0; i < 4; i++)
            {
                rotnib2 += w3array[i];
            }

            
            richTextBox1.AppendText("rotnib2 = ");
            richTextBox1.AppendText("" + rotnib2);

            char[] rotnib2array = rotnib2.ToCharArray();





            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(rotnib2array[j].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j]);
                        count++;
                        if (count == 4)
                        {
                            pi = i;

                        }

                    }

                }
                count = 0;
            }

            /* richTextBox1.AppendText(Environment.NewLine);
             richTextBox1.AppendText("pi = ");
             richTextBox1.AppendText("" + pi+ "    ");*/

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(rotnib2array[j + 4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi2 = i;

                        }

                    }

                }
                count = 0;
            }



            string subnib2 = "";

            for (int i = 0; i < 4; i++)
            {
                subnib2 += sbox[pi, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib2 += sbox[pi2, i];
            }



            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("subnib2 = ");
            richTextBox1.AppendText("" + subnib2);


            char[] subnib2array = subnib2.ToCharArray();



            string w4 = "";

            for (int i = 0; i < subnib2array.Length; i++)
            {
                if (Convert.ToInt32(subnib2array[i].ToString()) == Convert.ToInt32(w4xor1array[i].ToString()))
                {
                    w4 += "0";
                }
                else
                {
                    w4 += "1";
                }
            }
            richTextBox1.AppendText(Environment.NewLine);


            richTextBox1.AppendText("w4 = ");
            richTextBox1.AppendText("" + w4);

            char[] w4array = w4.ToCharArray();

            string w5 = "";

            for (int i = 0; i < w4array.Length; i++)
            {
                if (Convert.ToInt32(w4array[i].ToString()) == Convert.ToInt32(w3array[i].ToString()))
                {
                    w5 += "0";
                }
                else
                {
                    w5 += "1";
                }
            }

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);


            richTextBox1.AppendText("w5 = ");
            richTextBox1.AppendText("" + w5);

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            string key0 = "";
            key0 = w0 + w1;
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("key0 = ");
            richTextBox1.AppendText("" + key0);
            char[] key0array = key0.ToCharArray();


            string key1 = "";
            key1 = w2 + w3;
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("key1 = ");
            richTextBox1.AppendText("" + key1);
            char[] key1array = key1.ToCharArray();

            string key2 = "";
            key2 = w4 + w5;
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("key2 = ");
            richTextBox1.AppendText("" + key2);
            char[] key2array = key2.ToCharArray();

            string pxorkey0 = "";

            for (int i = 0; i < plainarray.Length; i++)
            {
                if (Convert.ToInt32(plainarray[i].ToString()) == Convert.ToInt32(key0array[i].ToString()))
                {
                    pxorkey0 += "0";
                }
                else
                {
                    pxorkey0 += "1";
                }
            }
            char[] pxorkey0array = pxorkey0.ToCharArray();

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("Plain Text XOR key0 = ");
            richTextBox1.AppendText("" + pxorkey0);


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(pxorkey0array[j].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j]);
                        count++;
                        if (count == 4)
                        {
                            pi = i;

                        }

                    }

                }
                count = 0;
            }

            /* richTextBox1.AppendText(Environment.NewLine);
             richTextBox1.AppendText("pi = ");
             richTextBox1.AppendText("" + pi+ "    ");*/

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(pxorkey0array[j + 4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi2 = i;

                        }

                    }

                }
                count = 0;
            }

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(pxorkey0array[j + 4+4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi3 = i;

                        }

                    }

                }
                count = 0;
            }

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(pxorkey0array[j + 4 + 4 +4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi4 = i;

                        }

                    }

                }
                count = 0;
            }



            string subnib3 = "";

            for (int i = 0; i < 4; i++)
            {
                subnib3 += sbox[pi, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib3 += sbox[pi2, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib3 += sbox[pi3, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib3 += sbox[pi4, i];
            }

            char[] subnib3array = subnib3.ToCharArray();

            
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("Nibble sub Round 1 = ");
            richTextBox1.AppendText("" + subnib3);

            /*string binaryval = "";
             binaryval = Convert.ToString(Convert.ToInt32("a", 16), 2);

             richTextBox1.AppendText(Environment.NewLine);



             richTextBox1.AppendText("w3 = ");
             richTextBox1.AppendText("" + binaryval);*/

            string shift1 = "";

            for(int i = 0; i < 4; i++)
            {
                shift1 += subnib3array[i];
            }

            for (int i = 12; i < 16; i++)
            {
                shift1 += subnib3array[i];
            }

            for (int i = 8; i < 12; i++)
            {
                shift1 += subnib3array[i];
            }

            for (int i = 4; i < 8; i++)
            {
                shift1 += subnib3array[i];
            }



            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("shift Round 1 = ");
            richTextBox1.AppendText("" + shift1);

            char[] shift1array = shift1.ToCharArray();

            //string x = Convert.ToInt32("1011", 2).ToString("X");

           
            //////////////////////////Mix col/////////////////////////////////////////

            char[][] multi = {
                "123456789abcdef".ToArray(),
                "2468ace3175b9fd".ToArray(),
                "365cfa9b8de7412".ToArray(),
                "48c37bf62ea51d9".ToArray(),
                "5af72d8eb419c36".ToArray(),
                "6cabd71539fe824".ToArray(),
                "7e9f816da3425cb".ToArray(),
                "83b6e5dc4f7a291".ToArray(),
                "9182b3a4d5c6f7e".ToArray(),
                "a7de493f5821b6c".ToArray(),
                "b5ea1f47c29d683".ToArray(),
                "cb759e2a61df348".ToArray(),
                "d941c852fb63ea7".ToArray(),
                "ef1d32c97684ab5".ToArray(),
                "fd2964b1ec3875a".ToArray()
            };


            char[][] me =
            {
                "14".ToArray(),
                "41".ToArray()
            };

            string s00 = "";

            for (int i = 0; i < 4; i++)
            {
                s00 += shift1array[i];
            }

            string s10 = "";
            for (int i = 4; i < 8; i++)
            {
                s10 += shift1array[i];
            }

            string s01 = "";
            for (int i = 8; i < 12; i++)
            {
                s01 += shift1array[i];
            }

            string s11 = "";
            for (int i = 12; i < 16; i++)
            {
                s11 += shift1array[i];
            }


            string s00c = Convert.ToInt32(s00, 2).ToString("X");
            string s10c = Convert.ToInt32(s10, 2).ToString("X");
            string s01c = Convert.ToInt32(s01, 2).ToString("X");
            string s11c = Convert.ToInt32(s11, 2).ToString("X");


            string s00m = "";

            int me00d = int.Parse(me[0][0].ToString(), System.Globalization.NumberStyles.HexNumber);

            int s00d = int.Parse(s00c, System.Globalization.NumberStyles.HexNumber);



            int me01d = int.Parse(me[0][1].ToString(), System.Globalization.NumberStyles.HexNumber);

            int s10d = int.Parse(s10c, System.Globalization.NumberStyles.HexNumber);


            string s00dash1 = multi[me00d - 1][s00d - 1].ToString();
            string s00dash2 = multi[me01d - 1][s10d - 1].ToString();

            string s00dash1binary = "";
            s00dash1binary = Convert.ToString(Convert.ToInt32(s00dash1, 16), 2).PadLeft(4, '0');

            string s00dash2binary = "";
            s00dash2binary = Convert.ToString(Convert.ToInt32(s00dash2, 16), 2).PadLeft(4, '0');



            char[] s00dash1array = s00dash1binary.ToCharArray();
            char[] s00dash2array = s00dash2binary.ToCharArray();
           /* richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("shift Round 1 = ");
            richTextBox1.AppendText("" + s00dash1binary);*/

            for (int i = 0; i < s00dash2array.Length; i++)
            {
                if (Convert.ToInt32(s00dash2array[i].ToString()) == Convert.ToInt32(s00dash1array[i].ToString()))
                {
                    s00m += "0";
                }
                else
                {
                    s00m += "1";
                }
            }


            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("s00' = ");
            richTextBox1.AppendText("( " + me00d + " * " + s00c +" )" + " + ( " + me01d + " * " + s10c + " ) = "+ s00dash1 + " + " + s00dash2+" = " + s00m );


            string s10m = "";

            int me10d = int.Parse(me[1][0].ToString(), System.Globalization.NumberStyles.HexNumber);

            //int s00d = int.Parse(s00c, System.Globalization.NumberStyles.HexNumber);



            int me11d = int.Parse(me[1][1].ToString(), System.Globalization.NumberStyles.HexNumber);

            //int s10d = int.Parse(s10c, System.Globalization.NumberStyles.HexNumber);

            string s10dash1 = multi[me10d - 1][s00d - 1].ToString();
            string s10dash2 = multi[me11d - 1][s10d - 1].ToString();


            string s10dash1binary = "";
            s10dash1binary = Convert.ToString(Convert.ToInt32(s10dash1, 16), 2).PadLeft(4, '0');

            string s10dash2binary = "";
            s10dash2binary = Convert.ToString(Convert.ToInt32(s10dash2, 16), 2).PadLeft(4, '0');

            char[] s10dash1array = s10dash1binary.ToCharArray();
            char[] s10dash2array = s10dash2binary.ToCharArray();

            for (int i = 0; i < s10dash2array.Length; i++)
            {
                if (Convert.ToInt32(s10dash2array[i].ToString()) == Convert.ToInt32(s10dash1array[i].ToString()))
                {
                    s10m += "0";
                }
                else
                {
                    s10m += "1";
                }
            }

            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("s10' = ");
            richTextBox1.AppendText("( " + me10d + " * " + s00c + " )" + " + ( " + me11d + " * " + s10c + " ) = " + s10dash1 + " + " + s10dash2 + " = " + s10m);




            string s01m = "";

            //int me10d = int.Parse(me[1][0].ToString(), System.Globalization.NumberStyles.HexNumber);

            int s01d = int.Parse(s01c, System.Globalization.NumberStyles.HexNumber);



            //int me11d = int.Parse(me[1][1].ToString(), System.Globalization.NumberStyles.HexNumber);

            int s11d = int.Parse(s11c, System.Globalization.NumberStyles.HexNumber);

            string s01dash1 = multi[me00d - 1][s01d - 1].ToString();
            string s01dash2 = multi[me01d - 1][s11d - 1].ToString();


            string s01dash1binary = "";
            s01dash1binary = Convert.ToString(Convert.ToInt32(s01dash1, 16), 2).PadLeft(4, '0');

            string s01dash2binary = "";
            s01dash2binary = Convert.ToString(Convert.ToInt32(s01dash2, 16), 2).PadLeft(4, '0');


            char[] s01dash1array = s01dash1binary.ToCharArray();
            char[] s01dash2array = s01dash2binary.ToCharArray();


            for (int i = 0; i < s01dash2array.Length; i++)
            {
                if (Convert.ToInt32(s01dash2array[i].ToString()) == Convert.ToInt32(s01dash1array[i].ToString()))
                {
                    s01m += "0";
                }
                else
                {
                    s01m += "1";
                }
            }

            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("s01' = ");
            richTextBox1.AppendText("( " + me00d + " * " + s01c + " )" + " + ( " + me01d + " * " + s11c + " ) = " + s01dash1 + " + " + s01dash2 + " = " + s01m);



            string s11m = "";

            //int me10d = int.Parse(me[1][0].ToString(), System.Globalization.NumberStyles.HexNumber);

            //int s01d = int.Parse(s01c, System.Globalization.NumberStyles.HexNumber);



            //int me11d = int.Parse(me[1][1].ToString(), System.Globalization.NumberStyles.HexNumber);

            //int s11d = int.Parse(s11c, System.Globalization.NumberStyles.HexNumber);

            string s11dash1 = multi[me10d - 1][s01d - 1].ToString();
            string s11dash2 = multi[me11d - 1][s11d - 1].ToString();


            string s11dash1binary = "";
            s11dash1binary = Convert.ToString(Convert.ToInt32(s11dash1, 16), 2).PadLeft(4, '0');

            string s11dash2binary = "";
            s11dash2binary = Convert.ToString(Convert.ToInt32(s11dash2, 16), 2).PadLeft(4, '0');


            char[] s11dash1array = s11dash1binary.ToCharArray();
            char[] s11dash2array = s11dash2binary.ToCharArray();

            for (int i = 0; i < s11dash2array.Length; i++)
            {
                if (Convert.ToInt32(s11dash2array[i].ToString()) == Convert.ToInt32(s11dash1array[i].ToString()))
                {
                    s11m += "0";
                }
                else
                {
                    s11m += "1";
                }
            }


            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("s11' = ");
            richTextBox1.AppendText("( " + me10d + " * " + s01c + " )" + " + ( " + me11d + " * " + s11c + " ) = " + s11dash1 + " + " + s11dash2 + " = " + s11m);


            string mixcol = s00m + s10m + s01m + s11m;


            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("Mix columns = ");
            richTextBox1.AppendText("" + mixcol);

            char[] mixcolarray = mixcol.ToCharArray();

            string mixXORkey1 = "";
            for (int i = 0; i < mixcolarray.Length; i++)
            {
                if (Convert.ToInt32(mixcolarray[i].ToString()) == Convert.ToInt32(key1array[i].ToString()))
                {
                    mixXORkey1 += "0";
                }
                else
                {
                    mixXORkey1 += "1";
                }
            }


            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("Mix col XOR key1 = ");
            richTextBox1.AppendText("" + mixXORkey1);


            char[] mixXORkey1array = mixXORkey1.ToCharArray();



            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(mixXORkey1array[j].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j]);
                        count++;
                        if (count == 4)
                        {
                            pi = i;

                        }

                    }

                }
                count = 0;
            }

            /* richTextBox1.AppendText(Environment.NewLine);
             richTextBox1.AppendText("pi = ");
             richTextBox1.AppendText("" + pi+ "    ");*/

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(mixXORkey1array[j + 4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi2 = i;

                        }

                    }

                }
                count = 0;
            }

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(mixXORkey1array[j + 4 + 4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi3 = i;

                        }

                    }

                }
                count = 0;
            }

            count = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Convert.ToInt32(mixXORkey1array[j + 4 + 4 + 4].ToString()) == nibble[i, j])
                    {
                        //richTextBox1.AppendText("" + rotnib1array[j + 4]);
                        count++;
                        if (count == 4)
                        {
                            pi4 = i;

                        }

                    }

                }
                count = 0;
            }



            string subnib4 = "";

            for (int i = 0; i < 4; i++)
            {
                subnib4 += sbox[pi, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib4 += sbox[pi2, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib4 += sbox[pi3, i];
            }
            for (int i = 0; i < 4; i++)
            {
                subnib4 += sbox[pi4, i];
            }

            char[] subnib4array = subnib4.ToCharArray();



            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("Nibble sub Round 2 = ");
            richTextBox1.AppendText("" + subnib4);



            string shift2 = "";

            for (int i = 0; i < 4; i++)
            {
                shift2 += subnib4array[i];
            }

            for (int i = 12; i < 16; i++)
            {
                shift2 += subnib4array[i];
            }

            for (int i = 8; i < 12; i++)
            {
                shift2 += subnib4array[i];
            }

            for (int i = 4; i < 8; i++)
            {
                shift2 += subnib4array[i];
            }



            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("shift Round 2 = ");
            richTextBox1.AppendText("" + shift2);

            char[] shift2array = shift2.ToCharArray();



            string cipher = "";
            for (int i = 0; i < shift2array.Length; i++)
            {
                if (Convert.ToInt32(shift2array[i].ToString()) == Convert.ToInt32(key2array[i].ToString()))
                {
                    cipher += "0";
                }
                else
                {
                    cipher += "1";
                }
            }
            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText(Environment.NewLine);

            richTextBox1.AppendText("cipher text = ");
            richTextBox1.AppendText("" + cipher);

            textBox3.Text = cipher;






        }
    }
}
