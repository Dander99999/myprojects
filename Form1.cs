using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_crossword
{
    public partial class Form1 : Form
    {
        int x, y, x1, y1, xig, yig;
        int xl, yl, xl1, yl1, xigl, yigl;
        int min, sec = 0;
        string s, st;
        string secst, minst;
        string num;
        int igrakol;
        int zamnum;
        int zamoshibki;
        int playinsloshnost;
        int ysheporiden;
        int skrit = 0;
        int timerprodolshit = 1;
        object ob;
        object obnot;
        int zampon = 0;
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Pomosh helpplay = new Pomosh();
            timer1.Stop();
            helpplay.ShowDialog();
            if(ysheporiden != 1)
            {
                if (timerprodolshit != 0) timer1.Start();
            }
            helpplay.Dispose();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            DialogResult yhodite = MessageBox.Show("Вы что уходите?", "Выход", MessageBoxButtons.YesNo);
            if(yhodite == DialogResult.Yes)
            {
                MessageBox.Show("Ладно спасибо, что сыграли в нашу игру!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Вы нас напугали =)");
                timer1.Start();
            }

        }

        private void toolskrit_Click(object sender, EventArgs e)
        {
            if(skrit == 1)
            {
            if (pnligra.Visible != false)
            {
                lbligra.Visible = false;
                lbltime.Visible = false;
                pnligra.Visible = false;
                pnlslevprov.Visible = false;
                pnlverhyaprov.Visible = false;
                    if(zampon == 1)
                    {
                        btnsdatsya.Visible = false;
                    }
            }
            else
            {
                lbligra.Visible = true;
                lbltime.Visible = true;
                pnligra.Visible = true;
                pnlslevprov.Visible = true;
                pnlverhyaprov.Visible = true;
                    if (zampon == 1)
                    {
                        btnsdatsya.Visible = true;
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            if(ochenslosh == 3)
            {
                frm.button4.Visible = true;
            }
            frm.ShowDialog();
            this.Show();
            playinsloshnost = frm.sloshnost;
            timer1.Stop();
            min = 0;
            sec = 0;
            zamnum = 0;
            zamoshibki = 0;
            skrit = 0;
            ysheporiden = 0;
            zampon = 0;
            timerprodolshit = 1;
            pnligra.Visible = false;
            pnlslevprov.Visible = false;
            pnlverhyaprov.Visible = false;
            lbltime.Visible = false;
            lbligra.Visible = false;
            btnsdatsya.Visible = false;
            btnstart.Visible = false;
            pnligra.Controls.Clear();
            pnlslevprov.Controls.Clear();
            pnlverhyaprov.Controls.Clear();
            frm.Dispose();
            //MessageBox.Show(playinsloshnost.ToString());
            btnstart.Visible = true;
            if(playinsloshnost == 1)
            {
                pnligra.Size = new Size(400, 400);
                pnlslevprov.Size = new Size(160, 400);
                pnlverhyaprov.Size = new Size(400, 160);
            }
            if (playinsloshnost == 2)
            {
                pnligra.Size = new Size(480, 480);
                pnlslevprov.Size = new Size(160, 480);
                pnlverhyaprov.Size = new Size(480, 160);
            }
            if (playinsloshnost == 3)
            {
                pnligra.Size = new Size(560, 560);
                pnlslevprov.Size = new Size(160, 560);
                pnlverhyaprov.Size = new Size(560, 160);
            }
            if (playinsloshnost == 4)
            {
                pnligra.Size = new Size(760, 720);
                pnlslevprov.Size = new Size(160, 720);
                pnlverhyaprov.Size = new Size(760, 160);
            }
        }

        private void buttonochki_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы набирать очки надо проходить все уровни без повтора.\r\nВсего очков " + ochenslosh);
        }

        public int ochenslosh = 0;
        int proidenleg, proidensred, proidenhard = 0;     
        private void btnsdatsya_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if(playinsloshnost == 1 && timerprodolshit != 0)
            {
                help1 h1 = new help1();
                h1.ShowDialog();
                h1.Dispose();
                timerprodolshit = h1.idk;
            }
            if (playinsloshnost == 2 && timerprodolshit != 0)
            {
                help2 h2 = new help2();
                h2.ShowDialog();
                h2.Dispose();
                timerprodolshit = h2.idk;
            }
            if (playinsloshnost == 3 && timerprodolshit != 0)
            {
                help3 h3 = new help3();
                h3.ShowDialog();
                h3.Dispose();
                timerprodolshit = h3.idk;
            }
            if (playinsloshnost == 4 && timerprodolshit != 0)
            {
                help4 h4 = new help4();
                h4.ShowDialog();
                h4.Dispose();
                timerprodolshit = h4.idk;
            }
            if(timerprodolshit == 1)
            {
                timer1.Start();
            }
            else
            {
                min = 0;
                sec = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (sec > 9)
            {
                secst = sec.ToString();
                if (sec == 60)
                {
                    min++;
                    sec = 0;
                }
            }
            else
            {
                secst = "0" + sec.ToString();
            }

            if (min > 9)
            {
                minst = min.ToString();
            }
            else
            {
                minst = "0" + min.ToString();
            }

            lbltime.Text = minst + " : " + secst;
            if (min == 2 && sec == 0)
            {
                btnsdatsya.Visible = true;
                zampon = 1;
            }
            sec++;

            if(playinsloshnost == 1)
            {
                if(zamnum == 46 && zamoshibki == 0)
                {
                timer1.Stop();
                MessageBox.Show("Вы решили кроссворд!!!");
                    ysheporiden = 1;
                if(proidenleg == 0)
                    {
                        ochenslosh += 1;
                        proidenleg = 1;
                    }
                }
            }
            if (playinsloshnost == 2)
            {
                if (zamnum == 70 && zamoshibki == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Вы решили кроссворд!!!");
                    ysheporiden = 1;
                    if (proidensred == 0)
                    {
                        ochenslosh += 1;
                        proidensred = 1;
                    }
                }
            }
            if(playinsloshnost == 3)
            {
                if (zamnum == 102 && zamoshibki == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Вы решили кроссворд!!!");
                    ysheporiden = 1;
                    if (proidenhard == 0)
                    {
                        ochenslosh += 1;
                        proidenhard = 1;
                    }
                }
            }
            if(playinsloshnost == 4)
            {
                if(zamnum == 207 && zamoshibki == 0)
                {
                    ysheporiden = 1;
                    timer1.Stop();
                    MessageBox.Show("Вы снова решили кроссворд.\r\nНа этом игра заканчивается спасибо что провели время с нами в нашей любимой головоломке.\r\nНадеюсь вам понравилось наша игра я очень старался сделать его прикольным!\r\n\r\nАвтор:Чередник Артём");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Приветствую вас дорогие друзья на игре подназванием Японский_Кроссворд");
            DialogResult chtotakoe = MessageBox.Show("Хотите узнать по подробнее что такое Японский_Кроссворд", "Описание", MessageBoxButtons.YesNo);
            if (chtotakoe == DialogResult.Yes) MessageBox.Show("Японские кроссворды (также нонограммы) — логические головоломки, в которых зашифровано пиксельное изображение. Разгадывать кроссворд нужно с помощью чисел, расположенных слева от строк и сверху от столбцов.\r\n\r\n\r\nРазмер кроссвордов может доходить до 150x150. Игрок с помощью специальных логических приемов вычисляет цвет каждой клетки. Решение может занять как пару минут на кроссвордах для начинающих, так и десятки часов на сложных головоломках.");
            DialogResult pravila = MessageBox.Show("Нужно вам объяснять правила игры?", "Правила игры", MessageBoxButtons.YesNo);
            if (pravila == DialogResult.Yes) MessageBox.Show("Изначально холст кроссворда белый. Кроссворд нужно восстановить местоположения красных клеток и поставить пустые места крестики что означает что там не будет закрашено");
            ob = Properties.Resources.ResourceManager.GetObject("red");
            obnot = Properties.Resources.ResourceManager.GetObject("notred");
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            x = pnlverhyaprov.Size.Width / 40;
            y = pnlverhyaprov.Size.Height / 40;
            x1 = pnlslevprov.Size.Width / 40;
            y1 = pnlslevprov.Size.Height / 40;
            xig = pnligra.Size.Width / 40;
            yig = pnligra.Size.Height / 40;
            yl = pnlverhyaprov.Size.Height - 40;
            xl1 = pnlslevprov.Size.Width - 40;
            yigl = pnligra.Size.Height - 40;
            skrit = 1;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Button btnverh = new Button();
                    s = i.ToString() + "" + j.ToString();
                    btnverh.Size = new Size(40, 40);
                    btnverh.Location = new Point(xl, yl);
                    btnverh.Enabled = false;
                    if (playinsloshnost == 1)
                    {
                        switch (s)
                        {
                            case "00": btnverh.Text = "2"; break;
                            case "01": btnverh.Text = "2"; break;
                            case "02": btnverh.Text = "1"; break;
                            case "03": btnverh.Text = "10"; break;
                            case "04": btnverh.Text = "1"; break;
                            case "05": btnverh.Text = "2"; break;
                            case "06": btnverh.Text = "5"; break;
                            case "07": btnverh.Text = "3"; break;
                            case "08": btnverh.Text = "1"; break;
                            case "09": btnverh.Text = "2"; break;
                            case "11": btnverh.Text = "3"; break;
                            case "12": btnverh.Text = "5"; break;
                            case "14": btnverh.Text = "5"; break;
                            case "15": btnverh.Text = "3"; break;
                            case "22": btnverh.Text = "1"; break;
                        }
                    }
                    if (playinsloshnost == 2)
                    {
                        switch (s)
                        {
                            case "00": btnverh.Text = "7"; break;
                            case "01": btnverh.Text = "3"; break;
                            case "02": btnverh.Text = "2"; break;
                            case "03": btnverh.Text = "1"; break;
                            case "04": btnverh.Text = "3"; break;
                            case "05": btnverh.Text = "3"; break;
                            case "06": btnverh.Text = "5"; break;
                            case "07": btnverh.Text = "4"; break;
                            case "08": btnverh.Text = "1"; break;
                            case "09": btnverh.Text = "2"; break;
                            case "010": btnverh.Text = "2"; break;
                            case "011": btnverh.Text = "7"; break;
                            case "11": btnverh.Text = "4"; break;
                            case "12": btnverh.Text = "8"; break;
                            case "13": btnverh.Text = "8"; break;
                            case "14": btnverh.Text = "1"; break;
                            case "18": btnverh.Text = "2"; break;
                            case "19": btnverh.Text = "3"; break;
                            case "110": btnverh.Text = "1"; break;
                            case "21": btnverh.Text = "1"; break;
                            case "210": btnverh.Text = "2"; break;
                        }
                    }
                    if(playinsloshnost == 3)
                    {
                        switch (s)
                        {
                            case "00": btnverh.Text = "2"; break;
                            case "01": btnverh.Text = "4"; break;
                            case "02": btnverh.Text = "6"; break;
                            case "03": btnverh.Text = "4"; break;
                            case "04": btnverh.Text = "8"; break;
                            case "05": btnverh.Text = "5"; break;
                            case "06": btnverh.Text = "7"; break;
                            case "07": btnverh.Text = "7"; break;
                            case "08": btnverh.Text = "7"; break;
                            case "09": btnverh.Text = "1"; break;
                            case "010": btnverh.Text = "2"; break;
                            case "011": btnverh.Text = "2"; break;
                            case "012": btnverh.Text = "10"; break;
                            case "013": btnverh.Text = "7"; break;
                            case "10": btnverh.Text = "5"; break;
                            case "11": btnverh.Text = "2"; break;
                            case "13": btnverh.Text = "2"; break;
                            case "19": btnverh.Text = "7"; break;
                            case "110": btnverh.Text = "7"; break;
                            case "111": btnverh.Text = "7"; break;
                        }
                    }
                    if(playinsloshnost == 4)
                    {
                        switch (s)
                        {
                            case "00": btnverh.Text = "2"; break;
                            case "01": btnverh.Text = "3"; break;
                            case "02": btnverh.Text = "2"; break;
                            case "03": btnverh.Text = "2"; break;
                            case "04": btnverh.Text = "5"; break;
                            case "05": btnverh.Text = "4"; break;
                            case "06": btnverh.Text = "4"; break;
                            case "07": btnverh.Text = "2"; break;
                            case "08": btnverh.Text = "4"; break;
                            case "09": btnverh.Text = "4"; break;
                            case "010": btnverh.Text = "3"; break;
                            case "011": btnverh.Text = "3"; break;
                            case "012": btnverh.Text = "7"; break;
                            case "013": btnverh.Text = "12"; break;
                            case "014": btnverh.Text = "3"; break;
                            case "015": btnverh.Text = "1"; break;
                            case "016": btnverh.Text = "2"; break;
                            case "017": btnverh.Text = "1"; break;
                            case "018": btnverh.Text = "4"; break;
                            case "11": btnverh.Text = "1"; break;
                            case "12": btnverh.Text = "2"; break;
                            case "13": btnverh.Text = "10"; break;
                            case "14": btnverh.Text = "6"; break;
                            case "15": btnverh.Text = "1"; break;
                            case "16": btnverh.Text = "6"; break;
                            case "17": btnverh.Text = "1"; break;
                            case "18": btnverh.Text = "2"; break;
                            case "19": btnverh.Text = "4"; break;
                            case "110": btnverh.Text = "4"; break;
                            case "111": btnverh.Text = "4"; break;
                            case "112": btnverh.Text = "3"; break;
                            case "113": btnverh.Text = "4"; break;
                            case "114": btnverh.Text = "8"; break;
                            case "115": btnverh.Text = "12"; break;
                            case "116": btnverh.Text = "8"; break;
                            case "117": btnverh.Text = "2"; break;
                            case "21": btnverh.Text = "2"; break;
                            case "22": btnverh.Text = "6"; break;
                            case "25": btnverh.Text = "5"; break;
                            case "27": btnverh.Text = "9"; break;
                            case "28": btnverh.Text = "1"; break;
                            case "29": btnverh.Text = "7"; break;
                            case "210": btnverh.Text = "7"; break;
                            case "211": btnverh.Text = "2"; break;
                            case "212": btnverh.Text = "5"; break;
                            case "214": btnverh.Text = "2"; break;
                            case "217": btnverh.Text = "4"; break;
                            case "38": btnverh.Text = "6"; break;
                            case "311": btnverh.Text = "5"; break;
                        }
                    }
                    //btnverh.Click += ButtonVerh_Click;
                    xl += 40;
                    pnlverhyaprov.Controls.Add(btnverh);

                }
                yl -= 40;
                xl = 0;
            }

            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < y1; j++)
                {
                    Button btnslev = new Button();
                    st = i.ToString() + "" + j.ToString();
                    btnslev.Size = new Size(40, 40);
                    btnslev.Location = new Point(xl1, yl1);
                    btnslev.Enabled = false;
                    if(playinsloshnost == 1)
                    {
                    switch (st)
                    {
                        case "00": btnslev.Text = "1"; break;
                        case "01": btnslev.Text = "3"; break;
                        case "02": btnslev.Text = "1"; break;
                        case "03": btnslev.Text = "5"; break;
                        case "04": btnslev.Text = "4"; break;
                        case "05": btnslev.Text = "6"; break;
                        case "06": btnslev.Text = "7"; break;
                        case "07": btnslev.Text = "1"; break;
                        case "08": btnslev.Text = "1"; break;
                        case "09": btnslev.Text = "1"; break;
                        case "12": btnslev.Text = "2"; break;
                        case "17": btnslev.Text = "2"; break;
                        case "18": btnslev.Text = "3"; break;
                        case "19": btnslev.Text = "5"; break;
                        case "27": btnslev.Text = "3"; break;
                        case "28": btnslev.Text = "1"; break;
                    }
                    }
                    if(playinsloshnost == 2)
                    {
                        switch (st)
                        {
                            case "00": btnslev.Text = "6"; break;
                            case "01": btnslev.Text = "6"; break;
                            case "02": btnslev.Text = "1"; break;
                            case "03": btnslev.Text = "2"; break;
                            case "04": btnslev.Text = "1"; break;
                            case "05": btnslev.Text = "3"; break;
                            case "06": btnslev.Text = "4"; break;
                            case "07": btnslev.Text = "4"; break;
                            case "08": btnslev.Text = "1"; break;
                            case "09": btnslev.Text = "1"; break;
                            case "010": btnslev.Text = "1"; break;
                            case "011": btnslev.Text = "1"; break;
                            case "10": btnslev.Text = "2"; break;
                            case "11": btnslev.Text = "4"; break;
                            case "12": btnslev.Text = "1"; break;
                            case "13": btnslev.Text = "2"; break;
                            case "14": btnslev.Text = "1"; break;
                            case "15": btnslev.Text = "5"; break;
                            case "16": btnslev.Text = "5"; break;
                            case "19": btnslev.Text = "2"; break;
                            case "110": btnslev.Text = "3"; break;
                            case "111": btnslev.Text = "4"; break;
                            case "22": btnslev.Text = "2"; break;
                            case "23": btnslev.Text = "2"; break;
                            case "24": btnslev.Text = "4"; break;
                            case "32": btnslev.Text = "2"; break;
                        }
                    }
                    if(playinsloshnost == 3)
                    {
                        switch (st)
                        {
                            case "00": btnslev.Text = "1"; break;
                            case "01": btnslev.Text = "6"; break;
                            case "02": btnslev.Text = "13"; break;
                            case "03": btnslev.Text = "9"; break;
                            case "04": btnslev.Text = "14"; break;
                            case "05": btnslev.Text = "13"; break;
                            case "06": btnslev.Text = "14"; break;
                            case "07": btnslev.Text = "8"; break;
                            case "08": btnslev.Text = "2"; break;
                            case "09": btnslev.Text = "2"; break;
                            case "010": btnslev.Text = "2"; break;
                            case "011": btnslev.Text = "2"; break;
                            case "012": btnslev.Text = "2"; break;
                            case "013": btnslev.Text = "2"; break;
                            case "10": btnslev.Text = "1"; break;
                            case "11": btnslev.Text = "5"; break;
                            case "13": btnslev.Text = "1"; break;
                            case "17": btnslev.Text = "2"; break;
                            case "23": btnslev.Text = "1"; break;
                            case "27": btnslev.Text = "2"; break;
                        }
                    }
                    if(playinsloshnost == 4)
                    {
                        switch (st)
                        {
                            case "00": btnslev.Text = "4"; break;
                            case "01": btnslev.Text = "8"; break;
                            case "02": btnslev.Text = "12"; break;
                            case "03": btnslev.Text = "4"; break;
                            case "04": btnslev.Text = "3"; break;
                            case "05": btnslev.Text = "5"; break;
                            case "06": btnslev.Text = "6"; break;
                            case "07": btnslev.Text = "8"; break;
                            case "08": btnslev.Text = "6"; break;
                            case "09": btnslev.Text = "5"; break;
                            case "010": btnslev.Text = "9"; break;
                            case "011": btnslev.Text = "9"; break;
                            case "012": btnslev.Text = "5"; break;
                            case "013": btnslev.Text = "5"; break;
                            case "014": btnslev.Text = "4"; break;
                            case "015": btnslev.Text = "7"; break;
                            case "016": btnslev.Text = "6"; break;
                            case "017": btnslev.Text = "3"; break;
                            case "10": btnslev.Text = "2"; break;
                            case "11": btnslev.Text = "3"; break;
                            case "12": btnslev.Text = "1"; break;
                            case "13": btnslev.Text = "7"; break;
                            case "14": btnslev.Text = "6"; break;
                            case "15": btnslev.Text = "10"; break;
                            case "16": btnslev.Text = "2"; break;
                            case "17": btnslev.Text = "6"; break;
                            case "18": btnslev.Text = "4"; break;
                            case "19": btnslev.Text = "1"; break;
                            case "110": btnslev.Text = "1"; break;
                            case "111": btnslev.Text = "4"; break;
                            case "112": btnslev.Text = "1"; break;
                            case "113": btnslev.Text = "5"; break;
                            case "114": btnslev.Text = "5"; break;
                            case "115": btnslev.Text = "2"; break;
                            case "116": btnslev.Text = "1"; break;
                            case "117": btnslev.Text = "2"; break;
                            case "20": btnslev.Text = "1"; break;
                            case "23": btnslev.Text = "2"; break;
                            case "24": btnslev.Text = "4"; break;
                            case "26": btnslev.Text = "6"; break;
                            case "28": btnslev.Text = "3"; break;
                            case "29": btnslev.Text = "2"; break;
                            case "210": btnslev.Text = "2"; break;
                            case "212": btnslev.Text = "4"; break;
                            case "214": btnslev.Text = "1"; break;
                            case "215": btnslev.Text = "3"; break;
                            case "216": btnslev.Text = "3"; break;
                            case "39": btnslev.Text = "4"; break;
                        }
                    }
                    //btnslev.Click += Buttonslev_Click;
                    yl1 += 40;
                    pnlslevprov.Controls.Add(btnslev);
                }
                xl1 -= 40;
                yl1 = 0;
            }
            for (int i = 0; i < yig; i++)
            {
                for (int j = 0; j < xig; j++)
                {
                    PictureBox btnigra = new PictureBox();
                    btnigra.Size = new Size(40, 40);
                    btnigra.Location = new Point(xigl, yigl);
                    btnigra.Tag = j.ToString() + "" + i.ToString();
                    btnigra.Name = "0";
                    btnigra.BorderStyle = BorderStyle.FixedSingle;
                    btnigra.BackColor = Color.White;
                    btnigra.SizeMode = PictureBoxSizeMode.Zoom;
                    btnigra.MouseClick += Buttonigra_MouseClick;
                    btnigra.MouseEnter += DvigatMouse_MouseEnter;
                    btnigra.MouseLeave += DvigatMouse_MouseLeave;
                    xigl += 40;
                    pnligra.Controls.Add(btnigra);
                }
                yigl -= 40;
                xigl = 0;
            }
            timer1.Start();
            pnligra.Visible = true;
            pnlslevprov.Visible = true;
            pnlverhyaprov.Visible = true;
            lbltime.Visible = true;
            lbligra.Visible = true;
            igrakol++;
            lbligra.Text = "Игра " + igrakol.ToString();
            btnstart.Visible = false;
        }
        private void ButtonVerh_Click(object sender, EventArgs e)
        {

        }
        private void Buttonslev_Click(object sender, EventArgs e)
        {

        }
        private void DvigatMouse_MouseEnter(object sender, EventArgs e)
        {
            PictureBox picigrapoln = (PictureBox)sender;
            for (int i = 0; i < x; i++)
            {
                picigrapoln.BackColor = Color.SlateGray;
            }
            for (int i = 0; i < y; i++)
            {
                picigrapoln.BackColor = Color.SlateGray;
            }
        }
        private void DvigatMouse_MouseLeave(object sender, EventArgs e)
        {
            PictureBox picigrapoln = (PictureBox)sender;
            for (int i = 0; i < x; i++)
            {
                picigrapoln.BackColor = Color.White;
            }
            for (int i = 0; i < y; i++)
            {
                picigrapoln.BackColor = Color.White;
            }
        }
        PictureBox picigrapoln;
        private void Buttonigra_MouseClick(object sender, MouseEventArgs e)
        {
            picigrapoln = (PictureBox)sender;
            num = picigrapoln.Tag.ToString();
            int stolbez = Convert.ToInt32(num) / 10;
            int stroka = Convert.ToInt32(num) - stolbez * 10;
            if (e.Button == MouseButtons.Left)
            {
                if (picigrapoln.Image != ob)
                {
                    picigrapoln.Image = (Bitmap)ob;
                    picigrapoln.Name = "1";
                }
                else
                {
                    picigrapoln.Image = null;
                    picigrapoln.Name = "0";
                }
            }
            else
            {
                if (picigrapoln.Image != obnot)
                {
                    picigrapoln.Image = (Bitmap)obnot;
                    picigrapoln.Name = "0";
                }
                else
                {
                    picigrapoln.Image = null;
                    picigrapoln.Name = "0";
                }
            }
            if(playinsloshnost == 1)
            {
                    switch (num)
                    {
                    case "20": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "30": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "40": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "50": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "60": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "80": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "31": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "51": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "61": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "71": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "91": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "22": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "32": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "42": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "62": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "72": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "92": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "13": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "23": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "33": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "43": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "53": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "63": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "73": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "14": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "24": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "34": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "44": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "54": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "64": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "25": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "35": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "45": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "55": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "06": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "16": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "26": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "36": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "46": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "07": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "17": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "37": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "18": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "28": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "38": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "39": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    default: if (picigrapoln.Name == "1") zamoshibki -= 1; if (picigrapoln.Name == "0") zamoshibki += 1; break;
                }
            }
            if (playinsloshnost == 2)
            {
                switch (num)
                {
                    case "00": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "10": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "20": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "30": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "50": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "01": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "11": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "21": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "51": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "02": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "12": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "52": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "03": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "04": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "14": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "24": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "34": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "05": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "15": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "25": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "35": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "45": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "85": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "95": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "105": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "115": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "06": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "16": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "26": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "36": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "46": if(picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "96": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "106": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "116": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "17": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "27": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "37": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "47": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "67": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "117": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "28": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "38": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "68": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "78": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "108": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "118": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "29": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "39": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "69": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "79": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "99": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "119": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "110": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "210": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "310": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "410": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "610": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "710": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "810": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "910": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1010": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1110": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "211": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "311": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "611": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "711": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "811": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "911": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1011": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1111": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    default: if (picigrapoln.Name == "1") zamoshibki -= 1; if (picigrapoln.Name == "0") zamoshibki += 1; break;
                }
            }
            if (playinsloshnost == 3)
            {
                switch (num)
                {
                    case "90": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "100": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "101": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "122": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "123": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "133": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "124": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "134": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "125": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "135": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "06": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "16": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "36": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "46": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "66": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "76": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "86": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "96": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "106": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "116": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "126": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "136": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "07": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "17": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "27": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "37": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "47": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "57": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "67": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "77": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "87": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "97": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "107": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "117": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "127": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "137": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "18": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "28": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "38": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "48": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "58": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "68": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "78": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "88": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "98": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "108": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "118": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "128": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "138": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "09": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "19": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "29": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "39": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "49": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "59": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "69": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "79": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "89": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "99": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "109": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "119": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "129": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "139": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "010": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "210": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "410": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "510": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "610": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "710": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "810": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "910": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1010": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1110": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1210": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "011": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "211": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "311": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "411": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "511": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "611": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "711": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "811": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "911": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1011": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1111": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1211": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "012": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "212": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "312": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "412": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "612": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "712": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "812": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "912": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1012": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1112": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "013": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "413": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "111": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "112": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    default: if (picigrapoln.Name == "1") zamoshibki -= 1; if (picigrapoln.Name == "0") zamoshibki += 1; break;
                }
            }
            if(playinsloshnost == 4)
            {
                switch (num)
                {
                    case "00": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "10": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "90": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "100": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "110": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "01": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "11": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "21": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "51": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "81": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "91": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "101": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "111": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "121": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "131": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "12": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "22": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "32": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "52": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "62": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "82": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "92": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "102": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "112": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "122": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "132": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "142": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "33": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "53": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "63": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "73": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "83": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "93": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "123": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "133": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "143": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "153": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "44": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "54": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "64": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "74": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "84": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "104": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "114": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "124": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "134": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "144": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "15": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "25": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "35": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "45": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "65": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "95": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "105": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "115": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "125": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "135": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "26": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "36": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "46": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "56": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "76": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "86": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "96": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "106": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "116": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "126": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "136": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "146": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "156": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "37": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "47": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "67": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "87": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "97": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "107": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "117": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "127": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "137": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "147": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "157": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "167": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "18": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "28": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "38": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "48": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "68": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "78": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "98": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "138": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "148": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "158": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "168": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "178": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "19": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "29": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "39": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "59": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "69": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "79": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "89": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "109": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "119": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "129": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "139": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "149": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "159": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "210": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "310": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "410": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "510": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "610": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "710": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "910": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1010": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1110": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1210": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1310": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1410": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1510": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1610": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "211": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "311": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "411": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "511": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "611": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "711": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "911": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1011": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1211": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1311": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1411": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1511": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1611": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1711": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "212": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "312": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "412": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "512": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "612": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "712": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "812": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "912": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1012": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1112": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1312": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1412": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1512": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1612": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1712": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "213": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "313": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "413": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "513": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "713": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "813": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "913": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1013": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1113": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1213": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1413": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1513": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1613": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "314": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "414": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "714": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "814": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "914": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1014": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1114": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1214": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1314": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1514": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1614": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1714": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1814": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "415": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "715": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "815": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "915": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1015": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1115": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1215": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1315": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1415": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1515": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1615": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1715": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1815": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "716": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "816": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "916": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1116": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1216": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1316": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1416": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1516": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1616": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1716": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1816": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "817": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1217": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1317": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1517": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1617": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1717": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    case "1817": if (picigrapoln.Name == "1") zamnum += 1; if (picigrapoln.Name == "0") zamnum -= 1; break;
                    default: if (picigrapoln.Name == "1") zamoshibki -= 1; if (picigrapoln.Name == "0") zamoshibki += 1; break;
                }
            }
        }
    }
}