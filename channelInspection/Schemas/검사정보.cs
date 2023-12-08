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
        //[Column("iditm", Order = 1), Required, Key, JsonProperty("iditm"), Description("Item")]
        //public 검사항목 검사항목 { get; set; } = 검사항목.None;
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
}
