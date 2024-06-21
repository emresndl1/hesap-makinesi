using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
         private char _islem;
        private bool _ekrantemizleme;
        private int _ilksayı;

        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
          

            if (ekranlbl.Text=="0")ekranlbl.Text ="";
            ekranlbl.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizleme)
            {
                ekranlbl.Text = "";
                _ekrantemizleme = false;
            }
            if (ekranlbl.Text == "0") ekranlbl.Text = "";

            ekranlbl.Text += "0";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizleme = true;
            _ilksayı = Convert.ToInt32(ekranlbl.Text);
        }

        private void btneşit_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlbl.Text);
            int sonuç;

            switch (_islem)
            {
                case '+':
                    sonuç = _ilksayı + ikincisayi;
                break;

                case '-':
                    sonuç = _ilksayı - ikincisayi;
                break;

                case '*':
                    sonuç = _ilksayı * ikincisayi;
                break;

                case '/':
                    sonuç = _ilksayı / ikincisayi;
                break;
                default:
                    sonuç =0;
                    break;

            }
            ekranlbl.Text = Convert.ToString(sonuç);

        }

        private void btnÇıkart_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizleme = true;
            _ilksayı = Convert.ToInt32(ekranlbl.Text);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizleme = true;
            _ilksayı = Convert.ToInt32(ekranlbl.Text);
        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizleme = true;
            _ilksayı = Convert.ToInt32(ekranlbl.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ekranlbl.Text = "0";
        }
    }
}
