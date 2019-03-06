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

namespace HyundaeView._02._view._02_2._Right
{
    public partial class 탑메인 : Form
    {
        _01._module.create ct = new _01._module.create();
        Panel pn01, pn02, pn03, pn04, pn05, pn06, pn07, pn08;
        public 탑메인()
        {
            InitializeComponent();
            Load += 탑메인_Load;
        }

        private void 탑메인_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(1320, 890);
            this.Text = "탑메인";
            linelist();
            panellist();
            pn01list();



        }
        private void linelist()
        {
            //선에 관련된 부분(label 로 선을 표현)
            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 50, 1)); 
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 820, 1)); 
            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                lb.BorderStyle = BorderStyle.None;
                lb.BackColor = Color.LightGray;
            }
        }
        private void panellist()
        {
           

            pnSet pn2 = new pnSet(this, 440, 230, 780, 70);
            Panel pn02 = ct.panel(pn2);
            pn02.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn02);

            pnSet pn3 = new pnSet(this, 360, 230, 100, 320);
            Panel pn03 = ct.panel(pn3);
            pn03.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn03);

            pnSet pn4 = new pnSet(this, 360, 230, 480, 320);
            Panel pn04 = ct.panel(pn4);
            pn04.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn04);

            pnSet pn5 = new pnSet(this, 360, 230, 860, 320);
            Panel pn05 = ct.panel(pn5);
            pn05.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn05);

            pnSet pn6 = new pnSet(this, 360, 230, 100, 570);
            Panel pn06 = ct.panel(pn6);
            pn06.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn06);

            pnSet pn7 = new pnSet(this, 360, 230, 480, 570);
            Panel pn07 = ct.panel(pn7);
            pn07.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn07);

            pnSet pn8 = new pnSet(this, 360, 230, 860, 570);
            Panel pn08 = ct.panel(pn8);
            pn08.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn08);

          
        }
        private void pn01list()
        {
            pnSet pn1 = new pnSet(this, 660, 230, 100, 70);
            Panel pn01 = ct.panel(pn1);
            pn01.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn01);

            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "고객찾기및등록", "고객찾기및등록", 132, 230, 0, 0, btn_Click));
            btn_list.Add(new btnSet(this, "결제하기", "결제하기", 132, 230, 132, 0, btn_Click));
            btn_list.Add(new btnSet(this, "미정", "미정", 132, 230, 264, 0, btn_Click));
            btn_list.Add(new btnSet(this, "미정", "미정", 132, 230, 396, 0, btn_Click));
            btn_list.Add(new btnSet(this, "미정", "미정", 132, 230, 528, 0, btn_Click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.BackColor = Color.FromArgb(255, 102, 2);
                btn.ForeColor = Color.Beige;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                pn01.Controls.Add(btn);
            }
        }
        private void btn_Click(object o, EventArgs e)
        {

        }
    }
}
