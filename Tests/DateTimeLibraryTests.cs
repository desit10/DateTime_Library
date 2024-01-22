using DateTime_Library;

namespace Tests
{
    [TestClass]
    public class DateTimeLibraryTests
    {
        [TestMethod]
        public void TestDateTimeDifference()
        {            
            DateTime dateStart = new DateTime(2024, 1, 1);
            DateTime dateEnd = new DateTime(2024, 1, 3);
            int expected = 2;
            DateTimeFormatting dateTimeFormatting = new DateTimeFormatting();

            int actual = dateTimeFormatting.DateTimeDifference(dateStart, dateEnd);            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsLeapYear()
        {            
            bool expected = true;
            DateTimeFormatting dateTimeFormatting = new DateTimeFormatting();

            bool actual = dateTimeFormatting.IsLeapYear(2024);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTimeofDay()
        {
            DateTime date = new DateTime(2024, 1, 1, 20, 0, 0);            
            string expected = "20:00:00";
            DateTimeFormatting dateTimeFormatting = new DateTimeFormatting();

            string actual = dateTimeFormatting.TimeofDay(date);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDateTimeformat()
        {
            DateTime date = new DateTime(2024, 1, 1);
            string expected = "2024.01.01";
            DateTimeFormatting dateTimeFormatting = new DateTimeFormatting();

            string actual = dateTimeFormatting.DateTimeformat(date, "yyyy.MM.dd", "ru-RU");
            Assert.AreEqual(expected, actual);
        }
    }
}
