using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO;
using channelInspection.Utils;
using System.Diagnostics;

namespace channelInspection.Schemas
{
    public class CameraAttribute : Attribute
    {
        public Boolean Whether = true;
        public CameraAttribute(Boolean cam) { Whether = cam; }

        public static Boolean IsCamera(장치구분 구분)
        {
            CameraAttribute a = Util.GetAttribute<CameraAttribute>(구분);
            if (a == null) return false;
            return a.Whether;
        }
    }

    public class ResultAttribute : Attribute
    {
        public 검사그룹 검사그룹 = 검사그룹.None;
        public 결과분류 결과분류 = 결과분류.None;
        public 장치구분 장치구분 = 장치구분.None;
        public ResultAttribute() { }
        public ResultAttribute(검사그룹 그룹, 결과분류 결과, 장치구분 장치) { 검사그룹 = 그룹; 장치구분 = 장치; 결과분류 = 결과; }
    }

    public enum 결과구분
    {
        [Description("Waiting")]
        NO = 0,
        [Description("Measuring")]
        IN = 1,
        [Description("Pass")]
        PS = 2,
        [Description("Error")]
        ER = 3,
        [Description("NG")]
        NG = 5,
        [Description("OK")]
        OK = 7,
    }
    public enum 단위구분
    {
        [Description("mm")]
        mm = 0,
        [Description("ø")]
        ø = 1,
        [Description("µm")]
        µm = 2,
        [Description("px")]
        px = 3,
    }
    public enum 검사그룹
    {
        [Description("None")]
        None,
        [Description("Pattern")]
        형상검사,
        [Description("Blob")]
        블롭검사,
        [Description("Dimensional")]
        치수검사,
    }

    public enum 검사항목 : Int32
    {
        [Result(), ListBindable(false)]
        None = 0,
        [Result(검사그룹.치수검사, 결과분류.Detail, 장치구분.Cam01)]
        LINE1좌측2_4부,
        [Result(검사그룹.치수검사, 결과분류.Detail, 장치구분.Cam02)]
        LINE1우측2_4부,
        [Result(검사그룹.치수검사, 결과분류.Detail, 장치구분.Cam04)]
        LINE2좌측2_4부,
        [Result(검사그룹.치수검사, 결과분류.Detail, 장치구분.Cam05)]
        LINE2우측2_4부,
    }

    public enum 장치구분
    {
        [Description("None"), Camera(false)]
        None = 0,
        [Description("Cam01"), Camera(true)]
        Cam01 = 1,
        [Description("Cam02"), Camera(true)]
        Cam02 = 2,
        [Description("Cam03"), Camera(true)]
        Cam03 = 3,
        [Description("Cam04"), Camera(true)]
        Cam04 = 4,
        [Description("Cam05"), Camera(true)]
        Cam05 = 5,
        [Description("Cam06"), Camera(true)]
        Cam06 = 6,
    }
    public enum 결과분류
    {
        None,
        Summary,
        Detail,
    }

    [Table("inspd")]
    public class 검사정보
    {
        [Column("idwdt", Order = 0), Required, Key, JsonProperty("idwdt"), Description("Time")]
        public DateTime 검사일시 { get; set; } = DateTime.Now;
        [Column("iditm", Order = 1), Required, Key, JsonProperty("iditm"), Description("Item")]
        public 검사항목 검사항목 { get; set; } = 검사항목.None;
        [Column("idgrp"), JsonProperty("idgrp"), Description("Group")]
        public 검사그룹 검사그룹 { get; set; } = 검사그룹.None;
        [Column("iddev"), JsonProperty("iddev"), Description("Device")]
        public 장치구분 검사장치 { get; set; } = 장치구분.None;
        [Column("idcat"), JsonProperty("idcat"), Description("Category")]
        public 결과분류 결과분류 { get; set; } = 결과분류.None;
        [Column("iduni"), JsonProperty("iduni"), Description("Unit")]
        public 단위구분 측정단위 { get; set; } = 단위구분.mm;
        [Column("idstd"), JsonProperty("idstd"), Description("Standard")]
        public Decimal 기준값 { get; set; } = 0m;
        [Column("idmin"), JsonProperty("idmin"), Description("Min")]
        public Decimal 최소값 { get; set; } = 0m;
        [Column("idmax"), JsonProperty("idmax"), Description("Max")]
        public Decimal 최대값 { get; set; } = 0m;
        [Column("idoff"), JsonProperty("idoff"), Description("Offset")]
        public Decimal 보정값 { get; set; } = 0m;
        [Column("idcal"), JsonProperty("idcal"), Description("Calib(µm)")]
        public Decimal 교정값 { get; set; } = 1m;
        [Column("idmes"), JsonProperty("idmes"), Description("Measure")]
        public Decimal 측정값 { get; set; } = 0m;
        [Column("idval"), JsonProperty("idval"), Description("Value")]
        public Decimal 결과값 { get; set; } = 0m;
        [Column("idres"), JsonProperty("idres"), Description("Result")]
        public 결과구분 측정결과 { get; set; } = 결과구분.NO;
        [NotMapped, JsonProperty("iduse"), Description("Used")]
        public Boolean 검사여부 { get; set; } = true;

        [NotMapped, JsonIgnore]
        public Double 검사시간 = 0;

        public 검사정보() { }
        public 검사정보(검사정보 정보) { this.Set(정보); }

        public void Reset(DateTime? 일시 = null)
        {
            if (일시 != null) this.검사일시 = (DateTime)일시;
            this.측정값 = 0;
            this.결과값 = 0;
            this.측정결과 = 결과구분.IN;
        }
        public void Set(검사정보 정보)
        {
            if (정보 == null) return;
            foreach (PropertyInfo p in typeof(검사정보).GetProperties())
            {
                if (!p.CanWrite) continue;
                Object v = p.GetValue(정보);
                if (v == null) continue;
                p.SetValue(this, v);
            }

            this.측정값 = 0;
            this.결과값 = 0;
            this.측정결과 = 결과구분.NO;
        }
    }

    [Table("inspl")]
    public class 검사결과
    {
        [Column("ilwdt"), Required, Key, JsonProperty("ilwdt"), Description("Time")]
        public DateTime 검사일시 { get; set; } = DateTime.Now;
        [Column("ilmcd"), JsonProperty("ilmcd"), Description("Model")]
        public 모델구분 모델구분 { get; set; } = 모델구분.None;
        [Column("ilnum"), JsonProperty("ilnum"), Description("Index")]
        public Int32 검사코드 { get; set; } = 0;
        [Column("ilpattern"), JsonProperty("ilres"), Description("Result")]
        public 결과구분 형상결과 { get; set; } = 결과구분.NO;
        [Column("ilblob"), JsonProperty("ilctq"), Description("CTQ")]
        public 결과구분 블롭결과 { get; set; } = 결과구분.NO;
        [Column("ildis"), JsonProperty("ilapp"), Description("Suface")]
        public 결과구분 치수결과 { get; set; } = 결과구분.NO;
        [Column("ilngs"), JsonProperty("ilngs"), Description("NG Info")]
        public String 불량정보 { get; set; } = String.Empty;

        [NotMapped, JsonProperty("inspd")]
        public List<검사정보> 검사내역 { get; set; } = new List<검사정보>();

        public 검사결과()
        {
            this.검사일시 = DateTime.Now;
            this.모델구분 = Global.환경설정.선택모델;
        }

        public void Reset()
        {
            this.검사일시 = DateTime.Now;
            this.모델구분 = Global.환경설정.선택모델;
            this.형상결과 = 결과구분.NO;
            this.블롭결과 = 결과구분.NO;
            this.치수결과 = 결과구분.NO;
            this.불량정보 = String.Empty;
            this.검사내역.Clear();

            검사설정자료 자료 = Global.모델자료.GetItem(this.모델구분)?.검사설정;
            foreach (검사정보 정보 in 자료)
            {
                if (!정보.검사여부) continue;
                this.검사내역.Add(new 검사정보(정보) { 검사일시 = this.검사일시 });
            }
        }

        public 검사정보 GetItem(검사항목 항목) => 검사내역.Where(e => e.검사항목 == 항목).FirstOrDefault();

        // 카메라 검사결과 적용
        public Boolean SetResult(String name, Single value, Boolean ok) => SetResult(검사내역.Where(e => e.검사항목.ToString() == name).FirstOrDefault(), value, ok);
        public Boolean SetResult(검사항목 항목, Single value, Boolean ok) => SetResult(검사내역.Where(e => e.검사항목 == 항목).FirstOrDefault(), value, ok);
        public Boolean SetResult(검사정보 검사, Single value, Boolean ok)
        {
            if (검사 == null) return false;
            if (Single.IsNaN(value))
            {
                검사.측정결과 = 결과구분.ER;
                return false;
            }

            검사.결과값 = (Decimal)Math.Round(value, Global.환경설정.결과자릿수);
            검사.측정값 = 검사.결과값;
            검사.측정결과 = ok ? 결과구분.OK : 결과구분.NG;
            //Debug.WriteLine(검사.측정값, 검사.검사항목.ToString());
            return true;
        }

        // 일반 검사결과 적용
        public Boolean SetResult(검사항목 항목, Single value) => SetResult(검사내역.Where(e => e.검사항목 == 항목).FirstOrDefault(), value);
        public Boolean SetResult(String name, Single value) => SetResult(검사내역.Where(e => e.검사항목.ToString() == name).FirstOrDefault(), value);
        public Boolean SetResult(검사정보 검사, Single value)
        {
            if (검사 == null) return false;
            if (Single.IsNaN(value))
            {
                검사.측정결과 = 결과구분.ER;
                return false;
            }
            검사.측정값 = (Decimal)Math.Round(value, Global.환경설정.결과자릿수);
            검사.결과값 = 검사.측정값 + 검사.보정값;
            Boolean ok = 검사.결과값 >= 검사.최소값 && 검사.결과값 <= 검사.최대값;
            검사.측정결과 = ok ? 결과구분.OK : 결과구분.NG;
            return true;
        }

        public void AddRange(List<검사정보> 자료)
        {
            this.검사내역.AddRange(자료);
        }
    }
}
