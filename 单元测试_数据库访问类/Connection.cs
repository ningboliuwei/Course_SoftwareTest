using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;


namespace 单元测试_数据库访问类
{
        public class Connection
        {
            public static SqlConnection GetConnection()
            {
                string connString = "data source=.;uid=Student;pwd=123456;database=NUnitTest_DB";

                SqlConnection connection = new SqlConnection(connString);

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                }
                catch (Exception exception)
                {
                    connection = null;
                }

                return connection;
            }
        }
}