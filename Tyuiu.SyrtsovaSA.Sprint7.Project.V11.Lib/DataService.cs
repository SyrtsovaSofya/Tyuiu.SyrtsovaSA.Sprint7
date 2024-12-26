using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public string[,] GetData(string path)
        {
            string file = File.ReadAllText(path, Encoding.GetEncoding(1251));
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length == 0)
                return null;
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }
            return array;
        }

        public bool AddData(string path, string[] line)
        {
            string str = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (i != line.Length - 1)
                    str = str + line[i] + ";";
                else
                    str = str + line[i];
            }
            File.AppendAllText(path, str + Environment.NewLine, Encoding.GetEncoding(1251));
            return true;
        }

        public bool UpdateData(string path, string[] line, int rowIndex)
        {
            string str = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (i != line.Length - 1)
                    str = str + line[i] + ";";
                else
                    str = str + line[i];
            }
            string[] lines = File.ReadAllLines(path, Encoding.GetEncoding(1251));
            lines[rowIndex] = str;
            File.WriteAllLines(path, lines, Encoding.GetEncoding(1251));
            return true;
        }

        public bool DeleteData(string path, int rowIndex)
        {
            List<string> lines = File.ReadAllLines(path, Encoding.GetEncoding(1251)).ToList<string>();
            lines.Remove(lines[rowIndex]);
            File.WriteAllLines(path, lines, Encoding.GetEncoding(1251));
            return true;
        }

        public double GetAverageValue(double[] array)
        {
            double avg = array.Average();
            return avg;
        }
        public double GetMinValue(double[] array)
        {
            double min = array.Min();
            return min;
        }
        public double GetMaxValue(double[] array)
        {
            double max = array.Max();
            return max;
        }
    }
}
