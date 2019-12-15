using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class game : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_image;

        public game()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            words = new string[] { "карнавал", "праздник", "дед мороз", "олень", "сюрприз", "ёлочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
            start_game(richTextBox1);
        }
        static bool is_contains(string word, char symbol)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    return true;
                }
            }

            return false;
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
        static void start_game(RichTextBox wordArea)
        {
            Random rnd = new Random();
            current_word = words[rnd.Next(0, words.Length)];
            wordArea.Text = get_show_text(current_word);
            centering_text(wordArea);
        }
        static string get_show_text(string word)
        {
            string result_text = "";
            for (int i = 0; i < word.Length; i++)
            {
                result_text += "*";
                
            }

            return result_text;
        }
        static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }
        static string get_new_show_text(string word, char symbol, string old_show_text)
        {


            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    old_show_text = old_show_text.Remove(i, 1);
                    old_show_text = old_show_text.Insert(i, symbol.ToString());
                   
                }
            }

            return old_show_text;
        }
        static void button_symbol_click(RichTextBox wordArea, Button cur_button, Button start_button, char symbol)
        {
           
            if (is_contains(current_word, symbol))
            {
                wordArea.Text = get_new_show_text(current_word, symbol, wordArea.Text);
                if (is_contains(wordArea.Text, '_'))
                {
                    return;
                }
                else
                {
                    using (succesForm gameForm = new succesForm())
                    {
                        gameForm.ShowDialog();
                    }
                }
            }
            else
            {
                lives--;
                lives_image[lives].Visible = false;
                if (lives == 0)
                {
                    using (loseForm  gameForm = new loseForm())
                    {
                        gameForm.ShowDialog();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button1, button33, 'a');
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button3, button33, 'б');
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button4, button33, 'в');
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button5, button33, 'г');
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button6, button33, 'д');
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button11, button33, 'е');
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button10, button33, 'ё');
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button9, button33, 'ж');
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button8, button33, 'з');
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button7, button33, 'и');
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button21, button33, 'й');
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button20, button33, 'к');
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button19, button33, 'л');
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button18, button33, 'м');
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button17, button33, 'н');
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button31, button33, 'о');
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button30, button33, 'п');
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button29, button33, 'р');
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button28, button33, 'с');
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button27, button33, 'т');
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button26, button33, 'у');
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button25, button33, 'ф');
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button24, button33, 'х');
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button23, button33, 'ц');
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button22, button33, 'ч');
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button32, button33, 'ш');
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button16, button33, 'щ');
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button15, button33, 'ъ');
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button14, button33, 'ы');
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button13, button33, 'ь');
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button12, button33, 'э');
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button36, button33, 'ю');
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            button_symbol_click(richTextBox1, button35, button33, 'я');
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            words = new string[] { "карнавал", "праздник", "дед мороз", "олень", "сюрприз", "ёлочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            start_game(richTextBox1);

        }

        private void Button34_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}