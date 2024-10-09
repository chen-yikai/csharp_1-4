using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tempBtn_Click(object sender, EventArgs e)
        {
            float cTemp = float.Parse(tempIn.Text); // 攝氏溫度
            fTemp.Text = (cTemp*9/5+32).ToString(); // 計算並設定攝氏溫度轉華氏溫度 (華氏 = 攝氏*9/5+32)
        }

        private void bmiBtn_Click(object sender, EventArgs e)
        {
            float bmiKg = float.Parse(bmikgin.Text); // 體重(公斤)
            float bmiM = float.Parse(bmikgin.Text); // 身高(公尺)
            bmi.Text = ( bmiKg / Math.Pow(bmiM,2)).ToString(); // 計算並設定bmi值 (體重/身高^2)
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            float bottom = float.Parse(triangleBottomIn.Text); // 三角形底(cm)
            float height = float.Parse(triangleHeghtIn.Text); // 三角形高(cm)
            triangleArea.Text = (bottom * height /2).ToString(); // 計算並設定三角形面積 (底*高/2)s
            triangleEdge.Text = (Math.Sqrt(Math.Pow(bottom, 2)+Math.Pow(height,2))).ToString(); // 計算並設定三角形斜邊 畢氏定理(a^2+b^2=c^2)
        }
    }
}