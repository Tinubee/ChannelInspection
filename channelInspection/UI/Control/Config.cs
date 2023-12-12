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
    public partial class Config : UserControl
    {
        public Config()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.bind환경설정.DataSource = Global.환경설정;
            this.d기본경로.SelectedPath = Global.환경설정.기본경로;
            this.d데이터저장.SelectedPath = Global.환경설정.문서저장;
            this.d이미지저장.SelectedPath = Global.환경설정.사진저장;
            this.cb양품이미지저장여부.Checked = Global.환경설정.사진저장OK;
            this.cb불량이미지저장여부.Checked = Global.환경설정.사진저장NG;
            this.cb비전검사사용여부.Checked = Global.환경설정.검사여부;

            this.tb설정저장경로.Text = this.d기본경로.SelectedPath;
            this.tb데이터저장경로.Text = this.d데이터저장.SelectedPath;
            this.tb이미지저장경로.Text = this.d이미지저장.SelectedPath;

            this.b설정저장.Click += B설정저장_Click;
            this.b설정저장경로선택.Click += B설정저장경로선택_Click;
            this.b데이터저장경로선택.Click += B데이터저장경로선택_Click;
            this.b이미지저장경로선택.Click += B이미지저장경로선택_Click;

            this.cb비전검사사용여부.CheckedChanged += Cb비전검사사용여부_CheckedChanged;
            this.cb불량이미지저장여부.CheckedChanged += Cb불량이미지저장여부_CheckedChanged;
            this.cb양품이미지저장여부.CheckedChanged += Cb양품이미지저장여부_CheckedChanged;
        }

        private void Cb비전검사사용여부_CheckedChanged(object sender, EventArgs e)
        {
           Global.환경설정.검사여부 = cb비전검사사용여부.Checked;
        }

        private void Cb불량이미지저장여부_CheckedChanged(object sender, EventArgs e)
        {
            Global.환경설정.사진저장NG = cb불량이미지저장여부.Checked;
        }

        private void Cb양품이미지저장여부_CheckedChanged(object sender, EventArgs e)
        {
            Global.환경설정.사진저장OK = cb양품이미지저장여부.Checked;
        }

        private void B이미지저장경로선택_Click(object sender, EventArgs e)
        {
            if (this.d데이터저장.ShowDialog() == DialogResult.OK)
                this.tb이미지저장경로.Text = this.d데이터저장.SelectedPath;

        }

        private void B데이터저장경로선택_Click(object sender, EventArgs e)
        {
            if (this.d데이터저장.ShowDialog() == DialogResult.OK)
                this.tb데이터저장경로.Text = this.d데이터저장.SelectedPath;
        }

        private void B설정저장경로선택_Click(object sender, EventArgs e)
        {
            if (this.d기본경로.ShowDialog() == DialogResult.OK)
                this.tb설정저장경로.Text = this.d기본경로.SelectedPath;
        }

        private void B설정저장_Click(object sender, EventArgs e)
        {
            //설정파일 저장로직 추가해야됨.
            this.bind환경설정.EndEdit();
            if (!Util.Confirm("환경 설정을 저장 하시겠습니까?", "Save")) return;

            Global.환경설정.Save();
        }
    }
}
