using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            StaticData.Employee.Add("Терещенко В.О.", 1);
            StaticData.EmployeeList.Add("Терещенко В.О.");
            StaticData.Employee.Add("Шевченко Н.А.", 2);
            StaticData.EmployeeList.Add("Шевченко Н.А.");

            StaticData.ClassEmployee.Add(1, 1.4f);
            StaticData.ClassEmployee.Add(2, 1.4f);
            StaticData.ClassEmployee.Add(3, 1.4f);
            StaticData.ClassEmployee.Add(4, 1.4f);
            StaticData.ClassEmployee.Add(5, 1.4f);


            Application.Run(new Form1());
        }
    }
}
