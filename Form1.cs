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
            float cTemp = float.Parse(tempIn.Text);
            fTemp.Text = (cTemp*9/5+32).ToString();
        }

        private void bmiBtn_Click(object sender, EventArgs e)
        {
            float bmiKg = float.Parse(bmikgin.Text);
            float bmiM = float.Parse(bmikgin.Text);
            bmi.Text = ( bmiKg / Math.Pow(bmiM,2)).ToString();
        }

        private void triangleBtn_Click(object sender, EventArgs e)
        {
            float bottom = float.Parse(triangleBottomIn.Text);
            float height = float.Parse(triangleHeghtIn.Text);
            triangleArea.Text = (bottom * height /2).ToString();
            triangleEdge.Text = (Math.Sqrt(Math.Pow(bottom, 2)+Math.Pow(height,2))).ToString();
        }
    }
}
