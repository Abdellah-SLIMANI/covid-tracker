using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Test
    {
        //if the result is true then it's Positive(sick) and vice versa
        static Boolean _testResult;
        static DateTime _testTime;

        public Test() { }

        /// <summary>
        /// Generates a boolean that we concider to be the test result of a person
        /// </summary>
        /// <returns>true if he is infected and vice versa</returns>

        public static Boolean generateTestResult()
        {
            Random rng = new Random();
            _testResult = rng.Next(0, 2) > 0;
            _testTime = DateTime.Now;
            return _testResult;
        }
    }
}
