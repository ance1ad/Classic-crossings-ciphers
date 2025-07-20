using System.IO;
using System.Numerics;
using System.Windows.Forms;
using static Cipher.StringFormat;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using System.Windows.Forms.VisualStyles;

namespace Cipher
{
    
    public partial class Form1 : Form
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъьыэюя_,.АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯ";
        bool textLoaded = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        // Шифр Изгородью
        private void IzgorodCipher(string text)
        {
            if (text.Length % 2 != 0)
                text += ".";
            int len = text.Length;
            string str1 = "";
            string str2 = "";
            for (int i = 0; i < len; i += 2)
            {
                str1 += text[i];
                if (i + 1 < len)
                    str2 += text[i + 1];
            }
            textBox2.Text = "";
            textBox2.Text += str1 += str2;
        }


        private void IzgorodDeCipher(string code)
        {
            if (code.Length % 2 != 0)
                code += ".";
            int len = code.Length;
            string deCode = "";
            textBox2.Text = "";
            for (int i = 0; i < len/2; i += 1)
            {
                deCode += code[i];
                if(len / 2 + i < len)
                    deCode += code[len/2+i];
            }
            textBox2.Text = deCode;
        }


        private int[] KeyCheck()
        {
            // Проверим что есть все цифры 
            string keyStr = DeleteRepeatSymbols(keyBox.Text);
            keyBox.Text = keyStr;
            int len = keyStr.Length;
            int counter = 0;
            for (int i = 0; i < keyStr.Length; i++)
            {
                for (int j = 1; j < keyStr.Length+1; j++)
                {
                    if (keyStr[i].ToString() == j.ToString()) counter++;
                }
            }
            int[] arr = {0};
            if (counter == len)
            {
                arr = new int[len]; 
                for (int i = 0; i < len; i++)
                {
                    arr[i] = int.Parse(keyStr[i].ToString());
                }
                
            }
            return arr;
        }



        // Шифр Ключом
        private string KeyCipher(string text)
        {
            int[] key = KeyCheck();
            if(key.Length < 2)
            {
                warningLabel.Text = "Ошибка ключа\nне все введены цифры от 1 до длины ключа";
                return "";
            }
            string outStr = "";
            // Доп символы для группы
            for (int i = 0; i < text.Length % key.Length; i++) { 
                text += text[i];
            }

            for (int i = 0; i < text.Length; i += key.Length)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    outStr += text[i + key[j] - 1]; //ХЗ
                }
            }
            return outStr;
        }

        
        private string KeyDeCipher(string text)
        {
            int[] key = KeyCheck();
            if (key.Length < 2)
            {
                warningLabel.Text = "Ошибка ключа\nне все введены цифры от 1 до длины ключа";
                return "";
            }
            string outStr = "";
            textBox2.Text = "";

            char[] outArr = new char[text.Length]; 
            for (int i = 0; i < text.Length; i += key.Length)
            {
                for (int j = 0; j < key.Length; j++)
                {
 
                    outArr[key[j] - 1 + i] = text[i + j]; 

                }
                
            }
            for (int i = 0; i < text.Length; i++)
            {
                textBox2.Text += outArr[i];
            }
            return outStr;
        }


        // Комбинированный шифр
        private string[,] CreateCombineMatrix(int stolb, string text)
        {
            // по кол-ву столбцов определяем кол-во строк исходя из текста
            int strok = text.Length / stolb;
            string[,] matrix = new string[strok,stolb];
            int counter = 0;
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    matrix[i, j] = text[counter].ToString();
                    counter++;
                }
            }
            warningText.Text = "";
            for (int i = 0; i < strok; i++)
            {
                for (int j = 0; j < stolb; j++)
                {
                    warningText.Text += matrix[i, j];
                }
                warningText.Text += "\n";
            }
            return matrix;

        }


        private void CombineCipher(string text, int choise)
        {
            int[] key = KeyCheck();
            if (key.Length < 2)
            {
                warningLabel.Text = "Ошибка ключа\nне все введены цифры от 1 до длины ключа";
                return;
            }

            // Доп символы для группы
            for (int i = 0; i < text.Length % key.Length; i++)
                text += text[i];
            var matrix = CreateCombineMatrix(key.Length, text);
            int stolb = key.Length;
            int strok = text.Length / stolb;
            string[,] outm = new string[strok, stolb];

            for (int i = 0; i < stolb; i++)
            {
                for (int j = 0; j < strok; j++)
                {
                    outm[j, i] = matrix[j, key[i] - 1];
                }
            }
            if (choise == 1)
            {

                for (int i = 0; i < stolb; i++)
                {
                    for (int j = 0; j < strok; j++)
                    {
                        textBox2.Text += outm[j, i];
                    }
                }
            }
            else
            {
                textBox2.Text = "";
                string[,] dec = new string[strok, stolb];
                for (int i = 0; i < stolb; i++)
                {
                    for (int j = 0; j < strok; j++)
                    {
                        dec[j, key[i] - 1] = outm[j,i];
                    }
                }
                for (int i = 0; i < strok; i++)
                {
                    for (int j = 0; j < stolb; j++)
                    {
                        textBox2.Text += dec[i,j];
                    }
                }
            }
        }


        




        // Шифровать
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                warningLabel.Text = "Введите текст";
                return;
            }
            textBox1.Text = DeleteSymbols(textBox1.Text, alphabet);
            if (radioButton1.Checked)
            {
                IzgorodCipher(textBox1.Text);
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = KeyCipher(textBox1.Text);
            }
            else if (radioButton3.Checked)
            {
                CombineCipher(textBox1.Text,1);
            }
            else if (radioButton4.Checked)
            {
                IzgorodCipher(textBox1.Text);
                IzgorodCipher(textBox2.Text);
            }
            else
            {
                warningLabel.Text = "Выберите алгоритм шифрования";
            }
        }


        // Дешифровать
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                IzgorodDeCipher(textBox2.Text);
            }
            else if (radioButton2.Checked)
            {
                KeyDeCipher(textBox2.Text);
            }
            else if (radioButton3.Checked)
            {
                CombineCipher(textBox1.Text, 2);
            }
            else if (radioButton4.Checked)
            {
                IzgorodDeCipher(textBox2.Text);
                IzgorodDeCipher(textBox2.Text);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (int.TryParse(keyBox.Text, out int number))
                {

                    warningLabel.Text = "";
                }
                else
                {
                    keyBox.Text = "";
                    warningLabel.Text = "Введите числовое значение ключа!";
                }
            }
        }


        private void keyVisible(bool flag)
        {
            keyLabel.Visible = flag;
            keyBox.Visible = flag;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Длина текста = " + textBox1.Text.Length;
            if (textBox1.Text == "") 
            { 
                textLoaded = false;
                warningLabel.Text = "Введите текст или загрузите из файла,'\nалфавит - русские символы и знаки _,.";
            }
            else
            {
                textLoaded = true;
                warningLabel.Text = "";

            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Enabled) {keyVisible(false);}
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Enabled) { keyVisible(true); }
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Enabled) { keyVisible(true); }
        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Enabled) { keyVisible(false); }
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            string path = @"D:\BSTU\ИБ\2\Cipher2\text.txt";
            string fileText = await File.ReadAllTextAsync(path);
            fileText = fileText.ToLower();
            textBox1.Text = fileText;
            textBox1.Text = DeleteSymbols(textBox1.Text, alphabet);
            textLoaded = true;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string path = @"D:\BSTU\ИБ\1\Cipher\playfireCoded.txt";
            await File.WriteAllTextAsync(path, textBox2.Text);
        }
    }
}