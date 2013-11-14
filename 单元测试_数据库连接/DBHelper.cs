using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace 单元测试_数据库连接
{
	internal class DBHelper
	{
		public static object ExecuteScalar(SqlConnection connection, string cmdText)
		{
			SqlCommand cmd = new SqlCommand(cmdText, connection);

			using (connection)
			{
				object val = cmd.ExecuteScalar();

				return val;
			}
		}

		public static int ExecuteNonQuery(SqlConnection connection, string cmdText)
		{
			SqlCommand cmd = new SqlCommand(cmdText, connection);

			using (connection)
			{
				int val = cmd.ExecuteNonQuery();

				return val;
			}
		}

		public static SqlDataReader ExecuteReader(SqlConnection connection, string cmdText)
		{
			SqlCommand cmd = new SqlCommand(cmdText, connection);

			try
			{
				SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				cmd.Parameters.Clear();
				return rdr;
			}
			catch
			{
				connection.Close();
				throw;
			}
		}
	}
}