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
    public partial class 개인고객_고객등록_계약고객 : Form
    {
        _01._module.create ct = new _01._module.create();
        public 개인고객_고객등록_계약고객()
        {
            Load += 개인고객_고객등록_계약고객_Load;
        }

        private void 개인고객_고객등록_계약고객_Load(object sender, EventArgs e)
        {
            //화면 사이즈
            ClientSize = new Size(1320, 890);
            //페이지 이름 지정
            this.Text = "계약고객등록/조회";
            textlist();
            linelist();
            labellist();
            buttonlist();
            comboboxlist();

        }
        //라인리스트
        private void linelist()
        {
            //선에 관련된 부분(label 로 선을 표현)
            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "선", "", 1120, 2, 100, 30, 1)); //0
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 61, 1));
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 102, 1)); //2
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 132, 1));
            line_list.Add(new lbSet(this, "선", "", 1120, 1, 100, 163, 1));

            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 204, 1)); //5
            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 204, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 235, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 235, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 266, 1));

            line_list.Add(new lbSet(this, "선", "", 450, 1, 770, 266, 1)); //10
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 297, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 297, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 328, 1));
            line_list.Add(new lbSet(this, "선", "", 450, 1, 770, 328, 1));

            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 359, 1)); //15
            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 359, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 390, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 421, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 467, 1));

            line_list.Add(new lbSet(this, "선", "", 420, 1, 670, 467, 1)); //20
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 498, 1));
            line_list.Add(new lbSet(this, "선", "", 420, 1, 670, 498, 1));
            line_list.Add(new lbSet(this, "선", "", 420, 1, 670, 529, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 570, 1));

            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 570, 1)); //25
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 600, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 600, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 630, 1));
            line_list.Add(new lbSet(this, "선", "", 450, 1, 770, 630, 1));

            line_list.Add(new lbSet(this, "선", "", 550, 1, 670, 660, 1)); //30
             /*
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 700, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 731, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 762, 1));
            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 793, 1));

            line_list.Add(new lbSet(this, "선", "", 550, 1, 100, 824, 1)); //35
            */


            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                lb.BorderStyle = BorderStyle.None;
                if (i == 0 || i == 2 || i == 5 || i == 6 || i == 19 || i == 20 || i == 24 || i == 25 || i == 31) lb.BackColor = Color.Red;
                else lb.BackColor = Color.LightGray;
            }
        }
        //label 리스트
        private void labellist()
        {
            //label 배열에 담아서 반복문 실행 후 출력
            ArrayList content_list = new ArrayList();
            content_list.Add(new lbSet(this, "기본정보", "▷ 기본정보", 250, 20, 95, 80, 12));
            content_list.Add(new lbSet(this, "연락처", "＊연락처", 250, 20, 95, 204 - 18, 8));
            content_list.Add(new lbSet(this, "주소", "＊주소", 250, 20, 665, 204 - 18, 8));
            content_list.Add(new lbSet(this, "직업", "＊직업", 250, 20, 95, 467 - 18, 8));
            content_list.Add(new lbSet(this, "고객정보 취등경로", "＊고객정보 취득경로", 250, 20, 665, 467 - 18, 8));
            content_list.Add(new lbSet(this, "부가정보", "▷ 부가정보", 250, 16, 95, 570 - 38, 12));
            content_list.Add(new lbSet(this, "연락처", "＊연락처", 250, 20, 95, 570 - 18, 8));
            content_list.Add(new lbSet(this, "주소", "＊주소", 250, 20, 665, 570 - 18, 8));
            //content_list.Add(new lbSet(this, "개인(신용)정보 처리동의", "＊개인(신용)정보 처리동의", 250, 20, 95, 700 - 18, 8));
            content_list.Add(new lbSet(this, "메모", "＊메모", 250, 10, 95, 700 - 18, 8));
            content_list.Add(new lbSet(this, "세", "세", 20, 12, 750, 144, 8));
            content_list.Add(new lbSet(this, "@", "@", 20, 12, 312, 401, 9));
            content_list.Add(new lbSet(this, "급", "급", 20, 12, 240, 477, 9));

            content_list.Add(new lbSet(this, "고객검색", "고객검색", 100, 30, 100, 31, 8)); //8

            //조건문 걸어주기
            content_list.Add(new lbSet(this, "주민번호", "주민번호", 100, 30, 400, 31, 8));

            content_list.Add(new lbSet(this, "소속플래너사번", "소속플래너사번", 100, 30, 700, 31, 8));
            content_list.Add(new lbSet(this, "국적", "국적", 100, 30, 100, 103, 8));
            content_list.Add(new lbSet(this, "주민등록번호", "주민등록번호", 100, 30, 300, 103, 8));
            content_list.Add(new lbSet(this, "고객명", "고객명", 100, 30, 600, 103, 8));
            content_list.Add(new lbSet(this, "영문명", "영문명", 100, 30, 900, 103, 8));
            content_list.Add(new lbSet(this, "생년월일", "생년월일", 100, 30, 100, 133, 8));
            content_list.Add(new lbSet(this, "연령(만)", "연령(만)", 100, 30, 600, 133, 8));

            content_list.Add(new lbSet(this, "구분", "구분", 100, 30, 100, 205, 8));
            content_list.Add(new lbSet(this, "연락처", "연락처", 210, 30, 201, 205, 8));
            content_list.Add(new lbSet(this, "통신사", "통신사", 130, 30, 412, 205, 8));
            content_list.Add(new lbSet(this, "삭제", "삭제", 108, 30, 543, 205, 8));

            content_list.Add(new lbSet(this, "휴대폰1", "휴대폰1", 100, 30, 100, 236, 8));
            content_list.Add(new lbSet(this, "자택", "자택", 100, 30, 100, 267, 8));
            content_list.Add(new lbSet(this, "직장", "직장", 100, 30, 100, 298, 8));
            content_list.Add(new lbSet(this, "휴대폰2", "휴대폰2", 100, 30, 100, 329, 8));
            content_list.Add(new lbSet(this, "FAX", "FAX", 100, 30, 100, 360, 8));
            content_list.Add(new lbSet(this, "이메일", "이메일", 100, 30, 100, 391, 8));

            content_list.Add(new lbSet(this, "구분", "구분", 100, 30, 670, 205, 8));
            content_list.Add(new lbSet(this, "주소", "주소", 320, 30, 771, 205, 8));
            content_list.Add(new lbSet(this, "변경일", "변경일", 128, 30, 1092, 205, 8));

            content_list.Add(new lbSet(this, "자택", "자택", 100, 60, 670, 236, 8));
            content_list.Add(new lbSet(this, "직장", "직장", 100, 60, 670, 298, 8));

            content_list.Add(new lbSet(this, "관리사원번호", "관리사원번호", 140, 30, 670, 468, 8));
            content_list.Add(new lbSet(this, "취득경로", "취득경로", 140, 30, 811, 468, 8));
            content_list.Add(new lbSet(this, "등록일", "등록일", 140, 30, 952, 468, 8));

            content_list.Add(new lbSet(this, "구분", "구분", 100, 30, 100, 571, 8));
            content_list.Add(new lbSet(this, "기타", "기타", 100, 30, 100, 602, 8));
            content_list.Add(new lbSet(this, "연락처", "연락처", 210, 30, 201, 571, 8));
            content_list.Add(new lbSet(this, "통신사", "통신사", 130, 30, 412, 571, 8));
            content_list.Add(new lbSet(this, "삭제", "삭제", 108, 30, 543, 571, 8));

            content_list.Add(new lbSet(this, "구분", "구분", 100, 30, 670, 571, 8));
            content_list.Add(new lbSet(this, "주소", "주소", 320, 30, 771, 571, 8));
            content_list.Add(new lbSet(this, "변경일", "변경일", 128, 30, 1092, 571, 8));
            content_list.Add(new lbSet(this, "기타(한글)", "기타(한글)", 100, 60, 670, 602, 8));

            for (int i = 0; i < content_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)content_list[i]);
                if (i > 11)
                {
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.SkyBlue;
                }

            }

        }
        //textbox 리스트
        private void textlist()
        {
            ArrayList textbox_list = new ArrayList();
            textbox_list.Add(new tbSet(this, "주민등록번호", 120, 20, 510, 36));
            textbox_list.Add(new tbSet(this, "소속플래너사번", 90, 20, 810, 36));
            textbox_list.Add(new tbSet(this, "국적", 80, 20, 210, 108)); //2
            textbox_list.Add(new tbSet(this, "주민등록번호", 120, 20, 410, 108));
            textbox_list.Add(new tbSet(this, "고객명", 100, 20, 710, 108));
            textbox_list.Add(new tbSet(this, "영문명", 130, 20, 1010, 108));
            textbox_list.Add(new tbSet(this, "연령(만)", 40, 20, 710, 138));

            textbox_list.Add(new tbSet(this, "휴대폰1처음", 60, 20, 210, 241));
            textbox_list.Add(new tbSet(this, "휴대폰1중간", 60, 20, 275, 241));
            textbox_list.Add(new tbSet(this, "휴대폰1끝", 60, 20, 340, 241));

            textbox_list.Add(new tbSet(this, "휴대폰1통신사", 80, 20, 435, 241));

            textbox_list.Add(new tbSet(this, "자택처음", 60, 20, 210, 272));
            textbox_list.Add(new tbSet(this, "자택중간", 60, 20, 275, 272));
            textbox_list.Add(new tbSet(this, "자택끝", 60, 20, 340, 272));

            textbox_list.Add(new tbSet(this, "직장처음", 60, 20, 210, 303));
            textbox_list.Add(new tbSet(this, "직장중간", 60, 20, 275, 303));
            textbox_list.Add(new tbSet(this, "직장끝", 60, 20, 340, 303));

            textbox_list.Add(new tbSet(this, "휴대폰2처음", 60, 20, 210, 334));
            textbox_list.Add(new tbSet(this, "휴대폰2중간", 60, 20, 275, 334));
            textbox_list.Add(new tbSet(this, "휴대폰2끝", 60, 20, 340, 334));

            textbox_list.Add(new tbSet(this, "휴대폰2통신사", 80, 20, 435, 334));

            textbox_list.Add(new tbSet(this, "FAX처음", 60, 20, 210, 365));
            textbox_list.Add(new tbSet(this, "FAX중간", 60, 20, 275, 365));
            textbox_list.Add(new tbSet(this, "FAX끝", 60, 20, 340, 365));

            textbox_list.Add(new tbSet(this, "이메일처음", 100, 20, 210, 396));
            textbox_list.Add(new tbSet(this, "이메일끝", 100, 20, 330, 396));

            textbox_list.Add(new tbSet(this, "이메일선택", 80, 20, 435, 396));

            textbox_list.Add(new tbSet(this, "자택우편번호", 60, 20, 780, 241));
            textbox_list.Add(new tbSet(this, "자택주소버튼", 20, 20, 841, 241));
            textbox_list.Add(new tbSet(this, "자택주소상단", 250, 20, 865, 241));
            textbox_list.Add(new tbSet(this, "자택주소변경일", 95, 20, 1120, 241));
            textbox_list.Add(new tbSet(this, "자택주소하단", 250, 20, 780, 272));
            textbox_list.Add(new tbSet(this, "자택주소하단2", 180, 20, 1035, 272));

            textbox_list.Add(new tbSet(this, "직장우편번호", 60, 20, 780, 303));
            textbox_list.Add(new tbSet(this, "직장주소버튼", 20, 20, 841, 303));
            textbox_list.Add(new tbSet(this, "직장주소상단", 250, 20, 865, 303));
            textbox_list.Add(new tbSet(this, "직장주소변경일", 95, 20, 1120, 303));
            textbox_list.Add(new tbSet(this, "직장주소하단", 250, 20, 780, 334));
            textbox_list.Add(new tbSet(this, "직장주소하단2", 180, 20, 1035, 334));

            textbox_list.Add(new tbSet(this, "직업코드", 60, 20, 110, 473));
            textbox_list.Add(new tbSet(this, "직업코드버튼", 20, 20, 171, 473));
            textbox_list.Add(new tbSet(this, "급수", 40, 20, 195, 473));
            textbox_list.Add(new tbSet(this, "직업명", 250, 20, 260, 473));

            //420, 1, 670, 467, 1
            textbox_list.Add(new tbSet(this, "관리사번호코드", 70, 20, 687, 503));
            textbox_list.Add(new tbSet(this, "관리사번호버튼", 20, 20, 758, 503));
            textbox_list.Add(new tbSet(this, "취득경로", 120, 20, 821, 503));
            textbox_list.Add(new tbSet(this, "등록일", 100, 20, 975, 503));

            //550, 1, 100, 600, 1
            textbox_list.Add(new tbSet(this, "기타연락처처음", 60, 20, 210, 605));
            textbox_list.Add(new tbSet(this, "기타연락처중간", 60, 20, 275, 605));
            textbox_list.Add(new tbSet(this, "기타연락처끝", 60, 20, 340, 605));

            textbox_list.Add(new tbSet(this, "기타연락처통신사", 80, 20, 435, 605));

            //550, 1, 100, 670, 1
            textbox_list.Add(new tbSet(this, "자택우편번호", 60, 20, 780, 605));
            textbox_list.Add(new tbSet(this, "자택주소버튼", 20, 20, 841, 605));
            textbox_list.Add(new tbSet(this, "자택주소상단", 250, 20, 865, 605));
            textbox_list.Add(new tbSet(this, "자택주소변경일", 95, 20, 1120, 605));
            textbox_list.Add(new tbSet(this, "자택주소하단", 250, 20, 780, 636));
            textbox_list.Add(new tbSet(this, "자택주소하단2", 180, 20, 1035, 636));

            textbox_list.Add(new tbSet(this, "메모", 550, 125, 100, 700));
            for (int i = 0; i < textbox_list.Count; i++)
            {
                TextBox tb = ct.txtbox((tbSet)textbox_list[i]);
            }
        }
        //button 리스트
        private void buttonlist()
        {
            ArrayList btn_list = new ArrayList();
            // 90, 20, 810, 36
            btn_list.Add(new btnSet(this, "조회", "조회", 50, 20, 1165, 36,조회클릭));
            btn_list.Add(new btnSet(this, "초기화", "초기화", 60, 25, 1035, 795, 초기화));
            btn_list.Add(new btnSet(this, "저장", "저장", 60, 25, 1100, 795, 저장));
            btn_list.Add(new btnSet(this, "닫기", "닫기", 60, 25, 1165, 795, 닫기));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.FlatStyle = FlatStyle.Flat;
                if(i>0)
                {
                   btn.Font = new Font("Tahoma",11F, FontStyle.Regular);
                }
            }
        }
        //콤보박스 리스트
        private void comboboxlist()
        {

        }
        private void 조회클릭(object o , EventArgs e)
        {

        }
        private void 초기화(object o, EventArgs e)
        {

        }
        private void 저장(object o, EventArgs e)
        {

        }
        private void 닫기(object o, EventArgs e)
        {

        }

    }
}
