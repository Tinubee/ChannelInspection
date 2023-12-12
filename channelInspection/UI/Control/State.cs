using channelInspection.Schemas;
using channelInspection.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace channelInspection.UI.Control
{
    public partial class State : UserControl
    {
        private Int32 originIndex;
        public State()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.bind모델자료.DataSource = Global.모델자료.선택모델;
            this.cb모델선택.DataSource = Global.모델자료;
            this.cb모델선택.DisplayMember = "모델구분";

            this.originIndex = Global.모델자료.선택모델.모델번호;
            this.cb모델선택.SelectedIndex = this.originIndex;
            this.cb모델선택.SelectedIndexChanged += 모델변경;
        }

        private void 모델변경(object sender, EventArgs e)
        {
            if (this.cb모델선택.SelectedItem == null) return;
            모델구분 모델 = (모델구분)this.cb모델선택.SelectedIndex;
            if (Global.환경설정.선택모델 == 모델) return;
            if (!Util.Confirm("모델을 변경 하시겠습니까?"))
            {
                this.cb모델선택.SelectedIndexChanged -= 모델변경;
                this.cb모델선택.SelectedIndex = this.originIndex;
                this.cb모델선택.SelectedIndexChanged += 모델변경;
                //e.Cancel = true;
                return;
            }

            this.originIndex = this.cb모델선택.SelectedIndex;
            Global.환경설정.모델변경요청(모델);
        }
    }
}
