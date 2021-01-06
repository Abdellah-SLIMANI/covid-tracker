using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Location
    {
        private string _locationsName;
        public List<Person> peoplePedningTest = new List<Person>();

        public Location() { }

        public string locationName
        {
            get
            {
                return _locationsName;
            }
            set
            {
                _locationsName = value;
            }
        }

        private Boolean sickPersonDetector()
        {
            for (int i = 0; i < peoplePedningTest.Count; i++)
                if (peoplePedningTest[i].isAffected)
                    return true;
            return false;
        }

        public List<Person> generatePeoplePendingTest()
        {
            if (sickPersonDetector())
                for (int i = 0; i < peoplePedningTest.Count; i++)
                    if (!peoplePedningTest[i].isAffected)
                        peoplePedningTest[i].isSuspected = true;
            return peoplePedningTest;
        }
    }
}