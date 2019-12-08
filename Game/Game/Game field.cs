using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game_field : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_image;
        static void start_game (RichTextBox wordArea, PictureBox[] lives_image)
        {

        }
        static string get_show_text (string word)
        {
            string result = "";

            return result;
        }
        static void centering_text(RichTextBox word_area)
        {

        }
        static bool is_contains (string word,char symbol)
        {
           bool result = true;

            return result;
        }
        static string get_new_show_text (string word, char symbol,string old_show_text)
        {
            string result = "";

            return result;
        }
        static void button_symbol_click (RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
        }
        public Game_field()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            words = new string[] { "карнавал", "ёлочка", "праздник", "дед мороз", "олень", "сюрприз", "зима", "снегурочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
            //pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
        }

       
    }
}
