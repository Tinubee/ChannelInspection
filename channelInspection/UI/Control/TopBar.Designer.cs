namespace channelInspection.UI.Control
{
    partial class TopBar
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b창최대화 = new System.Windows.Forms.Button();
            this.b창최소화 = new System.Windows.Forms.Button();
            this.b창닫기 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.deviceLamp1 = new channelInspection.UI.Control.DeviceLamp();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.b창최대화, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.b창최소화, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b창닫기, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1771, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // b창최대화
            // 
            this.b창최대화.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b창최대화.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b창최대화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b창최대화.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b창최대화.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b창최대화.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.b창최대화.Location = new System.Drawing.Point(50, 1);
            this.b창최대화.Margin = new System.Windows.Forms.Padding(0);
            this.b창최대화.Name = "b창최대화";
            this.b창최대화.Size = new System.Drawing.Size(48, 38);
            this.b창최대화.TabIndex = 2;
            this.b창최대화.Text = "ㅁ";
            this.b창최대화.UseVisualStyleBackColor = true;
            // 
            // b창최소화
            // 
            this.b창최소화.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b창최소화.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b창최소화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b창최소화.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b창최소화.Location = new System.Drawing.Point(1, 1);
            this.b창최소화.Margin = new System.Windows.Forms.Padding(0);
            this.b창최소화.Name = "b창최소화";
            this.b창최소화.Size = new System.Drawing.Size(48, 38);
            this.b창최소화.TabIndex = 1;
            this.b창최소화.Text = "ㅡ";
            this.b창최소화.UseVisualStyleBackColor = true;
            // 
            // b창닫기
            // 
            this.b창닫기.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.b창닫기.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b창닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b창닫기.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.b창닫기.Location = new System.Drawing.Point(99, 1);
            this.b창닫기.Margin = new System.Windows.Forms.Padding(0);
            this.b창닫기.Name = "b창닫기";
            this.b창닫기.Size = new System.Drawing.Size(49, 38);
            this.b창닫기.TabIndex = 0;
            this.b창닫기.Text = "X";
            this.b창닫기.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.deviceLamp1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 40);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // deviceLamp1
            // 
            this.deviceLamp1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.deviceLamp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceLamp1.Location = new System.Drawing.Point(1, 1);
            this.deviceLamp1.Margin = new System.Windows.Forms.Padding(0);
            this.deviceLamp1.Name = "deviceLamp1";
            this.deviceLamp1.Size = new System.Drawing.Size(446, 38);
            this.deviceLamp1.TabIndex = 0;
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(1920, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b창최대화;
        private System.Windows.Forms.Button b창최소화;
        private System.Windows.Forms.Button b창닫기;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DeviceLamp deviceLamp1;
    }
}
