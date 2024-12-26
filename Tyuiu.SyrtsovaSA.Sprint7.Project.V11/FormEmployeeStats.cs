using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    public partial class FormEmployeeStats : Form
    {
        public FormEmployeeStats()
        {
            InitializeComponent();
            var ds = new DataService();
            string employeesPath = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\employees.csv";
            var data = ds.GetData(employeesPath);
            var employeesMoney = new double[data.GetLength(0)];
            var moneyIndex = 8;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                var moneyString = data[i, moneyIndex].Replace('.', ',');
                var parseSuccess = double.TryParse(moneyString, out double money);
                if (!parseSuccess)
                {
                    MessageBox.Show("Оклад введен неправильно.");
                    return;
                }
                employeesMoney[i] = money;
            }
            textBoxMoneyAVG_SSA.Text = employeesMoney.Average().ToString();
            textBoxMaxMoney_SSA.Text = employeesMoney.Max().ToString();
            textBoxMinMoney_SSA.Text = employeesMoney.Min().ToString();
            var employeesCount = data.Length;
            textBoxEmployeesCount_SSA.Text = employeesCount.ToString();
            List<double> avgMoneyForRoles = new List<double>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                chartEmployees_SSA.Series[0].Points.AddXY(data[i, 3], data[i, 8]);
            }
        }
    }
}
