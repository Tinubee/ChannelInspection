using channelInspection.Schemas;
using channelInspection.Utils;
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
    public partial class CamSetting : UserControl
    {
        public CamSetting()
        {
            InitializeComponent();
        }

        public Boolean Init()
        {
            this.dataGridView1.DataSource = Global.그랩제어.Values;
            this.dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;

            b설정저장.Click += B설정저장_Click;

            return true;
        }

        private void B설정저장_Click(object sender, EventArgs e)
        {
            if (!Util.Confirm("카메라 설정을 저장 하시겠습니까?", "Save")) return;

            Global.그랩제어.Save();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            //HikeGigE 장치 = view.GetRow(e.RowHandle) as HikeGigE;
            //if (장치 == null) return;
            //GridControl1.EmbeddedNavigator.Buttons.DoClick(GridControl1.EmbeddedNavigator.Buttons.EndEdit);
            //if (e.Column.FieldName == this.col밝기.FieldName) 장치.밝기적용();
            //else if (e.Column.FieldName == this.col대비.FieldName) 장치.대비적용();
            //else if (e.Column.FieldName == this.col노출.FieldName) 장치.노출적용();
        }
    }
}
