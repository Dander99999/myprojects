using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Japanese_crossword
{
    public partial class help4 : Form
    {
        object obh;
        object obh1;
        public int idk;
        public help4()
        {
            InitializeComponent();
        }

        private void help4_Load(object sender, EventArgs e)
        {
            obh = Properties.Resources.ResourceManager.GetObject("listochek");
            obh1 = Properties.Resources.ResourceManager.GetObject("lvl4");
            DialogResult otvet = MessageBox.Show("Вы хотите не большую подсказку", "Подсказка", MessageBoxButtons.YesNo);
            if (otvet == DialogResult.Yes)
            {
                pictureBox1.Image = (Bitmap)obh;
                idk = 1;
            }
            else
            {
                pictureBox1.Image = (Bitmap)obh1;
                idk = 0;
            }
        }
    }
}
