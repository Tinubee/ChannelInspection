using channelInspection.Schemas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace channelInspection.UI.Control
{
    public partial class LogViewer : UserControl
    {
        public LogViewer()
        {
            InitializeComponent();
        }

        public void Init()
        {
            //this.BindLocalization.DataSource = 번역;
            //Localization.SetColumnCaption(this.GridView1, typeof(로그정보));

            //e시작.DateTime = DateTime.Today;
            //e종료.DateTime = DateTime.Today;
            //b검색.ImageOptions.SvgImage = Resources.GetSvgImage(SvgImageType.검색);
            //GridView1.Init();
            //GridControl1.DataSource = Global.로그자료;
            dataGridView1.DataSource = Global.로그자료;
            this.b검색.Click += B검색_Click;
        }

        private void B검색_Click(object sender, EventArgs e)
        {
            Global.로그자료.Load(this.e시작.Value, this.e종료.Value);
        }
    }
}
