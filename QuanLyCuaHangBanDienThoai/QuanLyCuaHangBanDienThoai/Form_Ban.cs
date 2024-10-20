using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDienThoai
{
    public partial class Form_Ban : Form
    {
        public Form_Ban()
        {
            InitializeComponent();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form_HoaDonBan hdb = new Form_HoaDonBan();
            //hdb.ShowDialog();
            this.Close();
        }

        private void btnCTHDB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_ChiTietHoaDonBan cthdb = new Form_ChiTietHoaDonBan();
            cthdb.ShowDialog();
            this.Close();
        }
    }
}
