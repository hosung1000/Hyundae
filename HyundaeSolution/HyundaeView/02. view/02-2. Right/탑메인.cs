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
        Panel pn01, pn02, pn03, pn04, pn05, pn06, pn07, pn08, pn09;
        ListView lv;
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
            pn01list();
            pn02list();
            pn03list();
            pn04list();
            pn05list();
            pn06list();
            pn07list();
            pn08list();
            pn09list();
        }
        //선
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
        //버튼 사진 넣을 예정
        private void pn01list()
        {
            pnSet pn1 = new pnSet(this, 660, 230, 100, 70);
            Panel pn01 = ct.panel(pn1);
            pn01.BackColor = Color.FromArgb(241, 141, 0);
            Controls.Add(pn01);

            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "계약통합조회", "계약통합조회", 132, 230, 0, 0, btn_Click));
            btn_list.Add(new btnSet(this, "계약고객등록/조회", "고객등록/조회", 132, 230, 132, 0, btn_Click));
            btn_list.Add(new btnSet(this, "결제하기", "결제하기", 132, 230, 264, 0, btn_Click));
            btn_list.Add(new btnSet(this, "미정", "미정", 132, 230, 396, 0, btn_Click));
            btn_list.Add(new btnSet(this, "미정", "미정", 132, 230, 528, 0, btn_Click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.BackColor = Color.FromArgb(241, 141, 0);
                btn.ForeColor = Color.Beige;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                pn01.Controls.Add(btn);
            }
        }
        private void btn_Click(object o, EventArgs e)
        {

        }

        //사진 넣을 예정
        private void pn02list()
        {
            pnSet pn2 = new pnSet(this, 440, 230, 780, 70);
            Panel pn02 = ct.panel(pn2);
            pn02.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn02);
        }

        private void pn03list()
        {
            pnSet pn3 = new pnSet(this, 360, 230, 100, 320);
            Panel pn03 = ct.panel(pn3);
            pn03.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn03);
        }

        private void pn04list()
        {
            pnSet pn4 = new pnSet(this, 360, 230, 480, 320);
            Panel pn04 = ct.panel(pn4);
            pn04.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn04);
        }

        //공지사항
        private void pn05list()
        {
            pnSet pn5 = new pnSet(this, 360, 230, 860, 320);
            Panel pn05 = ct.panel(pn5);
            pn05.BackColor = Color.White;
            pn05.BorderStyle = BorderStyle.None;
            Controls.Add(pn05);

            TabControl tc1 = new TabControl();
            TabPage tp1 = new TabPage();
            TabPage tp2 = new TabPage();

            tc1.Controls.Add(tp1);
            tc1.Controls.Add(tp2);
            tc1.Location = new Point(10, 40);
            tc1.Size = new Size(340, 180);
            tc1.TabIndex = 0;
            tc1.Name = "공지사항";

            tp1.Size = new Size(340, 180);
            tp1.Text = "전사공지";
            tp1.UseVisualStyleBackColor = true;

            tp2.Size = new Size(340, 180);
            tp2.Text = "점포공지";
            tp2.UseVisualStyleBackColor = true;

            lbSet lb = new lbSet(this, "공지사항", "공지사항", 100, 15, 10, 20, 10);
            Label lb1 = ct.lable(lb);


            btnSet btn = new btnSet(this, "전체보기", "전체보기>", 90, 25, 250, 15, pn05전체보기_click);
            Button btn1 = ct.btn((btnSet)btn);
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.FlatAppearance.BorderSize = 0;
            pn05.Controls.Add(lb1);
            pn05.Controls.Add(tc1);
            pn05.Controls.Add(btn1);

        }
        private void pn05전체보기_click(object o, EventArgs e)
        {

        }

        //추천상품
        private void pn06list()
        {
            pnSet pn6 = new pnSet(this, 360, 180, 100, 570);
            Panel pn06 = ct.panel(pn6);
            pn06.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn06);
        }

        //미정
        private void pn07list()
        {
            pnSet pn7 = new pnSet(this, 360, 230, 480, 570);
            Panel pn07 = ct.panel(pn7);
            pn07.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(pn07);
        }

        //모집종사자보수교육<DB만들어야함>
        private void pn08list()
        {
            pnSet pn8 = new pnSet(this, 360, 230, 860, 570);
            Panel pn08 = ct.panel(pn8);
            pn08.BackColor = Color.White;
            Controls.Add(pn08);

            ArrayList lb_list = new ArrayList();
            lb_list.Add(new lbSet(this,"모집종사보수교육", "모집종사보수교육",180,20,10,20,10));
            for(int i = 0; i<lb_list.Count;i++)
            {
                Label lb = ct.lable((lbSet)lb_list[i]);
                pn08.Controls.Add(lb);
            }
            lvSet lv2 = new lvSet(this, "lv2", 340, 100, 10, 50, lv2_mouseClick);
            lv = ct.listview(lv2);
            lv.Font = new Font("Tahoma", 15, FontStyle.Bold);
            lv.OwnerDraw = true;
            lv.DrawColumnHeader += Lv_DrawColumnHeader;
            lv.Columns.Add("", 0, HorizontalAlignment.Center);
            lv.Columns.Add("구분", 100, HorizontalAlignment.Center);
            lv.Columns.Add("수강신청", 120, HorizontalAlignment.Center);
            lv.Columns.Add("수강기간", 120, HorizontalAlignment.Center);
            
            pn08.Controls.Add(lv);
        }

        private void Lv_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.AliceBlue, e.Bounds);
            e.DrawText();
        }

        //콜 센터 정보
        private void pn09list()
        {
            pnSet pn9 = new pnSet(this, 360, 30, 100, 770);
            Panel pn09 = ct.panel(pn9);
            pn09.BackColor = Color.White;
            Controls.Add(pn09);

            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "콜 센터 정보", "콜 센터 정보", 90, 20, 20, 10, 10));
            line_list.Add(new lbSet(this, "선", "", 1, 20, 120, 5, 1));
           
            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                if (i == 1)
                {
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.LightGray;
                }
                pn09.Controls.Add(lb);
            }
            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "주요업무안내", "주요업무안내", 90, 20, 131, 6, pn09주요업무안내_click));
            btn_list.Add(new btnSet(this, "위", "∧", 20, 20, 330, 6, pn09주요업무안내_click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                pn09.Controls.Add(btn);
            }
        }
        //콜 센터 정보 올라가기
        private void pn10list()
        {
           
        }
        //^ 클릭시 pn10list() 뜨게 해야함
        private void pn09주요업무안내_click(object o, EventArgs e)
        {
            Button btn = (Button)o;
            switch (btn.Name)
            {
                case "주요업무안내":
                    콜센터주요업무 콜센터주요업무 = new 콜센터주요업무();
                    콜센터주요업무.StartPosition = FormStartPosition.Manual;
                    콜센터주요업무.Location = new Point(690, 550);
                    콜센터주요업무.Show();
                    break;
                case "위":
                    콜센터정보 콜센터 = new 콜센터정보();
                    콜센터.StartPosition = FormStartPosition.Manual;
                    콜센터.Location = new Point(698, 730);
                    콜센터.Show();
                    break;
            }
        }
        private void lv2_mouseClick(object o, EventArgs e)
        {
          

        }

    }
}
