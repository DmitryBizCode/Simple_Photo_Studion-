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
    public partial class AddEditService : Form
    {
        private readonly Services mainForm;
        private readonly float prices;
        private readonly int id;
        private readonly string serviceName;

        public AddEditService()
        {
            InitializeComponent();
        }
        public AddEditService(Services form, float price, int serviceId, string name)
        {
            this.mainForm = form;
            this.prices = price;
            this.id = serviceId;
            this.serviceName = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Додайте код для обробки натискання кнопки
        }
    }

}
