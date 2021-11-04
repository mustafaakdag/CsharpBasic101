using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpBasic101_Main
{
    public partial class AnaSayfa : Form
    {
        private bool Acik = false;

        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            gbUst.Size = new Size(5, 5);

            Meyve elma = new Meyve();

          
        }

        private void btnConsole_Click(object sender, EventArgs e)
        {
            //gbUst.Text = "Console Islemleri";
            gbUst.Text = btnConsole.Text;
            ToggleBtn();
            pnl1.Visible = true;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void btnForms_Click(object sender, EventArgs e)
        {
            gbUst.Text = btnForms.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = true;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void ToggleBtn()
        {
            

            if (Acik == false)
            {
                if (gbUst.Text != "***")
                {
                    gbUst.Size = new Size(5, 70);
                    Acik = true;
                }
            }
            else
            {
                gbUst.Size = new Size(5, 5);
                Acik = false;
                gbUst.Text = "***";
                if (gbUst.Text != "***")
                {
                    gbUst.Size = new Size(5, 70);
                    Acik = true;
                }
                else
                {
                    gbUst.Size = new Size(5, 5);
                    Acik = false;
                    gbUst.Text = "***";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbUst.Text = button1.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = true;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbUst.Text = button2.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = true;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbUst.Text = button3.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = true;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbUst.Text = button4.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = true;
            pnl7.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gbUst.Text = button5.Text;
            ToggleBtn();
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = true;
        }

        #region Console Islemleri
        private void btnHello_Click(object sender, EventArgs e)
        {
            //D:\VisualStudioProject\Source\Repos\CsharpBasic101\FirstConsoleAppp\bin\Debug\net5.0\FirstConsoleAppp.exe

            Process.Start(
                @"D:\VisualStudioProject\Source\Repos\CsharpBasic101\FirstConsoleAppp\bin\Debug\net5.0\FirstConsoleAppp.exe");
        }
        #endregion

        private void btnDegiskenler_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"D:\VisualStudioProject\Source\Repos\CsharpBasic101\Degiskenler\bin\Debug\net5.0\Degiskenler.exe");
        }

        private void btnDonguler_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"D:\VisualStudioProject\Source\Repos\CsharpBasic101\CsharpBasic101-Donguler\bin\Debug\CsharpBasic101-Donguler");
        }

        private void btnDiziler_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"D:\VisualStudioProject\Source\Repos\CsharpBasic101\CsharpBasic101-Diziler\bin\Debug\CsharpBasic101-Diziler.exe");
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            Process.Start(
                @"D:\VisualStudioProject\Source\Repos\CsharpBasic101\CsharpBasic101-DateTime\bin\Debug\CsharpBasic101-DateTime.exe");
        }
    }
}
