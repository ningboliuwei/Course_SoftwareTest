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
	public partial class _Default : System.Web.UI.Page
	{

		private static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);//创建连接的对象
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_OnClick(object sender, EventArgs e)
		{
			string commandText = @"SELECT COUNT(*) FROM Users
								   WHERE Username='" + txtUsername.Text + "'"
			                     + " AND Password='" + txtPassword.Text + "'";
			
			SqlCommand command = new SqlCommand(commandText, conn);

			try
			{
				if (conn.State != ConnectionState.Open)
				{
					conn.Open();
				}
				Response.Write(commandText);

				if (Convert.ToInt32(command.ExecuteScalar()) != 0)
				{
					Response.Write("登录成功");
				}
				else
				{
					Response.Write("用户名或密码不对");
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