using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _28_NguyenVinhKhiem_N1_NUnit;

namespace _28_NguyenVinhKhiem_N1_NUnitTester
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [TestMethod] //TC1: a=1, b=3, c=-4 => delta = 25 > 0 => PT có 2 nghiệm phân biệt
        public void Test2N()
        {
            double expected, actual;
            PTBac2 d = new PTBac2(1, 3, -4);
            expected = 25;
            actual = d.Execute("delta");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC1: a=1, b=2, c=-1 => delta = 0 => PT có 2 nghiệm kép
        public void TestNK()
        {
            double expected, actual;
            PTBac2 d = new PTBac2(1, 2, 1);
            expected = 0;
            actual = d.Execute("delta");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //TC1: a=1, b=1, c=-1 => delta = -3 < 0 => PT vô nghiệm
        public void TestVN()
        {
            double expected, actual;
            PTBac2 d = new PTBac2(1, 1, 1);
            expected = -3;
            actual = d.Execute("delta");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\28_Khiem_Data\28_Khiem_file.csv", "28_Khiem_file#csv", DataAccessMethod.Sequential)]
        public void TestReadData_28_Khiem()
        {
            int Khiem_28_a = int.Parse(TestContext.DataRow[0].ToString());
            int Khiem_28_b = int.Parse(TestContext.DataRow[1].ToString());
            int Khiem_28_c = int.Parse(TestContext.DataRow[2].ToString());
            double Khiem_28_expected = int.Parse(TestContext.DataRow[3].ToString());
            PTBac2 Khiem_28_PTBac2 = new PTBac2(Khiem_28_a, Khiem_28_b, Khiem_28_c);
            double Khiem_28_actual = Khiem_28_PTBac2.Execute("delta");
            Assert.AreEqual(Khiem_28_expected, Khiem_28_actual);
        }
    }
}
