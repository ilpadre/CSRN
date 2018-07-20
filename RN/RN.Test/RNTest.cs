using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RN.Test
{
    [TestClass]
    public class RNTest
    {
        [TestMethod]
        public void CanConvert_I()
        {
            int rn = RomanNumeral.ConvertFromRN("I");
            Assert.AreEqual(1, rn, "Returned incorrect value for I");
        }

        [TestMethod]
        public void CanConvert_V()
        {
            int rn = RomanNumeral.ConvertFromRN("V");
            Assert.AreEqual(5, rn, "Returned incorrect value for V");
        }

        [TestMethod]
        public void CanConvert_X()
        {
            int rn = RomanNumeral.ConvertFromRN("X");
            Assert.AreEqual(10, rn, "Returned incorrect value for X");
        }

        [TestMethod]
        public void CanConvert_L()
        {
            int rn = RomanNumeral.ConvertFromRN("L");
            Assert.AreEqual(50, rn, "Returned incorrect value for L");
        }

        [TestMethod]
        public void CanConvert_C()
        {
            int rn = RomanNumeral.ConvertFromRN("C");
            Assert.AreEqual(100, rn, "Returned incorrect value for C");
        }

        [TestMethod]
        public void CanConvert_D()
        {
            int rn = RomanNumeral.ConvertFromRN("D");
            Assert.AreEqual(500, rn, "Returned incorrect value for D");
        }

        [TestMethod]
        public void CanConvert_M()
        {
            int rn = RomanNumeral.ConvertFromRN("M");
            Assert.AreEqual(1000, rn, "Returned incorrect value for M");
        }

        [TestMethod]
        public void CanConvert_II()
        {
            int rn = RomanNumeral.ConvertFromRN("II");
            Assert.AreEqual(2, rn, "Returned incorrect value for II");
        }

        [TestMethod]
        public void CanConvert_III()
        {
            int rn = RomanNumeral.ConvertFromRN("III");
            Assert.AreEqual(3, rn, "Returned incorrect value for III");
        }

        [TestMethod]
        public void CanConvert_VI()
        {
            int rn = RomanNumeral.ConvertFromRN("VI");
            Assert.AreEqual(6, rn, "Returned incorrect value for VI");
        }

        [TestMethod]
        public void CanConvert_IV()
        {
            int rn = RomanNumeral.ConvertFromRN("IV");
            Assert.AreEqual(4, rn, "Returned incorrect value for IV");
        }

        [TestMethod]
        public void CanConvert_IX()
        {
            int rn = RomanNumeral.ConvertFromRN("IX");
            Assert.AreEqual(9, rn, "Returned incorrect value for IX");
        }

        [TestMethod]
        public void CanConvert_LX()
        {
            int rn = RomanNumeral.ConvertFromRN("LX");
            Assert.AreEqual(60, rn, "Returned incorrect value for IX");
        }

        [TestMethod]
        public void CanConvert_XL()
        {
            int rn = RomanNumeral.ConvertFromRN("XL");
            Assert.AreEqual(40, rn, "Returned incorrect value for XL");
        }

        [TestMethod]
        public void CanConvert_CCCLXXVI()
        {
            int rn = RomanNumeral.ConvertFromRN("CCCLXXVI");
            Assert.AreEqual(376, rn, "Returned incorrect value for CCCLXXVI");
        }

        [TestMethod]
        public void CanConvert_CMXCIX()
        {
            int rn = RomanNumeral.ConvertFromRN("CMXCIX");
            Assert.AreEqual(999, rn, "Returned incorrect value for CCCLXXVI");
        }

        [TestMethod]
        public void CanConvert_1()
        {
            string rn = RomanNumeral.ConvertToRN(1);
            Assert.AreEqual("I", rn);
        }

        [TestMethod]
        public void CanConvert_2()
        {
            string rn = RomanNumeral.ConvertToRN(2);
            Assert.AreEqual("II", rn);
        }

        [TestMethod]
        public void CanConvert_3()
        {
            string rn = RomanNumeral.ConvertToRN(3);
            Assert.AreEqual("III", rn);
        }

        [TestMethod]
        public void CanConvert_4()
        {
            string rn = RomanNumeral.ConvertToRN(4);
            Assert.AreEqual("IV", rn);
        }

        [TestMethod]
        public void CanConvert_5()
        {
            string rn = RomanNumeral.ConvertToRN(5);
            Assert.AreEqual("V", rn);
        }

        [TestMethod]
        public void CanConvert_6()
        {
            string rn = RomanNumeral.ConvertToRN(6);
            Assert.AreEqual("VI", rn);
        }

        [TestMethod]
        public void CanConvert_7()
        {
            string rn = RomanNumeral.ConvertToRN(7);
            Assert.AreEqual("VII", rn);
        }

        [TestMethod]
        public void CanConvert_8()
        {
            string rn = RomanNumeral.ConvertToRN(8);
            Assert.AreEqual("VIII", rn);
        }

        [TestMethod]
        public void CanConvert_9()
        {
            string rn = RomanNumeral.ConvertToRN(9);
            Assert.AreEqual("IX", rn);
        }

        [TestMethod]
        public void CanConvert_10()
        {
            string rn = RomanNumeral.ConvertToRN(10);
            Assert.AreEqual("X", rn);
        }

        [TestMethod]
        public void CanConvert_11()
        {
            string rn = RomanNumeral.ConvertToRN(11);
            Assert.AreEqual("XI", rn);
        }

        [TestMethod]
        public void CanConvert_12()
        {
            string rn = RomanNumeral.ConvertToRN(12);
            Assert.AreEqual("XII", rn);
        }

        [TestMethod]
        public void CanConvert_13()
        {
            string rn = RomanNumeral.ConvertToRN(13);
            Assert.AreEqual("XIII", rn);
        }

        [TestMethod]
        public void CanConvert_14()
        {
            string rn = RomanNumeral.ConvertToRN(14);
            Assert.AreEqual("XIV", rn);
        }

        [TestMethod]
        public void CanConvert_15()
        {
            string rn = RomanNumeral.ConvertToRN(15);
            Assert.AreEqual("XV", rn);
        }

        [TestMethod]
        public void CanConvert_16()
        {
            string rn = RomanNumeral.ConvertToRN(16);
            Assert.AreEqual("XVI", rn);
        }

        [TestMethod]
        public void CanConvert_17()
        {
            string rn = RomanNumeral.ConvertToRN(17);
            Assert.AreEqual("XVII", rn);
        }

        [TestMethod]
        public void CanConvert_18()
        {
            string rn = RomanNumeral.ConvertToRN(18);
            Assert.AreEqual("XVIII", rn);
        }

        [TestMethod]
        public void CanConvert_19()
        {
            string rn = RomanNumeral.ConvertToRN(19);
            Assert.AreEqual("XIX", rn);
        }

        [TestMethod]
        public void CanConvert_20()
        {
            string rn = RomanNumeral.ConvertToRN(20);
            Assert.AreEqual("XX", rn);
        }

        [TestMethod]
        public void CanConvert_79()
        {
            string rn = RomanNumeral.ConvertToRN(79);
            Assert.AreEqual("LXXIX", rn);
        }

        [TestMethod]
        public void CanConvert_100()
        {
            string rn = RomanNumeral.ConvertToRN(100);
            Assert.AreEqual("C", rn);
        }

        [TestMethod]
        public void CanConvert_127()
        {
            string rn = RomanNumeral.ConvertToRN(127);
            Assert.AreEqual("CXXVII", rn);
        }

        [TestMethod]
        public void CanConvert_200()
        {
            string rn = RomanNumeral.ConvertToRN(200);
            Assert.AreEqual("CC", rn);
        }

        [TestMethod]
        public void CanConvert_300()
        {
            string rn = RomanNumeral.ConvertToRN(300);
            Assert.AreEqual("CCC", rn);
        }

        [TestMethod]
        public void CanConvert_329()
        {
            string rn = RomanNumeral.ConvertToRN(329);
            Assert.AreEqual("CCCXXIX", rn);
        }

        [TestMethod]
        public void CanConvert_499()
        {
            string rn = RomanNumeral.ConvertToRN(499);
            Assert.AreEqual("CDXCIX", rn);
        }

        [TestMethod]
        public void CanConvert_777()
        {
            string rn = RomanNumeral.ConvertToRN(777);
            Assert.AreEqual("DCCLXXVII", rn);
        }

        [TestMethod]
        public void CanConvert_999()
        {
            string rn = RomanNumeral.ConvertToRN(999);
            Assert.AreEqual("CMXCIX", rn);
        }

        [TestMethod]
        public void CanConvert_1000()
        {
            string rn = RomanNumeral.ConvertToRN(1000);
            Assert.AreEqual("M", rn);
        }

    }
}
