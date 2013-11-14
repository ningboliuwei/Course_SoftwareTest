using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;


namespace 单元测试_数据库访问类
{
    [TestFixture]
    class ConnectionTest
    {
        [Test]
        public void GetConnectionTest()
        {
            Assert.IsNotNull(Connection.GetConnection());
        }
    }
}
