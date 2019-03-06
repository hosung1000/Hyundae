using HyundaeView._01._module;
using HyundaeView._02._view._02_1._left;
using HyundaeView._02._view._02_2._Right;
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

namespace HyundaeView._02._view
{
    public partial class main : Form
    {
        _01._module.create ct = new _01._module.create();
        Panel Leftpage, top, Left, Toppage;

        public main()
        {
            InitializeComponent();
            Load += MainMDI_Load;
        }

        private void MainMDI_Load(object sender, EventArgs e)
        {
            //페이지 이름 지정
            this.Text = "현대해상 영업포탈";

            //페이지 아이콘 지정
            //하단 작업줄 아이콘 지정

            //전체 사이즈 지정
            ClientSize = new Size(1920, 1020);
            
            //화면 시작 위치 지정
            StartPosition = FormStartPosition.Manual;
            Location = new Point(-10, 0);
            //MID
            this.IsMdiContainer = true;
            //페이지 상단 컨트롤바
            this.ControlBox = true;
            //테두리 설정
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Sidepage();
           
        }
        private void Sidepage()
        {
            //가장 왼쪽
            pnSet pn1 = new pnSet(this, 50, 1020, 0, 0);
            Panel Left = ct.panel(pn1);
            Left.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(Left);

            //가장 왼쪽 버튼 클릭시 나오는 폼<MDI>
            pnSet pn2 = new pnSet(this, 550, 1020, 50, 0);
            Leftpage = ct.panel(pn2);
            Controls.Add(Leftpage);

            //가장 위쪽
            pnSet pn3 = new pnSet(this, 1320, 130, 600, 0);
            Panel top = ct.panel(pn3);
            top.BackColor = Color.Beige;
            Controls.Add(top);

            //가장 위쪽 버튼 클릭스 나오는 폼<MDI>
            pnSet pn4 = new pnSet(this, 1320, 890, 600, 130);
            Toppage = ct.panel(pn4);
            Controls.Add(Toppage);

            고객찾기 고찾 = new 고객찾기();
            고찾.MdiParent = this;
            고찾.WindowState = FormWindowState.Maximized;
            고찾.FormBorderStyle = FormBorderStyle.None;
            Leftpage.Controls.Add(고찾);
            고찾.Show();


            탑메인 탑메인 = new 탑메인();
            탑메인.MdiParent = this;
            탑메인.WindowState = FormWindowState.Maximized;
            탑메인.FormBorderStyle = FormBorderStyle.None;
            Toppage.Controls.Add(탑메인);
            탑메인.Show();

            //가장 왼쪽 버튼 항목들
            //지금은 하드코딩으로 해놨는데 이미지버튼으로 대체 해야함
            ArrayList LBtn_list = new ArrayList();
            LBtn_list.Add(new btnSet(this, "고객찾기", "고객 찾기", 50, 102, 0, 252, LB_Click));
            LBtn_list.Add(new btnSet(this, "개인정보동의", "개인 정보 동의", 50, 102, 0, 354, LB_Click));
            LBtn_list.Add(new btnSet(this, "장기업무지원", "장기 업무 지원", 50, 102, 0, 456, LB_Click));
            LBtn_list.Add(new btnSet(this, "영업지원자료", "영업 지원 자료", 50, 102, 0, 558, LB_Click));
            LBtn_list.Add(new btnSet(this, "보상진행현황", "보상 진행 현황", 50, 102, 0, 660, LB_Click));
            LBtn_list.Add(new btnSet(this, "링크", "링크", 50, 102, 0, 762, LB_Click));


            for (int i = 0; i < LBtn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)LBtn_list[i]);
                btn.BackColor = Color.FromArgb(255, 102, 2);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                Left.Controls.Add(btn);
            }

            // 가장 위쪽 버튼 항목들
            ArrayList TBtn_list = new ArrayList();
            TBtn_list.Add(new btnSet(this, "메인", "메인", 30, 25, 90, 105, TB_Click));
            TBtn_list.Add(new btnSet(this, "고객", "고객", 50, 30, 180, 70, TB_Click));

            for (int i = 0; i < TBtn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)TBtn_list[i]);
                btn.BackColor = Color.FromArgb(255, 102, 2);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                top.Controls.Add(btn);
            }

        }
        //가장 왼쪽 버튼 클릭시 이벤트
        private void LB_Click(object o, EventArgs e)
        {
            Button btn = (Button)o;
            switch (btn.Name)
            {
                case "해야할업무":
                    해야할업무 해무 = new 해야할업무();
                    해무.MdiParent = this;
                    해무.WindowState = FormWindowState.Maximized;
                    해무.FormBorderStyle = FormBorderStyle.None;
                    Leftpage.Controls.Add(해무);
                    해무.Show();
                    break;

                case "고객찾기":
                    고객찾기 고객 = new 고객찾기();
                    고객.MdiParent = this;
                    고객.WindowState = FormWindowState.Maximized;
                    고객.FormBorderStyle = FormBorderStyle.None;
                    Leftpage.Controls.Add(고객);
                    고객.Show();
                    break;
            }
        }
        //가장 위쪽 버튼 클릭시 이벤트
        private void TB_Click(object o, EventArgs e)
        {
            Button btn = (Button)o;
            switch (btn.Name)
            {
                case "메인":
                    탑메인 탑메인 = new 탑메인();
                    탑메인.MdiParent = this;
                    탑메인.WindowState = FormWindowState.Maximized;
                    탑메인.FormBorderStyle = FormBorderStyle.None;
                    Toppage.Controls.Add(탑메인);
                    탑메인.Show();
                    break;
                case "고객":
                    개인고객_고객등록_계약고객 고객1 = new 개인고객_고객등록_계약고객();
                    고객1.MdiParent = this;
                    고객1.WindowState = FormWindowState.Maximized;
                    고객1.FormBorderStyle = FormBorderStyle.None;
                    Toppage.Controls.Add(고객1);
                    고객1.Show();
                    break;
            }
        }

        private void leftmdi()
        {
           
        }

        private void rightmdi()
        {
          
        }
    }
}
