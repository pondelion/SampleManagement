using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleManagement
{
    public partial class Statistic : Form
    {
        private Form1 mParentForm;

        public Statistic()
        {
            InitializeComponent();
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            mParentForm = (Form1)this.MdiParent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mParentForm.mAddDataForm.IsDisposed)
            {

                mParentForm.mAddDataForm = new AddDataForm();
                mParentForm.mAddDataForm.MdiParent = mParentForm;
                mParentForm.mAddDataForm.Show();

            }
            else
            {
                mParentForm.mAddDataForm.WindowState = FormWindowState.Normal;
                mParentForm.mAddDataForm.Show();

            }
        }
    }

    
}
