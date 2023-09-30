
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Linq;

namespace Playfair
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			this.inputKey.TextChanged += new EventHandler(onInputKeyChange);
			this.buttonEncrypt.Click += new EventHandler(encrypt);
			this.buttonDecrypt.Click += new EventHandler(decrypt);
		}
		Char[,] keyTable = new char[5, 5];
			
		private void onInputKeyChange(object sender, EventArgs e) {
			char[] alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ".ToCharArray();
			String key = new String(this.inputKey.Text.Distinct().ToArray());
			Regex rgx = new Regex("[^A-Z]");
			key = rgx.Replace(key, "");
			this.inputKey.Text = key;

			// move the cursor to the end of the line
			this.inputKey.SelectionStart = this.inputKey.Text.Length == 0 ? 0 : this.inputKey.Text.Length;
			this.inputKey.SelectionLength = 0;
			
			for(int i = 0; i < key.Length; i++) {
				for(int j = 0; j < alphabet.Length; j++) {
					if (alphabet[j] == key[i]) {
						alphabet[j] = ' ';
					}
					if ((key[i] == 'I') && (alphabet[j] == 'I')) {
						alphabet[j] = ' ';
					}
				}
			}

			var keyString = key + new string(alphabet);
			keyString = Regex.Replace(keyString, @"\s+", "");
			var keyShow = "";
			for(int i = 0; i < 5; i++) {
				for(int j = 0; j < 5; j++) {
					var index= i*5+j;
					keyTable[i,j] = keyString[index];
					if ((keyString[index] == 'I') || (keyString[index] == 'J'))  {
						keyShow += "I/J" + " ";
					}
					else keyShow += keyString[index] + " ";
				}
				keyShow += "\r\n";
			}
			this.textBoxKey.Text = keyShow;
		}
		private void encrypt(object sender, EventArgs e) {
			Regex rgx = new Regex("[^A-Z]");
			String message = rgx.Replace(this.inputMessage.Text, "");
			rgx = new Regex("[J]");
			message = rgx.Replace(message, "I");
			String keyString = "";
			for(int i = 0; i < 5; i++) {
				for(int j = 0; j < 5; j++) {
					keyString += keyTable[i, j];
				}
			}
			String result = "";
			for(int i = 0; i < message.Length - 1; i+=2) {
				int indexA = keyString.IndexOf(message[i]);
                int indexB = keyString.IndexOf(message[i+1]);
                int yA = indexA / 5;
                int xA = indexA - 5*yA;
                int yB = indexB / 5;
                int xB = indexB - 5*yB;
                if (xA == xB) {
					// Same column, replace with the character below.
					result += keyTable[(yA+1)%5, xA].ToString() + keyTable[(yB+1)%5, xB].ToString();
                }
                else if (yA == yB) {
					// Same row, replaced with the right character.
					result += keyTable[yA, (xA+1)%5].ToString() + keyTable[yB, (xB+1)%5].ToString();
                }
                else {
					// Intersection
					result += keyTable[yA, xB].ToString() + keyTable[yB, xA].ToString();
                }
                result += " ";
			}
			this.output.Text = result;
		}
		private void decrypt(object sender, EventArgs e) {
			Regex rgx = new Regex("[^A-Z]");
			String message = rgx.Replace(this.inputMessage.Text, "");
			rgx = new Regex("[J]");
			message = rgx.Replace(message, "I");
			String keyString = "";
			for(int i = 0; i < 5; i++) {
				for(int j = 0; j < 5; j++) {
					keyString += keyTable[i, j];
				}
			}

			String result = "";
			for(int i = 0; i < message.Length - 1; i+=2) {
				int indexA = keyString.IndexOf(message[i]);
                int indexB = keyString.IndexOf(message[i+1]);
                int yA = indexA / 5;
                int xA = indexA - 5*yA;
                int yB = indexB / 5;
                int xB = indexB - 5*yB;
                if (xA == xB) {
					// Same column, replace with the above character.
					if (yA == 0) yA = 5;
					if (yB == 0) yB = 5;	                	
                	result += keyTable[(yA-1)%5, xA].ToString() + keyTable[(yB-1)%5, xB].ToString();
                }
                else if (yA == yB) {
					// Same row, replaced with the character to the left.
					if (xA == 0) xA = 5;
					if (xB == 0) xB = 5;
                	result += keyTable[yA, (xA-1)%5].ToString() + keyTable[yB, (xB-1)%5].ToString();
                }
                else {
					// Intersection
					result += keyTable[yA, xB].ToString() + keyTable[yB, xA].ToString();
                }
			}
			this.output.Text = result;
		}

		private void textBoxKey_TextChanged(object sender, EventArgs e)
		{

		}

		private void buttonDecrypt_Click(object sender, EventArgs e)
		{

		}
	}
}
