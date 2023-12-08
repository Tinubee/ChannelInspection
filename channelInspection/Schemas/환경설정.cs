using Newtonsoft.Json;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using channelInspection.Utils;
using System.Windows.Forms;

namespace channelInspection.Schemas
{
    public class 환경설정
    {
        public delegate void 모델변경(모델구분 모델코드);
        public event 모델변경 모델변경알림;

        [JsonIgnore]
        public const String 프로젝트번호 = "23-1208-001";
        [Description("프로그램 동작구분"), JsonProperty("RunType")]
        public 동작구분 동작구분 { get; set; } = 동작구분.Live;
        [Description("Config Path"), JsonProperty("ConfigSavePath")]
        public String 기본경로 { get; set; } = @"C:\HKC\Channel\Config";
        [Description("Document Save Path"), JsonProperty("DocumentSavePath")]
        public String 문서저장 { get; set; } = @"C:\HKC\Channel\SaveData";
        [Description("Image Save Path"), JsonProperty("ImageSavePath")]
        public String 사진저장 { get; set; } = @"C:\HKC\Channel\SaveImage";
        [Description("Decimals"), JsonProperty("Decimals")]
        public Int32 결과자릿수 { get; set; } = 3;
        [Description("OK Image Save"), JsonProperty("SaveOK")]
        public Boolean 사진저장OK { get; set; } = false;
        [Description("NG Image Save"), JsonProperty("SaveNG")]
        public Boolean 사진저장NG { get; set; } = false;
        [Description("Results Storage Days"), JsonProperty("DaysToKeepResults")]
        public Int32 결과보관 { get; set; } = 900;
        [Description("Logs Storage Days"), JsonProperty("DaysToKeepLogs")]
        public Int32 로그보관 { get; set; } = 60;

        [JsonProperty("CurrentModel")]
        public 모델구분 선택모델 { get; set; } = 모델구분.K12SE_CHANNEL;

        [Description("Model Image Path")]
        public String 사진경로 { get { return Path.Combine(기본경로, "Items"); } } 
        [Description("비젼 Tools"), JsonIgnore]
        public String 도구경로 { get { return Path.Combine(기본경로, "Tools"); } }
        [Description("마스터 이미지"), JsonIgnore]
        public String 마스터사진 { get { return Path.Combine(기본경로, "Masters"); } }

        [JsonIgnore]
        public Boolean 강제배출 { get; set; } = false;
        [JsonIgnore]
        public Boolean 양품불량 { get; set; } = true;

        [JsonIgnore]
        public String Format { get { return "#,0." + String.Empty.PadLeft(this.결과자릿수, '0'); } }
        [JsonIgnore]
        public String 결과표현 { get { return "{0:" + Format + "}"; } }

        [JsonIgnore, Description("사용자명")]
        public String 사용자명 { get; set; } = String.Empty;
        //[JsonIgnore, Description("권한구분")]
        //public 유저권한구분 사용권한 { get; set; } = 유저권한구분.없음;

        [JsonIgnore, Description("검사여부")]
        public Boolean 검사여부 { get; set; } = true; // 검사로직 활성화 여부
        //[JsonProperty("UseCrop"), Description("크롭여부"), Translation("Use Crop", "크롭여부")]
        //public Boolean 크롭여부 { get; set; } = true; // 검사 시 크롭을 사용할 지 여부
        [JsonIgnore, Description("티칭모드")]
        public Boolean 티칭모드 { get; set; } = false; // 활성화 시 사진 강제 저장 됨

        [JsonIgnore]
        private String 저장파일 { get { return Path.Combine(this.기본경로, "Config.json"); } }
        [JsonIgnore, Description("이미지 저장 디스크 사용율")]
        public Int32 저장비율 { get { return 100 - this.SaveImageDriveFreeSpace(); } }

        public static NpgsqlConnection CreateDbConnection()
        {
            NpgsqlConnectionStringBuilder b = new NpgsqlConnectionStringBuilder() { Host = "localhost", Port = 5432, Username = "postgres", Password = "ivmadmin", Database = "channel" };
            return new NpgsqlConnection(b.ConnectionString);
        }

        public Boolean CanDbConnect()
        {
            Boolean can = false;
            try
            {
                NpgsqlConnection conn = CreateDbConnection();
                conn.Open();
                can = conn.ProcessID > 0;
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                //Global.오류로그(로그영역.GetString(), "데이터베이스 연결실패", ex.Message, true);
            }
            return can;
        }

        public Boolean Init()
        {
            return this.Load();
        }

        public void Close()
        {
            this.Save();
        }

        public Boolean Load()
        {
            //if (!CanDbConnect())
            //{
            //    //Global.오류로그(로그영역.GetString(), "데이터베이스 연결실패", "데이터베이스에 연결할 수 없습니다.", true);
            //    return false;
            //}

            Common.DirectoryExists(Path.Combine(Application.StartupPath, @"Views"), true);
            if (!Common.DirectoryExists(기본경로, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "기본설정 폴더를 생성할 수 없습니다.", true);
                return false;
            }
            if (!Common.DirectoryExists(사진저장, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "사진저장 폴더를 생성할 수 없습니다.", true);
            }
            if (!Common.DirectoryExists(문서저장, true))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", "문서저장 폴더를 생성할 수 없습니다.", true);
            }

            if (File.Exists(저장파일))
            {
                try
                {
                    환경설정 설정 = JsonConvert.DeserializeObject<환경설정>(File.ReadAllText(저장파일, Encoding.UTF8));
                    foreach (PropertyInfo p in 설정.GetType().GetProperties())
                    {
                        if (!p.CanWrite) continue;
                        Object v = p.GetValue(설정);
                        if (v == null) continue;
                        p.SetValue(this, v);
                    }
                }
                catch (Exception ex)
                {
                    //Global.오류로그(로그영역.GetString(), "환경설정 로드 실패", ex.Message, true);
                }
            }
            else
            {
                this.Save();
                //Global.정보로그(로그영역.GetString(), "환경설정 로드", "저장된 설정파일이 없습니다.", false);
            }

            Debug.WriteLine(this.동작구분, "동작구분");
            return true;
        }

        public void Save()
        {
            if (!Util.WriteAllText(저장파일, JsonConvert.SerializeObject(this, Util.JsonSetting())))
            {
                //Global.오류로그(로그영역.GetString(), "환경설정 저장", "환경설정 저장에 실패하였습니다.", true);
            }
        }

        public void 모델변경요청(모델구분 모델구분)
        {
            if (this.선택모델 == 모델구분) return;
            this.선택모델 = 모델구분;
            this.모델변경알림?.Invoke(this.선택모델);
        }








        #region 드라이브 용량계산
        private DriveInfo ImageSaveDrive = null;
        private DriveInfo GetSaveImageDrive()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (this.사진저장.StartsWith(drive.Name))
                {
                    //Debug.WriteLine(drive.Name, drive.VolumeLabel);
                    this.ImageSaveDrive = drive;
                    return this.ImageSaveDrive;
                }
            }
            if (drives.Length > 0)
                this.ImageSaveDrive = drives[0];

            return this.ImageSaveDrive;
        }

        public Int32 SaveImageDriveFreeSpace()
        {
            DriveInfo drive = this.GetSaveImageDrive();
            double FreeSpace = drive.AvailableFreeSpace / (double)drive.TotalSize * 100;
            return Convert.ToInt32(FreeSpace);
        }
        #endregion
    }
}
