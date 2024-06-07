using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_NguyenVinhKhiem_N1_NUnit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PTBac2_btn_Click(object sender, EventArgs e)
        {
            //28-Khiem
            int a, b, c, delta;
            string ketqua;
            if (!int.TryParse(textBox1.Text, out a) || !int.TryParse(textBox2.Text, out b) || !int.TryParse(textBox3.Text, out c))
            {
                textBox4.Text = "Các hệ số a, b, c phải là các số nguyên hợp lệ.";
                return;
            }

            PTBac2 d = new PTBac2(a, b, c);
            delta = d.Execute("delta");

            if (a == 0)
            {
                textBox4.Text = "Hệ số a phải khác 0";
            }
            else
            {
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    ketqua = "Phương trình có hai nghiệm phân biệt: ";
                    ketqua += "x1 = " + x1.ToString() + " và ";
                    ketqua += "x2 = " + x2.ToString();
                    textBox4.Text = ketqua;
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    ketqua = "Phương trình có một nghiệm kép: ";
                    ketqua += "x = " + x.ToString();
                    textBox4.Text = ketqua;
                }
                else
                {
                    textBox4.Text = "Phương trình không có nghiệm thực.";
                }
            }
        }
    }
}
