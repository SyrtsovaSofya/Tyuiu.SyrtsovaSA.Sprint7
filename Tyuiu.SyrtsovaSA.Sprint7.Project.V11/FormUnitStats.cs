using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    public partial class FormUnitStats : Form
    {
        public FormUnitStats()
        {
            InitializeComponent();
            var ds = new DataService();
            string unitsPath = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\units.csv";
            var data = ds.GetData(unitsPath);
            var unitsMoney = new double[data.GetLength(0)];
            var moneyIndex = 3;
            for (int i = 0; i < data.GetLength(0); i++)
            {
                var moneyText = data[i, moneyIndex].Replace('.', ',');
                var parsed = double.TryParse(moneyText, out double money);
                if (!parsed)
                {
                    MessageBox.Show("Фонд заработной платы за год введен неправильно.");
                    return;
                }
                unitsMoney[i] = money;
            }
            textBoxMoneyAVG_SSA.Text = unitsMoney.Average().ToString();
            textBoxMaxMoney_SSA.Text = unitsMoney.Max().ToString();
            textBoxMinMoney_SSA.Text = unitsMoney.Min().ToString();
            var unitsCount = data.Length;
            textBoxUnitsCount_SSA.Text = unitsCount.ToString();
            List<double> avgMoneyForRoles = new List<double>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                chartUnits_SSA.Series[0].Points.AddXY(data[i, 0], data[i, 1]);
            }
        }
    }
}
