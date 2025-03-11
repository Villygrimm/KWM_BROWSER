using CefSharp;
using CefSharp.DevTools.IndexedDB;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
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
            chromiumWebBrowser1.AddressChanged += ChromiumWebBrowser1_AddressChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            searchsystem = "https://www.google.com/search?q=";
            chromiumWebBrowser1.Load("https://doxbin.com/");
            chromiumWebBrowser1.FrameLoadEnd += chromiumWebBrowser1_FrameLoadEnd;
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


        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_1(object sender, EventArgs e)
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
      
        }

        private void chromiumWebBrowser1_LoadingStateChanged_1(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Back();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Reload();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Forward();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchsystem = "https://www.google.com/search?q=";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchsystem = "https://yandex.ru/search/?text=";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click_1(sender, e);
            }
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }




        private void chromiumWebBrowser1_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
         
        }
        private void ChromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            // Так как это срабатывает в другом потоке, используем Invoke
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = e.Address;
            }));
        }





    }
}
