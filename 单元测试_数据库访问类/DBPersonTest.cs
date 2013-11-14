using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;

namespace 单元测试_数据库访问类
{
    [TestFixture]
    internal class DBPersonTest
    {
        private Person person;
        private DBPerson dbPerson = new DBPerson();
        private int maxId;

        [SetUp]
        public void InitializePerson()
        {
            person = new Person();

            person.Username = "刘晨";
            person.Password = "123456";
            person.Age = 20;
            dbPerson.Insert(person);
            maxId = GetMaxId();
        }

        [Test]
        public void InsertTest()
        {
            person.Id = maxId;
            Compare(person, dbPerson.GetById(maxId));
        }

        [Test]
        public void UpdateTest()
        {
            Person personBeforeUpdate = dbPerson.GetById(maxId);
            personBeforeUpdate.Id = maxId;
            personBeforeUpdate.Username = "王敏";
            personBeforeUpdate.Password = "654321";
            personBeforeUpdate.Age = 40;
            dbPerson.Update(personBeforeUpdate);

            Person personAfterUpdate = dbPerson.GetById(maxId);
            Compare(personBeforeUpdate, personAfterUpdate);
        }

        [Test]
        public void GetByIdTest()
        {
            Person personExpected = person;
            Person personActual = dbPerson.GetById(maxId);
            personExpected.Id = maxId;
            Compare(person, personActual);
        }

        [Test]
        public void RemoveByIdTest()
        {
            dbPerson.RemoveById(maxId);
            Person personExpected= dbPerson.GetById(maxId);

            Assert.IsNull(personExpected);

        }

        [TearDown]
        public void FinalizePerson()
        {
            dbPerson.RemoveById(maxId);
        }


        public int GetMaxId()
        {
            string commandText = "SELECT MAX(id) FROM person";
            SqlCommand command = new SqlCommand(commandText, Connection.GetConnection());
            int maxId = 0;

            maxId = Convert.ToInt32(command.ExecuteScalar());

            return maxId;
        }

        public void Compare(Person personExpected, Person personActual)
        {
            Assert.AreEqual(personExpected.Id, personActual.Id);
            Assert.AreEqual(personExpected.Password, personActual.Password);
            Assert.AreEqual(personExpected.Username, personActual.Username);
            Assert.AreEqual(personExpected.Age, personActual.Age);
        }
    }
}