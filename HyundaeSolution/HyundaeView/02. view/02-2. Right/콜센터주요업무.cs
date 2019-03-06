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
            lblist();
            pn01list();
            pn02list();
            pn03list();
            pn04list();
        }
        private void lblist()
        {
            ArrayList label_list = new ArrayList();
            label_list.Add(new lbSet(this, "사고접수및상담", "＊사고접수 및 상담", 200, 15, 20, 10, 9));
            label_list.Add(new lbSet(this, "대출콜센터", "＊대출 콜센터", 200, 15, 335, 10, 9));
            label_list.Add(new lbSet(this, "전산장애접수", "＊전산장애접수", 200, 15, 20, 230, 9));
            label_list.Add(new lbSet(this, "영업지원콜센터", "＊영업지원 콜센터", 200, 15, 335, 180, 9));
            label_list.Add(new lbSet(this, "교차업무지원센터", "＊교차업무지원센터", 200, 15, 335, 300, 9));
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
        }
        private void pn02list()
        {
            pnSet pn2 = new pnSet(this, 300, 150, 340, 25);
            Panel pn02= ct.panel(pn2);
            pn02.BackColor = Color.LightGray;
            Controls.Add(pn02);
        }
        private void pn03list()
        {
            pnSet pn3 = new pnSet(this, 300, 70, 20, 245);
            Panel pn03 = ct.panel(pn3);
            pn03.BackColor = Color.LightGray;
            Controls.Add(pn03);
        }
        private void pn04list()
        {
            pnSet pn4 = new pnSet(this, 300, 100, 340, 195);
            Panel pn04 = ct.panel(pn4);
            pn04.BackColor = Color.LightGray;
            Controls.Add(pn04);
        }
    }
}
