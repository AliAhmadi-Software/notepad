using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setbk(object sender, EventArgs e)
        {
            txtnotepad.BackColor = Color.FromName(((ToolStripMenuItem)sender).Text);
            foreach (ToolStripMenuItem x in backColorToolStripMenuItem.DropDownItems)
                if (x.Equals(sender))
                    x.Checked = true;
                else
                    x.Checked = false;
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusbar1.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = txtnotepad.Font;
            fontDialog1.ShowDialog();
            txtnotepad.Font = fontDialog1.Font;
        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.ShowDialog();
            txtnotepad.ForeColor = colorDialog1.Color;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //System.IO.File.WriteAllText("C:\\layout.txt", txtnotepad.BackColor.Name);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //Now it show open dialog box.
            //Read the filename selected by the user with in open file dialog box.
            string fName = openFileDialog1.FileName;
            //Read the data by using StreamReader class
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fName);
                txtnotepad.Text = sr.ReadToEnd();
                sr.Close();
            }
          
          
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(fName);
                sw.Write(txtnotepad.Text);
                sw.Flush();
                sw.Close();
            }
         
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtnotepad.Paste();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtnotepad.SelectAll();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
