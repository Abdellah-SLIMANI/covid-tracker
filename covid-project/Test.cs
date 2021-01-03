using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Test
    {
        //if the result is true then it's Positive(sick) and vice versa
        private Boolean _testResult;
        private DateTime _testTime;

        public Test() { }

        public Boolean testResult
        {
            get
            {
                return _testResult;
            }
            set
            {
                _testResult = value;
            }
        }
        public DateTime testTime
        {
            get
            {
                return _testTime;
            }
            set
            {
                _testTime = value;
            }
        }

        public Boolean generateTestResult()
        {
            Random rng = new Random();
            testResult = rng.Next(0, 2) > 0;
            testTime = DateTime.Now;
            return testResult;
        }
    }
}
