using System;
using System.Windows.Forms;

namespace SDA_46337z_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CStack aList = new CStack();
            string ch;
            char chr;
            string word = "", wh = textBox1.Text;
            for (int i = 0; i < wh.Length; i++)
            {
                chr = wh[i];
                
                if (chr != ' ')
                {
                    word += chr;
                }
            }

            if (word.Length > 2)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length; i++)
                {
                    aList.Push(word.Substring(i, 1));
                }
                    int position = 0;
                    while (aList.Count > 0)
                    {
                        ch = aList.Pop().ToString();

                        if (ch != word.Substring(position, 1))
                        {
                            isPalindrome = false;
                            break;
                        }
                        position++;
                    }
                    _ = isPalindrome == true
                        ? richTextBox1.Text = String.Format("'{0}' е палиндром.", wh)
                        : richTextBox1.Text = String.Format("'{0}' не е палиндром.", wh);
            } else
            {
                richTextBox1.Text = String.Format("Въведената дума има по-малко от 3 символа.");
            }
        }
    }
}
