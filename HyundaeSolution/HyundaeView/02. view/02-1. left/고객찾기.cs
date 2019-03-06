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


namespace HyundaeView._02._view._02_1._left
{
    public partial class 고객찾기 : Form
    {
        _01._module.create ct = new _01._module.create();
        ComboBox cb;
        ListView lv;
        public 고객찾기()
        {
            InitializeComponent();
            
            Load += 고객찾기_Load;
        }
        string a = string.Format("·이름,휴대폰번호,주민등록번호 중 하나의 고객정보만으로도 검색 가능합니다.");
        string b = string.Format("※ 휴대폰 번호는 뒤의 4자리 숫자만 입력해도 검색 가능");
        private void 고객찾기_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(550, 1020);
            BackColor = Color.White;
            lblist();
            linelist();
            richlist();
            btnlist();
            lvlist();
         
        }
        //버튼 이벤트
        private void B_Click(object o , EventArgs e)
        {
            Button btn = (Button)o;
            switch(btn.Name)
            {
                case "X버튼":
                    고객찾기 고찾 = new 고객찾기();
                    고찾.Close();
                    break;
            }
        }
        private void lv2_mouseClick(object o, EventArgs e)
        {
            //클릭시 높이 늘리기.
            
        }
        //라벨
        private void lblist()
        {
            //label 배열에 담아서 반복문 실행 후 출력
            ArrayList content_list = new ArrayList();
            content_list.Add(new lbSet(this, "고객찾기", "고객찾기", 250, 20, 10, 40, 15));
            content_list.Add(new lbSet(this, "설명", a, 530, 10, 10, 100, 8));
            content_list.Add(new lbSet(this, "이름", "이름", 100, 30, 10, 121, 9));
            content_list.Add(new lbSet(this, "휴대폰번호", "휴대폰번호", 100, 60, 10, 152, 9));
            content_list.Add(new lbSet(this, "주민등록번호", "주민등록번호", 100, 30, 10, 213, 9));
            content_list.Add(new lbSet(this, "하이플래너", "하이플래너", 100, 30, 10, 244, 9));
            content_list.Add(new lbSet(this, "휴대폰번호입력", b, 330, 12, 120, 190, 9));

            for (int i = 0; i < content_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)content_list[i]);
                if (i > 1 && i < 6)
                {
                    lb.TextAlign = ContentAlignment.MiddleLeft;
                    lb.BorderStyle = BorderStyle.FixedSingle;
                    lb.BackColor = Color.SkyBlue;
                }
                else if (i > 6)
                {
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.SkyBlue;
                }


            }

        }
        //라인
        private void linelist()
        {
            //선에 관련된 부분(label 로 선을 표현)
            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 70, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 120, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 151, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 212, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 243, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 274, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 350, 1));

            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                lb.BorderStyle = BorderStyle.None;
                if (i == 0 || i == 6) lb.BackColor = Color.Red;
                else lb.BackColor = Color.Gray;
            }
        }
        //리치박스
        private void richlist()
        {
            //richtextbox 배열에 담아서 반복문 실행 후 출력
            ArrayList rich_list = new ArrayList();
            rich_list.Add(new richBoxSet(this, "이름", 140, 26, 120, 123));
            rich_list.Add(new richBoxSet(this, "휴대폰앞", 80, 26, 120, 155));
            rich_list.Add(new richBoxSet(this, "휴대폰중간", 80, 26, 215, 155));
            rich_list.Add(new richBoxSet(this, "휴대폰끝", 80, 26, 300, 155));
            rich_list.Add(new richBoxSet(this, "주민등록번호", 160, 26, 120, 215));
            //rich_list.Add();
            for (int i = 0; i < rich_list.Count; i++)
            {
                RichTextBox rc = ct.richbox((richBoxSet)rich_list[i]);
                rc.BorderStyle = BorderStyle.FixedSingle;
                rc.BackColor = Color.Chocolate;
                rc.SelectionFont = new Font("Tahoma", 9, FontStyle.Bold);
            }
        }
        //버튼
        private void btnlist()
        {
            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "조회", "조회", 50, 25, 490, 300, B_Click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
            }
        }
        //리스트뷰
        private void lvlist()
        {
            lvSet lv2 = new lvSet(this, "lv2", 530, 35, 10, 351, lv2_mouseClick);
            lv = ct.listview(lv2);
            lv.Font = new Font("Tahoma", 15, FontStyle.Bold);
            lv.Columns.Add("", 0, HorizontalAlignment.Center);
            lv.Columns.Add("구분", 80, HorizontalAlignment.Center);
            lv.Columns.Add("이름", 80, HorizontalAlignment.Center);
            lv.Columns.Add("주민번호", 160, HorizontalAlignment.Center);
            lv.Columns.Add("계약조회", 80, HorizontalAlignment.Center);
            lv.Columns.Add("휴대전화번호", 130, HorizontalAlignment.Center);
            lv.ForeColor = Color.SkyBlue;
        }
    }
}
