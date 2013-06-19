using System;
using NUnit.Framework;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {
        [Test]
        public void IsYouthDayOnThe17June2013()
        {
            var sut = new PublicHolidayNotifier(new DateTime(2013, 6, 17));
            var result = sut.GenerateNotification();
            Assert.That(result,Is.EqualTo("Today is Youth Day"));
        }

        [Test]
        public void IsNormalDayOnThe18June2013()
        {
            var sut = new PublicHolidayNotifier(new DateTime(2013, 6, 18));
            var result = sut.GenerateNotification();
            Assert.That(result,Is.EqualTo("Today is a normal day"));
        }
               
    }
}
