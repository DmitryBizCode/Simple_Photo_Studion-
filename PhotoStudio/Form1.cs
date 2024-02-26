using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PhotoStudio
{
    public partial class Form1 : Form
    {

        private int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            AddnewOrder widgetadd = new AddnewOrder(true,this);
            widgetadd.ShowDialog();
        }

        private void ServiceForm_Click(object sender, EventArgs e)
        {
            var Form = new Services();
            Form.Show();
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
        private float CalculateSumOrder(string packageType) {


            return 1;
        }
        public void AddGrid(string customer, string districtname, string package, string date, string time, string countOfTime, string employee)
        {

            dataGrid.Rows.Add(++Count, customer, package, date, time, districtname, countOfTime, employee, CalculateSumOrder(package));
        }
    }
}
