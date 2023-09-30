using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Project
{
    public partial class SDESForm : Form
    {
        int[] text;
        int[] key;
        int[] p10;
        int[] p8;
        int[] ip;
        int[] ep;
        int[] p4;
        int[] k1;
        int[] k2;

        public SDESForm()
        {
            InitializeComponent();
        }

        private void textTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b01".Contains(e.KeyChar);
        }

        private void keyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b01".Contains(e.KeyChar);
        }

        private void p10TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b1234567890 ".Contains(e.KeyChar);
        }

        private void p8TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b345678910 ".Contains(e.KeyChar);
        }

        private void ipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b12345678 ".Contains(e.KeyChar);
        }

        private void epTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b1234 ".Contains(e.KeyChar);
        }

        private void p4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !"\b1234 ".Contains(e.KeyChar);
        }

        private void SDESForm_Load(object sender, EventArgs e)
        {
            string[] row = { "1", "0", "3", "2" };
            s0DataGridView.Rows.Add(row);
            s0DataGridView.Rows[0].HeaderCell.Value = "0";

            row[0] = "3";
            row[1] = "2";
            row[2] = "1";
            row[3] = "0";
            s0DataGridView.Rows.Add(row);
            s0DataGridView.Rows[1].HeaderCell.Value = "1";

            row[0] = "0";
            row[1] = "2";
            row[2] = "1";
            row[3] = "3";
            s0DataGridView.Rows.Add(row);
            s0DataGridView.Rows[2].HeaderCell.Value = "2";

            row[0] = "3";
            row[1] = "1";
            row[2] = "3";
            row[3] = "2";
            s0DataGridView.Rows.Add(row);
            s0DataGridView.Rows[3].HeaderCell.Value = "3";

            row[0] = "0";
            row[1] = "1";
            row[2] = "2";
            row[3] = "3";
            s1DataGridView.Rows.Add(row);
            s1DataGridView.Rows[0].HeaderCell.Value = "0";

            row[0] = "2";
            row[1] = "0";
            row[2] = "1";
            row[3] = "3";
            s1DataGridView.Rows.Add(row);
            s1DataGridView.Rows[1].HeaderCell.Value = "1";

            row[0] = "3";
            row[1] = "0";
            row[2] = "1";
            row[3] = "0";
            s1DataGridView.Rows.Add(row);
            s1DataGridView.Rows[2].HeaderCell.Value = "2";

            row[0] = "2";
            row[1] = "1";
            row[2] = "0";
            row[3] = "3";
            s1DataGridView.Rows.Add(row);
            s1DataGridView.Rows[3].HeaderCell.Value = "3";

            resultsDataGridView.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            resultsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            resultsDataGridView.Rows.Clear();
            resultsDataGridView.Refresh();
            assignValues();
            k1 = generateKey(1, 1);
            k2 = generateKey(3, 2);
            int[] cipherText = getValueFromP(ip, text, "IP").ToArray();
            resultsDataGridView.Rows.Add(); 
            int[] leftHalf;
            int[] rightHalf = getHalf(cipherText, cipherText.Length / 2, cipherText.Length);
            leftHalf = doRound(cipherText, k1, 1, "K1");
            int[] copy = copyArray(cipherText);
            cipherText = mergeTwoArrays(rightHalf, leftHalf).ToArray();
            displayResult("Swapping", copy, cipherText);
            resultsDataGridView.Rows.Add();
            rightHalf = getHalf(cipherText, cipherText.Length / 2, cipherText.Length);
            leftHalf = doRound(cipherText, k2, 2, "K2");
            resultsDataGridView.Rows.Add();
            cipherText = mergeTwoArrays(leftHalf, rightHalf).ToArray();
            int[] ipInverse = generateIPInverse(ip);
            cipherText = getValueFromP(ipInverse, cipherText, "IP Inverse").ToArray();
            resultsDataGridView.Rows.Add();

            displayResult("Cipher Text", cipherText, new int[] { });
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            resultsDataGridView.Rows.Clear();
            resultsDataGridView.Refresh();
            assignValues();
            k1 = generateKey(1, 1);
            k2 = generateKey(3, 2);
            int[] plainText = getValueFromP(ip, text, "IP").ToArray();
            resultsDataGridView.Rows.Add();
            int[] leftHalf;
            int[] rightHalf = getHalf(plainText, plainText.Length / 2, plainText.Length);
            leftHalf = doRound(plainText, k2, 1, "K2");
            int[] copy = copyArray(plainText);
            plainText = mergeTwoArrays(rightHalf, leftHalf).ToArray();
            displayResult("Swapping", copy, plainText);
            resultsDataGridView.Rows.Add();
            rightHalf = getHalf(plainText, plainText.Length / 2, plainText.Length);
            leftHalf = doRound(plainText, k1, 2, "K1");
            resultsDataGridView.Rows.Add();
            plainText = mergeTwoArrays(leftHalf, rightHalf).ToArray();
            int[] ipInverse = generateIPInverse(ip);
            plainText = getValueFromP(ipInverse, plainText, "IP Inverse").ToArray();
            resultsDataGridView.Rows.Add();

            displayResult("Plain Text", plainText, new int[] { });
        }

        private int[] copyArray(int[] array)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                temp.Add(array[i]);
            }
            return temp.ToArray();
        }

        private void displayResult(string step, int[] before, int[] after)
        {
            string beforeValue = "";
            for (int i = 0; i < before.Length; i++)
            {
                beforeValue += before[i].ToString() + " ";
            }
            string afterValue = "";
            for (int i = 0; i < after.Length; i++)
            {
                afterValue += after[i].ToString() + " ";
            }

            resultsDataGridView.Rows.Add(new string[] { step, beforeValue, afterValue });
        }

        private void displayResult(string step, string before, int[] after)
        {
            string afterValue = "";
            for (int i = 0; i < after.Length; i++)
            {
                afterValue += after[i].ToString() + " ";
            }
            resultsDataGridView.Rows.Add(new string[] { step, before, afterValue });
        }

        private int[] generateIPInverse(int[] ip)
        {
            int[] tempArray = new int[8];
            for (int i = 0; i < ip.Length; i++)
            {
                tempArray[ip[i] - 1] = i + 1;
            }
            return tempArray;
        }

        private int[] doRound(int[] startText, int[] key, int itteration, string keyName)
        {
            displayResult("Round " + itteration, new int[] { }, new int[] { });
            int[] leftHalf = getHalf(startText, 0, startText.Length / 2);
            int[] rightHalf = getHalf(startText, startText.Length / 2, startText.Length);

            int[] tempArray = getValueFromP(ep, rightHalf, "EP").ToArray();
            tempArray = XOR(tempArray, key, keyName);
            tempArray = searchInSBoxes(tempArray);
            tempArray = getValueFromP(p4, tempArray, "P4").ToArray();
            tempArray = XOR(tempArray, leftHalf, "Left Half");
            return tempArray;
        }

        private int[] searchInSBoxes(int[] array)
        {
            string before = "";
            for (int i = 0; i < array.Length; i++)
            {
                before += array[i];
            }
            before += "\n";

            List<int> tempList = new List<int>();

            int[] leftHalf = getHalf(array, 0, array.Length / 2);
            int[] rightHalf = getHalf(array, array.Length / 2, array.Length);
            for (int i = 0; i < leftHalf.Length; i++)
            {
                before += leftHalf[i];
            }
            before += "\n";

            int[] tempLeftHalf = { leftHalf[1], leftHalf[2] };
            int[] tempRightHalf = { leftHalf[0], leftHalf[3] };
            int column = convertBinaryToDecimal(tempLeftHalf);
            int row = convertBinaryToDecimal(tempRightHalf);
            before += tempLeftHalf[0].ToString() + tempLeftHalf[1].ToString() + " = " + column + " (column)\n";
            before += tempRightHalf[0].ToString() + tempRightHalf[1].ToString() + " = " + row + " (row)\n";
            before += "From S0\n";
            int tempValue = int.Parse(s0DataGridView.Rows[row].Cells[column].Value.ToString());
            before += tempValue + " = ";
            int[] tempArray = convertDecimalToBinary(tempValue);
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempList.Add(tempArray[i]);
                before += tempArray[i];
            }

            for (int i = 0; i < rightHalf.Length; i++)
            {
                before += rightHalf[i];
            }
            before += "\n";
            tempLeftHalf = new int[2] { rightHalf[1], rightHalf[2] };
            tempRightHalf = new int[2] { rightHalf[0], rightHalf[3] };
            column = convertBinaryToDecimal(tempLeftHalf);
            row = convertBinaryToDecimal(tempRightHalf);
            before += tempLeftHalf[0].ToString() + tempLeftHalf[1].ToString() + " = " + column + " (column)\n";
            before += tempRightHalf[0].ToString() + tempRightHalf[1].ToString() + " = " + row + " (row)\n";
            before += "From S1\n";
            tempValue = int.Parse(s1DataGridView.Rows[row].Cells[column].Value.ToString());
            before += tempValue + " = ";
            tempArray = convertDecimalToBinary(tempValue);
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempList.Add(tempArray[i]);
                before += tempArray[i];
            }

            displayResult("S Boxes", before, tempList.ToArray());
            return tempList.ToArray();
        }

        private int[] generateKey(int shift, int itteration)
        {
            List<int> k = getValueFromP(p10, key, "P10");

            int[] leftHalf = getHalf(k.ToArray(), 0, k.Count / 2);
            int[] rightHalf = getHalf(k.ToArray(), k.Count / 2, k.Count);

            leftHalf = shiftArray(leftHalf, shift);
            rightHalf = shiftArray(rightHalf, shift);

            List<int> kAfter = mergeTwoArrays(leftHalf, rightHalf);
            displayResult("LS " + shift + " bit", k.ToArray(), kAfter.ToArray());
            kAfter = getValueFromP(p8, kAfter.ToArray(), "P8");
            displayResult("K" + itteration + " -->", kAfter.ToArray(), new int[] { });
            resultsDataGridView.Rows.Add();
            return kAfter.ToArray();
        }

        private List<int> mergeTwoArrays(int[] array1, int[] array2)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < array1.Length; i++)
            {
                tempList.Add(array1[i]);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                tempList.Add(array2[i]);
            }
            return tempList;
        }

        private int[] shiftArray(int[] array, int shift)
        {
            for (int i = 0; i < shift; i++)
            {
                int temp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = temp;
            }
            return array;
        }

        private int[] getHalf(int[] array, int start, int end)
        {
            List<int> half = new List<int>();
            for (int i = start; i < end; i++)
            {
                half.Add(array[i]);
            }
            return half.ToArray();
        }

        private List<int> getValueFromP(int[] p, int[] list, string pName)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < p.Length; i++)
            {
                temp.Add(list[p[i] - 1]);
            }
            displayResult(pName, list, temp.ToArray());
            return temp;
        }

        private int[] XOR(int[] array1, int[] array2, string step)
        {
            List<int> temp = new List<int>();
            string before = "";
            for (int i = 0; i < array1.Length; i++)
            {
                before += array1[i].ToString();
            }
            before += " XOR ";
            for (int i = 0; i < array2.Length; i++)
            {
                before += array2[i].ToString();
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    temp.Add(0);
                }
                else
                {
                    temp.Add(1);
                }
            }

            displayResult("XOR with " + step, before, temp.ToArray());

            return temp.ToArray();
        }
        
        private int convertBinaryToDecimal(int[] array)
        {
            int sum = 0;
            int current = 1;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == 1)
                {
                    sum += current;
                }
                current *= 2;
            }

            return sum;
        }

        private int[] convertDecimalToBinary(int decimalNumber)
        {
            int remainder;
            Stack<int> result = new Stack<int>();
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                result.Push(remainder);
                decimalNumber /= 2;
            }
            for (int i = result.Count; i < 2; i++)
            {
                result.Push(0);
            }
            return result.ToArray();
        }

        private void assignValues()
        {
            text = convertBinaryStringToIntArray(textTextBox.Text);
            key = convertBinaryStringToIntArray(keyTextBox.Text);
            p10 = convertStringToIntArray(p10TextBox.Text);
            p8 = convertStringToIntArray(p8TextBox.Text);
            ip = convertStringToIntArray(ipTextBox.Text);
            ep = convertStringToIntArray(epTextBox.Text);
            p4 = convertStringToIntArray(p4TextBox.Text);
        }

        private int[] convertStringToIntArray(string text)
        {
            List<int> list = new List<int>();
            string tempString = "";
            foreach (char character in text)
            {
                if (character != ' ')
                {
                    tempString += character;
                }
                else
                {
                    list.Add(int.Parse(tempString));
                    tempString = "";
                }
            }
            list.Add(int.Parse(tempString));
            return list.ToArray();
        }

        private int[] convertBinaryStringToIntArray(string text)
        {
            List<int> list = new List<int>();
            foreach (char character in text)
            {
                list.Add(int.Parse(character.ToString()));
            }
            return list.ToArray();
        }
    }
}
