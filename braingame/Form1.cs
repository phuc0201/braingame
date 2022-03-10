using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace braingame
{
    public partial class Form1 : Form
    {
        private Stack<PictureBox> stackPtb = new Stack<PictureBox>();
        Image img = Image.FromFile(Application.StartupPath + "\\Resources\\White_C_1_Last.png");
        Image imgLost = Image.FromFile(Application.StartupPath + "\\Resources\\imgCaVang.png");
        public Form1()
        {
            InitializeComponent();
            rdB_level1.Checked = true;
        }
        private bool check(PictureBox ptb)
        {
            if (stackPtb.Count == 0)
                return true;
            foreach(var _ptb in stackPtb)
            {
                if (_ptb == ptb)
                    return false;
                if (ptb.Left <= _ptb.Left + 60 && ptb.Left >= _ptb.Left || ptb.Left >= _ptb.Left - 60 && ptb.Left <= _ptb.Left)
                    return false;
            }
            return true;
        }
        private void Draw(int lv)
        {
            Random rd = new Random();
            for (int i=1; i<=lv; i++)
            {
                Color randomColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
                while (randomColor == Color.Gray || randomColor == Color.White)
                {
                    randomColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
                }

                PictureBox ptb = new PictureBox()
                {
                    Size = new Size(100, 100),
                    Location = new Point(rd.Next(100, 1000), rd.Next(100, 600)),
                    BackColor = randomColor,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                };
                ptb.Click += Ptb_Click;
                if (check(ptb) == true)
                {
                    pnl_Ptb.Controls.Add(ptb);
                    stackPtb.Push(ptb);
                }
                else
                    i--;
            }                       
        }

        private void Ptb_Click(object sender, EventArgs e)
        {
            PictureBox ptb = sender as PictureBox;
            if (ptb.BackgroundImage == null)
                return;
            if (stackPtb.Count == 0)
            {
                ptb.BackgroundImage = null;
                MessageBox.Show("WIN");
                pnl_Ptb.Controls.Clear();
                ptb_Color.BackColor = Color.White;
                if (rdB_level1.Checked == true)
                    Draw(5);
                if (rdB_level2.Checked == true)
                    Draw(10);
                btn_ss.Enabled = true;
            }
            else if (ptb.BackColor == ptb_Color.BackColor)
            {
                ptb.BackgroundImage = null;
                ptb_Color.BackColor = stackPtb.Pop().BackColor;
            }
            else
            {
                progressBar1.Value -= 25;
                ptb.Image = imgLost;
            }

            if (progressBar1.Value == 0)
            {
                MessageBox.Show("Non z bạn toi");
                stackPtb.Clear();
                pnl_Ptb.Controls.Clear();
                ptb_Color.BackColor = Color.White;
                if (rdB_level1.Checked == true)
                    Draw(5);
                if (rdB_level2.Checked == true)
                    Draw(10);
                btn_ss.Enabled = true;
            }    
        }

        private void btn_ss_Click(object sender, EventArgs e)
        {           
            foreach (var ptb in stackPtb)
            {
                ptb.BackgroundImage = img;
            }
            ptb_Color.BackColor = stackPtb.Pop().BackColor;
            btn_ss.Enabled = false;
        }

        private void rdB_level1_CheckedChanged(object sender, EventArgs e)
        {
            stackPtb.Clear();
            pnl_Ptb.Controls.Clear();
            Draw(5);
        }

        private void rdB_level2_CheckedChanged(object sender, EventArgs e)
        {
            stackPtb.Clear();
            pnl_Ptb.Controls.Clear();
            Draw(10);
        }
    }
}
