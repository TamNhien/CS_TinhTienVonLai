using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_TinhTienVonLai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTien.ResetText();
            txtLai.ResetText();
            txtNam.ResetText();
            ltKQ.Items.Clear();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            ltKQ.Items.Clear();
            double tienLai;
            double laiSuat = double.Parse(txtLai.Text.Replace("%", "")) / 100;
            double soTien = double.Parse(txtTien.Text);
            int soNam = int.Parse(txtNam.Text);

            for (int i = 1; i <= soNam; i++)
            {
                tienLai = soTien * laiSuat;
                ltKQ.Items.Add($"{i}\t {soTien:F2}\t {tienLai:F2}");
                soTien += tienLai;
            }
        }
    }
}
