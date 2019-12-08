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
        static string[] w;
        static string c_w;
        static string s_t;
        static int c_su;
        static int c_sp;
        static int c_l;
        static PictureBox[] l_i;

        public Form4()
        {
            InitializeComponent();

            l_i = new PictureBox[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6 };
            w = new string[] { "карнавал" + "елочка" + "праздник" + "сюрприз" + "подарок" };
            c_w = "";
            s_t = "";
            c_su = 0;
            c_sp = 0;
            c_l = l_i.Length;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FtBox(RichTextBox word_area, char sumbol, Button cb, Button sb)
        {
        }

        static void s_g(RichTextBox wordArrea)
        {

        }

        static void start_game(RichTextBox wordArrea, PictureBox l_i)
        {

        }

        public static void BSK(RichTextBox wordArrea,char sumbol,Button cb,Button sb)
        {
            bool ip = is_contains(c_w,);
        }
        static void centering_text(RichTextBox word_area)

        {

        }
        static bool is_contains(string w, char s)
        {

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == s)
                {
                    return true;
                }

            }
            return false;
        }
        static string get_show_text(string w)
        {
            string r = "";
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == ' ')
                {
                    r += "  ";
                    c_sp++;
                }
                else
                {
                    r += "* ";
                }

            }
            return r;
        }
        public static void ct(RichTextBox word_area)
        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
        }
        static string get_nshow_text(string w, char sumbol, string ost)
        {
            string resulf = "";
            for (int i = 0; i < ost.Length; i++)
            {
                if (w[i/2] == sumbol)
                {
                    resulf += sumbol + " ";
                    c_su++;
                }
                else
                {
                    resulf += ost[i] + " ";
                }
            }
            return resulf;
        }
    }

}
