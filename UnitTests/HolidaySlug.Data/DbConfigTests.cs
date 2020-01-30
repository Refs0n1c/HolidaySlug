using HolidaySlug.Data.Config;
using NUnit.Framework;

namespace UnitTests.HolidaySlug.Data
{
    [TestFixture]
    public class DbConfigTests
    {

        [Test]
        public void DBConfig_WhenInstantiated_GetsDevConnectionString()
        {
            var testDbConfig = new DbConfiguration();
            
            
            Assert.IsNotEmpty(testDbConfig.DevConnectionString);
            Assert.IsNotNull(testDbConfig.DevConnectionString);
            
        }


    }
}