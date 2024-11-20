#region

using System.Data;
using System.Data.SqlClient;

#endregion

namespace 单元测试_数据库连接 {
    internal class DBHelper {
        public static int ExecuteNonQuery(SqlConnection connection, string cmdText) {
            var cmd = new SqlCommand(cmdText, connection);

            using (connection) {
                var val = cmd.ExecuteNonQuery();

                return val;
            }
        }

        public static SqlDataReader ExecuteReader(SqlConnection connection, string cmdText) {
            var cmd = new SqlCommand(cmdText, connection);

            try {
                var rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                cmd.Parameters.Clear();
                return rdr;
            }
            catch {
                connection.Close();
                throw;
            }
        }

        public static object ExecuteScalar(SqlConnection connection, string cmdText) {
            var cmd = new SqlCommand(cmdText, connection);

            using (connection) {
                var val = cmd.ExecuteScalar();

                return val;
            }
        }
    }
}