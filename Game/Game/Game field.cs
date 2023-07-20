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
        static Button[] lit_buttons;
        static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int index = random.Next(0, words.Length - 1);
            current_word = words[index];
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            centering_text(wordArea);
            count_success = 0;
            lives = lives_image.Length;
        }
        static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {
            
            start_game(wordArea);
            var bmp = new Bitmap(Properties.Resources.prs);

            for (int i = 0; i < lives_image.Length; i++)
            {
                lives_image[i].SizeMode = PictureBoxSizeMode.Zoom;
                lives_image[i].Image = bmp;
            }
            //lives_image[0].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[0].Image = bmp;
            //lives_image[1].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[1].Image = bmp;
            //lives_image[2].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[2].Image = bmp;
            //lives_image[3].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[3].Image = bmp;
            //lives_image[4].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[4].Image = bmp;
            //lives_image[5].SizeMode = PictureBoxSizeMode.Zoom;
            //lives_image[5].Image = bmp;


        }

        static string get_show_text(string word)
        {
            string result_string = "";
            for (int i = 0; i < word.Length; i++)
            {
                result_string += "*";
            }

            return result_string;
        }
        static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
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
        static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            cur_button.Enabled = false;

            if (is_contains(current_word, symbol))
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
                centering_text(wordArea);
                if (is_contains(wordArea.Text, '*'))
                {
                    return;
                }
                else
                {
                    using (Saccess_form saccess_Form = new Saccess_form())
                    {
                        saccess_Form.ShowDialog();
                    }
                    startButton.PerformClick();
                }

            }
            else
            {
                lives--;
                lives_image[lives].Visible = false;
             
                if (lives > 0)
                {
                    return;
                }
                else
                {
                    using (Lose_form lose_Form = new Lose_form())
                    {
                        lose_Form.ShowDialog();
                    }
                    startButton.PerformClick();
                }
            }
        }
        public Game_field()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            Button [] lit_buttons = new Button[] { button01, button02, button03, button04, button05, button06, button07, button08,
                                         button09, button10, button11, button12, button13, button14, button15, button16,
                                         button17, button18, button19, button20, button21, button22, button23, button24,
                                         button25, button26, button27, button28, button29, button30, button31, button32,
                                         button33};
            for (int i = 0; i < lit_buttons.Length; i++)
            {
                lit_buttons[i].Enabled = true;
            }
            words = new string[] { "карнавал", "ёлочка", "праздник", "дедмороз", "олень", "сюрприз", "зима", "снегурочка" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            start_game(wordArea, lives_image);
        }

        private void button01_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'а', button01, buttonReplay);
        }

        private void Button02_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'б', button02, buttonReplay);
        }

        private void Button03_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'в', button03, buttonReplay);
        }

        private void Button04_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'г', button04, buttonReplay);
        }

        private void Button05_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'д', button05, buttonReplay);
        }

        private void Button06_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'е', button06, buttonReplay);
        }

        private void Button07_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ё', button07, buttonReplay);
        }

        private void Button08_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ж', button08, buttonReplay);
        }

        private void Button09_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'з', button09, buttonReplay);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'и', button10, buttonReplay);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'й', button11, buttonReplay);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'к', button12, buttonReplay);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'л', button13, buttonReplay);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'м', button14, buttonReplay);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'н', button15, buttonReplay);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'о', button16, buttonReplay);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'п', button17, buttonReplay);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'р', button18, buttonReplay);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'с', button19, buttonReplay);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'т', button20, buttonReplay);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'у', button21, buttonReplay);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ф', button22, buttonReplay);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'х', button23, buttonReplay);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ц', button24, buttonReplay);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ч', button25, buttonReplay);
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ш', button26, buttonReplay);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'щ', button27, buttonReplay);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ъ', button28, buttonReplay);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ы', button29, buttonReplay);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ь', button30, buttonReplay);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'э', button31, buttonReplay);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'ю', button32, buttonReplay);
        }

        private void Button33_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'я', button33, buttonReplay);
        }

        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonReplay_Click(object sender, EventArgs e)
        {
            start_game(wordArea);
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            for (int i = 0; i < lives_image.Length;i ++)
            {
                lives_image[i].Visible = true;
            }
            
            Button[] lit_buttons = new Button[] { button01, button02, button03, button04, button05, button06, button07, button08,
                                         button09, button10, button11, button12, button13, button14, button15, button16,
                                         button17, button18, button19, button20, button21, button22, button23, button24,
                                         button25, button26, button27, button28, button29, button30, button31, button32,
                                         button33};
            for (int i = 0; i < lit_buttons.Length; i++)
            {
                lit_buttons[i].Enabled = true;
            }
        }
    }
}