using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLInjection
{
	public partial class Products : System.Web.UI.Page
	{
		private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);//创建连接的对象

		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				LoadData();
			}
		}

		private void LoadData()
		{
			string id = Request.QueryString["id"];
			string commandText = @"SELECT * FROM Products
								   WHERE ProductId=" + id;
			SqlCommand command = new SqlCommand(commandText, conn);

			try
			{
				if (conn.State != ConnectionState.Open)
				{
					conn.Open();
				}
				Response.Write(commandText);

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