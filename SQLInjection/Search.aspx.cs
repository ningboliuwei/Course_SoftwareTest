using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLInjection
{
	using System.Configuration;
	using System.Data;
	using System.Data.SqlClient;

	public partial class Search : System.Web.UI.Page
	{
		private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);//创建连接的对象

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = txtKeyword.Text;
			string commandText = @"SELECT * FROM Products
								   WHERE ProductName LIKE '%" + keyword + "%'";
			SqlCommand command = new SqlCommand(commandText, conn);

			try
			{
				if (conn.State != ConnectionState.Open)
				{
					conn.Open();
				}
				Response.Write(commandText);
				Response.Write("<br/>");

				SqlDataReader reader = command.ExecuteReader();

				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Response.Write(reader[i].ToString() + ", ");
					}
					Response.Write("<br/>");
				}


			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			finally
			{
				conn.Close();
			}
		}
	}
}