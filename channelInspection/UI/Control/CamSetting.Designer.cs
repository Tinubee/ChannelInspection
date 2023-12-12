namespace channelInspection.UI.Control
{
    partial class CamSetting
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.구분DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.코드DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.명칭DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.설명DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주소DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.시간DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.노출DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.밝기DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.대비DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bind카메라설정 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b설정저장 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind카메라설정)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.구분DataGridViewTextBoxColumn,
            this.코드DataGridViewTextBoxColumn,
            this.명칭DataGridViewTextBoxColumn,
            this.설명DataGridViewTextBoxColumn,
            this.주소DataGridViewTextBoxColumn,
            this.시간DataGridViewTextBoxColumn,
            this.노출DataGridViewTextBoxColumn,
            this.밝기DataGridViewTextBoxColumn,
            this.대비DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bind카메라설정;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // 구분DataGridViewTextBoxColumn
            // 
            this.구분DataGridViewTextBoxColumn.DataPropertyName = "구분";
            this.구분DataGridViewTextBoxColumn.HeaderText = "구분";
            this.구분DataGridViewTextBoxColumn.Name = "구분DataGridViewTextBoxColumn";
            // 
            // 코드DataGridViewTextBoxColumn
            // 
            this.코드DataGridViewTextBoxColumn.DataPropertyName = "코드";
            this.코드DataGridViewTextBoxColumn.HeaderText = "코드";
            this.코드DataGridViewTextBoxColumn.Name = "코드DataGridViewTextBoxColumn";
            // 
            // 명칭DataGridViewTextBoxColumn
            // 
            this.명칭DataGridViewTextBoxColumn.DataPropertyName = "명칭";
            this.명칭DataGridViewTextBoxColumn.HeaderText = "명칭";
            this.명칭DataGridViewTextBoxColumn.Name = "명칭DataGridViewTextBoxColumn";
            // 
            // 설명DataGridViewTextBoxColumn
            // 
            this.설명DataGridViewTextBoxColumn.DataPropertyName = "설명";
            this.설명DataGridViewTextBoxColumn.HeaderText = "설명";
            this.설명DataGridViewTextBoxColumn.Name = "설명DataGridViewTextBoxColumn";
            // 
            // 주소DataGridViewTextBoxColumn
            // 
            this.주소DataGridViewTextBoxColumn.DataPropertyName = "주소";
            this.주소DataGridViewTextBoxColumn.HeaderText = "주소";
            this.주소DataGridViewTextBoxColumn.Name = "주소DataGridViewTextBoxColumn";
            // 
            // 시간DataGridViewTextBoxColumn
            // 
            this.시간DataGridViewTextBoxColumn.DataPropertyName = "시간";
            this.시간DataGridViewTextBoxColumn.HeaderText = "시간";
            this.시간DataGridViewTextBoxColumn.Name = "시간DataGridViewTextBoxColumn";
            // 
            // 노출DataGridViewTextBoxColumn
            // 
            this.노출DataGridViewTextBoxColumn.DataPropertyName = "노출";
            this.노출DataGridViewTextBoxColumn.HeaderText = "노출";
            this.노출DataGridViewTextBoxColumn.Name = "노출DataGridViewTextBoxColumn";
            // 
            // 밝기DataGridViewTextBoxColumn
            // 
            this.밝기DataGridViewTextBoxColumn.DataPropertyName = "밝기";
            this.밝기DataGridViewTextBoxColumn.HeaderText = "밝기";
            this.밝기DataGridViewTextBoxColumn.Name = "밝기DataGridViewTextBoxColumn";
            // 
            // 대비DataGridViewTextBoxColumn
            // 
            this.대비DataGridViewTextBoxColumn.DataPropertyName = "대비";
            this.대비DataGridViewTextBoxColumn.HeaderText = "대비";
            this.대비DataGridViewTextBoxColumn.Name = "대비DataGridViewTextBoxColumn";
            // 
            // bind카메라설정
            // 
            this.bind카메라설정.DataSource = typeof(channelInspection.Schemas.카메라장치);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.b설정저장, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // b설정저장
            // 
            this.b설정저장.BackColor = System.Drawing.Color.Silver;
            this.b설정저장.Dock = System.Windows.Forms.DockStyle.Right;
            this.b설정저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b설정저장.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b설정저장.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b설정저장.Image = global::channelInspection.Properties.Resources.SaveSetting;
            this.b설정저장.Location = new System.Drawing.Point(968, 308);
            this.b설정저장.Margin = new System.Windows.Forms.Padding(0);
            this.b설정저장.Name = "b설정저장";
            this.b설정저장.Size = new System.Drawing.Size(246, 55);
            this.b설정저장.TabIndex = 5;
            this.b설정저장.UseVisualStyleBackColor = false;
            // 
            // CamSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CamSetting";
            this.Size = new System.Drawing.Size(1215, 364);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind카메라설정)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bind카메라설정;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 구분DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 코드DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 명칭DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 설명DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주소DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시간DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 노출DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 밝기DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 대비DataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b설정저장;
    }
}
