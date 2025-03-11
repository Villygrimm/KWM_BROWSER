using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWM_BROWSER
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var settings = new CefSettings();
            settings.CefCommandLineArgs.Add("webrtc-ip-handling-policy", "disable_non_proxied_udp");

            Cef.Initialize(settings);

            Application.Run(new Form1());
        
        }
    }
}
