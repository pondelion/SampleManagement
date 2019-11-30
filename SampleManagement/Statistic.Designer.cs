namespace SampleManagement
{
    partial class Statistic
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChemicalFormula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolerRatio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolerRatio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolerRatio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolerRatio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Element5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MolerRatio5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureMassOfElement1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureMassOfElement2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuredMassOfElement3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasureMassOfElement4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeasuredMassOfElement5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMassBeforeCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMassAfterCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LossRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThresholdLossRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccessOrFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauseOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XRDAfterCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XRDDataAfterCreation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SampleImageAfterCreation = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AnnealingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMassAfterAnnealing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XRDAfterAnnealing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XRDDataAfterAnnealing = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SampleImageAfterAnnealing = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.splitter1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sample List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SketchFlow Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "データを追加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(3, 50);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(768, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "絞り込み";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(170, 15);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 16);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 20);
            this.comboBox1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "作成者";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail,
            this.edit,
            this.delete,
            this.Creator,
            this.CreationDate,
            this.SampleNumber,
            this.ChemicalFormula,
            this.x,
            this.y,
            this.z,
            this.Element1,
            this.MolerRatio1,
            this.Element2,
            this.MolerRatio2,
            this.Element3,
            this.MolerRatio3,
            this.Element4,
            this.MolerRatio4,
            this.Element5,
            this.MolerRatio5,
            this.MeasureMassOfElement1,
            this.MeasureMassOfElement2,
            this.MeasuredMassOfElement3,
            this.MeasureMassOfElement4,
            this.MeasuredMassOfElement5,
            this.TotalMassBeforeCreation,
            this.TotalMassAfterCreation,
            this.LossRate,
            this.ThresholdLossRate,
            this.SuccessOrFailure,
            this.CauseOfFailure,
            this.CreationRemark,
            this.XRDAfterCreation,
            this.XRDDataAfterCreation,
            this.SampleImageAfterCreation,
            this.AnnealingDate,
            this.TotalMassAfterAnnealing,
            this.XRDAfterAnnealing,
            this.XRDDataAfterAnnealing,
            this.SampleImageAfterAnnealing});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(768, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // detail
            // 
            this.detail.HeaderText = "詳細";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Width = 40;
            // 
            // edit
            // 
            this.edit.HeaderText = "編集";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 40;
            // 
            // delete
            // 
            this.delete.HeaderText = "削除";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 40;
            // 
            // Creator
            // 
            this.Creator.HeaderText = "作成者";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "作成日";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // SampleNumber
            // 
            this.SampleNumber.HeaderText = "ｻﾝﾌﾟﾙﾅﾝﾊﾞｰ";
            this.SampleNumber.Name = "SampleNumber";
            this.SampleNumber.ReadOnly = true;
            // 
            // ChemicalFormula
            // 
            this.ChemicalFormula.HeaderText = "組成式";
            this.ChemicalFormula.Name = "ChemicalFormula";
            this.ChemicalFormula.ReadOnly = true;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Width = 20;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            this.y.Width = 20;
            // 
            // z
            // 
            this.z.HeaderText = "z";
            this.z.Name = "z";
            this.z.ReadOnly = true;
            this.z.Width = 20;
            // 
            // Element1
            // 
            this.Element1.HeaderText = "元素1";
            this.Element1.Name = "Element1";
            this.Element1.ReadOnly = true;
            this.Element1.Width = 50;
            // 
            // MolerRatio1
            // 
            this.MolerRatio1.HeaderText = "元素1モル比";
            this.MolerRatio1.Name = "MolerRatio1";
            this.MolerRatio1.ReadOnly = true;
            this.MolerRatio1.Width = 70;
            // 
            // Element2
            // 
            this.Element2.HeaderText = "元素2";
            this.Element2.Name = "Element2";
            this.Element2.ReadOnly = true;
            this.Element2.Width = 50;
            // 
            // MolerRatio2
            // 
            this.MolerRatio2.HeaderText = "元素2モル比";
            this.MolerRatio2.Name = "MolerRatio2";
            this.MolerRatio2.ReadOnly = true;
            this.MolerRatio2.Width = 70;
            // 
            // Element3
            // 
            this.Element3.HeaderText = "元素3";
            this.Element3.Name = "Element3";
            this.Element3.ReadOnly = true;
            this.Element3.Width = 50;
            // 
            // MolerRatio3
            // 
            this.MolerRatio3.HeaderText = "元素3モル比";
            this.MolerRatio3.Name = "MolerRatio3";
            this.MolerRatio3.ReadOnly = true;
            this.MolerRatio3.Width = 70;
            // 
            // Element4
            // 
            this.Element4.HeaderText = "元素4";
            this.Element4.Name = "Element4";
            this.Element4.ReadOnly = true;
            this.Element4.Width = 50;
            // 
            // MolerRatio4
            // 
            this.MolerRatio4.HeaderText = "元素4モル比";
            this.MolerRatio4.Name = "MolerRatio4";
            this.MolerRatio4.ReadOnly = true;
            this.MolerRatio4.Width = 70;
            // 
            // Element5
            // 
            this.Element5.HeaderText = "元素5";
            this.Element5.Name = "Element5";
            this.Element5.ReadOnly = true;
            this.Element5.Width = 50;
            // 
            // MolerRatio5
            // 
            this.MolerRatio5.HeaderText = "元素5モル比";
            this.MolerRatio5.Name = "MolerRatio5";
            this.MolerRatio5.ReadOnly = true;
            this.MolerRatio5.Width = 70;
            // 
            // MeasureMassOfElement1
            // 
            this.MeasureMassOfElement1.HeaderText = "元素1秤量質量";
            this.MeasureMassOfElement1.Name = "MeasureMassOfElement1";
            this.MeasureMassOfElement1.ReadOnly = true;
            // 
            // MeasureMassOfElement2
            // 
            this.MeasureMassOfElement2.HeaderText = "元素2秤量質量";
            this.MeasureMassOfElement2.Name = "MeasureMassOfElement2";
            this.MeasureMassOfElement2.ReadOnly = true;
            // 
            // MeasuredMassOfElement3
            // 
            this.MeasuredMassOfElement3.HeaderText = "元素3秤量質量";
            this.MeasuredMassOfElement3.Name = "MeasuredMassOfElement3";
            this.MeasuredMassOfElement3.ReadOnly = true;
            // 
            // MeasureMassOfElement4
            // 
            this.MeasureMassOfElement4.HeaderText = "元素4秤量質量";
            this.MeasureMassOfElement4.Name = "MeasureMassOfElement4";
            this.MeasureMassOfElement4.ReadOnly = true;
            // 
            // MeasuredMassOfElement5
            // 
            this.MeasuredMassOfElement5.HeaderText = "元素5秤量質量";
            this.MeasuredMassOfElement5.Name = "MeasuredMassOfElement5";
            this.MeasuredMassOfElement5.ReadOnly = true;
            // 
            // TotalMassBeforeCreation
            // 
            this.TotalMassBeforeCreation.HeaderText = "作成前合計秤量質量";
            this.TotalMassBeforeCreation.Name = "TotalMassBeforeCreation";
            this.TotalMassBeforeCreation.ReadOnly = true;
            // 
            // TotalMassAfterCreation
            // 
            this.TotalMassAfterCreation.HeaderText = "作成後秤量質量";
            this.TotalMassAfterCreation.Name = "TotalMassAfterCreation";
            this.TotalMassAfterCreation.ReadOnly = true;
            // 
            // LossRate
            // 
            this.LossRate.HeaderText = "欠損率(%)";
            this.LossRate.Name = "LossRate";
            this.LossRate.ReadOnly = true;
            // 
            // ThresholdLossRate
            // 
            this.ThresholdLossRate.HeaderText = "欠損率閾値(%)";
            this.ThresholdLossRate.Name = "ThresholdLossRate";
            this.ThresholdLossRate.ReadOnly = true;
            // 
            // SuccessOrFailure
            // 
            this.SuccessOrFailure.HeaderText = "成否";
            this.SuccessOrFailure.Name = "SuccessOrFailure";
            this.SuccessOrFailure.ReadOnly = true;
            // 
            // CauseOfFailure
            // 
            this.CauseOfFailure.HeaderText = "失敗原因";
            this.CauseOfFailure.Name = "CauseOfFailure";
            this.CauseOfFailure.ReadOnly = true;
            // 
            // CreationRemark
            // 
            this.CreationRemark.HeaderText = "作成時備考";
            this.CreationRemark.Name = "CreationRemark";
            this.CreationRemark.ReadOnly = true;
            // 
            // XRDAfterCreation
            // 
            this.XRDAfterCreation.HeaderText = "作成後X線回折有無";
            this.XRDAfterCreation.Name = "XRDAfterCreation";
            this.XRDAfterCreation.ReadOnly = true;
            // 
            // XRDDataAfterCreation
            // 
            this.XRDDataAfterCreation.HeaderText = "作成後X線回折ﾃﾞｰﾀ";
            this.XRDDataAfterCreation.Name = "XRDDataAfterCreation";
            this.XRDDataAfterCreation.ReadOnly = true;
            this.XRDDataAfterCreation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XRDDataAfterCreation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SampleImageAfterCreation
            // 
            this.SampleImageAfterCreation.HeaderText = "作成後試料写真";
            this.SampleImageAfterCreation.Name = "SampleImageAfterCreation";
            this.SampleImageAfterCreation.ReadOnly = true;
            this.SampleImageAfterCreation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SampleImageAfterCreation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AnnealingDate
            // 
            this.AnnealingDate.HeaderText = "アニール日";
            this.AnnealingDate.Name = "AnnealingDate";
            this.AnnealingDate.ReadOnly = true;
            // 
            // TotalMassAfterAnnealing
            // 
            this.TotalMassAfterAnnealing.HeaderText = "アニール後質量";
            this.TotalMassAfterAnnealing.Name = "TotalMassAfterAnnealing";
            this.TotalMassAfterAnnealing.ReadOnly = true;
            // 
            // XRDAfterAnnealing
            // 
            this.XRDAfterAnnealing.HeaderText = "ｱﾆｰﾙ後X線回折有無";
            this.XRDAfterAnnealing.Name = "XRDAfterAnnealing";
            this.XRDAfterAnnealing.ReadOnly = true;
            // 
            // XRDDataAfterAnnealing
            // 
            this.XRDDataAfterAnnealing.HeaderText = "ｱﾆｰﾙ後X線回折ﾃﾞｰﾀ";
            this.XRDDataAfterAnnealing.Name = "XRDDataAfterAnnealing";
            this.XRDDataAfterAnnealing.ReadOnly = true;
            this.XRDDataAfterAnnealing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.XRDDataAfterAnnealing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SampleImageAfterAnnealing
            // 
            this.SampleImageAfterAnnealing.HeaderText = "ｱﾆｰﾙ後試料写真";
            this.SampleImageAfterAnnealing.Name = "SampleImageAfterAnnealing";
            this.SampleImageAfterAnnealing.ReadOnly = true;
            this.SampleImageAfterAnnealing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SampleImageAfterAnnealing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Statistic";
            this.Text = "Statistic";
            this.Load += new System.EventHandler(this.Statistic_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChemicalFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolerRatio1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolerRatio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolerRatio3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolerRatio4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Element5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MolerRatio5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureMassOfElement1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureMassOfElement2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuredMassOfElement3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasureMassOfElement4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeasuredMassOfElement5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMassBeforeCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMassAfterCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn LossRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThresholdLossRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuccessOrFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauseOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn XRDAfterCreation;
        private System.Windows.Forms.DataGridViewButtonColumn XRDDataAfterCreation;
        private System.Windows.Forms.DataGridViewButtonColumn SampleImageAfterCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnnealingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMassAfterAnnealing;
        private System.Windows.Forms.DataGridViewTextBoxColumn XRDAfterAnnealing;
        private System.Windows.Forms.DataGridViewButtonColumn XRDDataAfterAnnealing;
        private System.Windows.Forms.DataGridViewButtonColumn SampleImageAfterAnnealing;
    }
}