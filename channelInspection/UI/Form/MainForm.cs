using channelInspection.UI.Form;
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

namespace channelInspection
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private WaitForm WaitForm;

        public MainForm()
        {
            InitializeComponent();
            //this.ShowWaitForm();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            Global.Initialized += GlobalInitialized;
            Task.Run(() => { Global.Init(); });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!this.) return;
            e.Cancel = !Util.Confirm("프로그램을 종료하시겠습나까?");
            if (!e.Cancel)
            {
                //this.IsStarted = false;
                //this.e검사결과.Close();
                Global.Close();
            }
        }
        public void ShowWaitForm()
        {
            WaitForm = new WaitForm() {StartPosition = FormStartPosition.CenterScreen };
            WaitForm.Show(this);
        }
        public void HideWaitForm()
        {
            WaitForm.Close();
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
