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
    public partial class 콜센터주요업무 : Form
    {
        _01._module.create ct = new _01._module.create();
        public 콜센터주요업무()
        {
            InitializeComponent();
            Load += 콜센터주요업무_Load;
        }

        private void 콜센터주요업무_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(660, 380);
            
            this.BackColor = Color.White;
            //페이지 상단 컨트롤바
            this.ControlBox = false;
            lblist();
            pn01list();
            pn02list();
            pn03list();
            pn04list();
            btn();
        }
        private void lblist()
        {
            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "사고접수및상담", "＊사고접수 및 상담 < 1588-5656 >", 200, 15, 20, 10, 9));
            label_list.Add(new lbSet(this, "대출콜센터", "＊대출 콜센터 < 1588-5655 >", 200, 15, 335, 10, 9));
            label_list.Add(new lbSet(this, "전산장애접수", "＊전산장애접수 < 02-2628-4567 >", 200, 15, 20, 230, 9));
            label_list.Add(new lbSet(this, "영업지원콜센터", "＊영업지원 콜센터 < 1588-5657 >", 200, 15, 335, 180, 9));
            label_list.Add(new lbSet(this, "교차업무지원센터", "＊교차업무지원센터 < 1588-5658 >", 200, 15, 335, 305, 9));
            for (int i = 0; i < label_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)label_list[i]);
            }
        }
        private void pn01list()
        {
            pnSet pn1 = new pnSet(this, 300, 200, 20, 25);
            Panel pn01 = ct.panel(pn1);
            pn01.BackColor = Color.LightGray;
            Controls.Add(pn01);

            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "1", "①자동차 고장출동 요청", 200, 15, 10, 10 + 20, 9));
            label_list.Add(new lbSet(this, "2", "②차동차 사고 접수", 200, 15, 10, 25 + 20, 9));
            label_list.Add(new lbSet(this, "3", "③보험 신규 가입 상담", 200, 15, 10, 40 + 20, 9));
            label_list.Add(new lbSet(this, "2", "④질병, 상해사고접수 및 보험금 청구", 200, 15, 10, 55 + 20, 9));
            label_list.Add(new lbSet(this, "2", "⑤질병, 상해, 화재보험 조회, 변경, 해지", 200, 15, 10, 70 + 20, 9));
            label_list.Add(new lbSet(this, "2", "⑥자동차보험, 조회, 변경, 해지", 200, 15, 10, 85 + 20, 9));
            label_list.Add(new lbSet(this, "2", "⑦대출, 상담, 퇴직연금, 펀드 문의", 200, 15, 10, 100 + 20, 9));
            label_list.Add(new lbSet(this, "2", "⑧증명서 FAX 직접 발급", 200, 15, 10, 115 + 20, 9));
            label_list.Add(new lbSet(this, "2", "ⓞ고객불편 접수 및 ARS 이용요금 안내, 상담사 연결", 300, 15, 10, 130 + 20, 9));

            for (int i = 0; i < label_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)label_list[i]);
                pn01.Controls.Add(lb);
            }
        }
        private void pn02list()
        {
            pnSet pn2 = new pnSet(this, 300, 150, 340, 25);
            Panel pn02 = ct.panel(pn2);
            pn02.BackColor = Color.LightGray;
            Controls.Add(pn02);
            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "1", "①장기보험 계약대출 ARS신청", 200, 15, 10, 10 + 20, 9));
            label_list.Add(new lbSet(this, "2", "②장기보험 계약대출 신청", 200, 15, 10, 25 + 20, 9));
            label_list.Add(new lbSet(this, "3", "③일반대출(아피트담보 등)", 200, 15, 10, 40 + 20, 9));
            label_list.Add(new lbSet(this, "2", "④대출원리금 및 이자 상환", 200, 15, 10, 55 + 20, 9));
            label_list.Add(new lbSet(this, "2", "⑤개인정보조회동의 인증번호 입력", 200, 15, 10, 70 + 20, 9));
            label_list.Add(new lbSet(this, "2", "ⓞ상담사 연결", 200, 15, 10, 85 + 20, 9));

            for (int i = 0; i < label_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)label_list[i]);
                pn02.Controls.Add(lb);
            }

        }
        private void pn03list()
        {
            pnSet pn3 = new pnSet(this, 300, 70, 20, 245);
            Panel pn03 = ct.panel(pn3);
            pn03.BackColor = Color.LightGray;
            Controls.Add(pn03);
            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "1", "①전산 장애관련 문의 시 ARS를 통한 답변", 200, 15, 10, 10+10, 9));
            label_list.Add(new lbSet(this, "2", "②전산 장애관련 오류 시 상담사 연결을 통한 답변", 200, 15, 10, 25+10, 9));
            for (int i = 0; i < label_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)label_list[i]);
                pn03.Controls.Add(lb);
            }
        }
        private void pn04list()
        {
            pnSet pn4 = new pnSet(this, 300, 100, 340, 195);
            Panel pn04 = ct.panel(pn4);
            pn04.BackColor = Color.LightGray;
            Controls.Add(pn04);
            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "1", "①하이플래너 요청 보험료 안내 및 가입설계 상담", 300, 15, 10, 10 + 10, 9));
            label_list.Add(new lbSet(this, "2", "②하이플래너 요청 지급 및 업무지원(카드승인 등)", 300, 15, 10, 25 + 10, 9));
            for (int i = 0; i < label_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)label_list[i]);
                pn04.Controls.Add(lb);
            }
        }
        private void btn()
        {
            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "닫기", "닫기", 50, 30,590, 330, btn_Click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
            }
        }
        private void btn_Click(object o, EventArgs e)
        {
            this.Close();
        }
    }
}
