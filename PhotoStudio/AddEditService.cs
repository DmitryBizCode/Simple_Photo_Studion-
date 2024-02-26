using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PhotoStudio
{
    public partial class AddEditService : Form
    {
        private readonly Services mainForm;
        private readonly float prices;
        private readonly string id;
        private readonly string serviceName;

        public AddEditService()
        {
            InitializeComponent();
        }
        public AddEditService(Services form, float price, string name, string serviceId)
        {
            InitializeComponent();
            this.mainForm = form;
            this.prices = price;
            this.id = serviceId;
            this.serviceName = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.UpdateGrid(serviceName, prices, id);
            Close();
        }
    }

}
