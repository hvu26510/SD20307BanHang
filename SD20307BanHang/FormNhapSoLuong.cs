using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD20307BanHang
{
    public partial class FormNhapSoLuong : Form
    {
        public int DuLieuTraVe = 0;
        public FormNhapSoLuong()
        {
            InitializeComponent();
        }

        private void FromNhapSoLuong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DuLieuTraVe = int.Parse(numericUpDown1.Value.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
