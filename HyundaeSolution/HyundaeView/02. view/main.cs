using HyundaeView._01._module;
using HyundaeView._02._view._02_1._left;
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
        Panel Leftpage , top , Left;

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
            this.WindowState = FormWindowState.Maximized;
            //화면 시작 위치 지정
            StartPosition = FormStartPosition.Manual;
            Location = new Point(-10, 0);
            //MID
            this.IsMdiContainer = true;
            //페이지 상단 컨트롤바
            this.ControlBox = true;
            //테두리 설정
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            Sidepage();
        }
       private void Sidepage()
        {
            pnSet pn1 = new pnSet(this, 50, 1020, 0, 0);
            Panel Left = ct.panel(pn1);
            Left.BackColor = Color.FromArgb(255, 102, 2);
            Controls.Add(Left);

            pnSet pn2 = new pnSet(this, 550, 1020, 50, 130);
            Leftpage = ct.panel(pn2);
            Controls.Add(Leftpage);

            pnSet pn3 = new pnSet(this, 1870, 130, 50, 0);
            Panel top = ct.panel(pn3);
            top.BackColor = Color.Beige;
            Controls.Add(top);

            //지금은 하드코딩으로 해놨는데 이미지버튼으로 대체 해야함
            ArrayList Btn_list = new ArrayList();
            Btn_list.Add(new btnSet(this, "해야할업무", "해야할 업무", 50, 102, 0, 150, B_Click));
            Btn_list.Add(new btnSet(this, "고객찾기", "고객 찾기", 50, 102, 0, 252, B_Click));
            Btn_list.Add(new btnSet(this, "개인정보동의", "개인 정보 동의", 50, 102, 0, 354, B_Click));
            Btn_list.Add(new btnSet(this, "장기업무지원", "장기 업무 지원", 50, 102, 0, 456, B_Click));
            Btn_list.Add(new btnSet(this, "영업지원자료", "영업 지원 자료", 50, 102, 0, 558, B_Click));
            Btn_list.Add(new btnSet(this, "보상진행현황", "보상 진행 현황", 50, 102, 0, 660, B_Click));
            Btn_list.Add(new btnSet(this, "링크", "링크", 50, 102, 0, 762, B_Click));
           

            for(int i = 0; i<Btn_list.Count;i++)
            {
                Button btn = ct.btn((btnSet)Btn_list[i]);
                btn.BackColor = Color.FromArgb(255, 102, 2);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                Left.Controls.Add(btn);
            }          
        }

        void Sidepage2()
        {
            pnSet pn2 = new pnSet(this, 550, 1020, 50, 130);
            Leftpage = ct.panel(pn2);
            Controls.Add(Leftpage);
        }
        private void B_Click(object o, EventArgs e)
        {
            Button btn = (Button)o;
            switch(btn.Name)
            {
                case "해야할업무":
                    해야할업무 해무 = new 해야할업무();
                    해무.MdiParent = this;
                    해무.WindowState = FormWindowState.Maximized;
                    해무.FormBorderStyle = FormBorderStyle.None;
                    //Sidepage2();
                    Leftpage.Controls.Add(해무);
                    해무.Show();
                    break;

                case "고객찾기":
                    고객찾기 고객 = new 고객찾기();
                    고객.MdiParent = this;
                    고객.WindowState = FormWindowState.Maximized;
                    고객.FormBorderStyle = FormBorderStyle.None;
                    //Sidepage2();
                    Leftpage.Controls.Add(고객);
                    고객.Show();
                    break;
            }
        }
    }
}
