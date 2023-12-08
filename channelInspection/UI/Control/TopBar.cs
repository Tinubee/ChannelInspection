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
    public partial class TopBar : UserControl
    {
        public TopBar()
        {
            InitializeComponent();
            b창닫기.Click += B창닫기_Click;
            b창최대화.Click += B창최대화_Click;
            b창최소화.Click += B창최소화_Click;
        }

        private void B창최소화_Click(object sender, EventArgs e)
        {
            
        }

        private void B창최대화_Click(object sender, EventArgs e)
        {
           
        }

        private void B창닫기_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
