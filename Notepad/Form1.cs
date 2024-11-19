using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            DialogResult result = cd.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = ".txt";
                DialogResult result = saveFileDialog.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                if (result == DialogResult.OK)
                {
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex) { }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text document|*.txt|Word|*.docx|All Files|*.*";
                DialogResult result = openFileDialog.ShowDialog();
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex) { }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
