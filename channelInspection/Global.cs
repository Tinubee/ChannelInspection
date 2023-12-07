using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace channelInspection
{
    public static class Global
    {
        public static event EventHandler<Boolean> Initialized;

        public static String GetGuid()
        {
            Assembly assembly = typeof(Program).Assembly;
            GuidAttribute attribute = assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0] as GuidAttribute;
            return attribute.Value;
        }

        public static Boolean Init()
        {
            Debug.WriteLine(GetGuid(), "Process GUID");
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine("시스템 초기화에 실패하였습니다.");
            }
            Initialized.Invoke(null, false);
            return false;
        }

        public static Boolean Close()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("프로그램 종료 중 오류가 발생하였습니다.\n" + ex.Message);
                return false;
            }
           
        }
    }
}
