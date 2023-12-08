using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VM.PlatformSDKCS;

namespace channelInspection.Schemas
{
    public class 신호제어
    {
        public event Global.BaseEvent 입출변경알림;
        private 입력신호분석 입력자료 = new 입력신호분석();
        private 출력신호분석 출력자료 = new 출력신호분석();

        public enum 입력번호
        {
            LINE1_트리거신호 = 8,
            LINE1_결과체크신호 = 9,
            LINE2_트리거신호 = 10,
            LINE2_결과체크신호 = 9
        }

        public enum 출력번호
        {
            CAM1결과OK = 1,
            CAM1결과NG = 2,
            CAM2결과OK = 3,
            CAM2결과NG = 4,
            CAM3결과OK = 5,
            CAM3결과NG = 6,
            CAM4결과OK = 9,
            CAM4결과NG = 10,
            CAM5결과OK = 11,
            CAM5결과NG = 12,
            CAM6결과OK = 13,
            CAM6결과NG = 14,
        }

        public Boolean LINE1_트리거신호 { get { return 입력상태(입력번호.LINE1_트리거신호); } }
        public Boolean LINE1_결과체크신호 { get { return 입력상태(입력번호.LINE1_결과체크신호); } }
        public Boolean LINE2_트리거신호 { get { return 입력상태(입력번호.LINE2_트리거신호); } }
        public Boolean LINE2_결과체크신호 { get { return 입력상태(입력번호.LINE2_결과체크신호); } }

        public short 디바이스;
        public ushort[] didata;
        public Boolean 동작여부 = false;
        public Int32 실행주기 = 5;

        public Boolean Init() => this.Load();

        public Boolean Load()
        {
            디바이스 = DASK.Register_Card(DASK.PCI_7230, 0);
            if (디바이스 < 0)
            {
                Debug.WriteLine("Register_Card error!");
                return false;
            }
            //장치 start 해줘야됨.

            return true;
        }

        public void Start()
        {
            this.동작여부 = true;
            Task.Run(입출신호분석);
        }

        private async void 입출신호분석()
        {
            while (this.동작여부)
            {
                Boolean 변경 = this.입출상태갱신();
                if (변경) this.입출변경알림?.Invoke();
                await Task.Delay(this.실행주기);
            }
        }
        public Boolean 입력상태(입력번호 번호)
        {
            Boolean 상태 = this.입력자료.Get(번호);
            return 상태;
        }

        private Boolean 입출상태갱신()
        {
            //Dictionary<입력번호, Boolean> 입력변경 = this.입력자료.Set(입력);
            //Dictionary<출력번호, Boolean> 출력변경 = this.출력자료.Set(출력);

            //Boolean 변경 = 입력변경.Count > 0 || 출력변경.Count > 0;

            //if(입력변경.ContainsKey(입력번호.LINE1_트리거신호))
            //{
            //    //Line1 검사시작.
            //} else if(입력변경.ContainsKey(입력번호.LINE2_트리거신호))
            //{
            //    //Line2 검사시작.
            //}

            //return 변경;
            return true;
        }

        private class 신호정보
        {
            public Boolean 이전 { get; set; } = false;
            public Boolean 현재 { get; set; } = false;
            public Boolean 변경 { get { return 이전 != 현재; } }

            public Boolean Set(Boolean 상태)
            {
                이전 = 현재;
                현재 = 상태;
                return 변경;
            }
        }

        private class 입력신호분석 : Dictionary<입력번호, 신호정보>
        {
            public 입력신호분석()
            {
                foreach (입력번호 번호 in Enum.GetValues(typeof(입력번호)))
                    this.Add(번호, new 신호정보());
            }

            public Dictionary<입력번호, Boolean> Set(BitArray 입력)
            {
                Dictionary<입력번호, Boolean> 변경 = new Dictionary<입력번호, Boolean>();
                foreach (var 정보 in this)
                {
                    Int32 번호 = (int)정보.Key;
                    Boolean 상태 = 입력[번호];
                    if (정보.Value.Set(상태))
                        변경.Add(정보.Key, 상태);
                }
                return 변경;
            }

            public Boolean Get(입력번호 번호)
            {
                DASK.DI_ReadLine((ushort)Global.신호제어.디바이스, 0, (ushort)번호, out Global.신호제어.didata[(ushort)번호]);
                this[번호].현재 = Global.신호제어.didata[(ushort)번호] == 1 ? true : false;
                if (this.ContainsKey(번호)) return this[번호].현재;
                return false;
            }
        }

        private class 출력신호분석 : Dictionary<출력번호, 신호정보>
        {
            public 출력신호분석()
            {
                foreach (출력번호 번호 in Enum.GetValues(typeof(출력번호)))
                    this.Add(번호, new 신호정보());
            }

            public Dictionary<출력번호, Boolean> Set(BitArray 출력)
            {
                Dictionary<출력번호, Boolean> 변경 = new Dictionary<출력번호, Boolean>();
                foreach (var 정보 in this)
                {
                    Int32 번호 = (int)정보.Key;
                    Boolean 상태 = 출력[번호];
                    if (정보.Value.Set(상태))
                        변경.Add(정보.Key, 상태);
                }
                return 변경;
            }

            public Boolean Get(출력번호 번호)
            {
                if (this.ContainsKey(번호)) return this[번호].현재;
                return false;
            }
        }
    }
}
