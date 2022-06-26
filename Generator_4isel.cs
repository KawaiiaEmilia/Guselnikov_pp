using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check1 = 0;
            int check2 = 0;
            int check3 = 0;
            Random num = new Random();
            int[] pick3 = new int[3];

            for (int n = 0; n < pick3.Length; n++)
            {
                check1 = num.Next(1, 10);
                while (!(pick3.Contains(check1)))
                {
                    pick3[n] = check1;
                }
                textBox1.Text = (check1.ToString());
            }

            for (int n = 0; n < pick3.Length; n++)
            {
                check2 = num.Next(1, 10);
                while (!(pick3.Contains(check2)))
                {
                    pick3[n] = check2;
                }
                textBox2.Text = (check2.ToString());
            }

            for (int n = 0; n < pick3.Length; n++)
            {
                check3 = num.Next(1, 10);
                while (!(pick3.Contains(check3)))
                {
                    pick3[n] = check3;
                }
                textBox3.Text = (check3.ToString());
            }
        }
    }
}
