using GraphicsSetModuleCs;
using ImageSourceModuleCs;
using OpenCvSharp;
using ShellModuleCs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using VM.Core;
using VM.PlatformSDKCS;

namespace channelInspection.Schemas
{
    public enum Flow구분
    {
        Flow1 = 카메라구분.Cam01,
        Flow2 = 카메라구분.Cam02,
        Flow3 = 카메라구분.Cam03,
        Flow4 = 카메라구분.Cam04,
        Flow5 = 카메라구분.Cam05,
        Flow6 = 카메라구분.Cam06,
    }
    public class 비전도구 : List<비전마스터플로우>
    {
        public 비전도구() { }
        public VmGlobals 글로벌변수제어 = new VmGlobals();
        public Boolean Init() => Load();
        public void Save() => VmSolution.Save();

        public Boolean Load()
        {
            try
            {
                base.Clear();
                string 도구파일 = Global.모델자료[(int)Global.환경설정.선택모델].솔루션파일저장경로;
                //VM Solution 불러오기
                if (File.Exists(도구파일))
                {
                    VmSolution.Load(도구파일, null);
                    글로벌변수제어.Init();
                    VmSolution.Instance.DisableModulesCallback();
                    //Global.정보로그(로그영역, "솔루션 로드", "솔루션을 로드하였습니다.", false);
                }
                else
                {
                    //Global.오류로그(로그영역, "솔루션 로드", "솔루션파일이 없습니다.", true);
                    return false;
                }

                //모듈 콜백 Disable
                VmSolution.Instance.DisableModulesCallback();
                //데이터 새롭게 추가
                foreach (Flow구분 구분 in Enum.GetValues(typeof(Flow구분))) base.Add(new 비전마스터플로우(구분, "0"));

                return true;
            }
            catch (Exception e)
            {
                //Global.오류로그(로그영역, "솔루션 로드", "솔루션을 로드하는 중 오류가 발생하였습니다.", true);
                Debug.WriteLine(e.Message, "솔루션 로드");
                return false;
            }
        }

        public 비전마스터플로우 GetItem(Flow구분 구분)
        {
            foreach (비전마스터플로우 플로우 in this)
                if (플로우.구분 == 구분) return 플로우;
            return null;
        }

        public 비전마스터플로우 GetItem(카메라구분 구분)
        {
            foreach (비전마스터플로우 플로우 in this)
                if ((int)플로우.구분 == (int)구분) return 플로우;
            return null;
        }
        public void Close()
        {
            VmSolution.Instance.CloseSolution();
        }
    }

    public class 비전마스터플로우
    {
        public Flow구분 구분;
        public Boolean 결과;
        public Boolean 결과업데이트완료;
        public String PLC결과주소OK;
        public String PLC결과주소NG;

        public VmProcedure Procedure;
        public ImageSourceModuleTool imageSourceModuleTool;
        public GraphicsSetModuleTool graphicsSetModuleTool;
        public ShellModuleTool shellModuleTool;

        public 비전마스터플로우(Flow구분 구분, String plcAddress)
        {
            this.구분 = 구분;
            this.Init();
            if (this.graphicsSetModuleTool != null)
            {
                this.graphicsSetModuleTool.EnableResultCallback();
                this.shellModuleTool.EnableResultCallback();
                this.shellModuleTool.ModuleResultCallBackArrived += ShellModuleTool_ModuleResultCallBackArrived;
            }
            this.결과 = false;
            this.결과업데이트완료 = false;
        }
        private void ShellModuleTool_ModuleResultCallBackArrived(object sender, EventArgs e) { }

        public void Init()
        {
            this.Procedure = VmSolution.Instance[this.구분.ToString()] as VmProcedure;
            if (Procedure != null)
            {
                this.imageSourceModuleTool = this.Procedure["InputImage"] as ImageSourceModuleTool;
                this.graphicsSetModuleTool = this.Procedure["OutPutImage"] as GraphicsSetModuleTool;
                this.shellModuleTool = this.Procedure["결과"] as ShellModuleTool;

                if (this.imageSourceModuleTool != null)
                    this.imageSourceModuleTool.ModuParams.ImageSourceType = ImageSourceParam.ImageSourceTypeEnum.SDK;
            }
        }

        public Boolean Run(Mat mat)
        {
            this.결과 = false;
            this.결과업데이트완료 = false;
            if (this.imageSourceModuleTool == null)
            {
                //Global.오류로그(로그영역, "검사오류", $"[{구분}] VM 검사 모델이 없습니다.", false);
                return false;
            }
            try
            {
                this.imageSourceModuleTool.SetImageData(MatToImageBaseData(mat));
                this.Procedure.Run();
                // this.SetResult(구분);
                if ((ImvsSdkDefine.IMVS_MODULE_STRING_VALUE_EX[])this.shellModuleTool.Outputs[6].Value != null)
                {
                    String resultString = this.shellModuleTool == null ? "NG" : ((ImvsSdkDefine.IMVS_MODULE_STRING_VALUE_EX[])this.shellModuleTool.Outputs[6].Value)[0].strValue;
                    this.결과 = resultString == "OK" ? true : false;
                }


                //PLC에 검사결과 전송부분 추가해야됨.

                return true;
            }
            catch (Exception ex)
            {
                //Global.오류로그(로그영역, "검사오류", $"[{구분}] VM 검사오류: {ex.Message}", false);
                return false;
            }
        }

        private ImageBaseData MatToImageBaseData(Mat mat)
        {
            if (mat.Channels() != 1) return null;
            ImageBaseData imageBaseData;
            uint dataLen = (uint)(mat.Width * mat.Height * mat.Channels());
            byte[] buffer = new byte[dataLen];
            Marshal.Copy(mat.Ptr(0), buffer, 0, buffer.Length);
            imageBaseData = new ImageBaseData(buffer, dataLen, mat.Width, mat.Height, (int)VMPixelFormat.VM_PIXEL_MONO_08);
            return imageBaseData;
        }
    }
}
