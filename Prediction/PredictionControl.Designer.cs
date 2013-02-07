namespace AsterixDisplayAnalyser
{
    partial class PredictionControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3Active = new System.Windows.Forms.CheckBox();
            this.checkBox1Active = new System.Windows.Forms.CheckBox();
            this.checkBox2Active = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPswd = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHrs = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxACID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCriteria = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewDataSet = new System.Windows.Forms.DataGridView();
            this.ACID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarPrediction = new System.Windows.Forms.TrackBar();
            this.labelPredictionTimeReadout = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrediction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3Active);
            this.groupBox1.Controls.Add(this.checkBox1Active);
            this.groupBox1.Controls.Add(this.checkBox2Active);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // checkBox3Active
            // 
            this.checkBox3Active.AutoSize = true;
            this.checkBox3Active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBox3Active.Location = new System.Drawing.Point(6, 70);
            this.checkBox3Active.Name = "checkBox3Active";
            this.checkBox3Active.Size = new System.Drawing.Size(65, 17);
            this.checkBox3Active.TabIndex = 3;
            this.checkBox3Active.Text = "3 Active";
            this.checkBox3Active.UseVisualStyleBackColor = false;
            this.checkBox3Active.CheckedChanged += new System.EventHandler(this.checkBox3Active_CheckedChanged);
            // 
            // checkBox1Active
            // 
            this.checkBox1Active.AutoSize = true;
            this.checkBox1Active.BackColor = System.Drawing.Color.Yellow;
            this.checkBox1Active.Location = new System.Drawing.Point(6, 24);
            this.checkBox1Active.Name = "checkBox1Active";
            this.checkBox1Active.Size = new System.Drawing.Size(65, 17);
            this.checkBox1Active.TabIndex = 1;
            this.checkBox1Active.Text = "1 Active";
            this.checkBox1Active.UseVisualStyleBackColor = false;
            this.checkBox1Active.CheckedChanged += new System.EventHandler(this.checkBox1Active_CheckedChanged);
            // 
            // checkBox2Active
            // 
            this.checkBox2Active.AutoSize = true;
            this.checkBox2Active.BackColor = System.Drawing.Color.Blue;
            this.checkBox2Active.Location = new System.Drawing.Point(6, 47);
            this.checkBox2Active.Name = "checkBox2Active";
            this.checkBox2Active.Size = new System.Drawing.Size(65, 17);
            this.checkBox2Active.TabIndex = 2;
            this.checkBox2Active.Text = "2 Active";
            this.checkBox2Active.UseVisualStyleBackColor = false;
            this.checkBox2Active.CheckedChanged += new System.EventHandler(this.checkBox2Active_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPswd);
            this.groupBox2.Controls.Add(this.labelUser);
            this.groupBox2.Controls.Add(this.labelServer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(96, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "My Sql Connection";
            // 
            // labelPswd
            // 
            this.labelPswd.AutoSize = true;
            this.labelPswd.Location = new System.Drawing.Point(42, 65);
            this.labelPswd.Name = "labelPswd";
            this.labelPswd.Size = new System.Drawing.Size(35, 13);
            this.labelPswd.TabIndex = 6;
            this.labelPswd.Text = "label6";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(42, 42);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(35, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "label5";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(42, 19);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(35, 13);
            this.labelServer.TabIndex = 4;
            this.labelServer.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "user:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "server:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set/Modify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numericUpDownMin);
            this.groupBox3.Controls.Add(this.numericUpDownHrs);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxACID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxCriteria);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(215, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 118);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Lookup Settings";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(155, 89);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownMin.TabIndex = 11;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownHrs
            // 
            this.numericUpDownHrs.Location = new System.Drawing.Point(110, 89);
            this.numericUpDownHrs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHrs.Name = "numericUpDownHrs";
            this.numericUpDownHrs.Size = new System.Drawing.Size(32, 20);
            this.numericUpDownHrs.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Time ahead";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "ACID";
            // 
            // comboBoxACID
            // 
            this.comboBoxACID.FormattingEnabled = true;
            this.comboBoxACID.Location = new System.Drawing.Point(107, 61);
            this.comboBoxACID.Name = "comboBoxACID";
            this.comboBoxACID.Size = new System.Drawing.Size(109, 21);
            this.comboBoxACID.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Retrieve By";
            // 
            // comboBoxCriteria
            // 
            this.comboBoxCriteria.FormattingEnabled = true;
            this.comboBoxCriteria.Items.AddRange(new object[] {
            "No Filter",
            "ACID & Time",
            "Time Only",
            "ACID Only"});
            this.comboBoxCriteria.Location = new System.Drawing.Point(80, 34);
            this.comboBoxCriteria.Name = "comboBoxCriteria";
            this.comboBoxCriteria.Size = new System.Drawing.Size(136, 21);
            this.comboBoxCriteria.TabIndex = 4;
            this.comboBoxCriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCriteria_SelectedIndexChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 56);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Table 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Table 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Table 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(427, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewDataSet
            // 
            this.dataGridViewDataSet.AllowUserToDeleteRows = false;
            this.dataGridViewDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACID,
            this.Column1,
            this.LON,
            this.Time,
            this.FL,
            this.ACUR});
            this.dataGridViewDataSet.Location = new System.Drawing.Point(10, 178);
            this.dataGridViewDataSet.Name = "dataGridViewDataSet";
            this.dataGridViewDataSet.ReadOnly = true;
            this.dataGridViewDataSet.Size = new System.Drawing.Size(427, 401);
            this.dataGridViewDataSet.TabIndex = 5;
            // 
            // ACID
            // 
            this.ACID.HeaderText = "ACID";
            this.ACID.Name = "ACID";
            this.ACID.ReadOnly = true;
            this.ACID.Width = 57;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LAT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // LON
            // 
            this.LON.HeaderText = "LON";
            this.LON.Name = "LON";
            this.LON.ReadOnly = true;
            this.LON.Width = 60;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 130;
            // 
            // FL
            // 
            this.FL.HeaderText = "FL";
            this.FL.Name = "FL";
            this.FL.ReadOnly = true;
            this.FL.Width = 30;
            // 
            // ACUR
            // 
            this.ACUR.HeaderText = "ACUR";
            this.ACUR.Name = "ACUR";
            this.ACUR.ReadOnly = true;
            this.ACUR.Width = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "h";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "min";
            // 
            // trackBarPrediction
            // 
            this.trackBarPrediction.LargeChange = 60;
            this.trackBarPrediction.Location = new System.Drawing.Point(12, 127);
            this.trackBarPrediction.Maximum = 600;
            this.trackBarPrediction.Name = "trackBarPrediction";
            this.trackBarPrediction.Size = new System.Drawing.Size(425, 45);
            this.trackBarPrediction.TabIndex = 6;
            this.trackBarPrediction.TickFrequency = 60;
            this.trackBarPrediction.Value = 1;
            this.trackBarPrediction.ValueChanged += new System.EventHandler(this.trackBarPrediction_ValueChanged);
            // 
            // labelPredictionTimeReadout
            // 
            this.labelPredictionTimeReadout.AutoSize = true;
            this.labelPredictionTimeReadout.Location = new System.Drawing.Point(18, 158);
            this.labelPredictionTimeReadout.Name = "labelPredictionTimeReadout";
            this.labelPredictionTimeReadout.Size = new System.Drawing.Size(68, 13);
            this.labelPredictionTimeReadout.TabIndex = 7;
            this.labelPredictionTimeReadout.Text = "00 h : 00 min";
            // 
            // PredictionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 608);
            this.Controls.Add(this.labelPredictionTimeReadout);
            this.Controls.Add(this.trackBarPrediction);
            this.Controls.Add(this.dataGridViewDataSet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.MinimumSize = new System.Drawing.Size(383, 38);
            this.Name = "PredictionControl";
            this.Text = "Prediction Control";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PredictionControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrediction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3Active;
        private System.Windows.Forms.CheckBox checkBox1Active;
        private System.Windows.Forms.CheckBox checkBox2Active;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPswd;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LON;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACUR;
        private System.Windows.Forms.ComboBox comboBoxCriteria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxACID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownHrs;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarPrediction;
        private System.Windows.Forms.Label labelPredictionTimeReadout;



    }
}