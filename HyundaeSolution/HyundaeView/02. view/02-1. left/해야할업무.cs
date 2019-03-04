using HyundaeView._01._module;
using System;
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
    public partial class 해야할업무 : Form
    {
        _01._module.create ct = new _01._module.create();
        public 해야할업무()
        {
            InitializeComponent();
            Load += 해야할업무_Load;
        }

        private void 해야할업무_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(550,1020);

            lbSet lb1 = new lbSet(this,"해야할업무","해야할 업무",250,50,10,40,10);
            Label size = ct.lable(lb1);
            Controls.Add(size);
        }
    }
}
