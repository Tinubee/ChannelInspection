using Newtonsoft.Json;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using VM.Controls;
using System.Windows;

namespace channelInspection.Utils
{
    public class Util
    {

        public static Boolean WriteAllText(String file, String text)
        {
            try
            {
                File.WriteAllText(file, text, Encoding.UTF8);
                return true;
            }
            catch (UnauthorizedAccessException ex) { Util.DebugException(ex, 0); }
            catch (Exception ex) { DebugException(ex, 0); }
            return false;
        }

        public static JsonSerializerSettings JsonSetting(Boolean useIndented = true)
        {
            JsonSerializerSettings s = new JsonSerializerSettings();
            s.NullValueHandling = NullValueHandling.Ignore;
            s.DateParseHandling = DateParseHandling.DateTime;
            s.DateTimeZoneHandling = DateTimeZoneHandling.Local;
            s.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            if (useIndented) s.Formatting = Formatting.Indented;
            return s;
        }

        public static void DebugException(Exception ex, Int32 idx, String name = "Exception")
        {
            if (ex == null) return;
            Debug.WriteLine(ex.Message, $"{name}({idx.ToString()})");
            if (ex.InnerException != null)
                DebugException(ex.InnerException, idx + 1, name);
        }

        public static T GetAttribute<T>(Enum @enum)
        {
            Type type = @enum.GetType();
            return (T)type.GetField(type.GetEnumName(@enum)).GetCustomAttributes(typeof(T), true).FirstOrDefault();
        }

        public static String GetDescription(Enum val)
        {
            Type type = val.GetType();
            DescriptionAttribute a = GetAttribute<DescriptionAttribute>(val);
            if (a == null) return type.GetEnumName(val);
            return a.Description;
        }

        public static Boolean Confirm(String message, String caption = "")
        {
            if (String.IsNullOrEmpty(caption)) caption = "Confirm";
            return MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes;
        }
    }
}
