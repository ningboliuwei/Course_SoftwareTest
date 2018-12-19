using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace 单元测试_得分等级_Grade类_
{
    [TestFixture]
    class GradeTest
    {
        private Grade _grade;

        [SetUp]
        public void Initialize()
        {
            _grade = new Grade(55);
        }

        [Test]
        public void TestGetLevel()
        {
            Assert.AreEqual("B", new Grade(85).GetLevel());
            Assert.AreEqual("C", new Grade(75).GetLevel());
            Assert.AreEqual("A", new Grade(95).GetLevel());
            Assert.AreEqual("D", new Grade(65).GetLevel());
            Assert.AreEqual("F", new Grade(55).GetLevel());
        }

        [Test]
        public void TestGetLevelWithInvalideGrade()
        {
            _grade = new Grade(105);
            Assert.Throws<InvalidGradeException>(() => _grade.GetLevel());
        }

        [Test]
        public void TestGetMark()
        {
            Assert.AreEqual(55, _grade.GetMark());
        }

        [TearDown]
    }
}