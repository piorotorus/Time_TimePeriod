using Microsoft.VisualStudio.TestTools.UnitTesting;
using Time_TimePeriod;


namespace Time_TimePeriod.Test
{
    [TestClass()]
    public class Time_TimePeriodTests
    {

        [TestMethod()]
        public void CreatingTimeObjectByConstructor1()
        {
            Time punktCzasu = new Time(11, 22, 13);
            string expected = ("11:22:13");
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Konstruktor 1 dzia�a b��dnie");

        }
        [TestMethod()]
        public void CreatingTimeObjectByConstructor2()
        {
            Time punktCzasu = new Time();
            string expected = "0:0:0";
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Konstruktor 2 dzia�a b��dnie");

        }
        [TestMethod()]
        public void CreatingTimeObjectByConstructor3()
        {
            Time punktCzasu = new Time(11);
            string expected = ("11:0:0");
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Konstruktor 3 dzia�a b��dnie");

        }
        [TestMethod()]
        public void CreatingTimeObjectByConstructor4()
        {
            Time punktCzasu = new Time(11, 11);
            string expected = ("11:11:0");
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Konstruktor 4 dzia�a b��dnie");

        }
        [TestMethod()]
        public void CreatingTimeObjectByConstructor5()
        {
            Time punktCzasu = new Time("15:14:12");
            string expected = ("15:14:12");
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Konstruktor 5 dzia�a b��dnie");

        }
        [TestMethod()]
        public void GetVariablesFromTime()
        {
            Time punktCzasu = new Time("22:9:17");
            byte getGodziny = punktCzasu.Godziny;
            byte expectGodizny = 22;
            byte getMinuty = punktCzasu.Minuty;
            byte expectMinuty = 9;
            byte getSekundy = punktCzasu.Sekundy;
            byte expectSekundy = 17;
            Assert.AreEqual(expectGodizny, getGodziny, "Pobieranie warto�ci godzin jest b��dne");
            Assert.AreEqual(expectMinuty, getMinuty, "Pobieranie warto�ci minut jest b��dne");
            Assert.AreEqual(expectSekundy, getSekundy, "Pobieranie warto�ci sekund jest b��dne");
        }
        [TestMethod()]
        public void TimeToStingMethod()
        {
            Time punktCzasu = new Time("22:9:17");
            string expected = "22:9:17";
            string actual = punktCzasu.ToString();
            Assert.AreEqual(expected, actual, "Przekszta�canie na wy�wietlanie godziny nie dzia�a");
        }

        [TestMethod()]
        public void EqualsMethodTest()
        {
            Time punktCzasu1 = new Time("22:9:15");
            Time punktCzasu2 = new Time("21:9:15");
            bool areEqual = punktCzasu1.Equals(punktCzasu2);
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie punkt�w czasu nie dzia�a test1");
        }
        [TestMethod()]
        public void EqualsMethodTest2()
        {
            Time punktCzasu1 = new Time("22:9:25");
            Time punktCzasu2 = new Time("22:9:25");
            bool areEqual = punktCzasu1.Equals(punktCzasu2);
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie punkt�w czasu nie dzia�a test2");
        }
        [TestMethod()]
        public void EqualsMethodTest3()
        {
            Time punktCzasu1 = new Time("22:9:15");
            Time punktCzasu2 = new Time("21:9:15");
            bool areEqual = punktCzasu1 == punktCzasu2;
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie punkt�w czasu nie dzia�a test3");
        }
        [TestMethod()]
        public void EqualsMethodTest4()
        {
            Time punktCzasu1 = new Time("22:9:25");
            Time punktCzasu2 = new Time("22:9:25");
            bool areEqual = punktCzasu1 == punktCzasu2;
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie punkt�w czasu nie dzia�a test4");
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Time punktCzasu1 = new Time("2:2:2");
            int expected = 4573;
            int acctual = punktCzasu1.GetHashCode();
            Assert.AreEqual(expected, acctual, "Pobieranie Hashu punktu Time nie dzia�a");
        }
        [TestMethod()]
        public void NotEqualsMethodTest1()
        {
            Time punktCzasu1 = new Time("23:1:55");
            Time punktCzasu2 = new Time("21:9:15");
            bool areEqual = punktCzasu1 != punktCzasu2;
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Nier�wno�� czas�w dzia�a b��dnie test1");
        }
        [TestMethod()]
        public void NotEqualsMethodTest2()
        {
            Time punktCzasu1 = new Time("23:1:55");
            Time punktCzasu2 = new Time("23:1:55");
            bool areEqual = punktCzasu1 != punktCzasu2;
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Nier�wno�� czas�w dzia�a b��dnie test2");
        }
        [TestMethod()]
        public void CompareToTest1()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            int expected = 1;
            int acctual = punktCzasu1.CompareTo(punktCzasu2);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie punkt�w czasu test1");

        }
        [TestMethod()]
        public void CompareToTest2()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            int expected = -1;
            int acctual = punktCzasu2.CompareTo(punktCzasu1);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie punkt�w czasu test2");

        }
        [TestMethod()]
        public void CompareToTest3()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("13:1:55");
            int expected = 0;
            int acctual = punktCzasu2.CompareTo(punktCzasu1);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie punkt�w czasu test3");

        }
        [TestMethod()]
        public void OperatorMniejszo�ciTest()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            bool expected = true;
            bool acctual = punktCzasu1 < punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator < test1");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciTest2()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("3:15:26");
            bool expected = false;
            bool acctual = punktCzasu1 < punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator < test2");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciTest()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            bool expected = false;
            bool acctual = punktCzasu1 > punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator > test1");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciTest2()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("3:15:26");
            bool expected = true;
            bool acctual = punktCzasu1 > punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator > test2");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciTest()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            bool expected = true;
            bool acctual = punktCzasu1 <= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test1");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciTest2()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("3:15:26");
            bool expected = false;
            bool acctual = punktCzasu1 <= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test2");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciTest3()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("13:1:55");
            bool expected = true;
            bool acctual = punktCzasu1 <= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test3");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciTest()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("23:15:26");
            bool expected = false;
            bool acctual = punktCzasu1 >= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test1");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciTest2()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("3:15:26");
            bool expected = true;
            bool acctual = punktCzasu1 >= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test2");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciTest3()
        {
            Time punktCzasu1 = new Time("13:1:55");
            Time punktCzasu2 = new Time("13:1:55");
            bool expected = true;
            bool acctual = punktCzasu1 >= punktCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test3");
        }
        [TestMethod()]
        public void MethodZwielokrotnianiaTest1()
        {
            Time punktCzasu1 = new Time("1:2:3");
            string expected = "2:4:6";
            Assert.AreEqual(expected, punktCzasu1.Zwielokrotnienie(2).ToString(), "Nie dzia�a funkcja zwielokrotniania test1");
        }
        [TestMethod()]
        public void MethodZwielokrotnianiaTest2()
        {
            Time punktCzasu1 = new Time("3:2:3");
            string expected = "3:18:27";
            Assert.AreEqual(expected, punktCzasu1.Zwielokrotnienie(9).ToString(), "Nie dzia�a funkcja zwielokrotniania test2");
        }
        [TestMethod()]
        public void MethodPlusTest1()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            string expected = "1:20:10";
            Assert.AreEqual(expected, punktCzasu1.Plus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test1");

        }
        [TestMethod()]
        public void MethodPlusTest2()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "7:26:55";
            Assert.AreEqual(expected, punktCzasu1.Plus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test2");

        }
        [TestMethod()]
        public void MethodPlusTest3()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            Time acctual = Time.Plus(punktCzasu1, przedzia�Czasu2);
            string expected = "1:20:10";
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test3");

        }
        [TestMethod()]
        public void MethodPlusTest4()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            Time acctual = Time.Plus(punktCzasu1, przedzia�Czasu2);
            string expected = "7:26:55";
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test4");

        }
        [TestMethod()]
        public void OperatorPlusTest5()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            string expected = "1:20:10";
            Assert.AreEqual(expected, (punktCzasu1 + przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test5");
        }
        [TestMethod()]
        public void OperatorPlusTest6()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "7:26:55";
            Assert.AreEqual(expected, (punktCzasu1 + przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania do punktu przezia�u czasowego test6");
        }
        public void MethodMinusTest1()
        {
            Time punktCzasu1 = new Time("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            Assert.AreEqual(expected, punktCzasu1.Minus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test1");

        }
        [TestMethod()]
        public void MethodMinusTest2()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            Assert.AreEqual(expected, punktCzasu1.Minus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test2");

        }
        public void OperatorMinusTest3()
        {
            Time punktCzasu1 = new Time("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            Assert.AreEqual(expected, (punktCzasu1 - przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test3");

        }
        [TestMethod()]
        public void OperatorMinusTest4()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            Assert.AreEqual(expected, (punktCzasu1 - przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test4");

        }
        public void MethodMinusTest5()
        {
            Time punktCzasu1 = new Time("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            Time acctual = Time.Minus(punktCzasu1, przedzia�Czasu2);
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test5");

        }
        [TestMethod()]
        public void MethodMinusTest6()
        {
            Time punktCzasu1 = new Time("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            Time acctual = Time.Minus(punktCzasu1, przedzia�Czasu2);
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja odejmowania od punktu przezia�u czasowego test6");

        }
        [TestMethod()]
        public void GetVariablesFromTimePeriod()
        {
            TimePeriod okesCzasu = new TimePeriod("22:9:17");
            byte getGodziny = okesCzasu.Godziny;
            byte expectGodizny = 22;
            byte getMinuty = okesCzasu.Minuty;
            byte expectMinuty = 9;
            long getSekundy = okesCzasu.Sekundy;
            long expectSekundy = 17;
            long sumaCzasu = okesCzasu.SumaCzasu;
            long expectedSumaCzasu = 22 * 3600 + 9 * 60 + 17;
            Assert.AreEqual(expectGodizny, getGodziny, "Pobieranie warto�ci godzin jest b��dne");
            Assert.AreEqual(expectMinuty, getMinuty, "Pobieranie warto�ci minut jest b��dne");
            Assert.AreEqual(expectSekundy, getSekundy, "Pobieranie warto�ci sekund jest b��dne");
            Assert.AreEqual(expectedSumaCzasu, sumaCzasu, "Pobieranie warto�ci sumy czasu jest b��dne");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor1()
        {
            TimePeriod okresCzasu = new TimePeriod(11, 15, 3);
            string expected = okresCzasu.ToString();
            string acctual = "11:15:3";
            Assert.AreEqual(expected, acctual, "Konstruktor 1 dzia�a b��dnie");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor2()
        {
            TimePeriod okresCzasu = new TimePeriod(26, 15);
            string expected = okresCzasu.ToString();
            string acctual = "26:15:0";
            Assert.AreEqual(expected, acctual, "Konstruktor 2 dzia�a b��dnie");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor3()
        {
            TimePeriod okresCzasu = new TimePeriod(15);
            string expected = okresCzasu.ToString();
            string acctual = "0:0:15";
            Assert.AreEqual(expected, acctual, "Konstruktor 3 dzia�a b��dnie");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor4()
        {
            TimePeriod okresCzasu = new TimePeriod(367);
            string expected = okresCzasu.ToString();
            string acctual = "0:6:7";
            Assert.AreEqual(expected, acctual, "Konstruktor 4 dzia�a b��dnie");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor5()
        {
            Time punktCzasu1 = new Time(15, 13, 2);
            Time punktCzasu2 = new Time(4, 25, 33);
            TimePeriod okresCzasu = new TimePeriod(punktCzasu1, punktCzasu2);
            string expected = okresCzasu.ToString();
            string acctual = "10:47:29";
            Assert.AreEqual(expected, acctual, "Konstruktor 5 dzia�a b��dnie");
        }

        [TestMethod()]
        public void CreatingTimePeriodByConstructor6()
        {
            TimePeriod okresCzasu = new TimePeriod("15:2:38");
            string expected = okresCzasu.ToString();
            string acctual = "15:2:38";
            Assert.AreEqual(expected, acctual, "Konstruktor 6 dzia�a b��dnie");
        }

        [TestMethod()]
        public void TimePeriodToStingMethod()
        {
            TimePeriod okresCzasu = new TimePeriod("22:9:17");
            string expected = "22:9:17";
            string actual = okresCzasu.ToString();
            Assert.AreEqual(expected, actual, "Przekszta�canie na wy�wietlanie godziny nie dzia�a");
        }

        [TestMethod()]
        public void EqualsMethodTestPeriod()
        {
            TimePeriod okresCzasu1 = new TimePeriod("22:9:15");
            TimePeriod okresCzasu2 = new TimePeriod("14:9:15");
            bool areEqual = okresCzasu1.Equals(okresCzasu2);
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie okres�w czasu nie dzia�a test1");
        }

        [TestMethod()]
        public void EqualsMethodTestPeriod2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("22:9:25");
            TimePeriod okresCzasu2 = new TimePeriod("22:9:25");
            bool areEqual = okresCzasu1.Equals(okresCzasu2);
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie  okres czasu nie dzia�a test2");
        }
        [TestMethod()]
        public void EqualsMethodTestPeriod3()
        {
            TimePeriod okresCzasu1 = new TimePeriod("22:9:15");
            TimePeriod okresCzasu2 = new TimePeriod("21:9:15");
            bool areEqual = okresCzasu1 == okresCzasu2;
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie okres czasu nie dzia�a test3");
        }
        [TestMethod()]
        public void EqualsMethodTestPeriod4()
        {
            TimePeriod okresCzasu1 = new TimePeriod("22:9:25");
            TimePeriod okresCzasu2 = new TimePeriod("22:9:25");
            bool areEqual = okresCzasu1 == okresCzasu2;
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Przyr�wnywanie punkt�w czasu nie dzia�a test4");
        }
        [TestMethod()]
        public void GetHashCodePeriodTest()
        {
            TimePeriod okresCzasu1 = new TimePeriod("2:2:2");
            int expected = 4573;
            int acctual = okresCzasu1.GetHashCode();
            Assert.AreEqual(expected, acctual, "Pobieranie Hashu punktu TimePeriod nie dzia�a");
        }
        [TestMethod()]
        public void NotEqualsMethodPeriodTest1()
        {
            TimePeriod okresCzasu1 = new TimePeriod("23:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("21:9:15");
            bool areEqual = okresCzasu1 != okresCzasu2;
            bool expected = true;
            Assert.AreEqual(expected, areEqual, "Nier�wno�� okres�w czas�w dzia�a b��dnie test1");
        }
        [TestMethod()]
        public void NotEqualsMethodPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("23:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:1:55");
            bool areEqual = okresCzasu1 != okresCzasu2;
            bool expected = false;
            Assert.AreEqual(expected, areEqual, "Nier�wno�� okres�w czas�w dzia�a b��dnie test2");
        }
        [TestMethod()]
        public void CompareToPeriodTest1()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            int expected = 1;
            int acctual = okresCzasu1.CompareTo(okresCzasu2);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie odcink�w czasu test1");

        }
        [TestMethod()]
        public void CompareToPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            int expected = -1;
            int acctual = okresCzasu2.CompareTo(okresCzasu1);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie okres�w czasu test2");

        }
        [TestMethod()]
        public void CompareToPeriodTest3()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("13:1:55");
            int expected = 0;
            int acctual = okresCzasu2.CompareTo(okresCzasu1);
            Assert.AreEqual(expected, acctual, "Nie dzia�a por�wnywanie okres�w czasu test3");

        }
        [TestMethod()]
        public void OperatorMniejszo�ciPeriodTest()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            bool expected = true;
            bool acctual = okresCzasu1 < okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator < test1");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("3:15:26");
            bool expected = false;
            bool acctual = okresCzasu1 < okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator < test2");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciPeriodTest()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            bool expected = false;
            bool acctual = okresCzasu1 > okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator > test1");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("3:15:26");
            bool expected = true;
            bool acctual = okresCzasu1 > okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator > test2");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciPeriodTest()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            bool expected = true;
            bool acctual = okresCzasu1 <= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test1");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("3:15:26");
            bool expected = false;
            bool acctual = okresCzasu1 <= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test2");
        }
        [TestMethod()]
        public void OperatorMniejszo�ciR�wno�ciPeriodTest3()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("13:1:55");
            bool expected = true;
            bool acctual = okresCzasu1 <= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator <= test3");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciPeriodTest()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("23:15:26");
            bool expected = false;
            bool acctual = okresCzasu1 >= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test1");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciPeriodTest2()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("3:15:26");
            bool expected = true;
            bool acctual = okresCzasu1 >= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test2");
        }
        [TestMethod()]
        public void OperatorWi�kszo�ciR�wno�ciPeriodTest3()
        {
            TimePeriod okresCzasu1 = new TimePeriod("13:1:55");
            TimePeriod okresCzasu2 = new TimePeriod("13:1:55");
            bool expected = true;
            bool acctual = okresCzasu1 >= okresCzasu2;
            Assert.AreEqual(expected, acctual, "Nie dzia�a operator >= test3");
        }

        [TestMethod()]
        public void MethodPlusPeriodTest1()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            string expected = "25:20:10";
            Assert.AreEqual(expected, przedzia�Czasu1.Plus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych  test1");

        }
        [TestMethod()]
        public void MethodPlusPeriodTest2()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "7:26:55";
            Assert.AreEqual(expected, przedzia�Czasu1.Plus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych test2");

        }
        [TestMethod()]
        public void MethodPlusPeriodTest3()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            TimePeriod acctual = TimePeriod.Plus(przedzia�Czasu1, przedzia�Czasu2);
            string expected = "25:20:10";
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych  test3");

        }
        [TestMethod()]
        public void MethodPlusPeriodTest4()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            TimePeriod acctual = TimePeriod.Plus(przedzia�Czasu1, przedzia�Czasu2);
            string expected = "7:26:55";
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych  test4");

        }
        [TestMethod()]
        public void OperatorPlusPeriodTest5()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("23:15:26");
            string expected = "25:20:10";
            Assert.AreEqual(expected, (przedzia�Czasu1 + przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych  test5");
        }
        [TestMethod()]
        public void OperatorPlusPeriodTest6()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "7:26:55";
            Assert.AreEqual(expected, (przedzia�Czasu1 + przedzia�Czasu2).ToString(), "Nie dzia�a funkcja dodawania przedzia��w czasowych  test6");
        }
        public void MethodMinusPeriodTest1()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            Assert.AreEqual(expected, przedzia�Czasu1.Minus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test1");

        }
        [TestMethod()]
        public void MethodMinusPeriodTest2()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            Assert.AreEqual(expected, przedzia�Czasu1.Minus(przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test2");

        }
        public void OperatorMinusPeriodTest3()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            Assert.AreEqual(expected, (przedzia�Czasu1 - przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test3");

        }
        [TestMethod()]
        public void OperatorMinusPeriodTest4()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            Assert.AreEqual(expected, (przedzia�Czasu1 - przedzia�Czasu2).ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test4");

        }
        public void MethodMinusPeriodTest5()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("22:45:17");
            TimePeriod przedzia�Czasu2 = new TimePeriod("19:8:17");
            string expected = "2:37:0";
            TimePeriod acctual = TimePeriod.Minus(przedzia�Czasu1, przedzia�Czasu2);
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test5");

        }
        [TestMethod()]
        public void MethodMinusPeriodTest6()
        {
            TimePeriod przedzia�Czasu1 = new TimePeriod("2:4:44");
            TimePeriod przedzia�Czasu2 = new TimePeriod("5:22:11");
            string expected = "20:42:33";
            TimePeriod acctual = TimePeriod.Minus(przedzia�Czasu1, przedzia�Czasu2);
            Assert.AreEqual(expected, acctual.ToString(), "Nie dzia�a funkcja odejmowania przedzia��w czasowych  test6");

        }
    }
}
