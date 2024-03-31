using CefSharp;
using CefSharp.WinForms;
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

namespace KWM_BROWSER
{
    public partial class Form1 : Form
    {
        string searchsystem;
        public Form1()
        {
            InitializeComponent();
            searchsystem = "https://www.google.com/search?q=";
            chromiumWebBrowser1.Load("https://doxbin.com/");
            richTextBox1.Text = File.ReadAllText("history.t$");
            File.AppendAllText("history.t$", "google: "+ textBox1.Text + "\n");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(searchsystem + textBox1.Text);
            if (textBox1.Text.Contains("http://"))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
            else if (textBox1.Text.Contains("https://"))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
            File.AppendAllText("history.t$", "google:" + textBox1.Text + "\n");
            richTextBox1.Text = File.ReadAllText("history.t$");

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Back();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Forward();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://discord.gg/wuapy9hv");
            tabPage1.Select();
            tabPage1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://doxbin.com/");
            tabPage1.Select();
            tabPage1.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText("history.t$", "");
            richTextBox1.Text = File.ReadAllText("history.t$");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://youtu.be/dQw4w9WgXcQ?si=0weylM3CzRAOxTkp");
            tabPage1.Select();
            tabPage1.Show();
        }
    }
}
