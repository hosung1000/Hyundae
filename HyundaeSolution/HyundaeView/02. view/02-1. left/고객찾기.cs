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
        public 고객찾기()
        {
            InitializeComponent();
            
            Load += 고객찾기_Load;
        }

        private void 고객찾기_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(550, 1020);
            string a = string.Format("·이름,휴대폰번호,주민등록번호 중 하나의 고객정보만으로도 검색 가능합니다.");
            string b = string.Format("※ 휴대폰 번호는 뒤의 4자리 숫자만 입력해도 검색 가능");
            ArrayList content_list = new ArrayList();
            content_list.Add(new lbSet(this, "고객찾기", "고객찾기", 250, 20, 10, 40, 15));
            content_list.Add(new lbSet(this, "설명", a, 530, 10, 10, 100, 8));
            content_list.Add(new lbSet(this, "이름", "이름", 100, 30, 10, 121, 9));
            content_list.Add(new lbSet(this, "휴대폰번호", "휴대폰번호", 100, 60, 10, 152, 9));
            content_list.Add(new lbSet(this, "주민등록번호", "주민등록번호", 100, 30, 10, 213, 9));
            content_list.Add(new lbSet(this, "하이플래너", "하이플래너", 100, 30, 10, 244, 9));
            content_list.Add(new lbSet(this, "휴대폰번호입력",b, 330, 12, 120, 190, 9));

            for (int i = 0; i<content_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)content_list[i]);
                if(i>1 && i<6)
                {
                    lb.TextAlign = ContentAlignment.MiddleLeft;
                    lb.BorderStyle = BorderStyle.None;
                    lb.BackColor = Color.SkyBlue;
                }

            }

            ArrayList line_list = new ArrayList();
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 70, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 120, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 151, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 212, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 243, 1));
            line_list.Add(new lbSet(this, "선", "", 530, 1, 10, 274, 1));
           
            for (int i = 0; i < line_list.Count; i++)
            {
                Label lb = ct.lable((lbSet)line_list[i]);
                lb.BorderStyle = BorderStyle.None;
                if (i == 0)lb.BackColor = Color.Red;
                else lb.BackColor = Color.Gray;
            }

            ArrayList rich_list = new ArrayList();
            rich_list.Add(new richBoxSet(this,"이름",140,26,120,123));
            rich_list.Add(new richBoxSet(this,"휴대폰중간",80,26,215,155));
            rich_list.Add(new richBoxSet(this, "휴대폰중간", 80, 26, 300, 155));
            rich_list.Add(new richBoxSet(this, "주민등록번호", 160, 26, 120, 215));
            //rich_list.Add();
            for (int i = 0; i < rich_list.Count; i++)
            {
                RichTextBox rc = ct.richbox((richBoxSet)rich_list[i]);
                rc.BorderStyle = BorderStyle.FixedSingle;
                rc.BackColor = Color.Chocolate;
                rc.SelectionFont = new Font("Tahoma", 9, FontStyle.Bold);
            }

            ArrayList combo_list = new ArrayList();
            combo_list.Add(new comboboxSet(this, "휴대폰앞번호",100,26,120,155));
            for(int i = 0; i<combo_list.Count; i++)
            {
                ComboBox cb = ct.combobox((comboboxSet)combo_list[i]);
                cb.Items.Add("010");
                cb.Items.Add("011");
            }
            
        }
      
    }
}
