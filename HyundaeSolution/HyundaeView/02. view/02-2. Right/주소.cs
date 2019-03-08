using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyundaeView._02._view._02_2._Right
{
    public partial class 주소 : Form
    {
        개인고객_고객등록_계약고객 개인;
        public 주소(개인고객_고객등록_계약고객 form)
        {
            InitializeComponent();
            Load += 주소_Load;
            개인 = form;
        }
        Timer t1 = null;

        private void 주소_Load(object sender, EventArgs e)
        {
            t1 = new Timer();
            t1.Interval = 1000;
            t1.Tick += T1_Tick;
            t1.Start();
            webBrowser1.Navigate("http://192.168.3.17/daum.html");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted; ;
        }

        private void T1_Tick(object sender, EventArgs e)
        {
            string zonecode = webBrowser1.Document.GetElementById("zonecode").GetAttribute("value"); //우편번호
            string addr = webBrowser1.Document.GetElementById("addr").GetAttribute("value"); //주소
            if (zonecode != "")
            {
                string zon = zonecode;
                string add = addr;
                t1.Stop();
                //개인.textlist().
                this.Dispose();
            }

        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
