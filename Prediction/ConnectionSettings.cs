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
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void textBoxServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.mySqlDatabase = this.textBoxDatabase.Text;
            Properties.Settings.Default.MySqlServer = this.textBoxServer.Text;
            Properties.Settings.Default.MySqlUser = this.textBoxUser.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Connection Settings Saved");
            this.Close();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            this.textBoxDatabase.Text = Properties.Settings.Default.mySqlDatabase;
            this.textBoxServer.Text = Properties.Settings.Default.MySqlServer;
            this.textBoxUser.Text = Properties.Settings.Default.MySqlUser;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Server = Properties.Settings.Default.MySqlServer;
            string User = Properties.Settings.Default.MySqlUser;
            string Database = Properties.Settings.Default.mySqlDatabase;
            
            Properties.Settings.Default.mySqlDatabase = this.textBoxDatabase.Text;
            Properties.Settings.Default.MySqlServer = this.textBoxServer.Text;
            Properties.Settings.Default.MySqlUser = this.textBoxUser.Text;
            Properties.Settings.Default.Save();

            MySqlProvider TestSql = new MySqlProvider();
            
            if (TestSql.IsConnectionOK() == true)
                MessageBox.Show("Connection is OK");
            else
                MessageBox.Show("Connection FAILED");

            Properties.Settings.Default.mySqlDatabase = Database;
            Properties.Settings.Default.MySqlServer = Server;
            Properties.Settings.Default.MySqlUser = User;
            Properties.Settings.Default.Save();
        }
    }
}
