using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipMng
{
    public partial class ShowForm : Form
    {
        public ShowForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox1.SelectedText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextBox1.Text);
        }
    }
}
