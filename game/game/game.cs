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
        static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {

        }
        static string get_show_text(string word)
        {
            string result_text = "";
            for (int i = 0; i < word.Length; i++)
            {
                result_text += "_";
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
        static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button start_button)
        {

        }

    }
}