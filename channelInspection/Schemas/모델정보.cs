using channelInspection.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;

namespace channelInspection.Schemas
{
    public enum 모델구분
    {
        [Description("K12SE Channel")]
        K12SE_CHANNEL,
        [Description("K12A Channel")]
        K12A_CHANNEL,
    }
    public class 모델정보
    {
        [JsonProperty("Number")]
        public Int32 모델번호 { get { return (Int32)this.모델구분; } }
        [JsonProperty("ModelName")]
        public 모델구분 모델구분 { get; set; } = 모델구분.K12SE_CHANNEL;
        [JsonProperty("SolutionPath")]
        public String 솔루션파일저장경로 { get; set; } = String.Empty;
        //[JsonIgnore]
        //private String 검사목록파일 { get; set; } = String.Empty;
        //[JsonIgnore]
        //public String 마스터이미지1 { get; set; } = String.Empty;
        //[JsonIgnore]
        //public String 마스터이미지2 { get; set; } = String.Empty;
        //[JsonIgnore]
        //public 검사설정자료 검사설정 = null;

        public 모델정보() { }

        public 모델정보(모델구분 구분)
        {
            this.모델구분 = 구분;
            this.Init();
        }

        public void Init()
        {
            this.솔루션파일저장경로 = Path.Combine(Global.환경설정.도구경로, $"{this.모델구분}.sol");
            //this.검사설정 = new 검사설정자료(this);
        }
        public void Close() { }
    }

    public class 모델자료 : BindingList<모델정보>
    {
        private String 저장파일 { get { return Path.Combine(Global.환경설정.기본경로, $"Models.json"); } }
        public 모델정보 선택모델 { get { return this.GetItem(Global.환경설정.선택모델); } }
        
        public void Init()
        {
            this.Load();
        }

        public void Close()
        {
            this.Save();
            foreach (모델정보 모델 in this)
                모델.Close();
        }

        private void Load()
        {
            if (!File.Exists(저장파일))
            {
                this.BaseModel();
                this.Save();
                //Global.정보로그(로그영역.GetString(), "자료로드", "저장파일이 없습니다.", false);
                return;
            }
            try
            {
                List<모델정보> 자료 = JsonConvert.DeserializeObject<List<모델정보>>(File.ReadAllText(저장파일));
                if (자료 == null) return;
                자료.Sort((a, b) => a.모델번호.CompareTo(b.모델번호));
                자료.ForEach(e => this.Add(e));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                // Global.오류로그(로그영역.GetString(), "자료로드", ex.Message, false);
            }

            if (this.GetItem(Global.환경설정.선택모델) == null)
                if (this.Count > 0) Global.환경설정.선택모델 = this[0].모델구분;

            //foreach (모델정보 정보 in this)
            //{
            //    if (정보.양산일자 == DateTime.Today) continue;
            //    정보.양산일자 = DateTime.Today;
            //    정보.수량리셋();
            //}
            SettingLoad();
        }

        public void SettingLoad()
        {
            foreach (모델정보 정보 in this)
                SettingLoad(정보);
        }
        public void SettingLoad(모델구분 모델)
        {
            SettingLoad(this.GetItem(모델));
        }
        public void SettingLoad(모델정보 정보)
        {
            if (정보 == null) return;
            //if (정보.검사설정 == null) 정보.Init();
            //정보.검사설정.Load();
        }

        public void SettingSave()
        {
            foreach (모델정보 정보 in this)
                SettingSave(정보);
        }
        public void SettingSave(모델구분 모델)
        {
            SettingSave(this.GetItem(모델));
        }
        public void SettingSave(모델정보 정보)
        {
            //정보?.검사설정?.Save();
        }

        public 모델정보 GetItem(모델구분 모델코드)
        {
            return this.Where(e => e.모델구분 == 모델코드).FirstOrDefault();
        }

        private void BaseModel()
        {
            foreach (모델구분 구분 in typeof(모델구분).GetEnumValues())
            {
                모델정보 모델 = this.GetItem(구분);
                if (모델 == null) this.Add(new 모델정보(구분));
                //else 모델.모델설명 = 모델정보.GetModelDescription(구분);
            }
            if (this.선택모델 == null) Global.환경설정.선택모델 = 모델구분.K12SE_CHANNEL;
        }
        public void Save()
        {
            File.WriteAllText(저장파일, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
