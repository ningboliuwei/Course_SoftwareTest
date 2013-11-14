using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 单元测试_数据库访问类
{
    public class DBPerson
    {
        public void Insert(Person person)
        {
            string sql = @"insert into person(username,password,age) values(@username,@password,@age)";


            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@age", SqlDbType.Int));

                command.Parameters["@username"].Value = person.Username;
                command.Parameters["@password"].Value = person.Password;
                command.Parameters["@age"].Value = person.Age;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public void Update(Person person)
        {
            string sql = "update person set username=@username,password=@password,age=@age where id=@id";

            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
                command.Parameters.Add(new SqlParameter("@age", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));

                command.Parameters["@username"].Value = person.Username;
                command.Parameters["@password"].Value = person.Password;
                command.Parameters["@age"].Value = person.Age;
                command.Parameters["@id"].Value = person.Id;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }

        public Person GetById(int id)
        {
            string sql = "select * from person where id = @id";

            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Parameters["@id"].Value = id;


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Person person = null;

                    if (reader.Read())
                    {
                        person = new Person();

                        person.Id = id;
                        person.Username = reader["username"].ToString();
                        person.Password = reader["password"].ToString();
                        person.Age = Convert.ToInt32(reader["age"]);
                    }

                    return person;
                }
            }
        }

        public void RemoveById(int id)
        {
            string sql = "delete from person where id = @id";

            using (SqlConnection conn = Connection.GetConnection())
            {
                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                command.Parameters["@id"].Value = id;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    throw new Exception(exception.Message);
                }
            }
        }
    }
}