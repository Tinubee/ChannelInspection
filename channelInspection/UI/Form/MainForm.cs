using channelInspection.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace channelInspection.UI.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            Global.MainForm = this;
            this.Shown += MainForm_Shown;
            this.FormClosing += MainForm_FormClosing;
        }
        private Boolean Init()
        {
            //뷰어들 추가되면 초기화 시켜주면됨.
            return true;
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            try
            {
                Global.Initialized += GlobalInitialized;
                Task.Run(() => { Global.Init(); });
            }
            catch (Exception ex)
            {
                //Global.오류로그("메인페이지", "프로그램 시작", "프로그램 시작 중 오류가 발생하였습니다.\n" + ex.Message, true);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Util.Confirm("프로그램을 종료하시겠습나까?");
            if (!e.Cancel)
            {
                Global.Close();
            }
        }
        private void GlobalInitialized(object sender, Boolean e)
        {
            this.BeginInvoke(new Action(() => GlobalInitialized(e)));
        }
        private void GlobalInitialized(Boolean e)
        {
            Global.Initialized -= GlobalInitialized;
            if (!e) { this.Close(); return; }
            //this.HideWaitForm();
            Common.SetForegroundWindow(this.Handle.ToInt32());

            if (this.Init())
            {
                Debug.WriteLine("MainForm Init Finished.");
                //this.IsStarted = true;
                //Global.Start();
                //Login login = new Login();
                //login.Show();
            }
            else this.Close();
        }
    }
}
