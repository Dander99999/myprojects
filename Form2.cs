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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int sloshnost;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sloshnost = 1;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sloshnost = 2;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sloshnost = 3;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sloshnost = 4;
            this.Close();
        }
    }
}
