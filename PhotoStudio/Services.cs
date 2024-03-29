﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PhotoStudio
{
    public partial class Services : Form
    {
        private int CountID = 0;
        private readonly Form1 mainForm;
        public Services(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form;
            InitializationGrid();
        }
        private void InitializationGrid()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < StaticData.PackageList.Count && i < StaticData.Package.Count; i++) 
                AddGrid(StaticData.PackageList[i], StaticData.Package[StaticData.PackageList[i]]);   
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StaticData.Package.Add(TypeP.Text, float.Parse(Price.Text));
            StaticData.PackageList.Add(TypeP.Text);
            AddGrid(TypeP.Text, float.Parse(Price.Text));
        }
        private void AddGrid(string type, float price)
            => dataGridView1.Rows.Add(++CountID, type, price, 1);
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int rowIndex = selectedRow.Index;
                string str = (string)dataGridView1.Rows[rowIndex].Cells[1].Value;
                StaticData.PackageList.Remove(str);
                StaticData.Package.Remove(str);
                dataGridView1.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть рядок для видалення");
            }
        }
        public void UpdateGrid(string typename, float price, string str0)
        {
            int rowIndex1 = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[0].Value != null && (row.Cells[0].Value).ToString() == str0)
                    rowIndex1 = row.Index;
            if (rowIndex1 == -1)
            {
                MessageBox.Show($"Рядок не знайдено");
                return;
            }
            dataGridView1.Rows[rowIndex1].SetValues(str0, typename, price, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                float price = (float)selectedRow.Cells[2].Value;
                string str0 = selectedRow.Cells[0].Value.ToString();

                string typename = selectedRow.Cells[1].Value.ToString();
                AddEditService editDialog = new AddEditService(this, price, typename, str0);
                editDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Будь ласка виберіть рядок для редагування");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)            
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == textBox1.Text)
                {
                    MessageBox.Show($"{textBox1.Text} має ціну {row.Cells[2].Value} грн");
                    return;
                }
            MessageBox.Show($"Послугу з назвою {textBox1.Text} не знайдений.");
        }


        private void OrderForms_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }
    }
}
