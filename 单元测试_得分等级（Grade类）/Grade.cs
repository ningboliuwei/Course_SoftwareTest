using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单元测试_得分等级_Grade类_
{
    public class Grade
    {
        private readonly int _mark;

        public Grade(int mark)
        {
            _mark = mark;
        }

        public string GetLevel()
        {
            if (_mark > 100 || _mark < 0)
                throw new InvalidGradeException();

            if (_mark >= 90)
                return "A";

            if (_mark >= 80)
                return "B";

            if (_mark >= 70)
                return "C";

            if (_mark >= 60)
                return "D";

            return "F";
        }

        public int GetMark()
        {
            return _mark;
        }
    }
}
