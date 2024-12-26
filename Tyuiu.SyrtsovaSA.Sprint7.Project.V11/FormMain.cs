using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonEmployees_SSA_Click(this, EventArgs.Empty);
        }
        DataService ds = new DataService();
        string employeesPath = @"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\employees.csv";
        string unitsPath = @"..\Back-end\selling_company.csv";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void SearchEmployees()
        {
            string[,] data = ds.GetData(employeesPath);
            string search = textBoxSearchEmployees_SSA.Text.ToLower();
            if (string.IsNullOrWhiteSpace(search))
                search = "";
            string role = "";
            if (comboBoxSort_SSA.SelectedIndex != -1 && comboBoxSort_SSA.SelectedIndex != 0)
                role = comboBoxSort_SSA.SelectedItem.ToString();
            string degree = "";
            if (checkBoxDegree_SSA.Checked is true)
                degree = "ВО";
            var sortedData = new List<string[]>();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if ((data[i, 0].ToLower().Contains(search) || data[i, 1].ToLower().Contains(search)) && data[i, 3].Contains(role) && data[i,5].Contains(degree))
                {
                    var row = new string[data.GetLength(1)];
                    for (int j = 0; j < row.Length; j++)
                        row[j] = data[i, j];
                    sortedData.Add(row);
                }
            }

            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            dataGridViewEmployees_SSA.RowCount = rows;
            dataGridViewEmployees_SSA.ColumnCount = columns;
            dataGridViewEmployees_SSA.Columns[0].HeaderText = "ФИО";
            dataGridViewEmployees_SSA.Columns[1].HeaderText = "Адрес";
            dataGridViewEmployees_SSA.Columns[2].HeaderText = "Телефон";
            dataGridViewEmployees_SSA.Columns[3].HeaderText = "Должность";
            dataGridViewEmployees_SSA.Columns[4].HeaderText = "Дата рождения";
            dataGridViewEmployees_SSA.Columns[5].HeaderText = "Образование";
            dataGridViewEmployees_SSA.Columns[6].HeaderText = "Стаж";
            dataGridViewEmployees_SSA.Columns[7].HeaderText = "Дата зачисления";
            dataGridViewEmployees_SSA.Columns[8].HeaderText = "Оклад";

            var searchData = sortedData.ToArray();
            dataGridViewEmployees_SSA.RowCount = searchData.Length;
            dataGridViewEmployees_SSA.ColumnCount = searchData.Length == 0 ? 0 : searchData[0].Length;
            for (int r = 0; r < searchData.Length; r++)
            {
                for (int c = 0; c < searchData[0].Length; c++)
                {
                    dataGridViewEmployees_SSA.Rows[r].Cells[c].Value = searchData[r][c];
                }
            }
        }

        private void buttonGuide_SSA_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonAbout_SSA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSearchEmployees_SSA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_SSA.ToolTipTitle = "Поиск";
        }

        private void buttonEmployees_SSA_Click(object sender, EventArgs e)
        {
            panelEmployees_SSA.Visible = true;
            //panelUnits_SSA.Visible = false;
            try
            {
                string[,] data = ds.GetData(employeesPath);
                if (data is null)
                    return;
                List<string> roles = new List<string>();
                roles.Add("Все должности");
                int rows = data.GetLength(0);
                int columns = data.GetLength(1);
                dataGridViewEmployees_SSA.RowCount = rows;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewEmployees_SSA.Rows[r].Cells[c].Value = data[r, c];
                        if (c == 3)
                            roles.Add(data[r, c]);
                    }
                }
                comboBoxSort_SSA.DataSource = roles;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUnits_SSA_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchEmployees_SSA_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void buttonAddEmployee_SSA_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFIO_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxAdress_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPhone_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxRole_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxBirth_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxDegree_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxExperience_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxStartWork_SSA.Text) ||
                    string.IsNullOrWhiteSpace(textBoxMoney_SSA.Text))
                {
                    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string[] newEmployee = new string[] {
                        textBoxFIO_SSA.Text,
                        textBoxAdress_SSA.Text,
                        textBoxPhone_SSA.Text,
                        textBoxRole_SSA.Text,
                        textBoxBirth_SSA.Text,
                        textBoxDegree_SSA.Text,
                        textBoxExperience_SSA.Text,
                        textBoxStartWork_SSA.Text,
                        textBoxMoney_SSA.Text
                    };
                    dataGridViewEmployees_SSA.Rows.Add(newEmployee);
                    if (ds.AddData(employeesPath, newEmployee))
                        MessageBox.Show("Сотрудник добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearEmployeeTextBoxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearEmployeeTextBoxes()
        {
            textBoxFIO_SSA.Clear();
            textBoxAdress_SSA.Clear();
            textBoxPhone_SSA.Clear();
            textBoxRole_SSA.Clear();
            textBoxBirth_SSA.Clear();
            textBoxDegree_SSA.Clear();
            textBoxExperience_SSA.Clear();
            textBoxStartWork_SSA.Clear();
        }

        private void dataGridViewEmployees_SSA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columns = dataGridViewEmployees_SSA.ColumnCount;
            string[] updatedEmployee = new string[columns];
            for (int i = 0; i < columns; i++)
            {
                updatedEmployee[i] = dataGridViewEmployees_SSA[i, rowIndex].Value.ToString();
            }
            if (ds.UpdateData(employeesPath, updatedEmployee, rowIndex))
                MessageBox.Show("Сотрудник изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeleteEmployee_SSA_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewEmployees_SSA.SelectedRows[0].Index;
            if (rowIndex != dataGridViewEmployees_SSA.NewRowIndex)
                dataGridViewEmployees_SSA.Rows.RemoveAt(rowIndex);
            if (ds.DeleteData(employeesPath, rowIndex))
                MessageBox.Show("Сотрудник удален", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxDegree_SSA_CheckedChanged(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        private void buttonEmployeeStats_SSA_Click(object sender, EventArgs e)
        {
            FormEmployeeStats formEmployeeStats = new FormEmployeeStats();
            formEmployeeStats.ShowDialog();
        }
    }
}
