using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStudio
{
    public static class StaticData
    {
        public static List<string> PackageList = new List<string>();
        public static List<string> EmployeeList = new List<string>();
        public static Dictionary<string, float> Package = new Dictionary<string, float>();
        public static Dictionary<string, int> Employee = new Dictionary<string, int>();
        public static Dictionary<int, float> ClassEmployee = new Dictionary<int, float>();
    }
}
