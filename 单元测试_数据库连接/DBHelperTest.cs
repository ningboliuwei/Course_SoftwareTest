﻿#region

using System.Data.SqlClient;
using NUnit.Framework;

#endregion

namespace 单元测试_数据库连接 {
    [TestFixture]
    internal class DBHelperTest {
        private SqlConnection connection;

        // [TestFixtureSetUp]//Setup
        public void InitializeDBConnection() {
            connection = new SqlConnection("data source=127.0.0.1;database=schooldb;uid=Student;pwd=123456");
            connection.Open();
        }

        // [TestFixtureTearDown]//TearDown
        public void FinalizeDBConnection() {
            //connection.Close();
            //connection = null;
        }

        [Test]
        public void TestScalar() {
            Assert.AreEqual(6, DBHelper.ExecuteScalar(connection, "SELECT COUNT(*) FROM Students"));
        }
    }
}