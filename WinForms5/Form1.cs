using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinForms5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                label1.Text = openFileDialog1.FileName;
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void новыйАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            label1.Text = "Новый";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style ^ FontStyle.Bold);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style ^ FontStyle.Italic);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                System.Drawing.Font currentFont = richTextBox1.SelectionFont;
                richTextBox1.SelectionFont = new Font(currentFont, currentFont.Style ^ FontStyle.Underline);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fn = new FontDialog();
            DialogResult res = fn.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fn.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog cn = new ColorDialog();
            DialogResult res = cn.ShowDialog();
            if (res == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cn.Color;
            }
        }
    }
}
