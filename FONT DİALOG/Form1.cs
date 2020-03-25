using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FONT_DİALOG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = fontDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }
    }
}
