using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsterixDisplayAnalyser
{
    public partial class PredictionControl : Form
    {
        public PredictionControl()
        {
            InitializeComponent();
        }

        private void PredictionControl_Load(object sender, EventArgs e)
        {
            SyncConnectionData();
            this.comboBoxCriteria.SelectedIndex = 0;
            // Initialise Prediction Time Lookahead to the currently selected value
            this.trackBarPrediction.Value = SharedData.LookAheadTime.Minutes + (SharedData.LookAheadTime.Hours * 60);
        }

        private void SyncConnectionData()
        {
            this.labelPswd.Text = Properties.Settings.Default.mySqlDatabase;
            this.labelServer.Text = Properties.Settings.Default.MySqlServer;
            this.labelUser.Text = Properties.Settings.Default.MySqlUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionSettings CS = new ConnectionSettings();
            CS.ShowDialog();
            SyncConnectionData();
        }

        private void checkBox1Active_CheckedChanged(object sender, EventArgs e)
        {
            SharedData.Prediction1_Enabled = this.checkBox1Active.Checked;
        }

        private void checkBox2Active_CheckedChanged(object sender, EventArgs e)
        {
            SharedData.Prediction2_Enabled = this.checkBox2Active.Checked;
        }

        private void checkBox3Active_CheckedChanged(object sender, EventArgs e)
        {
            SharedData.Prediction3_Enabled = this.checkBox3Active.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get all available data
            if (this.comboBoxCriteria.SelectedIndex == 0)
            {
                System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = GetAllData();

                this.dataGridViewDataSet.Rows.Clear();
                foreach (MySqlProvider.PredictionDataSetOneRow Item in DataRetreived)
                    this.dataGridViewDataSet.Rows.Add(Item.ACID, Item.Lat, Item.Lon, Item.Time, Item.FL, Item.Accuracy);
            }
            // Get data based on ACID and Time filter
            else if (this.comboBoxCriteria.SelectedIndex == 1)
            {
            }
            // Get data based on Time only
            else if (this.comboBoxCriteria.SelectedIndex == 2)
            {
                System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = GetAllDataForDateTime();

                this.dataGridViewDataSet.Rows.Clear();
                foreach (MySqlProvider.PredictionDataSetOneRow Item in DataRetreived)
                    this.dataGridViewDataSet.Rows.Add(Item.ACID, Item.Lat, Item.Lon, Item.Time, Item.FL, Item.Accuracy);
            }
            // Get data based on ACID only
            else if (this.comboBoxCriteria.SelectedIndex == 3)
            {
                System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = GetAllDataForACID();

                this.dataGridViewDataSet.Rows.Clear();
                foreach (MySqlProvider.PredictionDataSetOneRow Item in DataRetreived)
                    this.dataGridViewDataSet.Rows.Add(Item.ACID, Item.Lat, Item.Lon, Item.Time, Item.FL, Item.Accuracy);
            }
        }

        // This method return Table Type choosen by the user
        private MySqlProvider.PredictionTableNumberType GetTableChoice()
        {
            MySqlProvider.PredictionTableNumberType Table;
            if (this.radioButton1.Checked)
                Table = MySqlProvider.PredictionTableNumberType.One;
            else if (this.radioButton2.Checked)
                Table = MySqlProvider.PredictionTableNumberType.Two;
            else
                Table = MySqlProvider.PredictionTableNumberType.Three;
            return Table;
        }
        
        // This method returns a list of ALL available data from the pre-selected table
        // It is then up to the user to decide what data to use
        private System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> GetAllData()
        {
            MySqlProvider MySQL = new MySqlProvider();
            return MySQL.GetAllData(GetTableChoice());
        }

        // This method returns a list of ALL available data from the pre-selected table
        // for the given ACID.It is then up to the user to decide what data to use
        private System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> GetAllDataForACID()
        {
            MySqlProvider MySQL = new MySqlProvider();
            return MySQL.GetAllDataForACID(GetTableChoice(), this.comboBoxACID.Text);
        }

        // This method returns a list of ALL available data from the pre-selected table
        // for the given DateTime.It is then up to the user to decide what data to use
        private System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> GetAllDataForDateTime()
        {
            MySqlProvider MySQL = new MySqlProvider();
            TimeSpan TimeToAdd = new TimeSpan(0, 0, 0);
            return MySQL.GetAllDataForTime(GetTableChoice(), TimeToAdd);
        }

        // This method returns a list of ALL available ACIDs from the currently selected table
        private System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> GetAllACIDsDataDistinct()
        {
            MySqlProvider MySQL = new MySqlProvider();
            return MySQL.GetAllACIDsDataDistinct(GetTableChoice());
        }

        private void comboBoxCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCriteria.SelectedIndex == 0)
            {
                comboBoxACID.Items.Clear();
                this.comboBoxACID.Enabled = false;
                this.numericUpDownHrs.Enabled = false;
                this.numericUpDownMin.Enabled = false;
            }
            else if (this.comboBoxCriteria.SelectedIndex == 1)
            {
                this.comboBoxACID.Enabled = true;
                this.numericUpDownHrs.Enabled = true;
                this.numericUpDownMin.Enabled = true;
                PupulateACID_ComboBox();
            }
            else if (this.comboBoxCriteria.SelectedIndex == 2)
            {
                comboBoxACID.Items.Clear();
                this.comboBoxACID.Enabled = false;
                this.numericUpDownHrs.Enabled = true;
                this.numericUpDownMin.Enabled = true;
            }
            else if (this.comboBoxCriteria.SelectedIndex == 3)
            {
                this.comboBoxACID.Enabled = true;
                this.numericUpDownHrs.Enabled = false;
                this.numericUpDownMin.Enabled = false;
                PupulateACID_ComboBox();
            }
        }

        // This method is to be called when ACID combobox is to 
        // be populated with all available ACIDs from the prediction table
        // so they can be presented to the user as available ACIDs in the filter.
        private void PupulateACID_ComboBox()
        {
            if (this.comboBoxACID.Enabled == true)
            {
                System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived = GetAllACIDsDataDistinct();

                this.comboBoxACID.Items.Clear();
                foreach (MySqlProvider.PredictionDataSetOneRow Item in DataRetreived)
                    this.comboBoxACID.Items.Add(Item.ACID);

                if (this.comboBoxACID.Items.Count > 0)
                this.comboBoxACID.SelectedIndex = 0;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PupulateACID_ComboBox();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PupulateACID_ComboBox();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            PupulateACID_ComboBox();
        }

        private void trackBarPrediction_ValueChanged(object sender, EventArgs e)
        {
            int h, min;
            h = (int)Math.Floor(this.trackBarPrediction.Value / 60.0);
            min = this.trackBarPrediction.Value - (h * 60);
            this.labelPredictionTimeReadout.Text = h.ToString() + " h : " + min.ToString() + " min";
            SharedData.LookAheadTime = new TimeSpan(h, min, 0);
        }
    }
}
