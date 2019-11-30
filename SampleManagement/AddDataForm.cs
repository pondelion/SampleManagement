using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace SampleManagement
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
            tabControl1_SelectedIndexChanged(this, null);
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox10.Enabled = false;
            textBox12.Enabled = false;
            textBox14.Enabled = false;
            textBox6.Enabled = false;
            textBox9.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;
            textBox15.Enabled = false;
            textBox20.Enabled = false;
            button4.Enabled = false;

            textBox19.Text = "1";

            dataGridView1.Rows.Add(new string[] { "削除", "0", "30" });
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0, 30);
            chart2.Series[0].Points.Add(dataPoint1);

            chart1.ChartAreas[0].BackColor = Color.Black; ;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Green;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Green;
            chart1.Series[0].Color = Color.Red;


            chart2.ChartAreas[0].BackColor = Color.Black; ;
            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Green;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Green;
            chart2.Series[0].Color = Color.Red;
            chart2.Series[0].MarkerSize = 10;
            chart2.Series[0].MarkerColor = Color.Red;
            chart2.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            chart2.Series[0].IsValueShownAsLabel = true;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button1.Enabled = true;
            button1.Text = "次へ";

            if (tabControl1.SelectedIndex == 0)
            {
                button2.Enabled = false;
            }
            if (tabControl1.SelectedIndex == tabControl1.TabCount - 1)
            {
                button1.Text = "登録";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
            {
                tabControl1.SelectedIndex++;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != 0)
            {
                textBox7.Enabled = true;
                textBox6.Enabled = true;
                string[] str;
                str = comboBox2.SelectedItem.ToString().Split(' ');
                label20.Text = str[1] + ":";
            }
            else
            {
                textBox7.Enabled = false;
                textBox6.Enabled = false;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox6.SelectedIndex != 0)
            {
                textBox14.Enabled = true;
                textBox15.Enabled = true;
                string[] str;
                str = comboBox6.SelectedItem.ToString().Split(' ');
                label24.Text = str[1] + ":";
            }
            else
            {
                textBox14.Enabled = false;
                textBox15.Enabled = false;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex != 0)
            {
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                string[] str;
                str = comboBox5.SelectedItem.ToString().Split(' ');
                label23.Text = str[1] + ":";
            }
            else
            {
                textBox12.Enabled = false;
                textBox13.Enabled = false;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex != 0)
            {
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                string[] str;
                str = comboBox4.SelectedItem.ToString().Split(' ');
                label22.Text = str[1] + ":";
            }
            else
            {
                textBox10.Enabled = false;
                textBox11.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != 0)
            {
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                string[] str;
                str = comboBox3.SelectedItem.ToString().Split(' ');
                label21.Text = str[1] + ":";
            }
            else
            {
                textBox8.Enabled = false;
                textBox9.Enabled = false;

            }
        }

        private void calculateTotalMeasuredMass()
        {
            double totalMass = 0.0;
            try
            {

                 if(textBox6.Enabled)
                {
                    totalMass += Double.Parse(textBox6.Text);
                 }
                 if (textBox9.Enabled)
                 {
                     totalMass += Double.Parse(textBox9.Text);
                 }
                 if (textBox11.Enabled)
                 {
                     totalMass += Double.Parse(textBox11.Text);
                 }
                 if (textBox13.Enabled)
                 {
                     totalMass += Double.Parse(textBox13.Text);
                 }
                 if (textBox15.Enabled)
                 {
                     totalMass += Double.Parse(textBox15.Text);
                 }

                 textBox16.Text = totalMass.ToString();

            }
            catch(Exception ex)
            {
            }



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calculateTotalMeasuredMass();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            calculateTotalMeasuredMass();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            calculateTotalMeasuredMass();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            calculateTotalMeasuredMass();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            calculateTotalMeasuredMass();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if(textBox18.Text != "")
            {
                try
                {
                    if (Double.Parse(textBox18.Text) <= Double.Parse(textBox19.Text))
                    {
                        comboBox7.SelectedIndex = 1;
                        textBox20.Enabled = false;
                    }
                    else if (Double.Parse(textBox18.Text) > Double.Parse(textBox19.Text))
                    {
                        comboBox7.SelectedIndex = 2;
                        textBox20.Enabled = true;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 1:
                    textBox20.Enabled = false;
                    break;
                case 2:
                    textBox20.Enabled = true;
                    break;
                default:
                    break;
            }

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                try
                {
                    textBox18.Text = (100.0 * (Double.Parse(textBox16.Text) - Double.Parse(textBox17.Text)) / Double.Parse(textBox16.Text)).ToString();

                }
                catch (Exception)
                {
                }

                if (textBox18.Text != "")
                {
                    try
                    {
                        if (Double.Parse(textBox18.Text) <= Double.Parse(textBox19.Text))
                        {
                            comboBox7.SelectedIndex = 1;
                            textBox20.Enabled = false;
                        }
                        else if (Double.Parse(textBox18.Text) > Double.Parse(textBox19.Text))
                        {
                            comboBox7.SelectedIndex = 2;
                            textBox20.Enabled = true;
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox22.Text = openFileDialog1.FileName;

                try
                {
                    pictureBox1.ImageLocation = @textBox22.Text;
                }
                catch (Exception)
                {
                    MessageBox.Show("A");
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                textBox23.Text = openFileDialog2.FileName;

                try
                {
                    StreamReader sr = new StreamReader(@textBox23.Text, System.Text.Encoding.Default);
                    string[] str;
                    List<DataPoint> data = new List<DataPoint>();
                    sr.ReadLine();
                    sr.ReadLine();
                    while(sr.Peek() >= 0)
                    {
                        str = sr.ReadLine().Split('\t');

                        data.Add(new DataPoint(float.Parse(str[0]), float.Parse(str[1])));
                    }
                    sr.Close();

                    drawXRDGraph(data);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("有効なファイル形式ではありません。\n" + ex.Message);

                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double time, temp;

            try
            {
                time = Double.Parse(textBox24.Text);
                temp = Double.Parse(textBox25.Text);
               
                dataGridView1.Rows.Add(new string[] { "削除", time.ToString(), temp.ToString() });
                drawAnnealingTvsTGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数値を入力してください。\n" + ex.Message);
            }
        }

        private void drawAnnealingTvsTGraph()
        {
            chart2.Series[0].Points.Clear();
            double time = 0.0, temp;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                time += Double.Parse(dataGridView1[1, i].Value.ToString());
                temp = Double.Parse(dataGridView1[2, i].Value.ToString());
                System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(time, temp);
                chart2.Series[0].Points.Add(dataPoint1);
            }
        }

        private void drawXRDGraph(List<DataPoint> data)
        {
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < data.Count; i++)
            {
                chart1.Series[0].Points.Add(data[i]);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                button4.Enabled = true;
            }
            else
            {
                button4.Enabled = false;
            }
        }

        
    }
}
