using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace HalconOffline
{

    
    public partial class Form1 : Form
    {

        HObject hv_Image = null;
        HObject hv_Region = null;

        HTuple hv_width = new HTuple(), hv_height = new HTuple();
        HTuple hv_threshold = new HTuple();


        public Form1()
        {
            InitializeComponent();

            this.MouseWheel += my_MouseWheel;
        }

        //マウスによる拡大・縮小機能
        private void my_MouseWheel(object sender, MouseEventArgs e)
        {
            Point pt1 = hSmartWindowControl1.Location;
            MouseEventArgs newe1 = new MouseEventArgs(e.Button, e.Clicks, e.X - pt1.X, e.Y - pt1.Y, e.Delta);
            hSmartWindowControl1.HSmartWindowControl_MouseWheel(sender, newe1);

            Point pt2 = hSmartWindowControl2.Location;
            MouseEventArgs newe2 = new MouseEventArgs(e.Button, e.Clicks, e.X - pt2.X, e.Y - pt2.Y, e.Delta);
            hSmartWindowControl2.HSmartWindowControl_MouseWheel(sender, newe2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOperatorSet.ReadImage(out hv_Image, "D:/image.bmp");

            HOperatorSet.GetImageSize(hv_Image, out hv_width, out hv_height);

            HOperatorSet.SetPart(hSmartWindowControl1.HalconWindow, 0, 0, hv_height - 1, hv_width - 1);
            HOperatorSet.SetPart(hSmartWindowControl2.HalconWindow, 0, 0, hv_height - 1, hv_width - 1);

            HOperatorSet.DispImage(hv_Image, hSmartWindowControl1.HalconWindow);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //終了ボタン
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("二値化閾値を正しく入力して下さい。", "エラー", MessageBoxButtons.OK);
                return;
            }

            hv_threshold = int.Parse(textBox1.Text);

            HOperatorSet.Threshold(hv_Image, out hv_Region, 0, hv_threshold);

            HOperatorSet.DispImage(hv_Image, hSmartWindowControl2.HalconWindow);
            HOperatorSet.DispObj(hv_Region, hSmartWindowControl2.HalconWindow);
        }
    }
}
