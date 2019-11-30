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
    public partial class MySQLLogin : Form
    {

        private Form1 mParentForm;

        public MySQLLogin()
        {
            InitializeComponent();
            
        }

        private void MySQLLogin_Load(object sender, EventArgs e)
        {
            mParentForm = (Form1)(this.MdiParent);
            comboBox1.SelectedIndex = 0;
            textBox1.Enabled = false;
            textBox4.Text = mParentForm.DataBaseName;
            textBox5.Text = mParentForm.TableName;
            textBox6.Text = mParentForm.MysqlPort;
            textBox2.Text = mParentForm.MysqlUsername;
            textBox3.Text = mParentForm.MysqlPassword;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.ToString() == "その他")
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szConnect;
            
            switch(comboBox1.SelectedItem.ToString())
            {
                case "general-p.ddo.jp":
                    mParentForm.MysqlHost = "general-p.ddo.jp";
                    break;
                case "localhost (127.0.0.1)":
                    mParentForm.MysqlHost = "127.0.0.1";
                    break;
                case "その他":
                    mParentForm.MysqlHost = textBox1.Text;
                    break;
                default:
                    mParentForm.MysqlHost = "127.0.0.1";
                    break;
            }

            mParentForm.MysqlPort = textBox6.Text;
            mParentForm.DataBaseName = textBox4.Text;
            mParentForm.MysqlUsername = textBox2.Text;
            mParentForm.MysqlPassword = textBox3.Text;

            szConnect = "Host=" + mParentForm.MysqlHost + "; Port=" + mParentForm.MysqlPort + "; Database=" + mParentForm.DataBaseName + "; User ID=" + mParentForm.MysqlUsername + "; Password=" + mParentForm.MysqlPassword + ";";
            try
            {
                if (mParentForm.mMSC != null)
                {
                    mParentForm.mMSC.Close();
                    mParentForm.mMSC = null;
                }
                mParentForm.mMSC = new MySqlConnection(szConnect);
                mParentForm.mMSC.Open();
                MessageBox.Show("接続成功");
                mParentForm.IsMysqlConnected = true;
                //((Form1)(this.MdiParent)).mMSC.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL接続に失敗しました\n"+ex.Message);
                
            }

            // テーブル作成
            // szSql = "CREATE TABLE Table1 (IntData int, StringData varchar(32))";
            //MySqlCommand command = new MySqlCommand(szSql, connection);
            // nRet = command.ExecuteNonQuery();

            // レコード追加
            //szSql = "INSERT INTO Table1 VALUES(1, 'data')";
            // command = new MySqlCommand(szSql, connection);
            // nRet = command.ExecuteNonQuery();

            // テーブル参照
            //DataTable dataTable = new DataTable();
           // szSql = "SELECT * FROM " + textBox5.Text;
           // MySqlDataAdapter adapter = new MySqlDataAdapter(szSql, mMSC);
           // nRet = adapter.Fill(dataTable);

            //mMSC.Close();

            // グリッドにバインド
            //dataGridView1.DataSource = dataTable;
        }
    }
}
