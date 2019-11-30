using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SampleManagement
{

    public partial class Form1 : Form
    {
        private Statistic mStatisticForm;
        private MySQLLogin mMySQLLoginForm;
        private string mDataBaseName;
        private string mTableName;
        private string mMysqlPort;
        private string mMysqlUsername;
        private string mMysqlPassword;
        private string mMysqlHost;
        private bool mIsMysqlConnected = false;
        public MySqlConnection mMSC = null;
        public AddDataForm mAddDataForm = null;

        public string DataBaseName
        {
            set
            {
                mDataBaseName = value;
            }
            get
            {
                return mDataBaseName;
            }
        }
        public string TableName
        {
            set
            {
                mTableName = value;
            }
            get
            {
                return mTableName;
            }
        }
        public string MysqlPort
        {
            set
            {
                mMysqlPort = value;
            }
            get
            {
                return mMysqlPort;
            }
        }
        public string MysqlUsername
        {
            set
            {
                mMysqlUsername = value;
            }
            get
            {
                return mMysqlUsername;
            }
        }
        public string MysqlPassword
        {
            set
            {
                mMysqlPassword = value;
            }
            get
            {
                return mMysqlPassword;
            }
        }
        public string MysqlHost
        {
            set
            {
                mMysqlHost = value;
            }
            get
            {
                return mMysqlHost;
            }
        }
        public bool IsMysqlConnected
        {
            set
            {
                mIsMysqlConnected = value;
            }
            get
            {
                return mIsMysqlConnected;
            }
        }

        public Form1()
        {
            InitializeComponent();

            mDataBaseName = "KLab";
            mTableName = "SampleList";
            mMysqlPort = "3306";

            this.IsMdiContainer = true;
            mStatisticForm = new Statistic();
            mStatisticForm.MdiParent = this;
            mMySQLLoginForm = new MySQLLogin();
            mMySQLLoginForm.MdiParent = this;
            mAddDataForm = new AddDataForm();
            mAddDataForm.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(30, 30);
            MdiClient mc = GetMdiClient(this);
            if (mc != null)
            {
                mc.BackColor = this.BackColor;
                mc.Invalidate();
            }
        }

        public static System.Windows.Forms.MdiClient
    GetMdiClient(System.Windows.Forms.Form f)
        {
            foreach (System.Windows.Forms.Control c in f.Controls)
                if (c is System.Windows.Forms.MdiClient)
                    return (System.Windows.Forms.MdiClient)c;
            return null;
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mStatisticForm.IsDisposed)
            {
                
                mStatisticForm = new Statistic();
                mStatisticForm.MdiParent = this;
                mStatisticForm.Show();
                
            }
            else
            {
                mStatisticForm.WindowState = FormWindowState.Normal;
                mStatisticForm.Show();
                
            }
        }

        private void ｻｰﾊﾞｰに接続ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mMySQLLoginForm.IsDisposed)
            {
                mMySQLLoginForm = new MySQLLogin();
                mMySQLLoginForm.MdiParent = this;
                mMySQLLoginForm.Show();
            }
            else
            {
                mMySQLLoginForm.WindowState = FormWindowState.Normal;
                mMySQLLoginForm.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mMSC != null)
            {
                try
                {
                    mMSC.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("MySQLのクローズに失敗しました\n" + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsMysqlConnected)
            {
                label1.Text = "接続されています";
            }
            else
            {
                label1.Text = "接続されていません"+DateTime.Now.ToString();
            }

            label3.Text = MysqlHost;
            label4.Text = MysqlUsername;
            label6.Text = DataBaseName;
            label8.Text = TableName;
        }

        
    }
}
