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
            MySqlProvider MySQL = new MySqlProvider();

            MySqlProvider.PredictionTableNumberType Table;
            if (this.radioButton1.Checked)
                Table = MySqlProvider.PredictionTableNumberType.One;
            else if (this.radioButton2.Checked)
                Table = MySqlProvider.PredictionTableNumberType.Two;
            else
                Table = MySqlProvider.PredictionTableNumberType.Three;


            System.Collections.Generic.List<MySqlProvider.PredictionDataSetOneRow> DataRetreived =
           MySQL.GetDataSet(Table);

           //this.dataGridViewDataSet
            foreach (MySqlProvider.PredictionDataSetOneRow Item in DataRetreived)
            {
                //this.dataGridViewDataSet
            }
        }

    }
}
