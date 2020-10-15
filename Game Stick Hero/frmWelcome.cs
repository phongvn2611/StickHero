using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Stick_Hero
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmMain Main = new frmMain();
            this.Hide();
            Main.ShowDialog();
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Stick Hero\r\n" +
                "Người viết: Võ Ngọc Phong\r\n" +
                "MSSV: 18110174\r\nĐH Sư phạm Kỹ thuật TPHCM",
                "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn giữ phím Space để tạo cầu\r\n" +
                "Giữ càng lâu cầu càng dài\r\n" +
                "Cầu chỉ dài chứ không ngắn lại\r\n" +
                "Cầu đặt được lên núi và qua cầu được 1 điểm\r\n" +
                "Cầu đặt được lên núi ngay điểm màu đỏ và qua cầu được 2 điểm\r\n" +
                "Cầu quá ngắn không đặt được lên núi hoặc đặt được lên núi " +
                "nhưng cầu quá dài bạn sẽ rớt xuống vực và thua cuộc",
                "Giúp đỡ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
