using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class Reports : Form
    {
        public Reports(float a, float b, int c)
        {
            InitializeComponent();
            Summ.Text = a.ToString() + " грн";
            ClearSumm.Text = b.ToString() + " грн";
            Countp.Text = c.ToString();
        }
    }
}
