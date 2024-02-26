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

        private void ADD_Click(object sender, EventArgs e)
        {
            AddOrUpdateOrder(true);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);

                string customer = selectedRow.Cells[1].Value.ToString();
                string districtname = selectedRow.Cells[5].Value.ToString();
                string package = selectedRow.Cells[2].Value.ToString();
                string date = selectedRow.Cells[3].Value.ToString();
                string time = selectedRow.Cells[4].Value.ToString();
                string countOfTime = selectedRow.Cells[6].Value.ToString();
                string employee = selectedRow.Cells[7].Value.ToString();

                AddnewOrder editDialog = new AddnewOrder(false, this, orderId, customer, districtname, package, date, time, countOfTime, employee);
                editDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть рядок для редагування");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);


                dataGrid.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть рядок для видалення");
            }
        }

        private float CalculateSumOrder(string employee, string package, string countOfTime)
        {
            int clases = StaticData.Employee[employee];
            float clasesfl = StaticData.ClassEmployee[clases];
            float packageprice = StaticData.Package[package];
            float result = packageprice * clasesfl * int.Parse(countOfTime);
            return result;
        }

        public void AddGrid(string customer, string districtname, string package, string date, string time, string countOfTime, string employee)
            => dataGrid.Rows.Add(++Count, customer, package, date, time, districtname, countOfTime, employee, CalculateSumOrder(employee, package, countOfTime));

        private void AddOrUpdateOrder(bool isAddMode)
        {
            AddnewOrder addOrUpdateDialog = new AddnewOrder(isAddMode, this);
            addOrUpdateDialog.ShowDialog();
        }
        public void UpdateGrid(int rowIndex, string customer, string districtname, string package, string date, string time, string countOfTime, string employee)
        {
            int rowIndex1 = -1;
            foreach (DataGridViewRow row in dataGrid.Rows)            
                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == rowIndex)
                    rowIndex1 = row.Index;
            if( rowIndex1 == -1)
            {
                MessageBox.Show($"Рядок не знайдено");
                return; 
            }
            dataGrid.Rows[rowIndex1].SetValues(rowIndex, customer, package, date, time, districtname, countOfTime, employee, CalculateSumOrder(employee, package, countOfTime));
        }

        private void ServiceForm_Click(object sender, EventArgs e)
        {
            var Form = new Services(this);
            Form.Show();
            this.Hide();
        }

        private void PersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm(this);
            employeeForm.Show();
            this.Hide();
        }
        private float CalculateSumm()
        {
            float result = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
                if (row.Cells[8].Value != null)
                    result += Convert.ToInt32(row.Cells[8].Value);
            return result;
        }
        private int CalculateCountSumm()
        {
            int result = 0;
            foreach (DataGridViewRow row in dataGrid.Rows)
                if (row.Cells[8].Value != null)
                    result ++;
            return result;
        }
        private float CalculateSummClear(int count, float summ) => summ - (count * (summ * 0.1f) * StaticData.EmployeeList.Count);
        
        private void звітністьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float summ = CalculateSumm();   
            int count = CalculateCountSumm();   
            var rep = new Reports(summ, CalculateSummClear(count, summ), count);
            rep.ShowDialog();
        }
    }
}
