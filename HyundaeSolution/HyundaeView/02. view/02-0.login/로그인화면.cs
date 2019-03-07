using HyundaeView._01._module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyundaeView._02._view._02_0.login
{
    public partial class 로그인화면 : Form
    {
        _01._module.create ct = new _01._module.create();

        public 로그인화면()
        {
            InitializeComponent();
            Load += 로그인화면_Load;
        }

        private void 로그인화면_Load(object sender, EventArgs e)
        {
            this.Text = "현대해상 영업포탈 시스템";

            this.ClientSize = new Size(1920, 1020);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(-10, 0);
            this.ControlBox = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            page();
        }
        private void page()
        {
            pnSet pn1 = new pnSet(this, 960, 500, 480, 350);
            Panel pn01 = ct.panel(pn1);
            pn01.BackColor = Color.White;
            Controls.Add(pn01);

            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "선", "", 1, 320, 420, 100, 1));
            line_list.Add(new lbSet(this, "선", "", 370, 1, 505, 370, 1));

            for (int i = 0; i<line_list.Count;i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                if(i<2)
                {
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.Black;
                }
                pn01.Controls.Add(lb);
            }

            ArrayList textbox_list = new ArrayList();
            textbox_list.Add(new tbSet(this,"아이디",370,30,505,150));
            textbox_list.Add(new tbSet(this, "비번", 370, 30, 505, 200));
            for (int i = 0; i<textbox_list.Count; i++)
            {
                TextBox tb = ct.txtbox((tbSet)textbox_list[i]);
                if(i<2)
                {
                    tb.Font = new Font(tb.Font.FontFamily, 14);
                }
                if(i==1)
                {
                    tb.PasswordChar = '*';
                    tb.MaxLength = 14;
                }
                pn01.Controls.Add(tb);
            }
            ArrayList button_list = new ArrayList();
            button_list.Add(new btnSet(this,"로그인","로그인",370,60,505,250,btn_Click));
            for(int i = 0; i < button_list.Count; i++)
            {
                Button bt = ct.btn((btnSet)button_list[i]);
                pn01.Controls.Add(bt);
            }
        }
        private void btn_Click(object o , EventArgs e)
        {
            this.Visible = false;
            main 메인 = new main();
            메인.Show();
        }
    }
}
