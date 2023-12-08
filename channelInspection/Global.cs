using channelInspection.Schemas;
using channelInspection.UI.Form;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace channelInspection
{
    public enum 동작구분
    {
        Live = 0,
        LocalTest = 2
    }
    public static class Global
    {
        public static MainForm MainForm = null;
        public delegate void BaseEvent();
        public static event EventHandler<Boolean> Initialized;

        public static 그랩제어 그랩제어;
        public static 조명제어 조명제어;
        public static 환경설정 환경설정;
        public static 비전도구 비전도구;
        public static 신호제어 신호제어;
        public static 모델자료 모델자료;

        public static class 장치상태
        {
            public static Boolean 정상여부 { get { return true; } }
            public static Boolean 카메라1 { get { return Global.그랩제어.카메라1.상태; } }
            public static Boolean 카메라2 { get { return Global.그랩제어.카메라2.상태; } }
            public static Boolean 카메라3 { get { return Global.그랩제어.카메라3.상태; } }
            public static Boolean 카메라4 { get { return Global.그랩제어.카메라4.상태; } }
            public static Boolean 카메라5 { get { return Global.그랩제어.카메라5.상태; } }
            public static Boolean 카메라6 { get { return Global.그랩제어.카메라6.상태; } }
        }

        public static Boolean Init()
        {
            Debug.WriteLine(GetGuid(), "Process GUID");
            try
            {
                그랩제어 = new 그랩제어();
                환경설정 = new 환경설정();
                모델자료 = new 모델자료();
                비전도구 = new 비전도구();
                //신호제어 = new 신호제어();
                조명제어 = new 조명제어();

                //그랩제어.Init();
                환경설정.Init();
                모델자료.Init();
                비전도구.Init();
                //신호제어.Init();
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
                그랩제어?.Close();
                //조명제어?.Close();
                환경설정?.Close();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("프로그램 종료 중 오류가 발생하였습니다.\n" + ex.Message);
                return false;
            }
           
        }

        public static String GetGuid()
        {
            Assembly assembly = typeof(Program).Assembly;
            GuidAttribute attribute = assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0] as GuidAttribute;
            return attribute.Value;
        }
    }
}
