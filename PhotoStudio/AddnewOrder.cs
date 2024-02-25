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
    public partial class AddnewOrder : Form
    {
        private readonly bool kindAdd; 
        public AddnewOrder(bool kindAdd)
        {
            InitializeComponent();
            this.kindAdd = kindAdd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customer = ClientName.Text;
                string districtname = District.Text;
                string package = Package.Text;
                string packageType = TypeOfPackege.Text;
                string date = Datetime.Text;
                string time = Time.Text;
                string countOfTime = TimeCount.Text;
                string employee = Employer.Text;

                Tuple<string, string, string, string, string, string, string, string> tupleData = Tuple.Create(customer, districtname, package, packageType, date, time, countOfTime, employee);

                if (kindAdd)
                {
                    Form1 qw = new Form1();
                    qw.AddGrid(tupleData);
                }

            }
            catch (Exception)
            {

                throw;
            }          
        }
    }
}
