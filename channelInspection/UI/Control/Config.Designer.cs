namespace channelInspection.UI.Control
{
    partial class Config
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b이미지저장경로선택 = new System.Windows.Forms.Button();
            this.tb데이터저장경로 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb설정저장경로 = new System.Windows.Forms.TextBox();
            this.tb이미지저장경로 = new System.Windows.Forms.TextBox();
            this.b설정저장경로선택 = new System.Windows.Forms.Button();
            this.b데이터저장경로선택 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb불량이미지저장여부 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cb양품이미지저장여부 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cb비전검사사용여부 = new System.Windows.Forms.CheckBox();
            this.n검사자료보관일 = new System.Windows.Forms.NumericUpDown();
            this.n로그보관일 = new System.Windows.Forms.NumericUpDown();
            this.n검사결과자릿수 = new System.Windows.Forms.NumericUpDown();
            this.b설정저장 = new System.Windows.Forms.Button();
            this.d기본경로 = new System.Windows.Forms.FolderBrowserDialog();
            this.d데이터저장 = new System.Windows.Forms.FolderBrowserDialog();
            this.d이미지저장 = new System.Windows.Forms.FolderBrowserDialog();
            this.bind환경설정 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n검사자료보관일)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n로그보관일)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n검사결과자릿수)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind환경설정)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.b이미지저장경로선택, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb데이터저장경로, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb설정저장경로, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb이미지저장경로, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b설정저장경로선택, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b데이터저장경로선택, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 136);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // b이미지저장경로선택
            // 
            this.b이미지저장경로선택.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b이미지저장경로선택.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b이미지저장경로선택.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b이미지저장경로선택.Location = new System.Drawing.Point(1092, 91);
            this.b이미지저장경로선택.Margin = new System.Windows.Forms.Padding(0);
            this.b이미지저장경로선택.Name = "b이미지저장경로선택";
            this.b이미지저장경로선택.Size = new System.Drawing.Size(122, 44);
            this.b이미지저장경로선택.TabIndex = 8;
            this.b이미지저장경로선택.Text = "선 택";
            this.b이미지저장경로선택.UseVisualStyleBackColor = true;
            // 
            // tb데이터저장경로
            // 
            this.tb데이터저장경로.BackColor = System.Drawing.Color.DimGray;
            this.tb데이터저장경로.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb데이터저장경로.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb데이터저장경로.Location = new System.Drawing.Point(244, 46);
            this.tb데이터저장경로.Margin = new System.Windows.Forms.Padding(0);
            this.tb데이터저장경로.Name = "tb데이터저장경로";
            this.tb데이터저장경로.ReadOnly = true;
            this.tb데이터저장경로.Size = new System.Drawing.Size(847, 39);
            this.tb데이터저장경로.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "설정 저장 경로";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(1, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "데이터 저장 경로";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(1, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "이미지 저장 경로";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb설정저장경로
            // 
            this.tb설정저장경로.BackColor = System.Drawing.Color.DimGray;
            this.tb설정저장경로.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb설정저장경로.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb설정저장경로.Location = new System.Drawing.Point(244, 1);
            this.tb설정저장경로.Margin = new System.Windows.Forms.Padding(0);
            this.tb설정저장경로.Name = "tb설정저장경로";
            this.tb설정저장경로.ReadOnly = true;
            this.tb설정저장경로.Size = new System.Drawing.Size(847, 39);
            this.tb설정저장경로.TabIndex = 3;
            // 
            // tb이미지저장경로
            // 
            this.tb이미지저장경로.BackColor = System.Drawing.Color.DimGray;
            this.tb이미지저장경로.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb이미지저장경로.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb이미지저장경로.Location = new System.Drawing.Point(244, 91);
            this.tb이미지저장경로.Margin = new System.Windows.Forms.Padding(0);
            this.tb이미지저장경로.Name = "tb이미지저장경로";
            this.tb이미지저장경로.ReadOnly = true;
            this.tb이미지저장경로.Size = new System.Drawing.Size(847, 39);
            this.tb이미지저장경로.TabIndex = 5;
            // 
            // b설정저장경로선택
            // 
            this.b설정저장경로선택.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b설정저장경로선택.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b설정저장경로선택.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b설정저장경로선택.Location = new System.Drawing.Point(1092, 1);
            this.b설정저장경로선택.Margin = new System.Windows.Forms.Padding(0);
            this.b설정저장경로선택.Name = "b설정저장경로선택";
            this.b설정저장경로선택.Size = new System.Drawing.Size(122, 44);
            this.b설정저장경로선택.TabIndex = 6;
            this.b설정저장경로선택.Text = "선 택";
            this.b설정저장경로선택.UseVisualStyleBackColor = true;
            // 
            // b데이터저장경로선택
            // 
            this.b데이터저장경로선택.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b데이터저장경로선택.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b데이터저장경로선택.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b데이터저장경로선택.Location = new System.Drawing.Point(1092, 46);
            this.b데이터저장경로선택.Margin = new System.Windows.Forms.Padding(0);
            this.b데이터저장경로선택.Name = "b데이터저장경로선택";
            this.b데이터저장경로선택.Size = new System.Drawing.Size(122, 44);
            this.b데이터저장경로선택.TabIndex = 7;
            this.b데이터저장경로선택.Text = "선 택";
            this.b데이터저장경로선택.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1215, 364);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.b설정저장, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 136);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1215, 228);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.n검사자료보관일, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.n로그보관일, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.n검사결과자릿수, 3, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1215, 159);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.cb불량이미지저장여부, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(304, 1);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(302, 38);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(1, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 36);
            this.label8.TabIndex = 7;
            this.label8.Text = "NG 이미지 저장";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb불량이미지저장여부
            // 
            this.cb불량이미지저장여부.AutoSize = true;
            this.cb불량이미지저장여부.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb불량이미지저장여부.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb불량이미지저장여부.Location = new System.Drawing.Point(151, 1);
            this.cb불량이미지저장여부.Margin = new System.Windows.Forms.Padding(0);
            this.cb불량이미지저장여부.Name = "cb불량이미지저장여부";
            this.cb불량이미지저장여부.Size = new System.Drawing.Size(150, 36);
            this.cb불량이미지저장여부.TabIndex = 8;
            this.cb불량이미지저장여부.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(607, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "검사 결과 자릿수";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(607, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 38);
            this.label6.TabIndex = 5;
            this.label6.Text = "로그 보관일";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(607, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "검사 자료 보관일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.cb양품이미지저장여부, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(302, 38);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(1, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 36);
            this.label7.TabIndex = 7;
            this.label7.Text = "OK 이미지 저장";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb양품이미지저장여부
            // 
            this.cb양품이미지저장여부.AutoSize = true;
            this.cb양품이미지저장여부.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb양품이미지저장여부.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb양품이미지저장여부.Location = new System.Drawing.Point(151, 1);
            this.cb양품이미지저장여부.Margin = new System.Windows.Forms.Padding(0);
            this.cb양품이미지저장여부.Name = "cb양품이미지저장여부";
            this.cb양품이미지저장여부.Size = new System.Drawing.Size(150, 36);
            this.cb양품이미지저장여부.TabIndex = 8;
            this.cb양품이미지저장여부.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cb비전검사사용여부, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1, 79);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(302, 38);
            this.tableLayoutPanel7.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(1, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 36);
            this.label9.TabIndex = 7;
            this.label9.Text = "검사 여부";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb비전검사사용여부
            // 
            this.cb비전검사사용여부.AutoSize = true;
            this.cb비전검사사용여부.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb비전검사사용여부.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb비전검사사용여부.Location = new System.Drawing.Point(151, 1);
            this.cb비전검사사용여부.Margin = new System.Windows.Forms.Padding(0);
            this.cb비전검사사용여부.Name = "cb비전검사사용여부";
            this.cb비전검사사용여부.Size = new System.Drawing.Size(150, 36);
            this.cb비전검사사용여부.TabIndex = 8;
            this.cb비전검사사용여부.UseVisualStyleBackColor = true;
            // 
            // n검사자료보관일
            // 
            this.n검사자료보관일.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n검사자료보관일.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.n검사자료보관일.Location = new System.Drawing.Point(910, 1);
            this.n검사자료보관일.Margin = new System.Windows.Forms.Padding(0);
            this.n검사자료보관일.Name = "n검사자료보관일";
            this.n검사자료보관일.Size = new System.Drawing.Size(304, 35);
            this.n검사자료보관일.TabIndex = 9;
            this.n검사자료보관일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n로그보관일
            // 
            this.n로그보관일.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n로그보관일.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.n로그보관일.Location = new System.Drawing.Point(910, 40);
            this.n로그보관일.Margin = new System.Windows.Forms.Padding(0);
            this.n로그보관일.Name = "n로그보관일";
            this.n로그보관일.Size = new System.Drawing.Size(304, 35);
            this.n로그보관일.TabIndex = 10;
            this.n로그보관일.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // n검사결과자릿수
            // 
            this.n검사결과자릿수.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n검사결과자릿수.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.n검사결과자릿수.Location = new System.Drawing.Point(910, 79);
            this.n검사결과자릿수.Margin = new System.Windows.Forms.Padding(0);
            this.n검사결과자릿수.Name = "n검사결과자릿수";
            this.n검사결과자릿수.Size = new System.Drawing.Size(304, 35);
            this.n검사결과자릿수.TabIndex = 11;
            this.n검사결과자릿수.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b설정저장
            // 
            this.b설정저장.BackColor = System.Drawing.Color.Silver;
            this.b설정저장.Dock = System.Windows.Forms.DockStyle.Right;
            this.b설정저장.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b설정저장.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.b설정저장.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b설정저장.Image = global::channelInspection.Properties.Resources.SaveSetting;
            this.b설정저장.Location = new System.Drawing.Point(910, 159);
            this.b설정저장.Margin = new System.Windows.Forms.Padding(0);
            this.b설정저장.Name = "b설정저장";
            this.b설정저장.Size = new System.Drawing.Size(305, 69);
            this.b설정저장.TabIndex = 4;
            this.b설정저장.UseVisualStyleBackColor = false;
            // 
            // bind환경설정
            // 
            this.bind환경설정.DataSource = typeof(channelInspection.Schemas.환경설정);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Config";
            this.Size = new System.Drawing.Size(1215, 364);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n검사자료보관일)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n로그보관일)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n검사결과자릿수)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bind환경설정)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb데이터저장경로;
        private System.Windows.Forms.TextBox tb설정저장경로;
        private System.Windows.Forms.TextBox tb이미지저장경로;
        private System.Windows.Forms.Button b이미지저장경로선택;
        private System.Windows.Forms.Button b설정저장경로선택;
        private System.Windows.Forms.Button b데이터저장경로선택;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb불량이미지저장여부;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb양품이미지저장여부;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cb비전검사사용여부;
        private System.Windows.Forms.NumericUpDown n검사자료보관일;
        private System.Windows.Forms.NumericUpDown n로그보관일;
        private System.Windows.Forms.NumericUpDown n검사결과자릿수;
        private System.Windows.Forms.Button b설정저장;
        private System.Windows.Forms.FolderBrowserDialog d기본경로;
        private System.Windows.Forms.FolderBrowserDialog d데이터저장;
        private System.Windows.Forms.FolderBrowserDialog d이미지저장;
        private System.Windows.Forms.BindingSource bind환경설정;
    }
}
