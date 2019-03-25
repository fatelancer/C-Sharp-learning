using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Save_Human
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (label1.Text == "Right")
                {
                    label1.Text = "Left";
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    label1.Text = "Right";
                    label1.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                label1.Text = "Text Changing is disabled";
                label1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
