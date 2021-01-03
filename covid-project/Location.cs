using System;
using System.Collections.Generic;
using System.Text;

namespace covid_project
{
    class Location
    {
        private string _locationsName;
        private DateTime _timeVisited;

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

        public DateTime timeVisited
        {
            get
            {
                return _timeVisited;
            }
            set
            {
                _timeVisited = value;
            }
        }
    }
}
