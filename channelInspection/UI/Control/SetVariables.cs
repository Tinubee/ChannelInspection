using channelInspection.UI.Form;
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
    public partial class SetVariables : UserControl
    {
        public SetVariables()
        {
            InitializeComponent();
            b도구설정.Click += B도구설정_Click;
            b설정저장.Click += B설정저장_Click;
        }

        private void B설정저장_Click(object sender, EventArgs e)
        {
           
        }

        private void B도구설정_Click(object sender, EventArgs e)
        {
            Teaching form = new Teaching();
            form.Show(Global.MainForm);
        }
    }
}
