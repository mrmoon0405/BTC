using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlyCuaHangBanDoAnhNhanh_NguyenAnhDung_17
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form1() ;
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
            this.Hide();
        }
        private void frm_FormClosed (object sender, EventArgs e)
        {
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
            frm.Show();
            this.Hide();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
