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
    public partial class 콜센터정보 : Form
    {
        _01._module.create ct = new _01._module.create();
        public 콜센터정보()
        {
            InitializeComponent();
            Load += 콜센터정보_Load;
        }

        private void 콜센터정보_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(360,230);
            this.FormBorderStyle = FormBorderStyle.None;
            콜센터정보안내();
        }
        private void 콜센터정보안내()
        {
            pnSet pn9 = new pnSet(this, 360, 230, 0, 0);
            Panel pn09 = ct.panel(pn9);
            pn09.BackColor = Color.White;
            Controls.Add(pn09);

            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "콜 센터 정보", "콜 센터 정보", 90, 20, 20, 10, 10));
            line_list.Add(new lbSet(this, "선", "", 1, 20, 120, 5, 1));
            line_list.Add(new lbSet(this, "전산장애접수", "·전산장애접수", 90, 20, 135, 80, 9));
            line_list.Add(new lbSet(this, "사고접수및상담", "·사고접수및상담", 100, 20, 135, 110, 9));
            line_list.Add(new lbSet(this, "영업지원콜센터", "·영업지원콜센터", 90, 20, 135, 140, 9));
            line_list.Add(new lbSet(this, "대출콜센터", "·대출콜센터", 90, 20, 135, 170, 9));
            line_list.Add(new lbSet(this, "교차업무지원센터", "·교차업무지원센터", 120, 20, 135, 200, 9));
            line_list.Add(new lbSet(this, "번호1", "02)2628-4567", 90, 20, 260, 80, 9));
            line_list.Add(new lbSet(this, "번호2", "1588-5656", 90, 20, 260, 110, 9));
            line_list.Add(new lbSet(this, "번호3", "1588-5657", 90, 20, 260, 140, 9));
            line_list.Add(new lbSet(this, "번호4", "1588-5655", 90, 20, 260, 170, 9));
            line_list.Add(new lbSet(this, "번호5", "1577-5658", 90, 20, 260, 200, 9));
            line_list.Add(new lbSet(this, "선", "", 225,1 , 135, 95+5, 1));
            line_list.Add(new lbSet(this, "선", "", 225, 1, 135, 125 + 5, 1));
            line_list.Add(new lbSet(this, "선", "", 225, 1, 135, 155 + 5, 1));
            line_list.Add(new lbSet(this, "선", "", 225, 1, 135, 185 + 5, 1));
           

            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                if (i == 1 || i>11)
                {
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.LightGray;
                }
                pn09.Controls.Add(lb);
            }
            ArrayList btn_list = new ArrayList();
            btn_list.Add(new btnSet(this, "주요업무안내", "주요업무안내", 90, 20, 131, 6, pn09주요업무안내_click));
            btn_list.Add(new btnSet(this, "위", "X", 20, 20, 330, 6, pn09주요업무안내_click));
            for (int i = 0; i < btn_list.Count; i++)
            {
                Button btn = ct.btn((btnSet)btn_list[i]);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                pn09.Controls.Add(btn);
            }
        }
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
                    this.Close();
                    break;
            }
        }
    }
}
