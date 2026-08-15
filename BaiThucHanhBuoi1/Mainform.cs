using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btnSaochep_Click(object sender, EventArgs e)
        {
            txtSaohep.Text = txtTen.Text;
        }

        //private void txtSaohep_TextChanged(object sender, EventArgs e)
        //{
        //    txtSaohep.Text = txtTen.Text;
        //}
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaohep.Text = txtTen.Text;
        }

       
    }
}
