using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form4 : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int count_success;
        static int count_spaces;
        static int lives;
        static PictureBox[] lives_image;

        public Form4()
        {
            InitializeComponent();
            lives_image = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3,
                                                pictureBox4, pictureBox5, pictureBox6};
            words = new string[] { "карнавал", "елочка" , "праздник" , "сюрприз", "подарок" };
            current_word = "";
            show_text = "";
            count_success = 0;
            count_spaces = 0;
            lives = lives_image.Length;

            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            start_game(wordArea, lives_image);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'а', button1, startGame);
        }

        private void FtBox(RichTextBox word_area, char sumbol, Button cb, Button sb)
        {
        }

        public static void start_game(RichTextBox wordArea)
        {
            Random random = new Random();
            int words_array_length = words.Length;
            int index_word = random.Next(0, words_array_length);
            current_word = words[index_word];
            count_spaces = 0;
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            centering_text(wordArea);
            lives = 6;
            count_success = 0;
        }
        public static void start_game(RichTextBox wordArea, PictureBox[] lives_image)
        {
            start_game(wordArea);
            var bmp = new Bitmap(Properties.Resources.depositphotos_14850833_stock_photo_red_gift_box);
            for (int i = 0; i < lives_image.Length; i++)
            {
                lives_image[i].SizeMode = PictureBoxSizeMode.Zoom;
                lives_image[i].Image = bmp;
            }
        }

        public static string get_show_text(string word)
        {
            string text = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    text += "  ";
                    count_spaces++;
                }
                else
                {
                    text += "_ ";
                }
            }
            return text;
        }

        public static void centering_text(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }

        public static bool is_contains(string word, char symbol)
        {
            bool isContains = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol)
                {
                    isContains = true;
                    return isContains;
                }
            }
            return isContains;
        }

        public static string get_new_show_text(string word, char symbol, string old_show_text)
        {
            string new_show_text = "";
            for (int i = 0; i < old_show_text.Length; i += 2)
            {
                if (word[i / 2] == symbol)
                {
                    new_show_text += symbol + " ";
                    count_success++;
                }
                else
                {
                    new_show_text += old_show_text[i] + " ";
                }
            }
            return new_show_text;
        }

        public static void button_symbol_click(RichTextBox wordArea, char symbol, Button cur_button, Button startButton)
        {
            bool is_cont = is_contains(current_word, symbol);
            if (is_cont)
            {
                show_text = get_new_show_text(current_word, symbol, show_text);
                wordArea.Text = show_text;
                centering_text(wordArea);
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }
            cur_button.Enabled = false;
            if ((count_success + count_spaces) == current_word.Length)
            {
                using (Form1 succesorm = new Form1())
                {
                    succesorm.ShowDialog();
                }
            }
            else if (lives == 0)
            {
                using (Form3 lossForm = new Form3())
                {
                    lossForm.ShowDialog();
                }
                startButton.PerformClick();
            }
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            start_game(wordArea, lives_image);

            Button[] buttons = new Button[] { button1, button2, button3, button4, button5,
            button6, button7, button8, button9, button10, button11, button12, button13,
            button14, button15, button16, button17, button18, button19, button20, button21,
            button22, button23, button24, button25, button26, button27, button28, button29,
            button30, button31};

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
        }

        private void CloseGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button_symbol_click(wordArea, 'б', button2, startGame);
        }
    }

}