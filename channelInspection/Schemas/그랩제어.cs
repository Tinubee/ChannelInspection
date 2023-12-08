using MvCamCtrl.NET;
using MvCamCtrl.NET.CameraParams;
using Newtonsoft.Json;
using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using channelInspection.Utils;
using System.Threading.Tasks;
using System.Threading;

namespace channelInspection.Schemas
{
    public enum 카메라구분
    {
        [Bindable(false)]
        None,
        [Description("측면1")]
        Cam01 = 1,
        [Description("측면2")]
        Cam02 = 2,
        [Description("상부1")]
        Cam03 = 3,
        [Description("측면3")]
        Cam04 = 4,
        [Description("측면4")]
        Cam05 = 5,
        [Description("상부2")]
        Cam06 = 6,
    }

    public class 그랩제어 : Dictionary<카메라구분, 카메라장치>
    {
        public delegate void 그랩완료대리자(카메라구분 구분, Mat 이미지);
        public event 그랩완료대리자 그랩완료보고;

        [JsonIgnore]
        private const string 로그영역 = "카메라";
        [JsonIgnore]
        private string 저장파일 { get { return Path.Combine(Global.환경설정.기본경로, "Cameras.json"); } }

        public HikeGigE 카메라1 = null;
        public HikeGigE 카메라2 = null;
        public HikeGigE 카메라3 = null;
        public HikeGigE 카메라4 = null;
        public HikeGigE 카메라5 = null;
        public HikeGigE 카메라6 = null;

        public Boolean Init()
        {
            this.카메라1 = new HikeGigE() { 구분 = 카메라구분.Cam01, 코드 = "" };
            this.카메라2 = new HikeGigE() { 구분 = 카메라구분.Cam02, 코드 = "" };
            this.카메라3 = new HikeGigE() { 구분 = 카메라구분.Cam03, 코드 = "" };
            this.카메라4 = new HikeGigE() { 구분 = 카메라구분.Cam04, 코드 = "" };
            this.카메라5 = new HikeGigE() { 구분 = 카메라구분.Cam05, 코드 = "" };
            this.카메라6 = new HikeGigE() { 구분 = 카메라구분.Cam06, 코드 = "" };

            this.Add(카메라구분.Cam01, this.카메라1);
            this.Add(카메라구분.Cam02, this.카메라2);
            this.Add(카메라구분.Cam03, this.카메라3);
            this.Add(카메라구분.Cam04, this.카메라4);
            this.Add(카메라구분.Cam05, this.카메라5);
            this.Add(카메라구분.Cam06, this.카메라6);

            // 카메라 설정 저장정보 로드
            카메라장치 정보;
            List<카메라장치> 자료 = Load();
            if (자료 != null)
            {
                foreach (카메라장치 설정 in 자료)
                {
                    정보 = this.GetItem(설정.구분);
                    if (정보 == null) continue;
                    정보.Set(설정);
                }
            }

            List<CCameraInfo> 카메라들 = new List<CCameraInfo>();
            Int32 nRet = CSystem.EnumDevices(CSystem.MV_GIGE_DEVICE, ref 카메라들);// | CSystem.MV_USB_DEVICE
            if (!Validate("Enumerate devices fail!", nRet, true)) return false;

            for (int i = 0; i < 카메라들.Count; i++)
            {
                CGigECameraInfo gigeInfo = 카메라들[i] as CGigECameraInfo;
                HikeGigE gige = this.GetItem(gigeInfo.chSerialNumber) as HikeGigE;
                if (gige == null) continue;
                //Debug.WriteLine(gigeInfo.chSerialNumber, "시리얼");
                gige.Init(gigeInfo);
                //if (gige.상태) gige.Start();
            }

            Debug.WriteLine($"카메라 갯수: {this.Count}");
            GC.Collect();
            return true;
        }

        private List<카메라장치> Load()
        {
            if (!File.Exists(this.저장파일)) return null;
            return JsonConvert.DeserializeObject<List<카메라장치>>(File.ReadAllText(this.저장파일), Util.JsonSetting());
        }

        public void Save()
        {
            if (!Util.WriteAllText(저장파일, JsonConvert.SerializeObject(this.Values, Util.JsonSetting())))
            {
                //Global.오류로그(로그영역, "카메라 설정 저장", "카메라 설정 저장에 실패하였습니다.", true);
            }
        }

        public void Close()
        {
            this.Save();
            foreach (카메라장치 장치 in this.Values)
                장치?.Close();
        }

        public void Ready(카메라구분 카메라) => this.GetItem(카메라)?.Ready();

        public void 그랩완료(카메라구분 카메라, Mat 이미지)
        {
            new Thread(() =>
            {
                Global.비전도구.GetItem((Flow구분)카메라).Run(이미지);
            }).Start();
            this.그랩완료보고?.Invoke(카메라, 이미지);
        }

        public 카메라장치 GetItem(카메라구분 구분)
        {
            if (this.ContainsKey(구분)) return this[구분];
            return null;
        }

        private 카메라장치 GetItem(String serial) => this.Values.Where(e => e.코드 == serial).FirstOrDefault();

        #region 오류메세지
        public static Boolean Validate(String message, Int32 errorNum, Boolean show)
        {
            if (errorNum == CErrorDefine.MV_OK) return true;

            String errorMsg = String.Empty;
            switch (errorNum)
            {
                case CErrorDefine.MV_E_HANDLE: errorMsg = "Error or invalid handle"; break;
                case CErrorDefine.MV_E_SUPPORT: errorMsg = "Not supported function"; break;
                case CErrorDefine.MV_E_BUFOVER: errorMsg = "Cache is full"; break;
                case CErrorDefine.MV_E_CALLORDER: errorMsg = "Function calling order error"; break;
                case CErrorDefine.MV_E_PARAMETER: errorMsg = "Incorrect parameter"; break;
                case CErrorDefine.MV_E_RESOURCE: errorMsg = "Applying resource failed"; break;
                case CErrorDefine.MV_E_NODATA: errorMsg = "No data"; break;
                case CErrorDefine.MV_E_PRECONDITION: errorMsg = "Precondition error, or running environment changed"; break;
                case CErrorDefine.MV_E_VERSION: errorMsg = "Version mismatches"; break;
                case CErrorDefine.MV_E_NOENOUGH_BUF: errorMsg = "Insufficient memory"; break;
                case CErrorDefine.MV_E_UNKNOW: errorMsg = "Unknown error"; break;
                case CErrorDefine.MV_E_GC_GENERIC: errorMsg = "General error"; break;
                case CErrorDefine.MV_E_GC_ACCESS: errorMsg = "Node accessing condition error"; break;
                case CErrorDefine.MV_E_ACCESS_DENIED: errorMsg = "No permission"; break;
                case CErrorDefine.MV_E_BUSY: errorMsg = "Device is busy, or network disconnected"; break;
                case CErrorDefine.MV_E_NETER: errorMsg = "Network error"; break;
                default: errorMsg = "Unknown error"; break;
            }

            //Global.오류로그("Camera", "Error", $"[{errorNum}] {message} {errorMsg}", show);
            return false;
        }
        #endregion
    }

    public class 카메라장치
    {
        [JsonProperty("Camera"), Description("Camera")]
        public virtual 카메라구분 구분 { get; set; } = 카메라구분.None;
        [JsonIgnore, Description("Index")]
        public virtual Int32 번호 { get; set; } = 0;
        [JsonProperty("Serial"), Description("Serial")]
        public virtual String 코드 { get; set; } = String.Empty;
        [JsonIgnore, Description("Name")]
        public virtual String 명칭 { get; set; } = String.Empty;
        [JsonProperty("Description"), Description("Description")]
        public virtual String 설명 { get; set; } = String.Empty;
        [JsonProperty("IpAddress"), Description("IP")]
        public virtual String 주소 { get; set; } = String.Empty;
        [JsonProperty("Timeout"), Description("Timeout")]
        public virtual Double 시간 { get; set; } = 1000;
        [JsonProperty("Exposure"), Description("Exposure")]
        public virtual Single 노출 { get; set; } = 300;
        [JsonProperty("BlackLevel"), Description("Black Level")]
        public virtual UInt32 밝기 { get; set; } = 0;
        [JsonProperty("Contrast"), Description("Contrast")]
        public virtual Single 대비 { get; set; } = 10;
        [JsonProperty("Width"), Description("Width")]
        public virtual Int32 가로 { get; set; } = 0;
        [JsonProperty("Height"), Description("Height")]
        public virtual Int32 세로 { get; set; } = 0;
        [JsonProperty("OffsetX"), Description("OffsetX")]
        public virtual Int32 OffsetX { get; set; } = 0;
        [JsonIgnore, Description("카메라 초기화 상태")]
        public virtual Boolean 상태 { get; set; } = false;
        [JsonIgnore]
        public const String 로그영역 = "카메라장치";

        public virtual void Set(카메라장치 장치)
        {
            if (장치 == null) return;
            this.코드 = 장치.코드;
            this.설명 = 장치.설명;
            this.시간 = 장치.시간;
            this.노출 = 장치.노출;
            this.대비 = 장치.대비;
            this.밝기 = 장치.밝기;
            this.가로 = 장치.가로;
            this.세로 = 장치.세로;
            this.OffsetX = 장치.OffsetX;
        }

        public virtual Boolean Init() => false;
        public virtual Boolean Ready() => false;
        public virtual Boolean Start() => false;
        public virtual Boolean Stop() => false;
        public virtual Boolean Close() => false;
        //public virtual void TurnOn() => Global.조명제어.TurnOn(this.구분);
        //public virtual void TurnOff() => Global.조명제어.TurnOff(this.구분);
    }

    public class HikeGigE : 카메라장치
    {
        [JsonIgnore]
        private CCamera Camera = null;
        [JsonIgnore]
        private CCameraInfo Device;
        [JsonIgnore]
        private cbOutputExdelegate ImageCallBackDelegate;

        public Boolean Init(CGigECameraInfo info)
        {
            try
            {
                this.Camera = new CCamera();
                this.Device = info;
                this.ImageCallBackDelegate = new cbOutputExdelegate(ImageCallBack);

                this.명칭 = info.chManufacturerName + " " + info.chModelName;
                UInt32 ip1 = (info.nCurrentIp & 0xff000000) >> 24;
                UInt32 ip2 = (info.nCurrentIp & 0x00ff0000) >> 16;
                UInt32 ip3 = (info.nCurrentIp & 0x0000ff00) >> 8;
                UInt32 ip4 = info.nCurrentIp & 0x000000ff;
                this.주소 = $"{ip1}.{ip2}.{ip3}.{ip4}";
                this.상태 = this.Init();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                //Global.오류로그(로그영역, "초기화", $"초기화 오류: {ex.Message}", true);
                this.상태 = false;
            }

            Debug.WriteLine($"{this.명칭}, {this.코드}, {this.주소}, {this.상태}");
            return this.상태;
        }

        public override Boolean Init()
        {
            Int32 nRet = this.Camera.CreateHandle(ref Device);
            if (!그랩제어.Validate($"[{this.구분}] 카메라 초기화에 실패하였습니다.", nRet, true)) return false;
            nRet = this.Camera.OpenDevice();
            if (!그랩제어.Validate($"[{this.구분}] 카메라 연결 실패!", nRet, true)) return false;
            그랩제어.Validate("", this.Camera.SetBoolValue("BlackLevelEnable", true), false);
            this.옵션적용();
            //Global.정보로그(로그영역, "카메라 연결", $"[{this.구분}] 카메라 연결 성공!", false);
            그랩제어.Validate("RegisterImageCallBackEx", this.Camera.RegisterImageCallBackEx(this.ImageCallBackDelegate, IntPtr.Zero), false);
            return true;
        }

        private void 옵션적용()
        {
            this.노출적용();
            this.대비적용();
            this.밝기적용();
        }

        public void 밝기적용() 
        {
            if (this.Camera == null) return;
            Int32 nRet = this.Camera.SetIntValue("BlackLevel", this.밝기); 
            그랩제어.Validate($"[{this.구분}] 밝기 설정에 실패하였습니다.", nRet, true);
        }

        public void 노출적용()
        {
            if (this.Camera == null) return;
            Int32 nRet = this.Camera.SetFloatValue("ExposureTime", this.노출);
            그랩제어.Validate($"[{this.구분}] 노출 설정에 실패하였습니다.", nRet, true);
        }

        public void 대비적용()
        {
            if (this.Camera == null) return;
            Int32 nRet = this.Camera.SetFloatValue("Gain", this.대비);
            그랩제어.Validate($"[{this.구분}] 대비 설정에 실패하였습니다.", nRet, true);
        }

        public override Boolean Start()
        {
            return 그랩제어.Validate($"{this.구분} 그래버 시작 오류!", Camera.StartGrabbing(), true);
        }

        public override Boolean Ready()
        {
            this.Camera.ClearImageBuffer();
            return Start();
        }

        public override Boolean Close()
        {
            if (this.Camera == null || !this.상태) return true;
            return 그랩제어.Validate($"{this.구분} 종료오류!", Camera.CloseDevice(), false);
        }

        public override Boolean Stop()
        {
            Camera.ClearImageBuffer();
            return 그랩제어.Validate($"{this.구분} 정지오류!", Camera.StopGrabbing(), false);
        }

        #region 이미지 그랩
        public Boolean TrigForce() => 그랩제어.Validate($"{this.구분} TriggerSoftware", this.Camera.SetCommandValue("TriggerSoftware"), true);

        private void ImageCallBack(IntPtr data, ref MV_FRAME_OUT_INFO_EX frameInfo, IntPtr user)
        {
            try
            {
                Mat image = new Mat(frameInfo.nHeight, frameInfo.nWidth, MatType.CV_8U, data);
                Global.그랩제어.그랩완료(this.구분, image);
                this.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                //Global.오류로그(로그영역, "Camera Call Back Error", $"[{this.구분}] {ex.Message}", false);
                return;
            }
        }
        #endregion
    }

    
}