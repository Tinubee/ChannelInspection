using channelInspection.Schemas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace channelInspection.UI.Control
{
    public partial class CamViewers : UserControl
    {
        public CamViewers()
        {
            InitializeComponent();
        }

        public void Init()
        {
            this.vmRenderControl1.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow1).graphicsSetModuleTool;
            this.vmRenderControl2.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow2).graphicsSetModuleTool;
            this.vmRenderControl3.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow3).graphicsSetModuleTool;
            this.vmRenderControl4.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow4).graphicsSetModuleTool;
            this.vmRenderControl5.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow5).graphicsSetModuleTool;
            this.vmRenderControl6.ModuleSource = Global.비전도구.GetItem(Flow구분.Flow6).graphicsSetModuleTool;
        }
    }
}
