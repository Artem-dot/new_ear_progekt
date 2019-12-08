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

    public partial class Form5 : Form
    {
        static string[] w;
        static string c_w;
        static string s_t;
        static int c_su;
        static int c_sp;
        static int c_l;
        static PictureBox[] l_i;
        public Form5()
        {
            InitializeComponent();

            l_i = new PictureBox[] { pictureBox7, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            w = new string[] { "карнавал" + "елочка" + "праздник" + "сюрприз" + "подарок" };
            c_w = "";
            s_t = "";
            c_su = 0;
            c_sp = 0;
            c_l = l_i.Length;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        static void s_g(RichTextBox wordArrea)
        {

        }

        static void start_game(RichTextBox wordArrea, PictureBox l_i)
        {

        }
        static string get_show_text(string w)
        {

        }
        static void centering_text (RichTextBox word_area)

        {

        }
        static bool is_contains () 







        private void Button31_Click(object sender, EventArgs e)
        {

        }
    }
}
