using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class AddnewOrder : Form
    {
        private readonly Form1 mainForm;
        private readonly bool isAddMode;
        private readonly int orderId;
        public AddnewOrder(bool isAddMode, Form1 form)
        {
            InitializeComponent();
            Package.DataSource = StaticData.PackageList;
            Employee.DataSource = StaticData.EmployeeList;
            Time.Format = DateTimePickerFormat.Custom;
            Time.CustomFormat = "HH:mm";
            Time.ShowUpDown = true;
            this.isAddMode = isAddMode;
            this.mainForm = form;
            Datetime.ShowUpDown = true;
            Datetime.CustomFormat = "dd.MM.yyyy";
            Datetime.Format = DateTimePickerFormat.Custom;
        }
        public AddnewOrder(bool isAddMode, Form1 form, int orderId, string customer, string districtname, string package, string date, string time, string countOfTime, string employee)
       : this(isAddMode, form)
        {
            InitializeComponent();
            this.orderId = orderId;
            ClientName.Text = customer;
            District.Text = districtname;
            Package.Text = package;
            Datetime.Text = date;
            Time.Text = time;
            TimeCount.Text = countOfTime;
            Employee.Text = employee;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customer = ClientName.Text;
                string districtname = District.Text;
                string package = Package.Text;
                string date = Datetime.Text;
                string time = Time.Text;
                string countOfTime = TimeCount.Text;
                string employee = Employee.Text;

                if (isAddMode)
                {
                    mainForm.AddGrid(customer, districtname, package, date, time, countOfTime, employee);
                }
                else
                {
                    if (orderId != -1)
                    {
                        mainForm.UpdateGrid(orderId, customer, districtname, package, date, time, countOfTime, employee);
                    }

                }

                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
