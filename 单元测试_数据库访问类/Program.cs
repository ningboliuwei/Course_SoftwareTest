using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_数据库访问类
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Username = "王晨";
            person1.Password = "123456";
            person1.Age = 25;
            DBPerson dbPerson = new DBPerson();
            dbPerson.Insert(person1);
            Console.WriteLine("新增了一条记录");

            Person person2 = dbPerson.GetById(4);
            person2.Password = "654321";
            person2.Username = "李敏";
            person2.Age = 40;
            dbPerson.Update(person2);
            Console.WriteLine("Id为 4的记录已被更新");

            int id = 3;
            dbPerson.RemoveById(id);
            Console.WriteLine("Id为 3的记录已被删除");
        }
    }
}