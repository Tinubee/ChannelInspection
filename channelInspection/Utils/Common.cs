using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace channelInspection.Utils
{
    public class Common
    {
        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);
        public static bool DirectoryExists(string Path, bool Create)
        {
            try
            {
                if (Directory.Exists(Path))
                    return true;

                Directory.CreateDirectory(Path);
                return Directory.Exists(Path);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message, "DirectoryExists");
                return false;
            }
        }
    }
}
