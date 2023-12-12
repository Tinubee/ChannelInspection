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
using VM.Controls;
using System.Windows;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

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
            Debug.WriteLine(ex.Message, $"{name}({idx})");
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
        public static String StrValue(Object value)
        {
            if (IsNullValue(value)) return String.Empty;
            return Convert.ToString(value).Trim(new char[] { Strings.Chr(32), ControlChars.Tab, ControlChars.Lf, ControlChars.Cr });
        }
        public static Decimal StrToNum(Object value)
        {
            String str = StrValue(value);
            if (String.IsNullOrEmpty(str)) return 0;
            Regex rx = new Regex(@"(-?[0-9,]+([.\d]+)?)");
            str = rx.Match(str).Value;
            if (String.IsNullOrEmpty(str)) return 0;
            return Convert.ToDecimal(str);
        }

        public static Boolean IsNullValue(Object value) => value == null || Convert.IsDBNull(value);
        public static Int32 IntValue(Object value) => Convert.ToInt32(StrToNum(value));
    }
}
