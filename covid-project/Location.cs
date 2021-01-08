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
        ///<Summary>
        ///Checks if there is an Infected Person in the Location
        ///</Summary>
        ///<returns>a Boolean depending on id there is infected peopple on the Location or Not</returns>
        private Boolean sickPersonDetector()
        {
            for (int i = 0; i < peoplePedningTest.Count; i++)
                if (peoplePedningTest[i].isAffected)
                    return true;
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>The list of persons in the Location</returns>
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