using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsISODownloader
{
    public partial class Form1 : Form
    {
        [DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
        const int URLMON_OPTION_USERAGENT = 0x10000001;

        public Form1()
        {
            InitializeComponent();
            string ua = "Mozilla/5.0 (iPad; CPU OS 10_3_1 like Mac OS X) AppleWwebKit/603.1.30 (KHTML, like Gecko) Version/10.0 Mobile/14E304 Safari/602.1";
            UrlMkSetSessionOption(URLMON_OPTION_USERAGENT, ua, ua.Length, 0);
            webBrowser1.Navigate("https://www.microsoft.com/fr-fr/software-download/windows10ISO");
        }
    }
} 
