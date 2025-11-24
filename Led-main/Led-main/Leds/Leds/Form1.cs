using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leds
{
    public partial class Form1 : Form
    {
        public Led Luz;
        public Form1()
        {
            InitializeComponent();
            Luz = new Led();
            Atualizainterface()
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_on_8_Click(object sender, EventArgs e)
        {

        }

        private void lbl_IndicarValor_Click(object sender, EventArgs e)
        {

        }
    }
}
