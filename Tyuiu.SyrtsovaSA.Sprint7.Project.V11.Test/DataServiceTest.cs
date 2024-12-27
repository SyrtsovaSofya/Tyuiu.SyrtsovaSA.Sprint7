using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Lib;

namespace Tyuiu.SyrtsovaSA.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetData()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\employees.csv";
            string[,] res = ds.GetData(pathSaveFile);
            string[,] wait = { { "Иванов Иван Иванович", "Тюмень, Широтная 25", "79829259272", "Менеджер", "07.03.2001", "ВО", "5", "17.05.2019" } };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckUpdateData()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\employees.csv";
            string[] data = {"Валиев Игорь Сергеевич;Тюмень, Судоремонтная 45;79829529672;Директор;15.03.2005;ВО;3;17.05.2021"};
            bool res = ds.UpdateData(pathSaveFile, data, 0);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckDeleteData()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"C:\Users\Linn\source\repos\Tyuiu.SyrtsovaSA.Sprint7\Tyuiu.SyrtsovaSA.Sprint7.Project.V11\Files\employees.csv";
            string[] data = { "Валиев Игорь Сергеевич;Тюмень, Судоремонтная 45;79829529672;Директор;15.03.2005;ВО;3;17.05.2021" };
            bool res = ds.DeleteData(pathSaveFile, 0);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void CheckGetAvgValue()
        {
            DataService ds = new DataService();
            double[] data = { 5, 4, 3 };
            double res = ds.GetAverageValue(data);
            Assert.AreEqual(4, res);
        }

        [TestMethod]
        public void CheckGetMaxValue()
        {
            DataService ds = new DataService();
            double[] data = { 5, 4, 3 };
            double res = ds.GetMinValue(data);
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void CheckMinAvgValue()
        {
            DataService ds = new DataService();
            double[] data = { 5, 4, 3 };
            double res = ds.GetMaxValue(data);
            Assert.AreEqual(5, res);
        }

    }
}
