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
            start_game(wordArea, l_i);

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BSK(wordArea, 'а', button1, startGame);
        }

        private void FtBox(RichTextBox word_area, char sumbol, Button cb, Button sb)
        {
        }

        static void s_g(RichTextBox wordArrea)
        {
            Random random = new Random();
            int wal = w.Length;
            int iw = random.Next(0, wal);
            c_w = w[iw];
            c_l = l_i.Length;
            c_su = 0;
            s_t = get_show_text(c_w);
            wordArrea.Text = s_t;
            ct(wordArrea);
           
        }

        static void start_game(RichTextBox wordArrea, PictureBox[] l_i)
        {
            s_g(wordArrea);
            Bitmap bmp = new Bitmap(Properties.Resources.depositphotos_14850833_stock_photo_red_gift_box);
            for(int i = 0; i < l_i.Length; i++)
            {
                l_i[i].SizeMode = PictureBoxSizeMode.Zoom;
                l_i[i].Image = bmp;
            }

        }

        
        static void centering_text(RichTextBox word_area)

        {
            word_area.SelectAll();
            word_area.SelectionAlignment = HorizontalAlignment.Center;
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
            public static void BSK(RichTextBox wordArrea,char sumbol,Button cb,Button sb)
        {
            bool ip = is_contains(c_w,sumbol);
            if (ip)
            {
                s_t = get_nshow_text(c_w, sumbol, s_t);
                wordArrea.Text = s_t;
                centering_text(wordArrea);
            }else
            {
                c_l--;
                l_i[c_l].Image = null;
            }
            cb.Enabled = false;
            if ((c_su + c_sp) == c_w.Length)
            {
                using (Form1 f = new Form1())
                {
                    f.ShowDialog();
                }

                sb.PerformClick();
            }
            else if (c_l == 0)
            {
                using (Form1 form = new Form1())
                {
                    form.ShowDialog();
                }
                sb.PerformClick();
            }



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