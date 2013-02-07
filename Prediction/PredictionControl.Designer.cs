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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewDataSet = new System.Windows.Forms.DataGridView();
            this.ACID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3Active);
            this.groupBox1.Controls.Add(this.checkBox1Active);
            this.groupBox1.Controls.Add(this.checkBox2Active);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prediction Tables";
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
            this.groupBox2.Location = new System.Drawing.Point(123, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 118);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATA SET";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(285, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(92, 118);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Set";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Table 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Table 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Table 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridViewDataSet.Location = new System.Drawing.Point(10, 140);
            this.dataGridViewDataSet.Name = "dataGridViewDataSet";
            this.dataGridViewDataSet.ReadOnly = true;
            this.dataGridViewDataSet.Size = new System.Drawing.Size(357, 150);
            this.dataGridViewDataSet.TabIndex = 5;
            // 
            // ACID
            // 
            this.ACID.HeaderText = "ACID";
            this.ACID.Name = "ACID";
            this.ACID.ReadOnly = true;
            this.ACID.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "LAT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // LON
            // 
            this.LON.HeaderText = "LON";
            this.LON.Name = "LON";
            this.LON.ReadOnly = true;
            this.LON.Width = 50;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
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
            // PredictionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 608);
            this.Controls.Add(this.dataGridViewDataSet);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataSet)).EndInit();
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
        private System.Windows.Forms.Label label4;
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



    }
}