using channelInspection.UI.Form;
using System;
using System.Threading;
using System.Windows.Forms;

namespace channelInspection
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        [Obsolete]
        static void Main()
        {
            bool createdNew = false;
            Mutex mtx = new Mutex(true, Global.GetGuid(), out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("프로그램이 이미 실행중입니다.");
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
