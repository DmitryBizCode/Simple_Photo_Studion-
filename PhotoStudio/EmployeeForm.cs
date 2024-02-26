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

namespace PhotoStudio
{
    public partial class EmployeeForm : Form
    {
        private readonly Form1 mainForm;

        public EmployeeForm(Form1 form)
        {
            this.mainForm = form;
            InitializeComponent();
            InitializationGrid();
        }
        private void InitializationGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < StaticData.EmployeeList.Count && i < StaticData.Employee.Count; i++)
                AddGrid(StaticData.EmployeeList[i], StaticData.Employee[StaticData.EmployeeList[i]]);
        }
        private void AddGrid(string NameEmpl, int cvalefication) => dataGridView1.Rows.Add(NameEmpl, cvalefication);
        private void button1_Click(object sender, EventArgs e)
        {
            string empl = Empl.Text;
            int cval = Convert.ToInt32(Cval.Text);
            AddGrid(empl, cval);
            StaticData.EmployeeList.Add(empl);
            StaticData.Employee.Add(empl, cval);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Введіть ПІБ для звільнення працівника");
                return;
            }

            bool found = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells.Count > 0 && row.Cells[0].Value != null && row.Cells[0].Value.ToString() == textBox2.Text)
                {
                    StaticData.EmployeeList.Remove(textBox2.Text);
                    StaticData.Employee.Remove(textBox2.Text);
                    dataGridView1.Rows.Remove(row);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show($"Не знайдено працівника з іменем {textBox2.Text}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBoxPIB.Text;
            int level = Convert.ToInt32(textBoxLevel.Text);

            int rowIndex1 = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value != null && (row.Cells[0].Value).ToString() == str)
                    rowIndex1 = row.Index;
            if (rowIndex1 == -1)
            {
                MessageBox.Show($"Працівника не знайдено");
                return;
            }
            dataGridView1.Rows[rowIndex1].SetValues(str, level);
            StaticData.Employee[str] = level;
        }
        private void ServiceForm_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
