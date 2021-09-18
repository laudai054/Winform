using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongTruNhanChia
{
    public partial class CongTruNhanChia : Form
    {
        public CongTruNhanChia()
        {
            InitializeComponent();
        }

        //Phép cộng
        private void butc_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txta.Text;
                double temp = 0, nsoThuNhat = 0, nsoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nsoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ nhất", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var soThuHai = txtb.Text;
                if (double.TryParse(soThuHai, out temp))
                    nsoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ hai", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ketQua = nsoThuNhat + nsoThuHai;

                ketqua.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Phép trừ
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  
                var soThuNhat = txta.Text;
                double temp = 0, nsoThuNhat = 0, nsoThuHai = 0;
                if(double.TryParse(soThuNhat, out temp))
                     nsoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ nhất", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var soThuHai = txtb.Text;
                if (double.TryParse(soThuHai, out temp))
                    nsoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ hai", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ketQua = nsoThuNhat - nsoThuHai;

                ketqua.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Phép nhân
        private void butn_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txta.Text;
                double temp = 0, nsoThuNhat = 0, nsoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nsoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ nhất", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var soThuHai = txtb.Text;
                if (double.TryParse(soThuHai, out temp))
                    nsoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ hai", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ketQua = nsoThuNhat * nsoThuHai;

                ketqua.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Phép chia
        private void butchia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txta.Text;
                double temp = 0, nsoThuNhat = 0, nsoThuHai = 0;
                if (double.TryParse(soThuNhat, out temp))
                    nsoThuNhat = Convert.ToDouble(soThuNhat);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ nhất", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var soThuHai = txtb.Text;
                if (double.TryParse(soThuHai, out temp))
                    nsoThuHai = Convert.ToDouble(soThuHai);
                else
                {
                    MessageBox.Show("Vui lòng nhập lại số thứ hai", "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var ketQua = nsoThuNhat / nsoThuHai;

                ketqua.Text = ketQua.ToString();
            }
            catch
            {
                MessageBox.Show("Bạn đã nhập sai", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
